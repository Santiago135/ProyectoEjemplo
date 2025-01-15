using ApplicationCore.Interfaces;
using Domain;
using Infrastructure;
using Infrastructure.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class UsuariosService(UsuariosReader usuariosReader) : IUsuariosService
    {
        public async Task<List<Usuario>> GetUsuarios()
        {
            var usuarios = await usuariosReader.GetUsuarios();
            return usuarios;
        }
    }
}
