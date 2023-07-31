using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactoController : ControllerBase
    {
        private PruebasContext _context;

        public ContactoController(PruebasContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<ContactosQR> Get() => _context.Contactos.ToList();
    }
}
