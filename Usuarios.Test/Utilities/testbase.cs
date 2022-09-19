using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Context;

namespace Usuarios.Test.Utilities
{
    public class testbase
    {
        protected ContextUsuario context;
        public testbase(ContextUsuario context)
        {
           // this.context = context ?? GetinMemoryContext();
        }

      /* private static ContextUsuario GetinMemoryContext()
        {
            var serviceProvider = new ServiceCollection()
                     .AddEntityFrameworkInMemoryDatabase()
                     .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<ContextUsuario>();
            var options = builder.UseInMemoryDatabase("test").UseInternalServiceProvider(serviceProvider).Options;

            ContextUsuario dbContext = new ContextUsuario(options);

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            return dbContext;
        }*/
    }
}
