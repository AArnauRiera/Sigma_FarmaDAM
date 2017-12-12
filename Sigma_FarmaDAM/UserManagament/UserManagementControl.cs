using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagament
{
    class UserManagementControl
    {
        private bool _formEdit;
        public UserManagementControl()
        {
            var userManagementForm = new UserManagement();
            userManagementForm.lblTitle.Text = "Add User";
            userManagementForm.btnUserManagement.Text = "Add";
            userManagementForm.Show();

            _formEdit = false;
        }
        public UserManagementControl(string value, string valueType)
        {
            var userManagementForm = new UserManagement();
            userManagementForm.lblTitle.Text = "Edit User";
            userManagementForm.btnUserManagement.Text = "Save";
            userManagementForm.Show();

            _formEdit = true;
        }
    }
}
