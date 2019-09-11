namespace FinalProjectWEBAPI.Migrations
{
    using FinalProjectWEBAPI.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinalProjectWEBAPI.Models.ContextDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinalProjectWEBAPI.Models.ContextDb context)
        {
            var TipoVeiculos = new List<TipoVeiculo>() {

                new TipoVeiculo(){CodVeiculo = 0, Descricao = "Automóvel" } ,                    
                new TipoVeiculo(){CodVeiculo = 1, Descricao = "Moto"},                         
                new TipoVeiculo(){CodVeiculo = 2, Descricao = "Bicicleta"},                          
                new TipoVeiculo(){CodVeiculo = 3, Descricao = "Patinete"},

            };

            TipoVeiculos.ForEach(s => context.Veiculos.AddOrUpdate(s));

            context.SaveChanges();

            var incrementMarcasCodigo = 1;

            var Marcas = new List<Marca>()

            {

                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Audi"},

                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "BMW"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Chevrolet"},
                           
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Citröen"},
                           
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Fiat"},
                           
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Ford"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Honda"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Hyundai"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Jeep"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Kia"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Mitsubishi"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Nissan"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Peugeot"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Renault"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Toyota"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Automóvel"),CodMarcas = incrementMarcasCodigo++,Descricao = "Volkswagen"},



                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Moto"),CodMarcas = incrementMarcasCodigo++,Descricao = "Dafra"},

                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Moto"),CodMarcas = incrementMarcasCodigo++,Descricao = "Honda"},
                           
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Moto"),CodMarcas = incrementMarcasCodigo++,Descricao = "Suzuki"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Moto"),CodMarcas = incrementMarcasCodigo++,Descricao = "Yamaha"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Moto"),CodMarcas = incrementMarcasCodigo++,Descricao = "Kawasaki"},
                            
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Moto"),CodMarcas = incrementMarcasCodigo++,Descricao = "BMW"},
                           
                new Marca(){Veiculo = TipoVeiculos.Single(x => x.Descricao == "Moto"),CodMarcas = incrementMarcasCodigo++,Descricao = "Ducati"},

            };

            Marcas.ForEach(s => context.Marcas.AddOrUpdate(s));

            context.SaveChanges();

            var incrementModelosCod = 1;

            var Modelos = new List<Modelo>()

            {

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "100" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "100 Avant" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "80" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "80 Avant" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "80 Cabriolet" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "A1" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "A3" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "A3 Cabriolet" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "A3 Sedan" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "A4" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "A4 Avant" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "A4 Cabriolet" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "A5" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "A6" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "A6 Avant" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "A7" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "A8" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "Allroad Avant" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "Q3" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "Q5" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "Q7" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "R8" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "RS2 Avant" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "RS3" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "RS3 Sedan" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "RS4" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "RS4 Avant" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "RS5" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "RS6" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "RS6 Avant" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "RS7" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "RS Q3" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "S3" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "S3 Sedan" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "S4" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "S4 Avant" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "S5" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "S6" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "S6 Avant" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "S7" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "S8" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "SQ5" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "TT" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "TT RS" , CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Audi" && x.Veiculo.CodVeiculo == 0),Descricao = "TTS" , CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "1M", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "2800", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "I3", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "I8", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "M2", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "M3", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "M3 Cabrio", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "M3 Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "M4", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "M5", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "M5 Touring", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "M6", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 1", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 1 Cabrio", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 1 Coupé", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 2", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 3", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 3 Cabrio", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 3 Compact", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 3 Coupé", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 3 Touring", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 4", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 5", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 5 Touring", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 6 Cabrio", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 6 Coupé", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 6 Gran Coupé", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 7", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Série 8", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "X1", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "X2", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "X3", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "X4", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "X5", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "X6", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Z3", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Z4 Coupé", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Z4 Roadster", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "BMW" && x.Veiculo.CodVeiculo == 0),Descricao = "Z8", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "A10", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "A20", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Agile", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Astra Hatch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Astra Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Astra Wagon", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Astrovan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Bel Air", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Blazer", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Bonanza", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Brasil", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Brasinca", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "C10", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "C14", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "C20", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Calibra Coupe", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Camaro", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Caprice Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Caprice Wagon", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Captiva", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Caravan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Cavalier", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Celta", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Chevette Hatch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Chevette Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Chevy 500", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Cheyenne", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Classic", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Cobalt", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Colorado", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Corsa Hatch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Corsa Pick-Up", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Corsa Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Corsa Wagon", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Corsica Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Corvette", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Cruze", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Cruze Sport6", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "D10", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "D20", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Equinox", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "HHR", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Impala", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Ipanema", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Kadett", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Kadett Conversivel", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Lumina APV", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Lumina Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Malibu", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Marajo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Meriva", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Montana", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Montana Combo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Monza", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Monza Hatch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Omega", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Onix", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Opala", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Opala Coupe", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Pick Up Chevrolet", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Prisma", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "S10 Cabine Dupla", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "S10 Cabine Simples", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Silverado", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Sonic", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Sonic Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Space Van", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Spin", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "SS10", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "SSR", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Suburban", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Suprema", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Tigra", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Tracker", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Trafic", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "TrailBlazer", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Vectra", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Vectra GT", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Veraneio", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Chevrolet" && x.Veiculo.CodVeiculo == 0),Descricao = "Zafira", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "Aircross", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "AX", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "Berlingo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "BX", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "C3", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "C3 Picasso", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "C4", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "C4 Cactus", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "C4 Lounge", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "C4 Pallas", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "C4 Picasso", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "C4 VTR", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "C5", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "C5 Break", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "C5 Tourer", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "C6", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "C8", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "DS3", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "DS4", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "DS5", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "Evasion", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "Grand C4 Picasso", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "Jumper", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "Jumpy", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "Xantia", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "Xantia Break", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "XM", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "XM Break", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "Xsara", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "Xsara Break", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "Xsara Coupe", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "Xsara Picasso", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Citröen" && x.Veiculo.CodVeiculo == 0),Descricao = "ZX", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "147", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "147 Furgao", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "147 Pick-Up", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "500", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Argo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Brava", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Bravo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Cinquecento", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Coupe", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Cronos", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Doblò", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Doblò Cargo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Ducato", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Duna", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Elba", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Fiorino", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Fiorino Pick-Up", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Freemont", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Grand Siena", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Idea", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Linea", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Marea", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Marea Weekend", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Mobi", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Oggi", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Palio", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Palio Weekend", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Panorama", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Premio", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Punto", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Punto Cabrio", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Siena", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Stilo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Strada", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Tempra", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Tipo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Toro", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Uno", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Uno Furgão", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Uno Mille", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Uno Pick-Up", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Fiat" && x.Veiculo.CodVeiculo == 0),Descricao = "Weekend", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Aerostar", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Aspire", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Belina", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Bronco", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Club Wagon", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Contour", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Corcel", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Coupe Deluxe", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Courier", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Courier Van", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Crown Victoria", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Del Rey", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Del Rey Belina / Scala", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "EcoSport", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Edge", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Escape", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Escort", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Escort Conversivel", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Escort Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Escort SW", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Excursion", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Expedition", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Explorer", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "F-1", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "F-100", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "F-1000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "F-150", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "F-250", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "F-350", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "F-4000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "F75", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Fairlane", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Fiesta Hatch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Fiesta Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Focus Hatch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Focus Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Ford 1929", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Furglaine", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Fusion", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Galaxie", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "GT", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Ibiza", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Jeep", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Ka+", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Ka Hatch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Landau", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Lincoln", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Maverick", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Mondeo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Mondeo Wagon", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Mustang", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "New Fiesta Hatch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "New Fiesta Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Pampa", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Probe", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Ranger (Cabine Dupla)", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Ranger (Cabine Simples-Estendida)", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Rural", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Taurus", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Taurus Wagon", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Thunderbird", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Transit", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Verona", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Versailles", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Versailles Royale", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Ford" && x.Veiculo.CodVeiculo == 0),Descricao = "Windstar", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "Accord", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "Accord Coupe", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "Accord Wagon", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "City", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "Civic", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "Civic Coupe", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "Civic Hatch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "Civic Targa", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "CR-V", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "Fit", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "HR-V", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "Legend", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "NSX", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "Odyssey", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "Passport", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "Prelude", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "Quadriciclo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Honda" && x.Veiculo.CodVeiculo == 0),Descricao = "WR-V", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Accent", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Accent Hatch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Atos", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Azera", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Coupe FX", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Creta", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Elantra", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Elantra Wagon", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Equus", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Excel", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Galloper", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Genesis", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "H1", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "H100", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "HB20", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "HB20S", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "HB20X", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "HR", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "i30", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "i30 CW", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "ix35", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Matrix", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Porter", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Santa Fe", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Scoupe", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Sonata", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Terracan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Trajet", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Tucson", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Veloster", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Hyundai" && x.Veiculo.CodVeiculo == 0),Descricao = "Veracruz", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Jeep" && x.Veiculo.CodVeiculo == 0),Descricao = "Cherokee", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Jeep" && x.Veiculo.CodVeiculo == 0),Descricao = "Commander", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Jeep" && x.Veiculo.CodVeiculo == 0),Descricao = "Compass", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Jeep" && x.Veiculo.CodVeiculo == 0),Descricao = "Grand Cherokee", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Jeep" && x.Veiculo.CodVeiculo == 0),Descricao = "Liberty", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Jeep" && x.Veiculo.CodVeiculo == 0),Descricao = "Renegade", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Jeep" && x.Veiculo.CodVeiculo == 0),Descricao = "Wrangler", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Besta", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Bongo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Cadenza", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Carens", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Carnival", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Cerato", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Ceres", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Clarus", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Grand Carnival", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Magentis", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Mohave", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Opirus", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Optima", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Picanto", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Quoris", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Rio", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Sephia", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Shuma", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Sorento", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Soul", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Sportage", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Kia" && x.Veiculo.CodVeiculo == 0),Descricao = " Stinger", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "3000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Airtrek", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "ASX", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Colt", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Diamant", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Eclipse", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Eclipse Cross", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Expo LRV", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Expo SP Van", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Galant", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Grandis", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "L200", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "L200 Outdoor", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "L200 Triton", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "L300", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Lancer", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Lancer Evolution", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Lancer Sportback", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Mirage", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Montero", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Outlander", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Pajero", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Pajero Dakar", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Pajero Full", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Pajero Sport", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Pajero TR4", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Mitsubishi" && x.Veiculo.CodVeiculo == 0),Descricao = "Space Wagon", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " 350Z", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " 370Z", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Altima", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Armada", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " AX", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Frontier", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Grand Livina", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " GT-R", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Juke", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Kicks", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " King Cab", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " LEAF", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Livina", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " March", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Maxima", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Micra", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Murano", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " NX 2000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Pathfinder", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Pick Up D21", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Pick Up D22", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Primera", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Quest", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Sentra", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Stanza", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " SX", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Terrano II", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Tiida", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Tiida Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " Versa", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " XTerra", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " XTRAIL", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Nissan" && x.Veiculo.CodVeiculo == 0),Descricao = " ZX", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 106", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 2008", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 205", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 205 Cabriolet", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 206", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 206 CC", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 206 SW", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 207", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 207 Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 207 SW", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 207 SW Escapade", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 208", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 3008", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 306", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 306 Break", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 306 Cabriolet", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 306 Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 307", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 307 CC", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 307 Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 307 SW", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 308", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 308 CC", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 405", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 405 Break", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 406", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 406 Break", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 406 Coupe", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 407", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 407 SW", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 408", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 5008", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 504", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 505", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 508", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 605", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 607", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 806", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " 807", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " Boxer", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " Expert", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " Hoggar", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " Partner", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Peugeot" && x.Veiculo.CodVeiculo == 0),Descricao = " RCZ", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " 19", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " 21", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Captur", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Clio", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Clio Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Duster", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Duster Oroch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Fluence", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Grand Scenic", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Kangoo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Kangoo Express", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Kwid", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Laguna", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Laguna Grand Tour", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Logan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Master", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Master Chassi", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Megane Cabriolet", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Megane Grand Tour", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Megane Hatch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Megane Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Safrane ", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Sandero", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Sandero Stepway", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Scenic", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Symbol", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Trafic", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Twingo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Renault" && x.Veiculo.CodVeiculo == 0),Descricao = " Zoe", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Avalon ", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Bandeirante Jipe", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Bandeirante Picape", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Camry ", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Camry Wagon", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Celica", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Corolla", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Corolla Fielder", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Corolla Wagon", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Corona Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Etios Hatch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Etios Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " FJ Cruiser", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Hilux Cabine Dupla", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Hilux Cabine Simples", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Land Cruiser Prado", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " MR2", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Paseo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Previa", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Prius", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " RAV4", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Sequoia", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Sienna", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Supra", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " SW4", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " T100", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Tacoma", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Trip", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Tundra", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Yaris Hatch", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Toyota" && x.Veiculo.CodVeiculo == 0),Descricao = " Yaris Sedan", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Amarok", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Apollo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Bora", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Brasília", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Caravelle", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "CC", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Corrado", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "CrossFox", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Eos", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Eurovan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Fox", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Fusca", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Gol", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Golf", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Golf Cabrio", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Gol Furgao", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Golf Variant", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Jetta", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Jetta Variant", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Karmann Ghia", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Kombi", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Kombi Furgão", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Kombi Pick-Up", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Logus", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "New Beetle", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "New Beetle Cabriolet", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Parati", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Passat", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Passat CC", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Passat Variant", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Pointer", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Polo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Polo Classic", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Polo Sedan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Puma", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Quantum", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Santana", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Saveiro", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Scirocco", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "SP2", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "SpaceCross", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "SpaceFox", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Tanger", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "T-Cross", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Tiguan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "TL", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Touareg", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Up!", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Van", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Variant", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Virtus", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao == "Volkswagen" && x.Veiculo.CodVeiculo == 0),Descricao = "Voyage", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Apache", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Cityclass 200i", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Fiddle", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Horizon", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Kansas", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Laser", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Maxsym 400i", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Next", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Riva", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Roadwin", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Smart", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Speed", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Super", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Sym Citycom", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Dafra" && x.Veiculo.CodVeiculo == 1),Descricao ="Zig", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="America Classic", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="BIZ 100", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="BIZ 110i", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="BIZ 125", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="C 100 Dream", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CB 1000R", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CB 1300", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CB 300R", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CB 400", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CB 450", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CB 500", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CB 600 (Hornet)", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CB 650", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CB 750", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CB 900", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CB Twister", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBR 1000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBR 1100", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBR 250R", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBR 450", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBR 500", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBR 600", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBR 650", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBR 900", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBR 929", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBR 954", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBX 150", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBX 200", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBX 250", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CBX 750", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CG 125", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CG 150", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CG 160", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CH 125 R", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CRF", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CRF 1000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="CTX 700", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="Elite 125", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="Gold Wing", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="LEAD", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="Magna 750", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="ML 125", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="NC 700X", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="NC 750X", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="NX 150", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="NX 200", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="NX 350", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="NX 4 Falcon", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="NXR 125", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="NXR 150", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="NXR 160", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="PCX", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="POP", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="SH", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="Shadow", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="Shadow Am", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="Shadow Vt", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="Silver Wing", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="Super Hawk", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="TRX (Quadriciclo)", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="Valkyrie", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="VFR", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="VT 600", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="VTX", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="X-ADV", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="XL 1000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="XL 125", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="Xl 250", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="XL 350", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="XL 700V", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="XLR 125", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="XLX 250", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="XLX 350", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="XR 200", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="XR 250", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="XR 650", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="XRE 190", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Honda" && x.Veiculo.CodVeiculo == 1),Descricao ="XRE 300", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Address Ae", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Address Ag", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Bandit 1200", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Bandit 1200S", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Bandit 1250", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Bandit 1250S", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Bandit 600", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Bandit 600S", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Bandit 650", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Bandit 650S", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Boulevard", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Burgman", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Dl 1000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Dl 650", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Dr 350", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Dr 650", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Dr 800", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Dr Z 400", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="En 125", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Freewind", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gladius", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gs 120", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gs 500", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsr 125", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsr 150i", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsr 750A ", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsx 1100", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsx 1250FA", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsx 1300", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsx 650F", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsx 750", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsx R 1000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsx R 1000 (25anos)", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsx R 1100", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsx R 1300", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsx R 750", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsx S 1000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsx S 1000FA", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Gsx S 750", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Hayabusa", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Inazuma", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Intruder", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Katana", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Lets II", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Marauder", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Rf 600", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Rf 900", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="RM-Z", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Savage", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="SV 650", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Tl 1000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Suzuki" && x.Veiculo.CodVeiculo == 1),Descricao ="Vx 800cc", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Axis 90", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Bws 50", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Crypton", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Crypton 100", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Drag Star 1100", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Drag Star 650", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Drag Star Xvs 650", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Dt 180 Z", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Dt 200", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Fazer 250 ie", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Fjr 1300", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Fz 6 600", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Fz1", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Fz6", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Fz6 s", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Fzr 1000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Fzr 600", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Grizzly", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Jog 50", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Jog Teen 50", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Magesty", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="MT 01", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="MT 03", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="MT 07", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="MT 09 ", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Neo", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="NMax", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Rd 125", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Rd 135", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Rd 350", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Rdz 125", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Rdz 135", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Royal Star 1300", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Tdm 225", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Tdm 850", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Tdm 900", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Tdr 180", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Tmax", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Trx 850", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="TT-R", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="V Max 1200", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="V Max 1700", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="V Star 1100 Classic", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Virago 750", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Wr", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xj6 F", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xj6 N", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xjr 1200", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="XT 1200Z", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="XT 225", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="XT 600", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="XT 660", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xtz 125 E", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xtz 125 K", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xtz 125 X", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xtz 150 Crosser", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xtz 250 Lander", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xtz 250 Tenere", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xtz 750", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xv 1100", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xv 250 (Virago)", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xv 535", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="Xvs Midnight", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="YBR 125", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="YBR 125 Factor", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="YBR 150 Factor", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="YFM", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="YS 150 Fazer", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="YS 250 Fazer", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="YZ", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="YZF 1000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="YZF 600", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="YZF 750", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="YZF R1", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="YZF R3", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Yamaha" && x.Veiculo.CodVeiculo == 1),Descricao ="YZF R6", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="Concours", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="D tracker x", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="ER 5", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="ER 6n", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="KLX", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="KX", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="KZ", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="Maxi II", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="Ninja", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="Versys", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="Voyager", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="Vulcan", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="Z 1000", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="Z 300", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="Z 650", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="Z 750", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="Z 800", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Kawasaki" && x.Veiculo.CodVeiculo == 1),Descricao ="Z 900", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="C 600", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="F 650", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="F 700", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="F 800", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="G 310", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="G 450", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="G 650", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="K 1100", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="K 1200", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="K 1300", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="K 1600", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="R 1100", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="R 1150", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="R 1200", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="BMW" && x.Veiculo.CodVeiculo == 1),Descricao ="S 1000", CodModelo = incrementModelosCod++ },



                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Desmosedici", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Diavel", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Hypermotard", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Hyperstrada", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Monster", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Multistrada", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Scrambler", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Sportclassic", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Streetfighter", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Super Sport 900 ss", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Super Touring St 2 900", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Super Touring St 4 900", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Superbike", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Superbike 749", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Superbike 916", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Superbike 996", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Superbike 998", CodModelo = incrementModelosCod++ },

                new Modelo(){ Marca = Marcas.Single(x => x.Descricao =="Ducati" && x.Veiculo.CodVeiculo == 1),Descricao ="Superbike 999", CodModelo = incrementModelosCod++ },

            };

            Modelos.ForEach(s => context.Modelos.AddOrUpdate(s));

            context.SaveChanges();

            var CorVeiculo = new List<Cor>()
            {
                new Cor(){CodCor = 0,Descricao = "Branco"},
                new Cor(){CodCor = 1,Descricao = "Preto"},
                new Cor(){CodCor = 2,Descricao = "Prata"},
                new Cor(){CodCor = 3,Descricao = "Cinza"},
                new Cor(){CodCor = 4,Descricao = "Vermelho"},
                new Cor(){CodCor = 5,Descricao = "Morrom/Bege"},
                new Cor(){CodCor = 6,Descricao = "Azul"},
                new Cor(){CodCor = 7,Descricao = "Verde"},
                new Cor(){CodCor = 8,Descricao = "Amarelo/Dourado"},
                new Cor(){CodCor = 9,Descricao = "Outras"},

            };
            CorVeiculo.ForEach(s => context.Cors.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
