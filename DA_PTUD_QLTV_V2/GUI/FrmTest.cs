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
        Helper helper = new Helper();

        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            string duongDan = helper.LayDuongDanAnhBia() + "Ban-ve-tu-do.jpg";
            Image anhBia = helper.LayAnhBiaDauSach(duongDan, 170, 178);
        }
    }
}