using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, 0, "Draugr Burial Mound", "You find yourself in the old cemetery of Old Valheim Warriors.", "/Engine;component/Images/Locations/FarmFields.png");
            newWorld.AddLocation(0, 0, "The Mines", "The mines were the Valheim acquired their prized metals. ", "/Engine;component/Images/Locations/FarmFields.png");
            newWorld.AddLocation(0, 0, "Abandoned Draugr Village", "A once lively village now filled with the undead warriors.", "/Engine;component/Images/Locations/FarmFields.png");
            newWorld.AddLocation(0, 0, "Black Tree on the White Mound", "A peculiar sight...", "/Engine;component/Images/Locations/FarmFields.png");
            newWorld.AddLocation(0, 0, "Forest of Lost Valor", "A forest filled with relics of past wars fought within the Realm.", "/Engine;component/Images/Locations/FarmFields.png");
            newWorld.AddLocation(0, 0, "Dwarven Forge ", "Once used by Dwarves from Svartalheim, left rotten.", "/Engine;component/Images/Locations/FarmFields.png");
            newWorld.AddLocation(0, 0, "DBifrost Gate: Valheim Entrance ", "A gateway severely damaged by the rot. ", "/Engine;component/Images/Locations/FarmFields.png");
            return newWorld;
        }
    }
}