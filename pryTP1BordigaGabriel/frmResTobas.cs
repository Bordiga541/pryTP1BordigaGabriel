﻿using System;
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
    public partial class frmResTobas : Form
    {
        public frmResTobas()
        {
            InitializeComponent();
        }

        private void frmResTobas_Load(object sender, EventArgs e)
        {

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmReserva reserva = new frmReserva();
            reserva.Show();
            this.Hide();
        }
    }
}
