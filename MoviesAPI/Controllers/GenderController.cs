using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data.Entities;
using MoviesAPI.Data.Repositories.Interfaces;
using MoviesAPI.Results;
using MoviesAPI.Services.Interfaces;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("api/genders")]
    public class GenderController : Controller
    {
        private readonly IGenderService _genderService;

        public  GenderController(IGenderService genderService)
        {
            _genderService = genderService;
        }
        [HttpGet]
        public GenderResult GetAll()
        {
            return _genderService.GetAll();
        }

        [HttpGet("{id}")]
        public GenderResult Get(int id)
        {
            return _genderService.Get(id);
        }

        [HttpPost]
        public GenderResult Insert(Gender gender)
        {
            return _genderService.InsertGender(gender);
        }

        [HttpDelete]
        public GenderResult Delete(int genderId)
        {
            return _genderService.DeleteGender(genderId);
        }

        [HttpPost("Update")]
        public GenderResult Update(Gender gender)
        {
            return _genderService.UpdateGender(gender);
        }
    }
}
