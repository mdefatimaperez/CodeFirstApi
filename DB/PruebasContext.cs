using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class PruebasContext : DbContext
    {
        
        //constructor                                                   //SE LO PASA AL PADRE   
        public PruebasContext(DbContextOptions<PruebasContext> options) : base(options)
        {

        }


        //espesificamos la creacion de la tabla Contactos CONTACTOSQR
        public DbSet<ContactosQR> Contactos {  get; set; }

         
    }
}