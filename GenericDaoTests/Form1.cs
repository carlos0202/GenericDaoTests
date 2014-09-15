using GenericDAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericDaoTests
{
    public partial class FrmGDAOTests : Form
    {
        public FrmGDAOTests()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rtbQuery.Text) || String.IsNullOrEmpty(rtbValues.Text))
            {
                MessageBox.Show("favor introducir todos los datos");
            }
            else
            {
                var matches = rtbValues.Text.Split(',');
                ArrayList values = new ArrayList();
                foreach (var val in matches)
                {
                    var value = val.Split('|');
                    var type = Type.GetType(value[1]);
                    values.Add(Convert.ChangeType(value[0],type));
                }
                var directions = rtbDirections.Text.Split(',');
                directions = (directions.Count() == 0 || directions[0] == "") ? null : directions;
                GenericDAO<OracleCommand, OracleConnection, OracleDataAdapter> dao =
                    new GenericDAO<OracleCommand, OracleConnection, OracleDataAdapter>();
                dynamic parameters = "";

                if (IsTextCommand.Checked)
                {
                    dao.FillCommand(rtbQuery.Text, values.ToArray(), directions);
                    parameters = DBUtils.getParameterNames<OracleCommand>(rtbQuery.Text);
                }
                else
                {
                    var prms = rtbQuery.Text.Split('&');
                    var procedureName = prms[0];
                    parameters = prms[1];
                    dao.FillCommand(procedureName, values.ToArray(), parameters, directions);
                }
                
                String result = "";
                result += string.Format("Query: \n {0} \n", rtbQuery.Text);

                result += "\nValores producidos en DbParameter\n\n";
                foreach (OracleParameter parameter in dao.Command.Parameters)
                {
                    result += string.Format("nombre: {3}, valor: {0}, tipo: {1}, direccion: {2}\n", parameter.Value, parameter.DbType, parameter.Direction, parameter.ParameterName);
                }
                rtbResult.Text = result;
            }
        }

    }
}
