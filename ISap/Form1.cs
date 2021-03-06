using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISap.Models;
using SAPbobsCOM;
namespace ISap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Company company = new Company();
            company.DbServerType = BoDataServerTypes.dst_MSSQL2019;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            using( DB_ISAPContext db = new DB_ISAPContext())
            {
                Ousr user = new Ousr();
                
                user.Usercode = "SDA";
                user.Username = "yyy";
                db.Add(user);                
                db.SaveChanges();
            }
            MessageBox.Show("registro ingresado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DB_ISAPContext db = new DB_ISAPContext())
            {
                Ousr user = new Ousr();
                user.IdOusr = 1;
                user.Usercode = "SDA";
                user.Username = "yyy";
                db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            MessageBox.Show("registro Actualizado");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Helpers.Utils.DB_Server = "DESKTOP-R24LB32";
            Helpers.Utils.DB_User = "sa";
            Helpers.Utils.DB_Pass = "1234";
            using (MyContext db = new MyContext())
            {
                
                var data = db.Ousrs
                           .Select(q => new
                           {
                               q.Usercode,
                               q.Username
                           });
                dgvHola.DataSource = data.ToList();
                
            }
        }
        
    }
}
