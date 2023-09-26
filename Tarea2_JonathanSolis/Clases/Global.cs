using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_JonathanSolis.Clases
{
    public static class Global
    {
        //Lista para registrar y buscar vehículos
        public static List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        // Tarifas segun el tipo de vehículo
        public static decimal fTarifaMotocicletas = 0.50m;
        public static decimal fTarifaPequeños = 1.00m;
        public static decimal fTarifaMedianos = 1.50m;
        public static decimal fTarifaGrandes = 2.00m;

        //Tarifas por hora o mas de 24 horas
        public static decimal fTarifaHoraFraccion = 1.20m;
        public static decimal fTarifa12Horas = 14.40m;

        //Lista de usuarios para el inicio de sesión
        public static Dictionary<string, string> listaUsuarios = new Dictionary<string, string>
        {
            {"Admin", "Admin" },
            {"Usuario1", "Usuario1" },
            {"Usuario2", "Usuario2" }
        };
    }
}
