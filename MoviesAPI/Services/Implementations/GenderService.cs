using System;
using System.Linq;
using MoviesAPI.Data.Entities;
using MoviesAPI.Data.Repositories.Interfaces;
using MoviesAPI.Results;
using MoviesAPI.Services.Interfaces;

namespace MoviesAPI.Services.Implementations
{
    public class GenderService:IGenderService
    {
        private readonly IGenderRepository _genderRepository;

        public GenderService(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }
        public GenderResult Get(int id)
        {
            var result = new GenderResult();
            try
            {
                var gender = _genderRepository.Get(id);
                if (gender == null)
                {
                    result.Success = false;
                    result.Message = "Gender not found";
                    return result;
                }

                result.Success = true;
                result.Content = gender;
                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
            
        }

        public GenderResult GetAll()
        {
            var result = new GenderResult();
            try
            {
                var genders = _genderRepository.GetAll().ToList();
                result.Success = true;
                result.Content = genders;
                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }

        public GenderResult DeleteGender(int id)
        {
            var result = new GenderResult();
            try
            {
                result.Success = _genderRepository.Delete(id);
                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }

        public GenderResult InsertGender(Gender gender)
        {
            var result = new GenderResult();
            try
            {
                _genderRepository.Insert(gender);
                result.Success = true;
                result.Content = gender;
                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }

        public GenderResult UpdateGender(Gender gender)
        {
            var result = new GenderResult();
            try
            {
                _genderRepository.Update(gender);
                result.Success = true;
                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }
    }
}
