using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Collections.Specialized;
using System.Security.AccessControl;
using System.Collections;
using System.Runtime.InteropServices;


namespace ACLEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bind_Click(object sender, EventArgs e)
        {
            string adPath = txtADPath.Text;
            string credUser = txtUserName.Text;
            string credPassword = txtPassword.Text;
            ACL acl = new ACL(adPath, credUser, credPassword);
            AuthorizationRuleCollection rules = acl.GetPermission();
            foreach (ActiveDirectoryAccessRule rule in rules)
            {
                ListViewItem item = new ListViewItem();
                //item.SubItems.Add(rule.IdentityReference.Value);
                string name = rule.IdentityReference.Value;
                if (name.StartsWith("S-"))
                {
                    string domainName="", accountName = "";
                    int iUse=0, accountNameSize = 0, domainNameSize = 0;
                    //int sid = int.Parse(name);
                    //LookupAccountSid("", ref name, accountName, ref accountNameSize, domainName, ref domainNameSize, ref iUse);
                    accountName = acl.LookupAccountSid(name);
                    item.SubItems.Add(accountName);
                }
                else
                {
                    item.SubItems.Add(name);
                }
                item.SubItems.Add(rule.AccessControlType.ToString());
                item.SubItems.Add(rule.ActiveDirectoryRights.ToString());
                item.SubItems.Add(rule.InheritanceFlags.ToString());
                item.SubItems.Add(rule.InheritanceType.ToString());
                item.SubItems.Add(rule.IsInherited.ToString());
                if ((ObjectAceFlags.InheritedObjectAceTypePresent & rule.ObjectFlags) == ObjectAceFlags.InheritedObjectAceTypePresent)
                {
                    item.SubItems.Add(rule.InheritedObjectType.ToString());
                    item.SubItems.Add(GetObjectType(rule.InheritedObjectType));
                }
                else
                {
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                }
                if ((ObjectAceFlags.ObjectAceTypePresent & rule.ObjectFlags) == ObjectAceFlags.ObjectAceTypePresent)
                {
                    item.SubItems.Add(rule.ObjectType.ToString());
                    item.SubItems.Add(GetObjectType(rule.ObjectType));
                }
                else
                {
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                }
                listVwACL.Items.Add(item);
            }
        }
        static string GetObjectType(Guid ObjectGuid)
        {
            if (hastable == null)
            {
                hastable = new Hashtable();
                hastableObjects = new Hashtable();
                DirectoryEntry extendedRights = new DirectoryEntry("LDAP://CN=Extended-Rights,CN=Configuration,DC=azaad,DC=punetest,DC=com", "administrator", "password");
                //Console.WriteLine("Extented Rights:");
                foreach (DirectoryEntry entry in extendedRights.Children)
                {
                    PropertyValueCollection pvC = entry.Properties["rightsGuid"];
                    if (false == hastable.Contains(pvC.Value))
                        hastable.Add(pvC.Value.ToString(), entry.Name);
                    //Console.WriteLine(pvC.Value.ToString() + " , " +entry.Name);
                }

                DirectoryEntry scheamaObject = new DirectoryEntry("LDAP://CN=Schema,CN=Configuration,DC=azaad,DC=punetest,DC=com", "administrator", "password");
                /*Console.WriteLine("***********************************************************************");
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("Objects:");*/
                foreach (DirectoryEntry entry in scheamaObject.Children)
                {
                    PropertyValueCollection pvC = entry.Properties["schemaIDGUID"];
                    if (pvC.Value != null)
                    {
                        Guid guid = new Guid((byte[])pvC.Value);
                        if (false == hastableObjects.Contains(guid.ToString()))
                            hastableObjects.Add(guid.ToString(), entry.Name);
                        //Console.WriteLine(guid.ToString() + " , " + entry.Name);
                    }
                }
            }
            string name = "";
            if (true == hastable.ContainsKey(ObjectGuid.ToString()))
                name = (string)hastable[ObjectGuid.ToString()];
            else if (true == hastableObjects.ContainsKey(ObjectGuid.ToString()))
                name = (string)hastableObjects[ObjectGuid.ToString()];

            return name;
        }
        private static Hashtable hastable;
        private static Hashtable hastableObjects;
        [DllImport("advapi32.dll", EntryPoint = "LookupAccountSid")]
        public static extern int LookupAccountSid(string lpSystemName, ref string Sid, string name, ref int cbName, string ReferencedDomainName, ref int cbReferencedDomainName, ref int peUse);
    }
}
