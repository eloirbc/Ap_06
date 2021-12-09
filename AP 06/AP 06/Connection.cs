using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AP_06.GestionSql;

namespace AP_06
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getFamilles();
            getMedicaments();
            getEtapes();
            getDecision();
        }
        private void btConnexion_Click(object sender, EventArgs e)
        {
            Hide();
            Menu oneMenu = new Menu();

            oneMenu.ShowDialog();
        }
    }
}
