using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMadrid.DTO;

    class UsuarioDTO
    {
    public List<Usuario> Usuarios = new List<Usuario>();

    public UsuarioDTO()
    {
        Usuarios.Add(new Usuario("Alvaro", "Gasca", "1", "1A"));
    }

    public void NuevoUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
    }
}

