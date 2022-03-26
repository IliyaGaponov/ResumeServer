using AutoMapper;
using Resume.Interfaces;
using Resume.Models;
using Resume.Models.DTO;
using Resume.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IMapper _mapper;

        public ContactService(IContactRepository contactRepository, IMapper mapper)
        {
            _contactRepository = contactRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreateContact(ContactDto contact)
        {
            return await _contactRepository.Create(_mapper.Map<Contact>(contact));
        }
    }
}
