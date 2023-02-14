using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Shared.Enums
{
    public enum MethodTypes
    {
        UploadFileToClient = 0,
        UploadFileToDeposit = 1,
        UploadFileToCredit = 2
    }

    public static class MethodNames
    {
        public static string GetName(MethodTypes type)
        {
            switch (type)
            {
                case MethodTypes.UploadFileToClient:
                    return "UploadFileToClient";
                case MethodTypes.UploadFileToDeposit:
                    return "UploadFileToDeposit";
                case MethodTypes.UploadFileToCredit:
                    return "UploadFileToCredit";
                default:
                    return "";
            }
        }
    }
}
