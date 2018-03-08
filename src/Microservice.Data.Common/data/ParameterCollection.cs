using System.Collections.ObjectModel;

namespace Microservices.Data.Common
{
    public class ParameterCollection : KeyedCollection<string, Parameter>
    {
        protected override string GetKeyForItem(Parameter item)
        {
            return item.Key;
        }
    }
}
