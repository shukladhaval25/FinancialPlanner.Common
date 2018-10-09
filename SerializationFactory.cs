namespace FinancialPlanner.Common
{
    public class SerializationFactory
    {
        public static ISerialization GetJSONSerializer()
        {
            return new JSONSerialization();
        }
    }
}
