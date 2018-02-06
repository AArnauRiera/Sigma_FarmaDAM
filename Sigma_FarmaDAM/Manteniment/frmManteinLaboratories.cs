﻿using Mantein;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Manteniment
{
    public partial class frmManteinLaboratories : frmManteinBase
    {
        public frmManteinLaboratories()
        {
            InitializeComponent();
        }

        protected override void OpenQuery()
        {
            frmQueryLaboratories query = new frmQueryLaboratories(dgwBase, "Laboratories");
            query.Show();
        }
    }
}