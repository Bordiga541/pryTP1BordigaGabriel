using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTP1BordigaGabriel
{
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

        private void cmdQuenaken_Click(object sender, EventArgs e)
        {
            frmResQuenaken frmResQuenaken = new frmResQuenaken();
            frmResQuenaken.Show();
            this.Hide();
        }

        private void cmdOnas_Click(object sender, EventArgs e)
        {
            frmResOnas frmResOnas = new frmResOnas();
            frmResOnas.Show();
            this.Hide();
        }

        private void cmdTobas_Click(object sender, EventArgs e)
        {
            frmResTobas frmResTobas = new frmResTobas();
            frmResTobas.Show(); 
            this.Hide();

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            main menu = new main();
            menu.Show();
            this.Hide();
        }
    }
}
