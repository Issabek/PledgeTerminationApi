using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OtbasyBank.Application.Interfaces;
using OtbasyBank.Application.Interfaces.Persistence;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Domain;
using OtbasyBank.Domain.Common;
using OtbasyBank.Infrastructure.Helpers;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Infrastructure.Services
{
    public class PledgeTerminatorUserService : IPledgeTerminatorUserService
    {
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        private List<SystemUser> _users = new List<SystemUser>
        {
            new SystemUser (){ Id = 1, UserName = "BPMUser", TestPassword = "SiniyIniy", Password="c6p$c1M09DYy", Role = "User"},
            new SystemUser() { Id = 2, UserName = "GlobalUser", TestPassword = "BeliyeRozy",Password="gHHu@yx031!@", Role = "User"}
        };
        private readonly IInternetBankingContext _context;
        private readonly IBusService _busService;
        private readonly IConfiguration _config;
        private readonly RetryExecutor _retryExecutor;
        public PledgeTerminatorUserService(IInternetBankingContext context, IBusService busService, IConfiguration config)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _busService = busService ?? throw new ArgumentNullException(nameof(busService));
            _retryExecutor = new(_busService);
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public string Login(string userName, string password)
        {
            //var user = _context.PledgeTerminatorUsers.FirstOrDefault(u=>u.UserName==userName.Trim());
            var user = _users.FirstOrDefault(f => f.UserName == userName);

            if (user == null || (_config["ServiceBus:IsTest"] == "Test" && user.TestPassword != password))
                throw new InvalidDataException("Login or password is wrong!");
            else
            {
                if ((password != user.Password || user == null) && _config["ServiceBus:IsTest"] != "Test")
                {
                    throw new InvalidDataException("Login or password is wrong!");
                }
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(ServiceCollectionExtension.SECRET);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Role, user.Role)
                }),

                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);
            return user.Token;

        }

    }
}
