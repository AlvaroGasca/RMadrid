using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMadrid.DTO;

    public class Usuario
    {
       public String nombre
    {
        get; set;
    }
    public String apellidos
    {
        get; set;
    }
   public String telefono
    {
        get; set;
    }
    public String dni { get; set;}

    public Usuario(string nombre, string apellidos, string telefono, string dni)
    {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.telefono = telefono;
        this.dni = dni;
    }
}

