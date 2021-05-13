namespace AwsDotnetCsharp
{
    public interface IJsonConverter
    {
        T DeserializeObject<T>(string content);
        string SerializeObject(object obj);
    }
}