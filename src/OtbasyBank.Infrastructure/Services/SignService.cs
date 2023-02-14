using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KalkanCryptCOMLib;
using Microsoft.Extensions.Configuration;
using OtbasyBank.Application.Interfaces.Services;

namespace OtbasyBank.Infrastructure.Services
{
    public class SignService :ISignService
    {
        string result;
        string outSign;
        string errStr;
        private readonly string _rootCertPath;
        private readonly IConfiguration _configuration;
        KalkanCryptCOM store = new KalkanCryptCOM();
        public SignService(IConfiguration configuration)
        {
            store.Init();
            _configuration = configuration;
            _rootCertPath = _configuration["RootCertificationPath"];
            string strCertPath = Path.Combine(_rootCertPath, "GOSTKNCA_c93c624c7e88b9ad60fa21ee99716165a65b200d.p12");
            string strCertPassword = "Asdf123456789_+-";
            store.LoadKeyStore((int)KalkanCryptCOMLib.KALKANCRYPTCOM_STORETYPE.KCST_PKCS12, strCertPassword, strCertPath, " ");
        }

        public string SignDoc(string docHash)
        {
            uint err;
            string errStr;
            string result = "";
            string outSign="";

            store.GetLastErrorString(out errStr, out err);

            if (err > 0)
            {
                //Log4net.ServiceLog.Error("UtilRegisterImpl.SignDoc(Ошибка при загрузке ЭЦП: Error: 0x" + err.ToString("X8") + " userId: " + userId);
                throw new Exception("Ошибка при загрузке ЭЦП: Error: 0x" + err.ToString("X8"));
            }

            store.SignData("", 514, docHash,  ref outSign);
            store.GetLastErrorString(out errStr, out err);
            if (err > 0)
            {
                //Log4net.ServiceLog.Error("UtilRegisterImpl.SignDoc(Ошибка при загрузке ЭЦП: Error: 0x" + err.ToString("X8") + "\r\n" + errStr.Replace("\n", "\r\n") + " userId: " + userId);
                throw new Exception("Ошибка при загрузке ЭЦП: Error: 0x" + err.ToString("X8") + "\r\n" + errStr.Replace("\n", "\r\n"));
            }
            outSign = outSign.Replace("-----BEGIN CMS-----", "").Replace("-----END CMS-----", "").Trim();
            result = outSign;

            return result;
        }
    }
}
