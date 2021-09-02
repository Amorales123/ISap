
namespace ISap.Setup
{
    partial class DBServer
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
            this.Server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Close = new FontAwesome.Sharp.IconButton();
            this.Save = new FontAwesome.Sharp.IconButton();
            this.TestConnection = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ServerTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(83, 64);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(333, 23);
            this.Server.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servidor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(83, 93);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(333, 23);
            this.User.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(83, 122);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(333, 23);
            this.Password.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // Close
            // 
            this.Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.Close.IconColor = System.Drawing.Color.Black;
            this.Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Close.IconSize = 35;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(118, 151);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(102, 52);
            this.Close.TabIndex = 14;
            this.Close.Text = "Cerrar";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Save
            // 
            this.Save.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.Save.IconColor = System.Drawing.Color.Black;
            this.Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Save.IconSize = 35;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(10, 151);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(102, 52);
            this.Save.TabIndex = 13;
            this.Save.Text = "Guardar";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // TestConnection
            // 
            this.TestConnection.IconChar = FontAwesome.Sharp.IconChar.Plug;
            this.TestConnection.IconColor = System.Drawing.Color.Black;
            this.TestConnection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TestConnection.IconSize = 35;
            this.TestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestConnection.Location = new System.Drawing.Point(422, 64);
            this.TestConnection.Name = "TestConnection";
            this.TestConnection.Size = new System.Drawing.Size(102, 52);
            this.TestConnection.TabIndex = 15;
            this.TestConnection.Text = "Probar Conexión";
            this.TestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TestConnection.UseVisualStyleBackColor = true;
            this.TestConnection.Click += new System.EventHandler(this.TestConnection_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo de Servidor";
            // 
            // ServerTypes
            // 
            this.ServerTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerTypes.FormattingEnabled = true;
            this.ServerTypes.Items.AddRange(new object[] {
            "SQL Server",
            "HANA Database"});
            this.ServerTypes.Location = new System.Drawing.Point(108, 35);
            this.ServerTypes.Name = "ServerTypes";
            this.ServerTypes.Size = new System.Drawing.Size(308, 23);
            this.ServerTypes.TabIndex = 17;
            // 
            // DBServer
            // 
            this.AcceptButton = this.Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Close;
            this.ClientSize = new System.Drawing.Size(535, 214);
            this.Controls.Add(this.ServerTypes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TestConnection);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.label1);
            this.Name = "DBServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor de Base de Datos";
            this.Load += new System.EventHandler(this.DBServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
       private FontAwesome.Sharp.IconButton Close;
        private FontAwesome.Sharp.IconButton Save;
        private FontAwesome.Sharp.IconButton TestConnection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ServerTypes;
    }
}