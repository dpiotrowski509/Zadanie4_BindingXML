using System.Collections.Generic;

namespace Zadanie4_BindingXML.Models
{
    public class CarCategory
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CarBrand> CarBrands { get; set; }
    }
}