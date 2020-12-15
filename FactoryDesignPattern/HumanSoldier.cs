using System.Collections.Generic;
using System.Linq;

namespace FactoryDesignPattern
{
    public class HumanSoldier : Unit
    {
        public HumanSoldier()
        {
            this.name = "Infantry man";
            this.buildingCost = 5;
            this.attackAccuracy = 1;
            this.defenseDodge = 2;
            this.equipments = new List<Equipment>();
        }

        public override void Stuff()
        {
            this.equipments.ToList().Add(new Equipment { Name = "Gun" });
            this.equipments.ToList().Add(new Equipment { Name = "Shield" });
        }
    }
}
