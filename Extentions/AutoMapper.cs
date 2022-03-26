using AutoMapper;
using Resume.Models;
using Resume.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Extentions
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<ContactDto, Contact>();
        }
    }
}
