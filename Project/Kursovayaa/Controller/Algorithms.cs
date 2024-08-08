using System;
using System.Collections.Generic;

namespace Kursovayaa
{
    class Algorithms
    {
        public static void NFDH(ref BinList binList, Rectangle panelRectangle, out int unresolved)
        {
            unresolved = 0; //неразрешенные прямоугольники

            int currentX = 0; //координата Х
            int currentHeight = 0; //высота уровня
            int currentY = 0; //координата У

            binList.Sort((Bin A, Bin B) => { if (A.Rectangle.Height > B.Rectangle.Height)
                { return -1; }
                else if (A.Rectangle.Height == B.Rectangle.Height)
                { return 0; }
                else { return 1; } 
            }); //сортировка по высоте

            foreach (Bin bin in binList)
            {
                //помещается ли прямоугольник в контейнер
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
                //если подходит, суем в эту лиинию
                bin.Rectangle.X = currentX;
                currentX += bin.Rectangle.Width;
                bin.Rectangle.Y = currentY;
                
                if (bin.Rectangle.Height > currentHeight)
                {
                    currentHeight = bin.Rectangle.Height;
                }
            }
        }
        static public void FFDH(ref BinList binList, Rectangle panelRectangle, out int unresolved)
        {
            unresolved = 0;

            binList.Sort((Bin A, Bin B) => {
                if (A.Rectangle.Height > B.Rectangle.Height)
                { return -1; }
                else if (A.Rectangle.Height == B.Rectangle.Height)
                { return 0; }
                else { return 1; }
            }); //сортировка по высоте

            int[] levels = new int[binList.Count];
            int levelcounter = 1;
            bool newlevel = true;
            int level = 0; //счетчик уровня
            int[] heightOfLevel = new int[binList.Count];

            foreach (Bin bin in binList)
            {
                if (bin.Rectangle.Y + bin.Rectangle.Height > panelRectangle.Height)
                {
                    unresolved++;
                }

                for (int j = 0; j < levelcounter; j++)
                {
                    if (levels[j] >= bin.Rectangle.Height)
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
                    bin.Rectangle.X = 0;
                    levels[levelcounter] = panelRectangle.Width - bin.Rectangle.Width;
                    bin.Rectangle.Y = level;
                    heightOfLevel[levelcounter] = level;
                    level += bin.Rectangle.Height;
                    levelcounter++;
                }
                newlevel = true;
            }
        }
        static public void BFDH(ref BinList binList, Rectangle panelRectangle, out int unresolved)
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
                    if (temp > 0 && temp < xspace) 
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
        static public void FCNR(ref BinList binList, Rectangle panelRectangle, out int unresolved)
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
                                Possible[index][Possible[index].Count - 2].Height - bin.Rectangle.Height);
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

