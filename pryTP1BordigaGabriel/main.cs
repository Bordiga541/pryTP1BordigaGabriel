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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void cmdReservar_Click(object sender, EventArgs e)
        {
            frmReserva reserva = new frmReserva();
            reserva.Show();
            this.Hide();
            
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdVerReservas_Click(object sender, EventArgs e)
        {
            frmVerReservas verReservas = new frmVerReservas();
            verReservas.Show();
            this.Hide();
        }
    }
}
