using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mantein;
using SearchSystem;
using UserRegister;

namespace Manteniment
{
    public partial class frmManteinUsers : frmManteinBase
    {
        public frmManteinUsers()
        {
            InitializeComponent();
        }

        private bool isOpened = false;

        public override void bntNew_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }

        /// <summary>
        /// abre un formulario para crear un nuevo usuario
        /// </summary>
        private void AddNewUser()
        {
            bool isOpened = false;
            frmUserRegister frmReg = new frmUserRegister();
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.GetType() == frmReg.GetType())
                {
                    isOpened = true;
                }
            }
            if (!isOpened)
            {
                frmReg.Show();
            }
        }

        protected override void OpenQuery()
        {
            frmQueryUsers frm = new frmQueryUsers(this, "Seller");
            frm.Show();
        }
    }
}
