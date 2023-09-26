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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        Buscar buscar;

        public struct Buscar
        {
            public string _buscar;
            public string _horaEntrada;
            public string _horaSalida;
            public DateTime _fecha;
        }
        
        //Método para abrir un formulario en el panel contenedor
        private void AbrirFormulario(object formulario)
        {
            //Si el panelContenedor tiene al menos 1 control lo remueve
            if(this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            //El parametro lo guarda en una variable tipo Form como un Form
            Form form = formulario as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(form);
            this.panelContenedor.Tag = form;
            form.Show();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Registros());
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Labels de hora y fecha en el menu principal
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnTarifa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Tarifas());
            
        }

        private void btnCosto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new CalcularCosto());
        }

        private void pbIconoBuscar_Click(object sender, EventArgs e)
        {
            foreach (var item in Global.listaVehiculos)
            {
                if (item._sPlaca.Equals(txtBuscar.Text))
                {
                    //Al dar click al icono buscar sus variables toma los valores del textBox y del vehiculo encontrado en la lista
                    buscar._buscar = txtBuscar.Text;
                    buscar._horaEntrada = item._dHoraEntrada.ToString("HH:mm:ss");
                    buscar._horaSalida = item._dHoraSalida.ToString("HH:mm:ss");
                    buscar._fecha = item._dFechaSalida;
                    AbrirFormulario(new CalcularCosto(buscar));
                }
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                foreach (var item in Global.listaVehiculos)
                {
                    if (item._sPlaca.Equals(txtBuscar.Text))
                    {
                        //Lo mismo que el anterior pero al presionar enter
                        buscar._buscar = txtBuscar.Text;
                        buscar._horaEntrada = item._dHoraEntrada.ToString("HH:mm:ss");
                        buscar._horaSalida = item._dHoraSalida.ToString("HH:mm:ss");
                        buscar._fecha = item._dFechaSalida;
                        AbrirFormulario(new Tarifas(buscar));
                    }
                }
            }
        }
    }
}
