namespace _09.RectangleIntersection
{
    using System;

    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double topLeftX;
        private double topLeftY;

        public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
        {
            this.id = id;
            this.width = Math.Abs(width);
            this.height = Math.Abs(height);
            this.topLeftX = topLeftX;
            this.topLeftY = topLeftY;
        }

        public string Id { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double TopLeftX { get; set; }

        public double TopLeftY { get; set; }

        public bool CheckIfTheyCross(Rectangle rectangle)
        {
            return rectangle.topLeftX + rectangle.width >= this.topLeftX &&
                rectangle.topLeftX <= this.topLeftX + this.width &&
                rectangle.topLeftY >= this.topLeftY - this.height &&
                rectangle.topLeftY - rectangle.height <= this.topLeftY;
        }
    }
}
