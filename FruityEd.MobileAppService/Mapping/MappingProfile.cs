using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FruityEd.MobileAppService.Controllers.Resources;
using FruityEd.MobileAppService.Core.Models;

namespace FruityEd.MobileAppService.Mapping
{
    public class MappingProfile : Profile
    {

        // Domain to API Resource

        public MappingProfile()
        {
            CreateMap<Location, KeyValuePairResource>();

        }

        
    }
}
