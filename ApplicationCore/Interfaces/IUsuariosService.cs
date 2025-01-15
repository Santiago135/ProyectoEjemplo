using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IUsuariosService
    {
        public Task<List<Usuario>> GetUsuarios();
    }
}
