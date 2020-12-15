using System.Collections.Generic;

namespace FactoryDesignPattern
{
    public abstract class Unit
    {
        protected string name;
        protected int buildingCost;
        protected int attackAccuracy;
        protected int defenseDodge;
        protected IEnumerable<Equipment> equipments;

        public string ConsumeResources()
        {
            return $"Consumes {this.buildingCost} resources to build the unit.";
        }

        public abstract void Stuff();

        public override string ToString()
        {
            string str = $@"Nom :  {this.name}
                            Building cost : {this.buildingCost}
                            Attack accuracy : {this.attackAccuracy}
                            Defense dodge : {this.defenseDodge}
                            Equipments : 
            ";

            foreach (Equipment equipment in this.equipments)
            {
                str += $@"{equipment.Name}";
            }

            return str;
        }
    }
}
