using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace sistema_prodgex
{
    class subRutinas
    {
        public static void llenarCombobox(ComboBox Cbo, string CadSql, string CampoVer, string CampoValor)
        {
            MySqlDataAdapter DA = new MySqlDataAdapter(CadSql, Conexion.Conex);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Cbo.DataSource = DS.Tables[0];
            Cbo.DisplayMember = CampoVer;
            Cbo.ValueMember = CampoValor;
            Cbo.SelectedIndex = -1;
        }
    }
}
