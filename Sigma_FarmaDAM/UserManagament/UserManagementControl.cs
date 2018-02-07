using System;
using DBUtils;
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

        }
        public UserManagementControl(string value)
        {
            _formEdit = true;

        }

        public DataTable SearchTableFromQuery (string query)
        {
            DBUtilities db = new DBUtilities();
            try
            {
                db.Conexion();
                dts = db.PortarPerConsulta(query);
                DataTable t = dts.Tables["Taula"];
                if (t.Rows.Count == 0)
                {
                    return null;
                }
                return t;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public bool SaveChanges (DataSet newDts, string query)
        {
            DBUtilities db = new DBUtilities();
            bool OK;

            try
            {
                db.Conexion();

                OK = db.Actualizar(query, "Taula", newDts);

                return OK;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
    }
}
