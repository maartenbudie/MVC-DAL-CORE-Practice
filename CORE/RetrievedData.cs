namespace Core
{
    public class RetrievedData
    {
        private readonly IData _data;
        public RetrievedData(IData data)
        {
            _data = data;
        }
        public List<int> IDs()
        {
            return _data.GetIDs();
        }
    }
}
