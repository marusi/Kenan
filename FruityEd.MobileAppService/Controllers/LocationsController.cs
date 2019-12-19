using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FruityEd.MobileAppService.Core.Models;
using FruityEd.MobileAppService.Persistence;
using AutoMapper;
using FruityEd.MobileAppService.Controllers.Resources;

namespace FruityEd.MobileAppService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : Controller
    {

        private readonly FruityEdDbContext context;
        private readonly IMapper mapper;

        public LocationsController(FruityEdDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet("/api/locations")]

        public async Task<IEnumerable<KeyValuePairResource>> GetLocations()
        {
            var locations = await context.Locations.ToListAsync();

            return mapper.Map<List<Location>, List<KeyValuePairResource>>(locations);

        }
    }
}
