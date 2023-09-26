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
    public partial class CalcularCosto : Form
    {
        Vehiculo vehiculo = new Vehiculo();

        public CalcularCosto()
        {
            InitializeComponent();
        }

        public CalcularCosto(MenuPrincipal.Buscar buscarPlaca)
        {
            InitializeComponent();
            var fecha = buscarPlaca._fecha;

            foreach (var item in Global.listaVehiculos)
            {
                if (item._sPlaca == buscarPlaca._buscar)
                {
                    //Trae los datos desde el formulario del que se llama a este constructor
                    lblPlacaCC.Text = item._sPlaca;
                    lblHEntradaCC.Text = item._dHoraEntrada.ToString();
                    lblHSalidaCC.Text = item._dHoraSalida.ToString();
                    break;
                }
            }

            foreach (var item in Global.listaVehiculos)
            {
                //Busqueda del vehiculo en la lista de vehiculos segun la placa
                if (item._sPlaca == buscarPlaca._buscar)
                {
                    //Setea el total de horas del vehiculo encontrado
                    item._iTotalHoras = vehiculo.calcularTotalHora(DateTime.Parse(lblHEntradaCC.Text), DateTime.Parse(lblHSalidaCC.Text), fecha);
                    if (item._iTotalHoras > 0)
                    {
                        lblTotalHorasCC.Text = Convert.ToString(vehiculo._iTotalHoras);
                    }
                    else
                    {
                        lblTotalHorasCC.Text = "0";
                    }
                }
            }
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            if (cbTipoVehiculoCC.Text.Length > 0)
            {
                //Busco el vehiculo registrado para setear sus datos (costo total y total de horas)
                foreach (var item in Global.listaVehiculos)
                {
                    //Condicional para usar el método 1 de calcular total
                    if (item._iTotalHoras > 0 && item._iTotalHoras < 24)
                    {
                        //Busqueda del vehiculo en la lista de vehiculos segun la placa
                        if (item._sPlaca == lblPlacaCC.Text)
                        {
                            //Aqui no setea la tarifa porque en mi caso no lo necesitaba para mostrar en el informe
                            //Pero se puede hacer de la misma forma agregando return en el metodo
                            vehiculo.calcularTarifa(cbTipoVehiculoCC.Text, Global.fTarifaHoraFraccion);
                            //setea el total del vehiculo que se encontró segun la placa
                            item._fTotal = vehiculo.calcularTotal();
                            lblCostoTotalCC.Text = Convert.ToString(item._fTotal);
                        }
                    }

                    //Condicional para usar el metodo 2 de calcular total
                    if (item._iTotalHoras >= 24)
                    {
                        //Busqueda del vehiculo en la lista de vehiculos segun la placa
                        if (item._sPlaca == lblPlacaCC.Text)
                        {
                            vehiculo.calcularTarifa(cbTipoVehiculoCC.Text, Global.fTarifa12Horas);
                            //Sobrecarga del método calcularTotal
                            //Usa el método con parametro
                            item._fTotal = vehiculo.calcularTotal(vehiculo._iTotalHoras);
                            lblCostoTotalCC.Text = Convert.ToString(item._fTotal);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Debe selecionar un tipo de vehículo");
            }

        }
    }
}
