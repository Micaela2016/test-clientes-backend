using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClientesApi.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ClientesApi.DataContext.Data
{
    public static class DbInitializer
    {
          public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var _context = new ClienteContext(serviceProvider.GetRequiredService<DbContextOptions<ClienteContext>>()))
            {
              if (_context.Clientes.Any()){
                return;
              }
              _context.Clientes.AddRange(
                new models.Cliente {Nombre="Micaela", Apellido="Orellano", Direccion="Rep siria"},
                new models.Cliente {Nombre="Micaela", Apellido="Orellano", Direccion="Rep siria"},
                new models.Cliente {Nombre="Micaela", Apellido="Orellano", Direccion="Rep siria"},
                new models.Cliente {Nombre="Micaela", Apellido="Orellano", Direccion="Rep siria"}
              );
            _context.SaveChanges();

            }
        }
    }
}