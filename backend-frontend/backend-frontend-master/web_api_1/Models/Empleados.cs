using System.ComponentModel.DataAnnotations;
namespace web_api_1.Models{
    public class Empleados{
        [Key]
        public int id_empleados{get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
        public int id_Puesto {get;set;}
        public string DPI {get;set;}
        public string FechaNacimiento {get;set;}
        public string FechaIgresoRegistro {get;set;}
    }
}