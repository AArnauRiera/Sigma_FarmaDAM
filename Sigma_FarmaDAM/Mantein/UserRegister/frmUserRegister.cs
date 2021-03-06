﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserRegister
{
    public partial class frmUserRegister : Form
    {
        private bool exit = false;
        public frmUserRegister()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento Click para guardar el nuevo usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// comprueba que el formato del texto sea el correcto y que los datos unicos no esten insertados en la BBDD, comprueba que las contraseñas sean iguales, si es todo correcto actualiza la BBDD con el nuevo usuario
        /// </summary>
        private void Save()
        {
            UserRegisterControl.UserRegisterControl control = new UserRegisterControl.UserRegisterControl(tbxUsername.Text);

            if (control.CheckControlsFormat(errorProvider, Controls, tbxUsername, tbxPassword) &&
                !control.CheckIsReal(tbxUsername, errorProvider, "Seller") &&
                !control.CheckIsReal(tbxEmail, errorProvider, "Seller") && 
                !control.CheckIsReal(tbxDNI, errorProvider, "Seller"))
            {
                if (control.CheckIfPasswordRepeatIsEqual(tbxPassword, tbxRepeatPassword, tbxUsername))
                {
                    exit = control.SaveChanges(Controls);
                    if (exit)
                    {
                        Close();
                        Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// Cuando se preme una tecla comprueba si es un Enter, si lo es guarda el nuevo usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserRegister_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter: Save();
                    break;
            }
        }

        /// <summary>
        /// al pulsar el boton de Cancelar cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
