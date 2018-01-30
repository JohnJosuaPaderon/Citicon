using System;

namespace Citicon.Forms.DataLinks
{
    public class ControlProperty<T>
    {
        public ControlProperty(Action<T> set, Func<T> get)
        {
            _Set = set ?? throw new ArgumentNullException(nameof(set));
            _Get = get ?? throw new ArgumentNullException(nameof(get));
        }

        private readonly Action<T> _Set;
        private readonly Func<T> _Get;
        
        public void Set(T value)
        {
            _Set(value);
        }

        public T Get()
        {
            return _Get();
        }
    }
}
