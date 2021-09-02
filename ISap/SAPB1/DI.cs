using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPbobsCOM;
using ISap.Helpers;
namespace ISap.SAPB1
{
    class DI
    {
        private Company company;

        public DI()
        {
            this.company = new Company();
        }

        public bool connect(out int errorCode, out string errorMessage)
        {
            bool result = false;
            errorCode = -1; 
            errorMessage = String.Empty;
            try
            {
                company.Server = Utils.DB_Server;
                company.DbServerType = (BoDataServerTypes)getServerTypeValue();
                company.UseTrusted = false;
                company.DbUserName = Utils.DB_User;
                company.DbPassword = Utils.DB_Pass;
                company.CompanyDB = Utils.SAP_Company;
                company.UserName = Utils.SAP_User;
                company.Password = Utils.SAP_Pass;
                company.language = BoSuppLangs.ln_Spanish_La;
                company.AddonIdentifier = String.Empty;
                company.LicenseServer = Utils.DB_Server;

                errorCode = company.Connect();
                if (errorCode != 0)
                    company.GetLastError(out errorCode, out errorMessage);
                else
                    result = true;
            }
            catch(Exception e)
            {
                errorMessage = e.Message;
            }
           
            return result;
        }

        private int getServerTypeValue()
        {
            Dictionary<string, int> values = Enum.GetValues(typeof(BoDataServerTypes))
                                        .Cast<BoDataServerTypes>()
                                        .ToDictionary(k => k.ToString(), v => (int)v);

            

            return values[Utils.DB_ServerType];
        }
    }
}
