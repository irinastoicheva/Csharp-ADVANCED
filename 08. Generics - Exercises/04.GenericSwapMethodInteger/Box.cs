using System.Collections.Generic;

namespace _04.GenericSwapMethodInteger
{
    class Box<T>
    {
        private T value;
        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{this.value.GetType()}: {this.value}";
        }

        public static void Swap(List<Box<T>> list, int firstIndex, int secondIndex)
        {
            if (list.Count > firstIndex && firstIndex >= 0 && list.Count > secondIndex && secondIndex >= 0)
            {
                var temp = list[firstIndex];
                list[firstIndex] = list[secondIndex];
                list[secondIndex] = temp;
            }
        }
    }
}
