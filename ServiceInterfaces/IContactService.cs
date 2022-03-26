using Resume.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.ServiceInterfaces
{
    public interface IContactService
    {
        Task<bool> CreateContact(ContactDto contact);
    }
}
