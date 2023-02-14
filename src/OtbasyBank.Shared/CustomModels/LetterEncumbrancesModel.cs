using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OtbasyBank.Shared.CustomModels
{
    public class LetterEncumbrancesModel
    {
        public string LnCode { get; set; }
        public string DateBegin { get; set; }
        public string CliLongName { get; set; }
        public string FltAddress { get; set; }
        public string DclCode { get; set; }
        public string EnsCode { get; set; }
        public string DocNumber { get; set; }
        public string DocDate { get; set; }
        public string PledgeDocNumber { get; set; }
        public string PledgeDocDate { get; set; }
        public List<string> AdditionalDocNumber { get; set; } = new List<string>();
        public List<string> AdditionalDocDate { get; set; } = new List<string>();
        public List<string> AdditionalPledgeDocNumber { get; set; } = new List<string>();
        public List<string> AdditionalPledgeDocDate { get; set; } = new List<string>();
        public List<string> TaxCodes { get; set; } = new List<string>();
        public List<string> CliCodes { get; set; } = new List<string>();
        public List<string> CliNames { get; set; } = new List<string>();

        public LetterEncumbrancesModel(XmlNode xml)
        {
            if (xml.SelectNodes("Cur/item").Count == 1)
            {
                LnCode = xml.SelectSingleNode("//LN_CODE") != null && !string.IsNullOrWhiteSpace(xml.SelectSingleNode("//LN_CODE").InnerText) ? xml.SelectSingleNode("//LN_CODE").InnerText : "";
                DateBegin = xml.SelectSingleNode("//DATE_BEGIN") != null && !string.IsNullOrWhiteSpace(xml.SelectSingleNode("//DATE_BEGIN").InnerText) ? xml.SelectSingleNode("//DATE_BEGIN").InnerText : "";
                CliLongName = xml.SelectSingleNode("//CLILONGNAME") != null && !string.IsNullOrWhiteSpace(xml.SelectSingleNode("//CLILONGNAME").InnerText) ? xml.SelectSingleNode("//CLILONGNAME").InnerText : "";
                FltAddress = xml.SelectSingleNode("//FLT_ADDRESS") != null && !string.IsNullOrWhiteSpace(xml.SelectSingleNode("//FLT_ADDRESS").InnerText) ? xml.SelectSingleNode("//FLT_ADDRESS").InnerText : "";
                DclCode = xml.SelectSingleNode("//DCL_CODE") != null && !string.IsNullOrWhiteSpace(xml.SelectSingleNode("//DCL_CODE").InnerText) ? xml.SelectSingleNode("//DCL_CODE").InnerText : "";
                EnsCode = xml.SelectSingleNode("//ENS_CODE") != null && !string.IsNullOrWhiteSpace(xml.SelectSingleNode("//ENS_CODE").InnerText) ? xml.SelectSingleNode("//ENS_CODE").InnerText : "";
            }
            if (xml.SelectNodes("Cur2/item").Count > 0)
            {
                XmlNode nod = xml.SelectNodes("Cur2/item")[0];
                DocNumber = nod.SelectSingleNode("DOCNUMBER") != null && !string.IsNullOrWhiteSpace(nod.SelectSingleNode("DOCNUMBER").InnerText) ? nod.SelectSingleNode("DOCNUMBER").InnerText : "";
                DocDate = nod.SelectSingleNode("DOCDATE") != null && !string.IsNullOrWhiteSpace(nod.SelectSingleNode("DOCDATE").InnerText) ? nod.SelectSingleNode("DOCDATE").InnerText : "";
                PledgeDocNumber = nod.SelectSingleNode("PLEDGEDOCNUMBER") != null && !string.IsNullOrWhiteSpace(nod.SelectSingleNode("PLEDGEDOCNUMBER").InnerText) ? nod.SelectSingleNode("PLEDGEDOCNUMBER").InnerText : "";
                PledgeDocDate = nod.SelectSingleNode("PLEDGEDOCDATE") != null && !string.IsNullOrWhiteSpace(nod.SelectSingleNode("PLEDGEDOCDATE").InnerText) ? nod.SelectSingleNode("PLEDGEDOCDATE").InnerText : "";
            }

            if (xml.SelectNodes("Cur2/item").Count > 1)
            {
                for (int i = 1; i < xml.SelectNodes("Cur2/item").Count; i++)
                {
                    XmlNode nod = xml.SelectNodes("Cur2/item")[i];
                    AdditionalDocNumber.Add(nod.SelectSingleNode("DOCNUMBER") != null && !string.IsNullOrWhiteSpace(nod.SelectSingleNode("DOCNUMBER").InnerText) ? nod.SelectSingleNode("DOCNUMBER").InnerText : "");
                    AdditionalDocDate.Add(nod.SelectSingleNode("DOCDATE") != null && !string.IsNullOrWhiteSpace(nod.SelectSingleNode("DOCDATE").InnerText) ? nod.SelectSingleNode("DOCDATE").InnerText : "");
                    AdditionalPledgeDocNumber.Add(nod.SelectSingleNode("PLEDGEDOCNUMBER") != null && !string.IsNullOrWhiteSpace(nod.SelectSingleNode("PLEDGEDOCNUMBER").InnerText) ? nod.SelectSingleNode("PLEDGEDOCNUMBER").InnerText : "");
                    AdditionalPledgeDocDate.Add(nod.SelectSingleNode("PLEDGEDOCDATE") != null && !string.IsNullOrWhiteSpace(nod.SelectSingleNode("PLEDGEDOCDATE").InnerText) ? nod.SelectSingleNode("PLEDGEDOCDATE").InnerText : "");
                }
            }

            if (xml.SelectNodes("Cur3/item").Count > 0)
            {
                foreach (XmlNode nod in xml.SelectNodes("Cur3/item"))
                {
                    TaxCodes.Add(nod.SelectSingleNode("TAXCODE") != null && !string.IsNullOrWhiteSpace(nod.SelectSingleNode("TAXCODE").InnerText) ? nod.SelectSingleNode("TAXCODE").InnerText : "");
                    CliCodes.Add(nod.SelectSingleNode("CLI_CODE") != null && !string.IsNullOrWhiteSpace(nod.SelectSingleNode("CLI_CODE").InnerText) ? nod.SelectSingleNode("CLI_CODE").InnerText : "");
                    CliNames.Add(nod.SelectSingleNode("CLI_NAME") != null && !string.IsNullOrWhiteSpace(nod.SelectSingleNode("CLI_NAME").InnerText) ? nod.SelectSingleNode("CLI_NAME").InnerText : "");
                }
            }
        }
        public LetterEncumbrancesModel()
        {
            LnCode = "SP210303-0235-0700";
            DateBegin = "3/18/2021 12:00:00 AM";
            CliLongName = "Individual_21442638259";
            FltAddress = "Западно-Казахстанская область, Бурлинский район, г. Аксай, улица Дружба народов, д. 4/6, кв. 62";
            //MrtCode = "PSP210303-0235-0700-1";
            //Dmaindea = "3/10/2021 12:00:00 AM";
            //AgrCode = "0";
            //AgrDate = "";
            //MrtCliLongName = "30.02635404 Individual_21442638259";
        }
    }

}
