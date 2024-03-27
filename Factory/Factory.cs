using DAL;
using Core;

namespace FactoryProj
{
    public static class Factory
    {
        public static IData CreateData()
        {
            return new Data();
        }
    }
}
