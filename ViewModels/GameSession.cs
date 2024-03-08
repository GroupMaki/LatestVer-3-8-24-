using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Factories;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Joshua";
            CurrentPlayer.Gold = 5000000;
            CurrentPlayer.CharacterClass = "Support";
            CurrentPlayer.HitPoints = 20;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();
            CurrentLocation = CurrentWorld.LocationAt(0, 0);

        }


    }
}
 