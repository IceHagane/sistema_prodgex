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
            string CadSql;
            CadSql = "SELECT nom_usuario, id_tipo_usuario from usuarios where pass_usuario='"+pass+"';";
            con.EjecutarConsulta(CadSql);
            if ( == 1)
            {
                MessageBox.Show("Usuario o Contraseña Invalido");
                txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show("Exito!");
            }

           
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            IngresoCompleto();
        }

    }
}
