using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_JonathanSolis.Clases
{
    public class Vehiculo
    {
        public string _sPlaca { get; set; }
        public DateTime _dHoraEntrada { get; set; }
        public DateTime _dHoraSalida { get; set; }
        public DateTime _dFechaSalida { get; set; }
        public string _sTipo { get; set; }
        public decimal _fTarifa { get; set; }
        public decimal _fTarifaTipoVehiculo { get; set; }
        public int _iTotalHoras { get; set; }
        public decimal _fTotal { get; set; }
        public String _sEstado { get; set; }

        public Vehiculo() { }

        public Vehiculo(string sPlaca, DateTime dHoraEntrada)
        {
            this._sPlaca = sPlaca;
            this._dHoraEntrada = dHoraEntrada;
            this._sEstado = "A";
        }

        public void calcularTarifa(string _tipo, decimal _Tarifa)
        {
            this._sTipo = _tipo;
            switch (_tipo)
            {
                case "Motocicletas":
                    this._fTarifaTipoVehiculo = Global.fTarifaMotocicletas;
                    break;
                case "Livianos":
                    this._fTarifaTipoVehiculo = Global.fTarifaPequeños;
                    break;
                case "Medianos":
                    this._fTarifaTipoVehiculo = Global.fTarifaMedianos;
                    break;
                case "Pesados":
                    this._fTarifaTipoVehiculo = Global.fTarifaGrandes;
                    break;

            }

            this._fTarifa = _Tarifa;
            if (_Tarifa == Global.fTarifaHoraFraccion)
            {
                _fTarifa = Global.fTarifaHoraFraccion;
            }
            else if (_Tarifa == Global.fTarifa12Horas)
            {
                _fTarifa = Global.fTarifa12Horas;
            }
        }

        public int  calcularTotalHora(DateTime _horaEntrada, DateTime _horaSalida, DateTime _fechaSalida)
        {
            _dHoraEntrada = _horaEntrada;
            _dHoraSalida = _horaSalida;
            TimeSpan diff = _dHoraSalida - _dHoraEntrada;
            this._iTotalHoras = ((int)Math.Ceiling(diff.TotalHours));
            if (_iTotalHoras == 24)
            {
                TimeSpan time = _fechaSalida - _horaEntrada;
                return ((int)Math.Ceiling(time.TotalHours));
            }
            else
            {
                return ((int)Math.Ceiling(diff.TotalHours));
            }

        }

        //Calcula tarifa para cuando el tiempo total es menor a 24 horas
        public decimal calcularTotal()
        {
            //Se puede hacer solo con this._fTotal, pero eso no setea el costo total del vehiculo registrado
            return (_fTarifaTipoVehiculo + _fTarifa) * _iTotalHoras;
        }

        //Calcula costo total para cuando el tiempo total es mayor o igual a 24 horas
        public decimal calcularTotal(int adicion)
        {
            //Usé return para poder guardarlo en los datos del vehiculo que se esté registrando o que ya esté registrado
            //Se puede hacer solo con this._fTotal, pero eso no setea el costo total del vehiculo registrado
            return ((_fTarifaTipoVehiculo + _fTarifa) * _iTotalHoras) + ((adicion - 24) * (_fTarifaTipoVehiculo + _fTarifa));
        }


    }
}
