﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;



namespace SearchSystem
{
    public partial class SearchSystem : Form
    {



        


        public SearchSystem()
        {
            InitializeComponent();
           
           

        }
       
        private void txtDrug_TextChanged(object sender, EventArgs e)
        {
            DBUtils BDUtils= new DBUtils();
            String Querry = txtDr
            BDUtils.PortarPerConsulta(txtDrug.Text())


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
