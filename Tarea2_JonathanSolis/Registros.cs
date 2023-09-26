using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2_JonathanSolis.Clases;

namespace Tarea2_JonathanSolis
{
    public partial class Registros : Form
    {
        public string _placa;
        public DateTime fechaSalida;
        //Definición del formato de placa con expresiones regulares
        public string validacionPlaca = "[A-Z]{3}[0-9]{3}";

        public Registros()
        {
            InitializeComponent();
        }

        public Registros(MenuPrincipal.Buscar buscarPlaca)
        {
            InitializeComponent();
            //Al llamar a este constructor y pasar como parametro la estructura Buscar
            //estoy importando los datos que guarde en las variables de la estructura
            //Y los muestro en los labels de este formulario
            txtPlacaEntrada.Text = buscarPlaca._buscar;
            txtPlacaSalida.Text = buscarPlaca._buscar;
            _placa = txtPlacaSalida.Text;
        }

        private void txtHoraEntrada_Click(object sender, EventArgs e)
        {
            //Da formato a la hora actual dando clic en el textBox
            txtHoraEntrada.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            if (validacionesEntrada())
            {
                try
                {
                    //Validaciones y guarda los datos pasandolos en el constructor
                    Vehiculo objVehiculo = new Vehiculo(txtPlacaEntrada.Text, DateTime.Parse(txtHoraEntrada.Text));
                    txtHoraEntrada.Text = objVehiculo._dHoraEntrada.Hour.ToString() + ":" + objVehiculo._dHoraEntrada.Minute.ToString() + ":" + objVehiculo._dHoraEntrada.Second.ToString();
                    Global.listaVehiculos.Add(objVehiculo);
                    MessageBox.Show("Vehículo registrado con éxito!");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Ingrese una hora de entrada válida");
                }
                
            }
        }

        private bool validacionesEntrada()
        {
            Regex regex = new Regex(validacionPlaca);
            MatchCollection match = regex.Matches(txtPlacaEntrada.Text);

            if (txtPlacaEntrada.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar la Placa");
                return false;
            }

            //Validacion para que la placa tengo un formato de 3 letras, 3 números y no pase de 6 caracteres en total
            if (match.Count == 0 || txtPlacaEntrada.Text.Length > 6)
            {
                MessageBox.Show("Debe ingresar una placa válida");
                return false;
            }

            if (txtHoraEntrada.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar la Hora");
                return false;
            }

            if (Global.listaVehiculos.Any(vehiculo => vehiculo._sPlaca == txtPlacaEntrada.Text))
            {
                MessageBox.Show("El vehículo ya se encuentra ingresado");
                return false;
            }    
            return true;
        }

        private bool validacionesSalida()
        {
            //Validaciones para los campos de salida
            //Está separado porque todos los textBoxs estan en el mismo formulario
            if (txtPlacaSalida.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar la Placa");
                return false;
            } 

            if (txtHoraSalida.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar la hora de salida");
                return false;
            }

            return true;
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            if (validacionesSalida())
            {
                //Validación por si el usuario ingresa una fecha menor a la fecha de entrada
                if (txtHoraSalida.Value < DateTime.Parse(txtHoraEntrada.Text))
                {
                    MessageBox.Show("Ingrese una fecha válida");
                }
                else
                {
                    foreach (var item in Global.listaVehiculos)
                    {
                        if (item._sPlaca == txtPlacaSalida.Text)
                        {
                            //Al encontrar el vehiculo guarda su hora de salida
                            item._dHoraSalida = txtHoraSalida.Value;
                            item._dFechaSalida = txtHoraSalida.Value;
                            MessageBox.Show("Guardado con éxito!");
                        }
                    }
                }
            }
            
            //Validación por si no se encuentra el vehículo
            if (Global.listaVehiculos.Any(vehiculo => vehiculo._sPlaca.Equals(txtPlacaSalida.Text)) == false)
            {
                MessageBox.Show("Primero registre la entrada del vehículo");
            }
        }

        private void txtPlacaSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //Al presionar enter en el textBox de placa Salida
                //Setea la hora de salida a la hora actual
                txtHoraSalida.Text = DateTime.Now.ToString("HH:mm:ss");
                if (validacionesSalida() && Global.listaVehiculos.Any(vehiculo => vehiculo._sPlaca.Equals(txtPlacaSalida.Text)))
                {
                    //Busqueda del vehiculo segun su placa
                    foreach (var item in Global.listaVehiculos)
                    {
                        if (item._sPlaca == txtPlacaSalida.Text)
                        {
                            //Setea los demas campos segun el vehículo encontrado
                            txtPlacaEntrada.Text = item._sPlaca;
                            txtHoraEntrada.Text = item._dHoraEntrada.ToString("HH:mm:ss");
                            break;
                        }
                    }
                }

                //Validación por si no se encuentra la placa del vehículo
                if (Global.listaVehiculos.Any(vehiculo => vehiculo._sPlaca.Equals(txtPlacaSalida.Text)) == false)
                {
                    MessageBox.Show("Primero registre la entrada del vehículo");
                }
            }
        }
    }
}
