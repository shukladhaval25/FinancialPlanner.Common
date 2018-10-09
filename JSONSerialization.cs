
namespace FinancialPlanner.Common
{
    using System;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JSONSerialization : ISerialization
    {
        private const string ARGUMENT_NULL_EXCEPTION = "Parameter value can not be null or empty.";
        private const string UNABLE_TO_DESERIALIZE = "Unable to deserialize.";
        private const string UNABLE_TO_SERIALIZE = "Unable to serialize.";
        private const string DESERIALIZED_OBJECT_NULL = "Deserialized Object is Null";

        public T DeserializeFromString<T>(string serilizedString)
        {
            T deserializeObject = default(T);

            if (!string.IsNullOrEmpty(serilizedString))
            {
                try
                {
                    deserializeObject = JsonConvert.DeserializeObject<T>(serilizedString);
                }
                catch (Exception ex)
                {
                    throwException( new Exception(UNABLE_TO_DESERIALIZE, ex));
                }
            }
            else
            {
                throwException(new ArgumentException(ARGUMENT_NULL_EXCEPTION));
            }

            return deserializeObject;
        }

        public T DeserializeFromStream<T>(Stream actionSerializeData)
        {
            T deserializeResult =  default(T);

            if (actionSerializeData == null)
            {
                throwException(new ArgumentException(ARGUMENT_NULL_EXCEPTION));
            }

            try
            {
                using (MemoryStream writeStream = new MemoryStream())
                {
                    actionSerializeData.CopyTo(writeStream);
                    actionSerializeData.Close();

                    writeStream.Position = 0;
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                    serializer.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
                    serializer.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
                    serializer.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

                    StreamReader srJsonReader = new StreamReader(writeStream);
                    srJsonReader.BaseStream.Position = 0;

                    var jsonTextReader1 = new JsonTextReader(srJsonReader);
                    deserializeResult = serializer.Deserialize<T>(jsonTextReader1);
                }
            }
            catch (Exception ex)
            {
                throwException(new Exception(UNABLE_TO_DESERIALIZE, ex));
            }

            return deserializeResult;
        }

        public string SerializeToString<T>(T objectTobeSerialized)
        {
            if (objectTobeSerialized != null)
            {
                try
                {
                    return JsonConvert.SerializeObject(objectTobeSerialized);
                }
                catch (Exception ex)
                {
                    throwException(new Exception(UNABLE_TO_SERIALIZE, ex));
                }
            }
            else
            {
                throwException(new ArgumentException(ARGUMENT_NULL_EXCEPTION));
            }

            return string.Empty;
        }

        public Stream SerializeToStream<T>(T objectTobeSerialize)
        {
            MemoryStream memoryStream = new MemoryStream();

            try
            {
                if (objectTobeSerialize != null)
                {
                    JsonSerializer serializer = new JsonSerializer();
                    var jsonTextWriter = new JsonTextWriter(new StreamWriter(memoryStream));
                    serializer.Serialize(jsonTextWriter, objectTobeSerialize);
                    jsonTextWriter.Flush();
                    memoryStream.Position = 0;
                    return memoryStream;
                }
                else
                {
                    throwException(new ArgumentNullException(ARGUMENT_NULL_EXCEPTION));
                }
            }
            catch (Exception ex)
            {
                throwException(new Exception(UNABLE_TO_SERIALIZE, ex));
            }

            return memoryStream;
        }

        private void throwException(Exception exceptionTobeThrown)
        {
            throw exceptionTobeThrown;
        }
               
        public bool IsValidJson(string value)
        {
            try
            {
                var json = JContainer.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
