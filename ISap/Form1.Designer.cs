﻿
namespace ISap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dgvHola = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHola)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvHola
            // 
            this.dgvHola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHola.Location = new System.Drawing.Point(12, 86);
            this.dgvHola.Name = "dgvHola";
            this.dgvHola.RowTemplate.Height = 25;
            this.dgvHola.Size = new System.Drawing.Size(515, 150);
            this.dgvHola.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 68);
            this.button2.TabIndex = 2;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 68);
            this.button3.TabIndex = 3;
            this.button3.Text = "SELECT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 250);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvHola);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "DEMO EntityFramework";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //hola, soy un comentario
        //adios ccc
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvHola;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

