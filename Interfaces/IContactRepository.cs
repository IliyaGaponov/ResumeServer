using Resume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Interfaces
{
    public interface IContactRepository
    {
        Task<bool> Create(Contact contact);
    }
}
