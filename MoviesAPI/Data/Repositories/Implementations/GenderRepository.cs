using MoviesAPI.Data.Entities;
using MoviesAPI.Data.Repositories.Interfaces;

namespace MoviesAPI.Data.Repositories.Implementations
{
    public class GenderRepository: Repository<Gender>, IGenderRepository
    {
        public GenderRepository(MoviesContext context) : base(context)
        {
        }
    }
}
