using Front_to_back_sneat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back_sneat.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Work> Works { get; set; }
        public SliderImage SliderImage { get; set; }
        public IEnumerable<Service> Services { get; set; }
    }
}
