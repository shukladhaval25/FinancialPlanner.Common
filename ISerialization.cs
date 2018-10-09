using System.IO;
namespace FinancialPlanner.Common
{
    public interface ISerialization
    {
        T DeserializeFromString<T>(string serilizedString);
        T DeserializeFromStream<T>(Stream serializedStream);

        string SerializeToString<T>(T objectTobeSerialize);
        Stream SerializeToStream<T>(T objectTobeSerialize);
        bool IsValidJson(string value);
    }
}
