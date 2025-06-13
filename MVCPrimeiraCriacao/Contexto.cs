
using Microsoft.EntityFrameworkCore;
using MVCPrimeiraCriacao.Models;
using System.Collections.Generic;

namespace MVCPrimeiraCriacao
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; } //definindo a tabela Produtos no banco de dados    

    }
}