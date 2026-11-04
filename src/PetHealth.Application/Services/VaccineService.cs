using AutoMapper;
using Data.Interfaces;
using PetHealth.Business.Exceptions;
using PetHealth.Business.Interfaces;
using PetHealth.Business.Models;

namespace PetHealth.Business.Services
{
    public class VaccineService : IVaccineService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICurrentUserService _currentUser;
        private readonly IMapper _mapper;

        public VaccineService(IUnitOfWork unitOfWork, IMapper mapper, ICurrentUserService currentUser)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _currentUser = currentUser;
        }
        public async Task<IEnumerable<VaccineModel>> GetByPetAsync(Guid petId)
        {
            await EnsurePetOwned(petId);
            var vaccines = await _unitOfWork.Vaccines.GetByPetAsync(petId);
            return _mapper.Map<IEnumerable<VaccineModel>>(vaccines);
        }

        public Task<VaccineModel> CreateAsync(VaccineModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }


        public Task<IEnumerable<VaccineModel>> GetUpcomingAsync(int withinDays)
        {
            throw new NotImplementedException();
        }

        public Task<VaccineModel> UpdateAsync(Guid id, VaccineModel model)
        {
            throw new NotImplementedException();
        }

        private async Task EnsurePetOwned(Guid petId)
        {
            var pet = await _unitOfWork.Pets.GetByIdAsync(petId) ?? throw new DirectoryNotFoundException("Pet not found.");

            if (pet.OwnerId != _currentUser.UserId)
            {
                throw new ForbiddenException("You do not own this pet.");
            }
        }
    }
}
