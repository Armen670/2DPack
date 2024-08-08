using System;
using System.Collections.Generic;

namespace Kursovayaa
{
    class FCNR
    {
        static public void Sort(ref BinList binList, Rectangle panelRectangle, out int unresolved) //недоделано
        {
            unresolved = 0;

            binList.Sort((Bin A, Bin B) => {
                if (A.Rectangle.Height > B.Rectangle.Height)
                { return -1; }
                else if (A.Rectangle.Height == B.Rectangle.Height)
                { return 0; }
                else
                { return 1; }
            });
            List<List<Rectangle>> Possible = new List<List<Rectangle>>();
            //asd[0].Add(new rect(1,2));
            int[] levels = new int[binList.Count]; int[] heightOfLevel = new int[binList.Count];
            int[] reverselevel = new int[binList.Count];
            int level = 0; ; int levelcounter = 0; bool[] PossFlag = new bool[binList.Count];
            foreach (Bin bin in binList)
            {
                if (bin.Rectangle.Y + bin.Rectangle.Height > panelRectangle.Height)
                {
                    unresolved++;
                }

                int xspace = Int32.MaxValue; int index = -1;
                Rectangle rectspace = new Rectangle(0, 0, Int32.MaxValue, Int32.MaxValue);
                int rectindex = -1;
                int rectindexlevel = -1;
                for (int j = 0; j < levelcounter; j++)
                {
                    int temp = levels[j] - bin.Rectangle.Width;
                    if ((temp > 0) && (temp < xspace))
                    {
                        xspace = temp; index = j;
                    }
                    for (int k = 0; k < Possible[j].Count; k++)
                    {
                        if (Possible[j][k] < rectspace && Possible[j][k] >= bin.Rectangle)
                        {
                            rectspace = new Rectangle(0, 0, Possible[j][k].Width - bin.Rectangle.Width,
                                Possible[j][k].Height - bin.Rectangle.Height);

                            rectindexlevel = j; rectindex = k;
                        }
                    }
                }
                if (index == -1 || rectindex == -1)
                {
                    reverselevel[levelcounter] = panelRectangle.Width;
                    Possible.Add(new List<Rectangle>()); Possible[levelcounter].Add(new Rectangle(0, 0, panelRectangle.Width
                        - bin.Rectangle.Width, bin.Rectangle.Height)); PossFlag[levelcounter] = true;

                    levels[levelcounter] = panelRectangle.Width - bin.Rectangle.Width;
                    heightOfLevel[levelcounter] = level;
                    bin.Rectangle.Y = level;
                    level += bin.Rectangle.Height; levelcounter++;
                    bin.Rectangle.X = 0;


                }
                else
                {
                    if (xspace <= rectspace.Width)
                    {
                        if (PossFlag[index])
                        {
                            Possible[index].Add(new Rectangle(0, 0, Possible[index][Possible[index].Count - 1].Width
                                - bin.Rectangle.Width, Possible[index][Possible[index].Count - 1].Height));

                            Possible[index][Possible[index].Count - 2] = new Rectangle(0, 0, Possible[index][Possible[index].Count - 2].Width,
                                Possible[index][Possible[index].Count - 2].Height- bin.Rectangle.Height);
                        }
                        bin.Rectangle.X = panelRectangle.Width - levels[index];
                        levels[index] -= bin.Rectangle.Width;
                        bin.Rectangle.Y = heightOfLevel[index];

                    }
                    else
                    {
                        reverselevel[rectindexlevel] -= Possible[rectindexlevel][rectindex].Width;
                        bin.Rectangle.X = reverselevel[rectindexlevel];
                        bin.Rectangle.Y = heightOfLevel[rectindexlevel] - bin.Rectangle.Height;
                        for (int j = Possible[rectindexlevel].Count - 1; j >= rectindex; j--)
                        {
                            Possible[rectindexlevel].RemoveAt(j);
                        }
                        PossFlag[rectindexlevel] = false;
                        for (int j = rectindex - 1; j >= 0; j--)
                        {
                            Possible[rectindexlevel][j] = new Rectangle(0, 0, Possible[rectindexlevel][j].Width - bin.Rectangle.Width,
                                Possible[rectindexlevel][j].Height);
                        }
                    }
                }
            }
        }
    }
}
