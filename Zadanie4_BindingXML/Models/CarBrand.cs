using System;
using System.Collections.Generic;

namespace Zadanie4_BindingXML.Models
{
    public class CarBrand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string EstablishmentYear { get; set; }
        public string ParentConcern { get; set; }
        public List<CarModel> CarModels { get; set; }
    }
}