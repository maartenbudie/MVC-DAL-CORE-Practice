namespace Core
{
    public interface IData
    {
        int id { get; set; }
        List<int> GetIDs();
    }
}
