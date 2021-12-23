using AutoMapper;
using InfoJobs.Data.Repository;
using InfoJobs.Dtos;
using InfoJobs.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InfoJobs.Services
{
    public class CandidateExperiencesServices : ICandidateExperiencesServices
    {


        private readonly IExperiencesRepo _repo;
        private readonly IMapper _mapper;

        public CandidateExperiencesServices(IExperiencesRepo repo, IMapper mapper)
        {

            this._mapper = mapper;
            this._repo = repo;

        }
        public async Task<IEnumerable<CandidateExperiencesDto>> GetAllExperiences()
        {
            var experiences = await _repo.GetAllExperiencesAsync();


            return _mapper.Map<IEnumerable<CandidateExperiencesDto>>(experiences);
        }

        public async Task<IEnumerable<CandidateExperiencesDto>> GetExperienceAsyncByCandidateId(int idCandidate)
        {

            var experiences = await _repo.GetExperiencesAsyncByCandidatesId(idCandidate);

            return _mapper.Map<IEnumerable<CandidateExperiencesDto>>(experiences);




        }

        public async Task<CandidateExperiencesDto> GetExperienceAsyncById(int idExperience)
        {

            var experience = await _repo.GetExperiencesAsyncById(idExperience);

            return _mapper.Map<CandidateExperiencesDto>(experience);



        }

        public async Task<CandidateExperiencesDto> PostExperienceAsync(CandidateExperiencesRequestDto experienceDto)
        {


            try
            {

                var experience = _mapper.Map<CandidateExperiences>(experienceDto);

                _repo.Add(experience);


                if (await _repo.SaveChangesAsync())
                {
                    var response = _mapper.Map<CandidateExperiencesDto>(experienceDto);
                    return response;
                }
                else
                {
                    throw new InvalidOperationException("Operação falhou");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }





        }


    }
}
