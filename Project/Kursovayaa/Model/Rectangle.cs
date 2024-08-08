namespace Kursovayaa
{
    public class Rectangle
    {
        //координаты
        public int X { get; set; }
        public int Y { get; set; }
        //параметры прямоугольника
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        //проверка параметров
        public bool FitsIn(Rectangle outer)
        {
            return (outer.Width >= this.Width && outer.Height >= this.Height);
        }

        public int Compare(Rectangle other)
        {
            if (this.Width == other.Width && this.Height == other.Height)
            {
                return 0;
            }

            int areaThis = this.Width * this.Height;
            int areaOther = other.Width * other.Height;
            if ((areaThis - areaOther) >= 0)
            {
                return 1;
            }
            return -1;
        }
        public static bool operator >(Rectangle A, Rectangle B) //перегрузки для сравнения
        {
            if (A.Width > B.Width && A.Height > B.Height) { return true; } else { return false; }
        }
        public static bool operator >=(Rectangle A, Rectangle B)
        {
            if (A.Width >= B.Width && A.Height >= B.Height) { return true; } else { return false; }
        }
        public static bool operator <=(Rectangle A, Rectangle B)
        {
            if (A.Width <= B.Width && A.Height <= B.Height) { return true; } else { return false; }
        }
        public static bool operator <(Rectangle A, Rectangle B)
        {
            if (A.Width < B.Width && A.Height < B.Height) { return true; } else { return false; }
        }
    }
}
