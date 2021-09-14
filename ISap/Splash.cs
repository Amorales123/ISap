using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ISap.Setup;
using ISap.Helpers;
namespace ISap
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
           
        }       
        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            evaluate();
            ProgressBar.Width += 3;
            if (ProgressBar.Width >= 700)
            {
                timer1.Stop();
                ProgressBar.Width = 3;
                Setup.Configuration configuration = new Setup.Configuration();
                configuration.Show();
                this.Hide();
            }            
            
        }
        private void evaluate()
        {
            timer1.Stop();
            if (evaluateDBServer())
            {
                
                if (MessageBox.Show("Deseas registrar configuración? ", "Servidor de Base de datos no encontrado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBServer server = new DBServer();
                    server.ShowDialog();                    
                }
            }else
            {
                Utils.DB_ServerType = Utils.getAppSettings("DBServerType");
                Utils.DB_Server = Utils.getAppSettings("DBServer");
                Utils.DB_User = Utils.getAppSettings("DBUser");
                Utils.DB_Pass = Utils.getAppSettings("DBPass");
            }
            if (evaluateSapServer())
            {                
                if (MessageBox.Show("Deseas registrar configuración? ", "Servidor de SAP B1 no encontrado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new ISap.Setup.SapServer().ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                Utils.SAP_Company = Utils.getAppSettings("SAPCompany");
                Utils.SAP_User = Utils.getAppSettings("SAPUser");
                Utils.SAP_Pass = Utils.getAppSettings("SapPass");
            }
            
            timer1.Start();
        }
        /// <summary>
        /// Evaluar la conectividad con el servidor de base de datos
        /// </summary>
        /// <returns> True or False</returns>
        private bool evaluateDBServer() => Utils.getAppSettings("DBServer") is null || Utils.getAppSettings("DBUser") is null || Utils.getAppSettings("DBPass") is null;

        /// <summary>
        /// Evaluar la conectividad con el servidor de SAP B1
        /// </summary>
        /// <returns> True or False</returns>
        private bool evaluateSapServer() => Utils.getAppSettings("SAPCompany") is null || Utils.getAppSettings("SAPUser") is null || Utils.getAppSettings("SapPass") is null;
 
    }
}
