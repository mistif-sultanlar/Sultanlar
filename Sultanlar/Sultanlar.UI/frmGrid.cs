﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace Sultanlar.UI
{
    public partial class frmGrid : Form
    {
        public frmGrid(DataTable DT)
        {
            InitializeComponent();
            dt = DT;
        }

        DataTable dt;

        private void frmGrid_Load(object sender, EventArgs e)
        {
            gridControl3.DataSource = dt;
        }
    }
}
