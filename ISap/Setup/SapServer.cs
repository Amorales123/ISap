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
using ISap.Helpers;
namespace ISap.Setup
{
    public partial class SapServer : Form
    {
        public SapServer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SapServer_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveOnDB())
            {
                MessageBox.Show("Credenciales grabadas exitosamente");
                this.Close();
            }else
                MessageBox.Show("Imposible Guardar cambios debido a que no se ha podido conectar con el servidor, favor intente nuevamente");

        }
        private bool saveOnDB()
        {
            if (testConnection())
            {
                using (ISap.Models.MyContext db = new ISap.Models.MyContext())
                {
                    Utils.AddOrUpdateAppSettings("SAPCompany", Database.Text);                    
                    Utils.AddOrUpdateAppSettings("SAPUser", User.Text);
                    Utils.AddOrUpdateAppSettings("SAPPass", Password.Text);
                    ISap.Models.SapServer sapServer = new ISap.Models.SapServer();
                    sapServer.CmpName = MyGrid.Rows[MyGrid.CurrentRow.Index].Cells[0].Value.ToString();
                    sapServer.DbName = Database.Text;
                    sapServer.Loc = MyGrid.Rows[MyGrid.CurrentRow.Index].Cells[2].Value.ToString();
                    sapServer.VersStr = MyGrid.Rows[MyGrid.CurrentRow.Index].Cells[3].Value.ToString();
                    db.Add(sapServer);
                    db.SaveChanges();
                }
                return true;
            }
            return false;
        }
        private void loadData()
        {
            
            using (MyContext db = new MyContext())
            {
               
                ServerTypes.DataSource = db.DbServers.Select(x => x.ServerType).ToList();
                Servers.DataSource = db.DbServers.Select(x => x.ServerName).ToList();
            }
            
        }

        private void Servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (Microsoft.Data.SqlClient.SqlConnection cn = new Microsoft.Data.SqlClient.SqlConnection(String.Format("Server={0};Database=SBO-COMMON;User Id={1};Password={2};", Utils.DB_Server, Utils.DB_User, Utils.DB_Pass)))
                {
                    var bindingSource = new BindingSource();
                    String query = @"SELECT cmpName AS Sociedad,dbName AS [Nombre DB] ,LOC AS Region,versStr AS Version FROM SRGC;";
                    using(Microsoft.Data.SqlClient.SqlDataAdapter dataAdapter = new Microsoft.Data.SqlClient.SqlDataAdapter(query, cn))
                    {
                        cn.Open();
                        using (Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder = new Microsoft.Data.SqlClient.SqlCommandBuilder(dataAdapter))
                        {
                            DataTable table = new DataTable();
                            dataAdapter.Fill(table);
                            bindingSource.DataSource = table;
                            MyGrid.ReadOnly = true;
                            MyGrid.DataSource = bindingSource;
                            Database.Text = MyGrid.Rows[MyGrid.CurrentRow.Index].Cells[1].Value.ToString();
                        }
                        cn.Close();
                    }
                }
            }
            catch
            {

            }
        }

        private void MyGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Database.Text = MyGrid.Rows[MyGrid.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void TestConnection_Click(object sender, EventArgs e)
        {
            testConnection();
        }

        private bool testConnection()
        {
            Utils.SAP_Company = Database.Text;
            Utils.SAP_User = User.Text;
            Utils.SAP_Pass = Password.Text;
            int errorCode;
            string errorMessage;
            if (new ISap.SAPB1.DI().connect(out errorCode, out errorMessage))
            {
                MessageBox.Show("Conexión Probada y conectada de forma exitosa");
                return true;
            }                
            else
                MessageBox.Show(String.Format("Errores durante la conexión {0}, {1}", errorCode.ToString(), errorMessage));
            return false;
        }
    }
}
