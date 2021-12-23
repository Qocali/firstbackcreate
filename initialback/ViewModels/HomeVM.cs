using initialback.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace initialback.ViewModels
{
    public class HomeVM
    {
        public List<Sliderimage> Sliderimage{ get; set; }
        public Slider Slider{ get; set; }
        public About About { get; set; }
        public List<Icon> Icon { get; set; }
        public List<Florish> Florishe { get; set; }
        public List<FlorishType> FlorishType { get; set; }
    }
}
