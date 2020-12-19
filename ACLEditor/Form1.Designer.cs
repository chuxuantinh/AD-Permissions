namespace ACLEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "hmmm"}, -1);
            this.txtADPath = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listVwACL = new System.Windows.Forms.ListView();
            this.Account = new System.Windows.Forms.ColumnHeader();
            this.AceType = new System.Windows.Forms.ColumnHeader();
            this.Permissions = new System.Windows.Forms.ColumnHeader();
            this.InheritenceFlag = new System.Windows.Forms.ColumnHeader();
            this.InheritenceType = new System.Windows.Forms.ColumnHeader();
            this.IsInherited = new System.Windows.Forms.ColumnHeader();
            this.InheritenceObjectType = new System.Windows.Forms.ColumnHeader();
            this.InheritenceObjectName = new System.Windows.Forms.ColumnHeader();
            this.ObjectType = new System.Windows.Forms.ColumnHeader();
            this.ObjectTypeName = new System.Windows.Forms.ColumnHeader();
            this.Bind = new System.Windows.Forms.Button();
            this.XXXX = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // txtADPath
            // 
            this.txtADPath.Location = new System.Drawing.Point(80, 29);
            this.txtADPath.Name = "txtADPath";
            this.txtADPath.Size = new System.Drawing.Size(356, 20);
            this.txtADPath.TabIndex = 0;
            this.txtADPath.Text = "LDAP://OU=InnerOU,OU=TestOU,DC=azaad,DC=punetest,DC=com";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(80, 71);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "Azaad\\Administrator";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(273, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADPath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // listVwACL
            // 
            this.listVwACL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.XXXX,
            this.Account,
            this.AceType,
            this.Permissions,
            this.InheritenceFlag,
            this.InheritenceType,
            this.IsInherited,
            this.InheritenceObjectType,
            this.InheritenceObjectName,
            this.ObjectType,
            this.ObjectTypeName});
            this.listVwACL.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listVwACL.Location = new System.Drawing.Point(12, 128);
            this.listVwACL.Name = "listVwACL";
            this.listVwACL.Size = new System.Drawing.Size(642, 256);
            this.listVwACL.TabIndex = 6;
            this.listVwACL.UseCompatibleStateImageBehavior = false;
            this.listVwACL.View = System.Windows.Forms.View.Details;
            // 
            // Account
            // 
            this.Account.DisplayIndex = 0;
            this.Account.Text = "Account";
            this.Account.Width = 68;
            // 
            // AceType
            // 
            this.AceType.DisplayIndex = 1;
            this.AceType.Text = "AceType";
            this.AceType.Width = 73;
            // 
            // Permissions
            // 
            this.Permissions.DisplayIndex = 2;
            this.Permissions.Text = "Permissions";
            this.Permissions.Width = 116;
            // 
            // InheritenceFlag
            // 
            this.InheritenceFlag.DisplayIndex = 3;
            this.InheritenceFlag.Text = "InheritenceFlag";
            this.InheritenceFlag.Width = 100;
            // 
            // InheritenceType
            // 
            this.InheritenceType.DisplayIndex = 4;
            this.InheritenceType.Text = "InheritenceType";
            this.InheritenceType.Width = 105;
            // 
            // IsInherited
            // 
            this.IsInherited.DisplayIndex = 5;
            this.IsInherited.Text = "IsInherited";
            this.IsInherited.Width = 83;
            // 
            // InheritenceObjectType
            // 
            this.InheritenceObjectType.DisplayIndex = 6;
            this.InheritenceObjectType.Text = "InheritenceObjectType";
            this.InheritenceObjectType.Width = 78;
            // 
            // InheritenceObjectName
            // 
            this.InheritenceObjectName.DisplayIndex = 7;
            this.InheritenceObjectName.Text = "InheritenceObjectName";
            this.InheritenceObjectName.Width = 107;
            // 
            // ObjectType
            // 
            this.ObjectType.DisplayIndex = 8;
            this.ObjectType.Text = "ObjectType";
            // 
            // ObjectTypeName
            // 
            this.ObjectTypeName.DisplayIndex = 9;
            this.ObjectTypeName.Text = "ObjectTypeName";
            // 
            // Bind
            // 
            this.Bind.Location = new System.Drawing.Point(388, 72);
            this.Bind.Name = "Bind";
            this.Bind.Size = new System.Drawing.Size(75, 23);
            this.Bind.TabIndex = 7;
            this.Bind.Text = "Bind";
            this.Bind.UseVisualStyleBackColor = true;
            this.Bind.Click += new System.EventHandler(this.Bind_Click);
            // 
            // XXXX
            // 
            this.XXXX.DisplayIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 420);
            this.Controls.Add(this.Bind);
            this.Controls.Add(this.listVwACL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtADPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtADPath;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listVwACL;
        private System.Windows.Forms.ColumnHeader Account;
        private System.Windows.Forms.ColumnHeader AceType;
        private System.Windows.Forms.ColumnHeader Permissions;
        private System.Windows.Forms.ColumnHeader InheritenceFlag;
        private System.Windows.Forms.ColumnHeader InheritenceType;
        private System.Windows.Forms.ColumnHeader IsInherited;
        private System.Windows.Forms.ColumnHeader InheritenceObjectType;
        private System.Windows.Forms.ColumnHeader InheritenceObjectName;
        private System.Windows.Forms.ColumnHeader ObjectType;
        private System.Windows.Forms.ColumnHeader ObjectTypeName;
        private System.Windows.Forms.Button Bind;
        private System.Windows.Forms.ColumnHeader XXXX;
    }
}

