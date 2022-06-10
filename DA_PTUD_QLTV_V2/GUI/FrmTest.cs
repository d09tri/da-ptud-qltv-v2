﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuetDauSach frm = new FrmQuetDauSach();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        List<int> lst = new List<int>();

        public void GanDuLieu(List<int> lst)
        {
            this.lst = lst;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string r = "";
            lst.ForEach(t => r += " " + t.ToString());
            MessageBox.Show(r);
        }
    }
}