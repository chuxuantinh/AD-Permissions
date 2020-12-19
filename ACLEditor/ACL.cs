using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Principal;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Collections;
using System.Collections.Specialized;
using System.Security.AccessControl;


namespace ACLEditor
{
    public class ACL
    {
        public ACL(string ADPath,string UserName,string Password)
        {
            this.adPath = ADPath;
            this.credUser = UserName;
            this.credPassword = Password;
        }
        public AuthorizationRuleCollection GetPermission()
        {
            DirectoryEntry objDE = new DirectoryEntry(adPath, credUser, credPassword);
            ActiveDirectorySecurity adSecurity = objDE.ObjectSecurity;
            string sd = adSecurity.GetSecurityDescriptorSddlForm(AccessControlSections.All);
            NTAccount account = new NTAccount("Azaad", "TestUser1");
            return adSecurity.GetAccessRules(true, true, account.GetType());
        }
        public string LookupAccountSid(string sid)
        {
            if (ForeignSPTable == null)
            {
                ForeignSPTable = new Hashtable();
                DirectoryEntry securityPrincipals = new DirectoryEntry("LDAP://CN=ForeignSecurityPrincipals,DC=azaad,DC=punetest,DC=com", "administrator", "password");
                foreach (DirectoryEntry entry in securityPrincipals.Children)
                {
                    PropertyValueCollection pvC = entry.Properties["cn"];
                    if (false == ForeignSPTable.Contains(pvC.Value.ToString()))
                        ForeignSPTable.Add(entry.Name, pvC.Value.ToString());
                }
            }
            if (WellKnownSPTable == null)
            {
                WellKnownSPTable = new Hashtable();
                DirectoryEntry securityPrincipals = new DirectoryEntry("LDAP://CN=WellKnown Security Principals,CN=Configuration,DC=azaad,DC=punetest,DC=com", "administrator", "password");
                foreach (DirectoryEntry entry in securityPrincipals.Children)
                {
                    PropertyValueCollection pvC = entry.Properties["objectSid"];
                    if (false == WellKnownSPTable.Contains(pvC.Value.ToString()))
                        WellKnownSPTable.Add(entry.Name, pvC.Value.ToString());
                }
            }
            string name = sid;
            if (true == WellKnownSPTable.ContainsKey(sid))
                name = (string)WellKnownSPTable[sid];
            else if (true == ForeignSPTable.ContainsKey(sid))
                name = (string)ForeignSPTable[sid];

            return name;
        }
        string adPath;
        string credUser;
        string credPassword;
        Hashtable ForeignSPTable, WellKnownSPTable;
    }
}
