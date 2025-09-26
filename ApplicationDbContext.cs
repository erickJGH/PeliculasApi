using System.Runtime.InteropServices.Marshalling;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using PeliculasApi.Entidades;
using PeliculasApi.Migrations;

namespace PeliculasApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {


        }

        public DbSet<Genero> Generos { get; set; }

        
    }
}

//Como hacer las migraciones en la terminal de Visual Studio Code:
//Add - Migration TablaGeneros


//Update-Database