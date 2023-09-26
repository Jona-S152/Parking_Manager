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
    public partial class Tarifas : Form
    {
        public Tarifas()
        {
            InitializeComponent();
        }

        public Tarifas(MenuPrincipal.Buscar buscarPlaca)
        {
            InitializeComponent();
            foreach (var item in Global.listaVehiculos)
            {
                //Busqueda del vehiculo en la lista de vehiculos segun la placa
                if (item._sPlaca == buscarPlaca._buscar)
                {
                    //Obtiene los datos del vehiculo encontrado y los muestra en el informe
                    lblPlacaInforme.Text = item._sPlaca;
                    lblHoraEntrada.Text = item._dHoraEntrada.ToString();
                    lblHoraSalida.Text = item._dHoraSalida.ToString();
                    lblTotalHoras.Text = item._iTotalHoras.ToString();
                    lblCostoTotal.Text = item._fTotal.ToString();
                    break;
                }
            }
        }

        #region Clic botones administrar tarifas por tipo vehiculo
        private void btnAdmMotos_Click(object sender, EventArgs e)
        {
            //Permite editar el txtbox
            txtMotocicletas.Enabled = true;
        }

        private void AdmLivianos_Click(object sender, EventArgs e)
        {
            txtLivianos.Enabled = true;
        }

        private void AdmMedianos_Click(object sender, EventArgs e)
        {
            txtMedianos.Enabled = true;
        }

        private void AdmPesados_Click(object sender, EventArgs e)
        {
            txtPesados.Enabled = true;
        }
        #endregion

        #region Enter modificar tarifas de tipo vehiculo
        private void txtMotocicletas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    //Setea la tarifa del vehiculo segun lo que se ingrese en el campo de texto de la interfaz
                    Global.fTarifaMotocicletas = decimal.Parse(txtMotocicletas.Text);
                    //Obtiene la tarifa por vehiculo motocicletas de la clase global
                    txtMotocicletas.Text = Global.fTarifaMotocicletas.ToString();
                    txtMotocicletas.Enabled = false;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Ingrese una tarífa válida\nUse coma y solo números");
                }
            }
        }

        private void txtLivianos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    Global.fTarifaPequeños = decimal.Parse(txtLivianos.Text);
                    //Obtiene la tarifa por vehiculo pequeño de la clase global
                    txtLivianos.Text = Global.fTarifaPequeños.ToString();
                    txtLivianos.Enabled = false;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Ingrese una tarífa válida\nUse coma y solo números");
                }
                
            }
        }

        private void txtMedianos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    Global.fTarifaMedianos = decimal.Parse(txtMedianos.Text);
                    //Obtiene la tarifa por vehiculo mediano de la clase global
                    txtMedianos.Text = Global.fTarifaMedianos.ToString();
                    txtMedianos.Enabled = false;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Ingrese una tarífa válida\nUse coma y solo números");
                }
            }
        }

        private void txtPesados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    Global.fTarifaGrandes = decimal.Parse(txtPesados.Text);
                    //Obtiene la tarifa por vehiculo pesado de la clase global
                    txtPesados.Text = Global.fTarifaGrandes.ToString();
                    txtPesados.Enabled = false;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Ingrese una tarífa válida\nUse coma y solo números");
                }
            }
        }
        #endregion

        #region Clic administrar tarifas horas
        private void AdmHoraFraccion_Click(object sender, EventArgs e)
        {
            //Permite editar el txtbox
            txtHoraFraccion.Enabled = true;
        }

        private void AdmHoras_Click(object sender, EventArgs e)
        {
            txtHoras.Enabled = true;
        }
        #endregion

        #region Enter modificar tarifas horas
        private void txtHoraFraccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    //Setea la tarifa de hora o fraccion segun lo que se ingrese en el campo de texto de la interfaz
                    Global.fTarifaHoraFraccion = decimal.Parse(txtHoraFraccion.Text);
                    //Para que simule una base de datos en el archivo.Designer tambien agregué esta linea
                    //Obtiene la tarifa por hora de la clase global
                    txtHoraFraccion.Text = Global.fTarifaHoraFraccion.ToString();
                    txtHoraFraccion.Enabled = false;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Ingrese una tarífa válida\nUse coma y solo números");
                }
            }
        }

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    //Setea la tarifa de hora o fraccion segun lo que se ingrese en el campo de texto de la interfaz
                    Global.fTarifa12Horas = decimal.Parse(txtHoras.Text);
                    txtHoras.Text = Global.fTarifa12Horas.ToString();
                    txtHoras.Enabled = false;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Ingrese una tarífa válida\nUse coma y solo números");
                }
            }
        }
        #endregion
    }
}
