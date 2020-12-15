namespace FactoryDesignPattern
{
    public class Factory
    {
        private SimpleFactory simpleFactory;
        
        public Factory()
        {
            this.simpleFactory = new SimpleFactory();
        }

        public Unit FormUnit(UnitType unitType)
        {
            Unit unit = this.simpleFactory.CreateUnit(unitType);
            unit.ConsumeResources();
            unit.Stuff();

            return unit;
        }
    }
}
