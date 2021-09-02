
namespace ISap.Setup
{
    partial class SapServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerTypes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Servers = new System.Windows.Forms.ComboBox();
            this.MyGrid = new System.Windows.Forms.DataGridView();
            this.TestConnection = new FontAwesome.Sharp.IconButton();
            this.Save = new FontAwesome.Sharp.IconButton();
            this.Close = new FontAwesome.Sharp.IconButton();
            this.Database = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(65, 26);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(140, 23);
            this.User.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(284, 26);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(157, 23);
            this.Password.TabIndex = 3;
            this.Password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ServerTypes
            // 
            this.ServerTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerTypes.FormattingEnabled = true;
            this.ServerTypes.Location = new System.Drawing.Point(65, 55);
            this.ServerTypes.Name = "ServerTypes";
            this.ServerTypes.Size = new System.Drawing.Size(140, 23);
            this.ServerTypes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Servidor ";
            // 
            // Servers
            // 
            this.Servers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Servers.FormattingEnabled = true;
            this.Servers.Location = new System.Drawing.Point(211, 55);
            this.Servers.Name = "Servers";
            this.Servers.Size = new System.Drawing.Size(230, 23);
            this.Servers.TabIndex = 6;
            this.Servers.SelectedIndexChanged += new System.EventHandler(this.Servers_SelectedIndexChanged);
            // 
            // MyGrid
            // 
            this.MyGrid.Location = new System.Drawing.Point(12, 109);
            this.MyGrid.MultiSelect = false;
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.ReadOnly = true;
            this.MyGrid.RowTemplate.Height = 25;
            this.MyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyGrid.Size = new System.Drawing.Size(539, 160);
            this.MyGrid.TabIndex = 7;
            this.MyGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyGrid_CellClick);
            // 
            // TestConnection
            // 
            this.TestConnection.IconChar = FontAwesome.Sharp.IconChar.Plug;
            this.TestConnection.IconColor = System.Drawing.Color.Black;
            this.TestConnection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TestConnection.IconSize = 35;
            this.TestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestConnection.Location = new System.Drawing.Point(449, 26);
            this.TestConnection.Name = "TestConnection";
            this.TestConnection.Size = new System.Drawing.Size(102, 52);
            this.TestConnection.TabIndex = 10;
            this.TestConnection.Text = "Probar Conexión";
            this.TestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TestConnection.UseVisualStyleBackColor = true;
            this.TestConnection.Click += new System.EventHandler(this.TestConnection_Click);
            // 
            // Save
            // 
            this.Save.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.Save.IconColor = System.Drawing.Color.Black;
            this.Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Save.IconSize = 35;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(12, 275);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(102, 52);
            this.Save.TabIndex = 11;
            this.Save.Text = "Guardar";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Close
            // 
            this.Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.Close.IconColor = System.Drawing.Color.Black;
            this.Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Close.IconSize = 35;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(120, 275);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(102, 52);
            this.Close.TabIndex = 12;
            this.Close.Text = "Cerrar";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.UseVisualStyleBackColor = true;
            // 
            // Database
            // 
            this.Database.Location = new System.Drawing.Point(98, 84);
            this.Database.Name = "Database";
            this.Database.ReadOnly = true;
            this.Database.Size = new System.Drawing.Size(343, 23);
            this.Database.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Base de Datos";
            // 
            // SapServer
            // 
            this.AcceptButton = this.Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Close;
            this.ClientSize = new System.Drawing.Size(563, 331);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.TestConnection);
            this.Controls.Add(this.MyGrid);
            this.Controls.Add(this.Servers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServerTypes);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label1);
            this.Name = "SapServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración Servidor SAP B1";
            this.Load += new System.EventHandler(this.SapServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ServerTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Servers;
        private System.Windows.Forms.DataGridView MyGrid;
        private FontAwesome.Sharp.IconButton TestConnection;
        private FontAwesome.Sharp.IconButton Save;
        private FontAwesome.Sharp.IconButton Close;
        private System.Windows.Forms.TextBox Database;
        private System.Windows.Forms.Label label4;
    }
}