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
using ISap.SAPB1;
namespace ISap.Setup
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void TestConnection_Click(object sender, EventArgs e)
        {
            Oinv invoice = new Oinv();
            Inv1 lines = new Inv1();
            using (MyContext db = new MyContext())
            {                
                invoice = db.Oinvs.Find(int.Parse(MyGrid.Rows[MyGrid.CurrentRow.Index].Cells[0].Value.ToString()));
                var data = (from d in db.Inv1s
                           select d).ToList();
            }
            Invoice sapInvoice = new Invoice();
            sapInvoice.newInvoice(invoice);
            //invoice.oin
            MessageBox.Show("hecho");
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            loadDocuments();
        }
        private void loadDocuments()
        {
            using (MyContext db = new MyContext())
            {                
             
                MyGrid.DataSource = db.Oinvs.Select(x => new
                {
                    x.IdOinv,
                    x.CardCode,
                    x.CardName,
                    x.DocDate,
                    x.DocTotal
                }).ToList();


            }
        }
    }
}
