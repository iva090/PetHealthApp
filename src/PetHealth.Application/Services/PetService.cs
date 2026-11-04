using AutoMapper;
using Data.Interfaces;
using PetHealth.Business.Exceptions;
using PetHealth.Business.Interfaces;
using PetHealth.Business.Models;
using PetHealth.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Business.Services
{
    public class PetService : IPetService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICurrentUserService _currentUser;

        public PetService(IUnitOfWork unitOfWork, IMapper mapper, ICurrentUserService currentUser)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _currentUser = currentUser;
        }
        public async Task<IReadOnlyList<PetModel>> GetMyPetsAsync()
        {
            var pets = await _unitOfWork.Pets.GetByOwnerAsync(_currentUser.UserId);
            return _mapper.Map<IReadOnlyList<PetModel>>(pets);
        }
        public async Task<PetModel> GetByIdAsync(Guid petId)
        {
            var pet = await _unitOfWork.Pets.GetWithDetailsAsync(petId) ?? throw new NotFoundException("Pet Not found.");
            EnsureOwner(pet);
            return _mapper.Map<PetModel>(pet);
        }

        public async Task<PetModel> CreateAsync(PetModel model)
        {
            var pet = _mapper.Map<Pet>(model);
            pet.OwnerId = _currentUser.UserId;
            await _unitOfWork.Pets.AddAsync(pet);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<PetModel>(pet);
        }

        public async Task DeleteAsync(Guid petId)
        {
            var pet = await _unitOfWork.Pets.GetByIdAsync(petId) ?? throw new NotFoundException("Pet Not found");
            EnsureOwner(pet);

            _unitOfWork.Pets.Delete(pet);
            await _unitOfWork.SaveChangesAsync();
        }



        public async Task<PetModel> UpdateAsync(Guid petId, PetModel model)
        {
            var pet = await _unitOfWork.Pets.GetByIdAsync(petId) ?? throw new NotFoundException("Pet Not Found");

            EnsureOwner(pet);

            _mapper.Map(model, pet);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<PetModel>(pet);
        }

        public void EnsureOwner(Pet pet)
        {
            if (pet.OwnerId != _currentUser.UserId)
            {
                throw new ForbiddenException("You do not own this pet.");
            }
        }
    }
}
