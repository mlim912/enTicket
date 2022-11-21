using enTicket.Data.Base;
using enTicket.Models;

namespace enTicket.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(dbContext context):base(context)
        {

        }
    }
}
