﻿using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using webApp_manha.Entidade;

namespace webApp_manha
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt)
        {}
        public DbSet<Produtos> PRODUTOS { get; set; }



    }
}
