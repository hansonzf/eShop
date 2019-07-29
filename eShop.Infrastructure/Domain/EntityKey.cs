using System;
using System.Collections.Generic;

namespace eShop.Infrastructure.Domain
{
    public class EntityKey<TKey> : ValueObject
    {
        private readonly TKey _key;

        public EntityKey(TKey key)
        {
            _key = key;
        }

        public TKey Key { get => _key; }

        public bool IsEmptyKey()
        {
            bool result = false;
            var keyType = typeof(TKey);

            if (keyType.IsPrimitive)
            { 
                switch (keyType.Name)
                {
                    case "String":
                        result = string.IsNullOrEmpty(_key.ToString());
                        break;
                    case "Int32":
                        result = int.Equals(0, _key);
                        break;
                    default:
                        break;
                }
            }

            return result;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            return new object[] { _key };
        }
    }
}
