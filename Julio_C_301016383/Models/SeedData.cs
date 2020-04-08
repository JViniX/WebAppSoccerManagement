using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace Julio_C_301016383.Models
{
    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Clubs.Any())
            {
                context.Clubs.AddRange(
                new Club
                {                        
                    Name = "Sport Recife",
                    Address = "80 Praia Bela Ave.",
                    Players = new List<Player>
                    {
                        new Player{ FirstName="Jose", LastName="Conrado", Age=24},
                        new Player{ FirstName="Paulo", LastName="Cesar", Age=22}
                    }
                },
                new Club
                {                    
                    Name = "Flamengo",
                    Address = "144 Copacabana Ave.",
                    Players = new List<Player>
                    {
                        new Player{ FirstName="Joao", LastName="Carvalho", Age=34},
                        new Player{ FirstName="Pedro", LastName="Amado", Age=28}
                    }
                },
                new Club
                {                    
                    Name = "Vasco da Gama",
                    Address = "131 General Almério de Moura Street",
                    Players = new List<Player>
                    {
                        new Player{ FirstName="Tiago", LastName="Cardoso", Age=29},
                        new Player{ FirstName="Marcos", LastName="Santos", Age=30}
                    }
                },
                new Club
                {
                    Name = "Palmeiras",
                    Address = "501 Paulista Ave.",
                    Players = new List<Player>
                    {
                        new Player{ FirstName="Allan", LastName="Carvalho", Age=35},
                        new Player{ FirstName="Vitor", LastName="Cesar", Age=36},
                        new Player{ FirstName="Gilvan", LastName="Pereira", Age=34},
                        new Player{ FirstName="Renato", LastName="Gaucho", Age=24}
                    }
                }


                    // Kyungjin Jeong - seed more clubs
                    ,
                    new Club
                    {
                        Name = "Progress",
                        Address = "941 Progress Ave"
                    },
                    new Club
                    {
                        Name = "Ashtonbee",
                        Address = "75 Ashtonbee Rd"
                    },
                    new Club
                    {
                        Name = "Employment Services",
                        Address = "941 Progress Ave"
                    },
                    new Club
                    {
                        Name = "Eglinton",
                        Address = "124 Eglinton Ave W"
                    },
                    new Club
                    {
                        Name = "Morningside",
                        Address = "755 Morningside Ave"
                    },
                    new Club
                    {
                        Name = "Pickering",
                        Address = "1340 Pickering Pkwy #102"
                    },
                    new Club
                    {
                        Name = "Downsview",
                        Address = "65 Carl Hall Rd"
                    }
                );
                context.SaveChanges();
            }

            //if (!context.Matches.Any())
            //{
            //    context.Matches.AddRange(
            //    new Match
            //    {
            //        Stadium = "Maracana",
            //        MatchDateAndTime = new DateTime(2019, 04, 20, 20, 30, 00), 
            //        Price = 250,
            //        ClubID1 = 1,
            //        ClubID2 = 2
            //    },
            //    new Match
            //    {
            //        Stadium = "Pacaembu",
            //        MatchDateAndTime = new DateTime(2019, 04, 22, 16, 30, 00),
            //        Price = 180,
            //        ClubID1 = 3,
            //        ClubID2 = 4
            //    }
            //    );
            //    context.SaveChanges();
            //}
        }
    }
}
