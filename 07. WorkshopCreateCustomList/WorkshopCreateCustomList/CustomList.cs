namespace WorkshopCreateCustomList
{
    using System;

    public class CustomList
    {
        public CustomList()
        {
            this.Arr = new object[2];
        }
        public object[] Arr { get; set; }
        public int Count { get; set; }


        private void Resize()
        {
            object[] temp = new object[Arr.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                temp[i] = Arr[i];
            }

            Arr = temp;
        }

        private void Shrink()
        {
            int sizeArr = this.Arr.Length / 2 == 0 ? 1 : this.Arr.Length * 2;

            object[] temp = new object[sizeArr];
            for (int i = 0; i < Arr.Length; i++)
            {
                temp[i] = Arr[i];
            }

            Arr = temp;
        }

        private void Shift(int index)
        {
            for (int i = this.Count;  i > index; i--)
            {
                Arr[i] = Arr[i - 1];
            }
        }
    }
}
