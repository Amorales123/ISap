
namespace ISap.Setup
{
    partial class Configuration
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
            this.MyGrid = new System.Windows.Forms.DataGridView();
            this.TestConnection = new FontAwesome.Sharp.IconButton();
            this.ConfBD = new FontAwesome.Sharp.IconButton();
            this.confSAP = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MyGrid
            // 
            this.MyGrid.Location = new System.Drawing.Point(12, 12);
            this.MyGrid.MultiSelect = false;
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.ReadOnly = true;
            this.MyGrid.RowTemplate.Height = 25;
            this.MyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyGrid.Size = new System.Drawing.Size(776, 207);
            this.MyGrid.TabIndex = 17;
            // 
            // TestConnection
            // 
            this.TestConnection.IconChar = FontAwesome.Sharp.IconChar.Plug;
            this.TestConnection.IconColor = System.Drawing.Color.Black;
            this.TestConnection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TestConnection.IconSize = 35;
            this.TestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestConnection.Location = new System.Drawing.Point(12, 225);
            this.TestConnection.Name = "TestConnection";
            this.TestConnection.Size = new System.Drawing.Size(102, 52);
            this.TestConnection.TabIndex = 16;
            this.TestConnection.Text = "Sincronizar";
            this.TestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TestConnection.UseVisualStyleBackColor = true;
            this.TestConnection.Click += new System.EventHandler(this.TestConnection_Click);
            // 
            // ConfBD
            // 
            this.ConfBD.BackgroundImage = global::ISap.Properties.Resources.BD;
            this.ConfBD.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConfBD.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.ConfBD.IconColor = System.Drawing.Color.Black;
            this.ConfBD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ConfBD.IconSize = 35;
            this.ConfBD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfBD.Location = new System.Drawing.Point(680, 225);
            this.ConfBD.Name = "ConfBD";
            this.ConfBD.Size = new System.Drawing.Size(108, 52);
            this.ConfBD.TabIndex = 18;
            this.ConfBD.Text = "Configurar Servidor BD";
            this.ConfBD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConfBD.UseMnemonic = false;
            this.ConfBD.UseVisualStyleBackColor = true;
            this.ConfBD.Click += new System.EventHandler(this.ConfBD_Click);
            // 
            // confSAP
            // 
            this.confSAP.BackgroundImage = global::ISap.Properties.Resources.BD;
            this.confSAP.Cursor = System.Windows.Forms.Cursors.Default;
            this.confSAP.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.confSAP.IconColor = System.Drawing.Color.Black;
            this.confSAP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.confSAP.IconSize = 35;
            this.confSAP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confSAP.Location = new System.Drawing.Point(552, 225);
            this.confSAP.Name = "confSAP";
            this.confSAP.Size = new System.Drawing.Size(122, 52);
            this.confSAP.TabIndex = 19;
            this.confSAP.Text = "Configurar Sociedades SAP";
            this.confSAP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confSAP.UseMnemonic = false;
            this.confSAP.UseVisualStyleBackColor = true;
            this.confSAP.Click += new System.EventHandler(this.confSAP_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Arreglo de TCs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 42);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cambio a Fecha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 284);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confSAP);
            this.Controls.Add(this.ConfBD);
            this.Controls.Add(this.MyGrid);
            this.Controls.Add(this.TestConnection);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView MyGrid;
        private FontAwesome.Sharp.IconButton TestConnection;
        private FontAwesome.Sharp.IconButton ConfBD;
        private FontAwesome.Sharp.IconButton confSAP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}