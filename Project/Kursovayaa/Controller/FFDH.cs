
namespace Kursovayaa
{
    class FFDH
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
            bool newlevel = true;
            int level = 0;
            int[] heightOfLevel = new int[binList.Count];
            foreach (Bin bin in binList)
            {
                if (bin.Rectangle.Y + bin.Rectangle.Height > panelRectangle.Height)
                {
                    unresolved++;
                }

                for (int j = 0; j < levelcounter; j++)
                {
                    //если не походит, перебегаем на линию выше
                    if (levels[j] >= bin.Rectangle.Height) //можно л использовать равно в сравнение , тоесть >= вместо >
                    {
                        bin.Rectangle.X = panelRectangle.Width - levels[j];
                        bin.Rectangle.Y = heightOfLevel[j];
                        levels[j] -= bin.Rectangle.Width;
                        newlevel = false;
                        break;
                    }
                }
                if (newlevel)
                {
                    bin.Rectangle.X = 0; // изменение координат
                    levels[levelcounter] = panelRectangle.Width - bin.Rectangle.Width;
                    bin.Rectangle.Y = level;
                    heightOfLevel[levelcounter] = level;
                    level += bin.Rectangle.Height;
                    levelcounter++;
                }
                newlevel = true;
            }
        }
    }
}
