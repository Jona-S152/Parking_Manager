using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2_JonathanSolis.Clases;

namespace Tarea2_JonathanSolis
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                if (Global.listaUsuarios.Any(usuario => usuario.Key.Equals(txtUsuario.Text) && usuario.Value.Equals(txtContraseña.Text)))
                {
                    this.Hide();
                    MenuPrincipal principal = new MenuPrincipal();
                    principal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
        }

        private bool validaciones()
        {
            if (txtUsuario.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Ingrese su nombre de usuario");
                txtUsuario.Focus();
                return false; 
            }
            if (txtContraseña.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese una contraseña");
                txtContraseña.Focus();
                return false;
            }
            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) txtContraseña.Focus();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (validaciones())
                {
                    if (Global.listaUsuarios.Any(usuario => usuario.Key.Equals(txtUsuario.Text) && usuario.Value.Equals(txtContraseña.Text)))
                    {
                        this.Hide();
                        MenuPrincipal principal = new MenuPrincipal();
                        principal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                }
            }
        }
    }
}
