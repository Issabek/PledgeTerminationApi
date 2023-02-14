using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using OtbasyBank.Shared.Helpers;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Shared.Extensions.Serilog
{
    public class SerilogLoggerConfiguration
    {
        private readonly IConfiguration _configuration;
        private string key = "DCStrPN10012018";
        public SerilogLoggerConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ILogger LogConfs(IWebHostEnvironment env)
        {
            var columnOpts = new ColumnOptions
            {
                AdditionalColumns = new Collection<SqlColumn>
                {
                    new SqlColumn
                    {
                        ColumnName = "UserIin", PropertyName = "UserIin", DataType = SqlDbType.VarChar, DataLength = 12, AllowNull = true
                    },
                    new SqlColumn
                    {
                        ColumnName = "StackTrace", PropertyName = "StackTrace", DataType = SqlDbType.NVarChar, DataLength = -1, AllowNull = true
                    },
                    new SqlColumn
                    {
                        ColumnName = "ExInnerMessage", PropertyName = "ExInnerMessage", DataType = SqlDbType.NVarChar, DataLength = -1, AllowNull = true
                    },
                    new SqlColumn
                    {
                        ColumnName = "ExInnerStackTrace", PropertyName = "ExInnerStackTrace", DataType = SqlDbType.NVarChar, DataLength = -1, AllowNull = true
                    }

                }
            };

            columnOpts.Store.Remove(StandardColumn.MessageTemplate);
            columnOpts.Store.Remove(StandardColumn.Properties);
            var isTest = _configuration["ServiceBus:IsTest"];
            var connectionString = "";
            if (isTest == "Test")
            {
                connectionString = _configuration.GetConnectionString("OnlineBank");
            }
            else
            {
                connectionString = Crypt.Decrypt(_configuration.GetConnectionString("OnlineBank"), key);
            }

            var sinkOpts = new MSSqlServerSinkOptions();
            sinkOpts.TableName = "ChangerequisitesLogs";
            sinkOpts.SchemaName = "OperationsLogs";

            var log = new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                            .Enrich.FromLogContext()
                            .WriteTo.MSSqlServer(
                                connectionString: connectionString,
                                sinkOptions: sinkOpts,
                                restrictedToMinimumLevel: LogEventLevel.Debug, columnOptions: columnOpts
                            )
                            .CreateLogger();

            return log;
        }



    }
}
