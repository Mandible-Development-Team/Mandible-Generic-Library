using System.Collections.Generic;

namespace Mandible.Core.Data
{
    public class Blackboard
    {
        private Dictionary<object, object> map = new();

        public T GetOrCreate<T>(object key) where T : new()
        {
            if (map.TryGetValue(key, out var obj))
                return (T)obj;

            T v = new();
            map[key] = v;
            return v;
        }

        public T Get<T>(object key) where T : class
        {
            map.TryGetValue(key, out var obj);
            return obj as T;
        }
    }
}



