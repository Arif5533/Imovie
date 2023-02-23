using imovie.Data.Base;
using imovie.Models;

namespace imovie.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>,IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
