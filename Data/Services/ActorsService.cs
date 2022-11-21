using enTicket.Data.Base;
using enTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace enTicket.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        private readonly dbContext _context;
        public ActorsService(dbContext context) : base(context) { }
        
    }
}
