using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagament
{
    class UserManagementControl
    {
        private DataSet dts = new DataSet();
        private bool _formEdit;
        public UserManagementControl()
        {
            _formEdit = false;
            UserManagement frm = new UserManagement();

        }
        public UserManagementControl(string value)
        {
            UserManagement frm = new UserManagement();
            SearchUser(value, frm);
            _formEdit = true;

        }

        public void SearchUser (string value, UserManagement frm)
        {
            DBUtils.DBUtils db = new DBUtils.DBUtils();
            string query = "SELECT * FROM Clients";
            try
            {
                dts = db.PortarPerConsulta(query);
                DataTable t = dts.Tables["Taula"];
                DataRow r = t.NewRow();

                MessageBox.Show(r["DNI"].ToString());

                dts.Tables[0].Rows.Add(r);
                db.Actualizar(query, "Taula", dts);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
