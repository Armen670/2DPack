using System;

namespace Kursovayaa
{
    class BFDH
    {
        static public void Sort(ref BinList binList, Rectangle panelRectangle, out int unresolved)
        {
            unresolved = 0;
            binList.Sort((Bin A, Bin B) => {
                if (A.Rectangle.Height > B.Rectangle.Height)
                { return -1; }
                else if (A.Rectangle.Height == B.Rectangle.Height)
                { return 0; }
                else { return 1; }
            });
            int[] levels = new int[binList.Count];
            int levelcounter = 1;
            int level = 0; // binList[i].Rectangle.Height;
            int[] heightOfLevel = new int[binList.Count];
            foreach (Bin bin in binList)
            {
                if (bin.Rectangle.Y + bin.Rectangle.Height > panelRectangle.Height)
                {
                    unresolved++;
                }

                int xspace = Int32.MaxValue;
                int index = -1;
                for (int j = 0; j < levelcounter; j++)
                {
                    //если не походит, перебегаем на линию выше
                    int temp = levels[j] - bin.Rectangle.Height;
                    if (temp > 0 && temp < xspace) //можно ли использовать равно в сравнение , тоесть >= вместо >
                    {
                        xspace = temp;
                        index = j;
                    }
                }
                if (index == -1)
                {
                    bin.Rectangle.X = 0; // изменение координат
                    levels[levelcounter] = panelRectangle.Width - bin.Rectangle.Width;
                    bin.Rectangle.Y = level;
                    heightOfLevel[levelcounter] = level;
                    level += bin.Rectangle.Height;
                    levelcounter++;
                }
                else
                {
                    bin.Rectangle.X = panelRectangle.Width - levels[index];
                    bin.Rectangle.Y = heightOfLevel[index];
                    levels[index] -= bin.Rectangle.Width;
                }
            }
        }
    }
}
