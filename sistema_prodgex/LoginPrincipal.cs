using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_prodgex
{
    public partial class LoginPrincipal : Form
    {
        Conexion con = new Conexion();
        public LoginPrincipal()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void IngresoCompleto()
        {
            if (txtUsuario.Text =="")
            {
                MessageBox.Show("Debe ingresar un Usuario");
                txtUsuario.Focus();
            }
            else 
            {
                if (txtPassword.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña");
                txtPassword.Focus();
            }
                 else
            {
                ingresar(txtUsuario.Text,txtPassword.Text);
            }
            }
           
        }

        private void ingresar(string usuario,string pass)
        {
            int cod;
            string CadSql;
<<<<<<< HEAD
            CadSql = "SELECT nom_usuario, id_tipo_usuario from usuarios where nom_usuario='"+usuario+"';";
           MySqlDataReader Rec = null;
            try
            {
                con.EjecutarConsulta(CadSql);
                while (con.Rec.Read())
                {
                    ClaseArchivador.username = con.Rec["nom_usuario"].ToString();
                    ClaseArchivador.password = con.Rec["pass_usuario"].ToString();
                   
                    ClaseArchivador.id_privilegio = Convert.ToInt32(Rec["id_tipo_usuario"]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Rec != null)
                {
                    con.CerrarConexion();
                    Rec = null;
                }
            }
            if (txtUsuario.Text.Equals(ClaseArchivador.username) && txtPassword.Text.Equals(ClaseArchivador.password))
            {

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña no valido");
            }
           
           
           

           
=======
            CadSql = "SELECT nom_usuario, id_tipo_usuario from usuarios where pass_usuario='"+pass+"';";
            con.EjecutarConsulta(CadSql); 
>>>>>>> origin/master
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
            //IngresoCompleto();
        }

    }
}
