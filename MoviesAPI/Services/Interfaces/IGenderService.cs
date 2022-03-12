using MoviesAPI.Data.Entities;
using MoviesAPI.Results;

namespace MoviesAPI.Services.Interfaces
{
    public interface IGenderService
    {
        public GenderResult Get(int id);
        public GenderResult GetAll();
        public GenderResult DeleteGender(int id);
        public GenderResult InsertGender(Gender gender);
        public GenderResult UpdateGender(Gender gender);
    }
}