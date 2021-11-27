namespace WebApplication.Entities
{
    public interface ISalveEntity
    {
        public void Parse<T>(string csvLine);
    }
}