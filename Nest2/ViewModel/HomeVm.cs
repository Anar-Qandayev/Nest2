using Nest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest2.ViewModel.HomeVM
{
    public class HomeVm
    {
        public List<Category> Categories { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductImg> ProductImages { get; set; }
    }
}
