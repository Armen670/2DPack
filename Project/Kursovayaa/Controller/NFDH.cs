
namespace Kursovayaa
{
    class NFDH
    {
        public static void Sort(ref BinList binList, Rectangle panelRectangle, out int unresolved)
        {
            unresolved = 0;  

            int currentX = 0; 
            int currentHeight = 0; //level
            int currentY = 0;

            binList.Sort((Bin A, Bin B) => { if (A.Rectangle.Height > B.Rectangle.Height) { return -1; } else if (A.Rectangle.Height == B.Rectangle.Height) { return 0; } else { return 1; } });

            foreach (Bin bin in binList)
            {
                if (currentY + bin.Rectangle.Height > panelRectangle.Height)
                {
                    unresolved++;
                }
                //если не походит, перебегаем на линию выше
                if (bin.Rectangle.Width + currentX > panelRectangle.Width)
                {
                    currentX = 0;
                    currentY += currentHeight;
                    currentHeight = 0;
                }
                //если подходит суем в эту лиинию
                bin.Rectangle.X = currentX;
                currentX += bin.Rectangle.Width;
                bin.Rectangle.Y = currentY;

                if (bin.Rectangle.Height > currentHeight)
                {
                    currentHeight = bin.Rectangle.Height;
                }
            }
        }
    }
}
