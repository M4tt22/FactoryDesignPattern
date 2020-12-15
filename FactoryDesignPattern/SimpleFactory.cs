namespace FactoryDesignPattern
{
    public class SimpleFactory
    {
        public Unit CreateUnit(UnitType unitType)
        {
            Unit unit = null;
            switch (unitType)
            {
                case UnitType.SOLDIER:
                    {
                        unit = new HumanSoldier();
                        break;
                    }

                case UnitType.COMMANDER:
                    {
                        unit = new HumanComander();
                        break;
                    }
            }

            return unit;
        }
    }

    public enum UnitType
    {
        SOLDIER,
        COMMANDER
    }
}
