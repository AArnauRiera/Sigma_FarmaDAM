using System;
using System.Data;
using Helpers;
using DBUtils;
using System.Windows.Forms;
using Sigma_Controls;

namespace UserManagament
{
    public partial class UserManagement : CentredForm
    {
        UserManagementControl control = new UserManagementControl();

        private bool _NTSHasChanged = true;
        private bool _edit = false;

        // Para añadir
        public UserManagement()
        {
            InitializeComponent();
            lblTitle.Text = "Añadir Cliente";
            CenterPanel(pnlUserManagmnet);
        }

        // Para editar
        public UserManagement(bool value)
        {
            InitializeComponent();
            _edit = value;
            lblTitle.Text = "Editar Cliente";
            CenterPanel(pnlUserManagmnet);
        }

        /// <summary>
        /// Al cargar el formulario se coje una DataTable con la tabla en la BBDD de NTS_Type y se inyecta en el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserManagement_Load(object sender, EventArgs e)
        {
            string query = "SELECT name FROM " + cbxNTS_Type.DBReference;
            DataTable t = control.SearchTableFromQuery(query);
            control.AddComboBoxData(t, cbxNTS_Type);
        }

        /// <summary>
        /// combrueba si se esta editando y si el NTS ha sido modificado, si es asi inyecta los datos segun el NTS en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxNTS_Leave(object sender, EventArgs e)
        {
            if (_NTSHasChanged && _edit)
            {
                control.getDataFromNtsSeach(pnlUserManagmnet.Controls, errorProvider);
                _NTSHasChanged = false;
            }
        }
         /// <summary>
         /// comprueba si el campo NTS esta siendo modificado
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void tbxNTS_TextChanged(object sender, EventArgs e)
        {
            _NTSHasChanged = true;
        }

        /// <summary>
        /// guarda los cambios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            control.SaveChanges(pnlUserManagmnet.Controls, _edit, errorProvider);
        }

        private void tbxDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
