using SimulationMicoHospital.Core.Models;
using SimulationMicoHospital.Core.RepositoryAbstracts;
using SimulationMicoHospital.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationMicoHospital.Data.RepositoryConcretes
{
    public class SliderRepository : GenericRepository<Slider>, ISliderRepository
    {
        public SliderRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
