using System.Collections.Generic;
using System.Linq;

namespace FactoryDesignPattern
{
    public class HumanComander : Unit
    {
        public HumanComander()
        {
            this.name = "Lieutenant";
            this.buildingCost = 14;
            this.attackAccuracy = 5;
            this.defenseDodge = 2;
            this.equipments = new List<Equipment>();
        }

        public override void Stuff()
        {
            this.equipments.ToList().Add(new Equipment { Name = "Uzi" });
            this.equipments.ToList().Add(new Equipment { Name = "Shield" });
        }
    }
}
