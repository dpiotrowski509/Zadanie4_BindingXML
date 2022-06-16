using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Zadanie4_BindingXML.Models;

namespace Zadanie4_BindingXML.XML
{
    public class ExampleXML
    {
        public ExampleXML()
        { 
            XmlSerializer serializer = new XmlSerializer(typeof(Cars));
            using (TextWriter writer = new StreamWriter("example.xml"))
            {
                serializer.Serialize(writer, CreateNewExampleDataToSerialization());
            }
        }


        private Cars CreateNewExampleDataToSerialization()
        {
            return new Cars
            {
                CarCategories = new List<CarCategory>()
                {
                    new CarCategory {
                        Name = "Samochody osobowe",
                        Description = "Opis samochodów osobowych",
                        CarBrands = new List<CarBrand>(){
                            new CarBrand {
                                Name = "Opel",
                                Description = "Opis dla marki Opel",
                                EstablishmentYear = new DateTime(1862,1,21).ToShortDateString(),
                                ParentConcern = "Stellantis",
                                CarModels = new List<CarModel>()
                                {
                                    new CarModel{
                                        Name = "Corsa",
                                        ProductionYear = 1993,
                                        DriveType = "FWD",
                                        EngineCompacity = 1.4d
                                    },
                                    new CarModel{
                                        Name = "Astra",
                                        ProductionYear = 1991,
                                        DriveType = "FWD",
                                        EngineCompacity = 1.4d
                                    },
                                }                             
                            },
                            new CarBrand {
                                Name = "BMW",
                                Description = "Opis dla marki BMW",
                                EstablishmentYear = new DateTime(1916,3,7).ToShortDateString(),
                                ParentConcern = "BMW",
                                CarModels = new List<CarModel>()
                                {
                                    new CarModel{
                                        Name = "E36",
                                        ProductionYear = 1993,
                                        DriveType = "RWD",
                                        EngineCompacity = 1.6d
                                    },
                                    new CarModel{
                                        Name = "E46",
                                        ProductionYear = 2000,
                                        DriveType = "RWD",
                                        EngineCompacity = 1.6d
                                    },
                                }                             
                            },
                        }
                    },
                    new CarCategory {
                        Name = "Samochody ciężarowe",
                        Description = "Opis samochodów ciężarowych",
                        CarBrands = new List<CarBrand>(){
                         new CarBrand {
                                Name = "MAN",
                                Description = "Opis dla marki MAN",
                                EstablishmentYear = new DateTime(1758,1,1).ToShortDateString(),
                                ParentConcern = "MAN",
                                CarModels = new List<CarModel>()
                                {
                                    new CarModel{
                                        Name = "MAN TGA",
                                        ProductionYear = 2000,
                                        DriveType = "NaN",
                                        EngineCompacity = 10.518d
                                    },
                                    new CarModel{
                                        Name = "MAN TGL",
                                        ProductionYear = 2005,
                                        DriveType = "NaN",
                                        EngineCompacity = 6.87d
                                    },
                                }
                            },
                            new CarBrand {
                                Name = "Volvo Trucks",
                                Description = "Opis dla marki Volvo",
                                EstablishmentYear = new DateTime(1928,1,1).ToShortDateString(),
                                ParentConcern = "Volvo",
                                CarModels = new List<CarModel>()
                                {
                                    new CarModel{
                                        Name = "Volvo FH12",
                                        ProductionYear = 1993,
                                        DriveType = "NaN",
                                        EngineCompacity = 12.1d
                                    },
                                    new CarModel{
                                        Name = "Volvo FH16",
                                        ProductionYear = 1993,
                                        DriveType = "NaN",
                                        EngineCompacity = 12.1d
                                    },
                                }
                            }
                        } 
                    },
                    new CarCategory {
                        Name = "Motory",
                        Description = "Opis motorów",
                        CarBrands = new List<CarBrand>(){
                        new CarBrand {
                                Name = "Yamaha",
                                Description = "Opis dla marki Yamaha",
                                EstablishmentYear = new DateTime(1887,10,12).ToShortDateString(),
                                ParentConcern = "Yamaha Group",
                                CarModels = new List<CarModel>()
                                {
                                    new CarModel{
                                        Name = "Yamaha TZR 50",
                                        ProductionYear = 1990,
                                        DriveType = "NaN",
                                        EngineCompacity = 50d
                                    },
                                    new CarModel{
                                        Name = "Yamaha YZF-R1",
                                        ProductionYear = 1997,
                                        DriveType = "NaN",
                                        EngineCompacity = 1d
                                    },
                                }
                            }
                        }
                    }
                }
            };

        }
    }
}
