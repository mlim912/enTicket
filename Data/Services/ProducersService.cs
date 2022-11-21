using enTicket.Data.Base;
using enTicket.Models;

namespace enTicket.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(dbContext context) : base(context)
        {
               
        }
    }
}
