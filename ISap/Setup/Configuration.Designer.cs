
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
            this.TestConnection = new FontAwesome.Sharp.IconButton();
            this.MyGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            this.SuspendLayout();
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
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 284);
            this.Controls.Add(this.MyGrid);
            this.Controls.Add(this.TestConnection);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton TestConnection;
        private System.Windows.Forms.DataGridView MyGrid;
    }
}