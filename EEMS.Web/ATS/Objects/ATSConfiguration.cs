using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEMS.Web.ATS.Objects
{
    public class ATSConfiguration
    {
        public string AccountName { get; set; }
        public string AccountKey { get; set; }
        public bool UseManagedIdentity { get; set; }

        public ATSConfiguration(string accountName, string accountKey, bool useManagedIdentity = false)
        {
            AccountName = accountName;
            AccountKey = accountKey;
            UseManagedIdentity = useManagedIdentity;
        }
    }
}
