using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAPbobsCOM;
using ISap.Helpers;
namespace ISap.Setup
{
    public partial class DBServer : Form
    {
        public DBServer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DBServer_Load(object sender, EventArgs e)
        {
            GetServerTypes();
        }
        private void GetServerTypes()
        {
            
            ServerTypes.DataSource = Enum.GetNames(typeof(BoDataServerTypes));
            
        }

        private void Close_Click(object sender, EventArgs e)
        {

        }

        private void TestConnection_Click(object sender, EventArgs e)
        {
            if (this.testConnection())            
                MessageBox.Show("Conexión Exitosa!");
            else
                MessageBox.Show("Conexión Fallida!");

        }

        private bool testConnection()
        {
            try
            {
                using (Microsoft.Data.SqlClient.SqlConnection cn = new Microsoft.Data.SqlClient.SqlConnection(String.Format("Server={0};Database=DB_ISAP;User Id={1};Password={2};", Server.Text, User.Text, Password.Text)))
                {                    
                    cn.Open();
                    cn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveConfig())
            {
                saveOnDB();
                MessageBox.Show("Credenciales grabadas exitosamente");
                this.Close();
            }else
                MessageBox.Show("Imposible Guardar cambios debido a que no se ha podido conectar con el servidor, favor intente nuevamente");           
        }

        private bool saveConfig()
        {
            if (testConnection())
            {
                Utils.DB_ServerType = ServerTypes.SelectedValue.ToString();
                Utils.DB_Server = Server.Text;
                Utils.DB_User = User.Text;
                Utils.DB_Pass = Password.Text;
                Utils.AddOrUpdateAppSettings("DBServerType", ServerTypes.SelectedValue.ToString());
                Utils.AddOrUpdateAppSettings("DBServer", Server.Text);
                Utils.AddOrUpdateAppSettings("DBUser", User.Text);
                Utils.AddOrUpdateAppSettings("DBPass", Password.Text);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void saveOnDB()
        {
            
            using(ISap.Models.MyContext db = new ISap.Models.MyContext())
            {
                ISap.Models.DbServer server = new ISap.Models.DbServer();
                server.ServerType = ServerTypes.SelectedValue.ToString();                
                server.ServerName = Server.Text;
                server.ServerUser = User.Text;
                server.ServerPass = Password.Text;
                db.Add(server);
                db.SaveChanges();
            }
            
        }
    }    
}
