using Resume.Interfaces;
using Resume.Models;
using Resume.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationContext _dbContext;

        public ContactRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Create(Contact contact)
        {
            await _dbContext.Contacts.AddAsync(contact);
            _dbContext.SaveChanges();

            return true;
        }
    }
}
