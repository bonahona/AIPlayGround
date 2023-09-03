
using UnityEngine;

namespace Shared {
    [System.Serializable]
    public class ValueRange
    {
        public int MinValue;
        public int MaxValue;

        public int GetValue() => Random.Range(MinValue, MaxValue);
    }
}