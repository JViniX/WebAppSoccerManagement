﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Julio_C_301016383.Models
{
    public class EFClubRepository : IClubRepository
    {
        private ApplicationDbContext context;

    
        public EFClubRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Club> Clubs => context.Clubs.Include(c => c.Players);
        
        public void SaveClub(Club club)
        {
            if (club.ClubID == 0)
            {
                context.Clubs.Add(club);
            }
            else
            {
                Club dbEntry = context.Clubs
                    .FirstOrDefault(c => c.ClubID == club.ClubID);
                if (dbEntry != null)
                {
                    dbEntry.Name = club.Name;
                    dbEntry.Address = club.Address;
                }
            }
            context.SaveChanges();
        }

        public Club DeleteClub(int clubID)
        {
            Club dbEntry = context.Clubs
                .FirstOrDefault(c => c.ClubID == clubID);
            if (dbEntry != null)
            {
                context.Clubs.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public IEnumerable<Player> clubPlayers(int clubID)
        {
            return context.Players.Where(p => p.ClubID == clubID);
        }

        public Player GetPlayer(int playerID)
        {
            return context.Players.FirstOrDefault(p => p.PlayerID == playerID);
        }

        public void SavePlayer(Player player)
        {
            if (player.PlayerID == 0)
            {
                context.Players.Add(player);
            }
            else
            {
                Player dbEntry = context.Players
                    .FirstOrDefault(p => p.PlayerID == player.PlayerID);
                if (dbEntry != null)
                {
                    dbEntry.FirstName = player.FirstName;
                    dbEntry.LastName = player.LastName;
                    dbEntry.Age = player.Age;
                    dbEntry.ClubID = player.ClubID;
                }
            }
            context.SaveChanges();
        }

        public Player DeletePlayer(int playerID)
        {
            Player dbEntry = context.Players
                .FirstOrDefault(p => p.PlayerID == playerID);
            if (dbEntry != null)
            {
                context.Players.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public string GetClubName (int clubID)
        {
            Club club = Clubs.FirstOrDefault(c => c.ClubID == clubID);
            return club.Name; 
        }
    }
}
