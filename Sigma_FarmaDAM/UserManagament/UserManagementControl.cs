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

        }
        public UserManagementControl(string value)
        {
            _formEdit = true;

        }

        public string[] SearchUser (string value)
        {
            string[] data = new string[0];
            DBUtils.DBUtils db = new DBUtils.DBUtils();
            string query = "SELECT * FROM Clients where NTS = '"+value+"'";
            try
            {
                db.Conexion();
                dts = db.PortarPerConsulta(query);
                DataTable t = dts.Tables[0];
                if (t != null)
                {
                    DataRow r = dts.Tables[0].Rows[0];
                    foreach (var val in r.ItemArray)
                    {
                        Array.Resize(ref data, data.Length + 1);
                        data[data.Length - 1] = val.ToString();

                    }
                }
                else
                {
                    data = null;
                }

                db.Actualizar(query, "Taula", dts);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                data = null;
            }

            return data;
        }
    }
}
