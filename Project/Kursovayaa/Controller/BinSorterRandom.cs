using System;
using System.Collections.Generic;

namespace Kursovayaa
{
    //функция scramble
    public class BinListSorterRandom
    {
        private static readonly Random randomGenerator = new Random();
        private static Dictionary<Bin, int> randomBinding; //ключи и значения

        public static void Sort(ref BinList binList, int panelWidth, int panelHeight, out int unresolved)
        {
            unresolved = 0;
            int binListCount = binList.Count;

            randomBinding = new Dictionary<Bin, int>(binListCount);

            foreach (Bin bin in binList)
            {
                randomBinding[bin] = randomGenerator.Next();
            }

            binList.Sort(CompareBins);

            int currentHeight = 0;
            int currentX = 0;
            int currentY = 0;

            foreach (Bin bin in binList)
            {
                if (currentY + bin.Rectangle.Height > panelHeight)
                {
                    unresolved++;
                }

                //если ширина выходит за панель, добавляем уровень
                if (currentX + bin.Rectangle.Width > panelWidth)
                {
                    currentX = 0;
                    currentY += currentHeight;
                    currentHeight = 0;
                }
                //если высота выходит за пределы уровня, поднимаем планку высоты уровня
                if (bin.Rectangle.Height > currentHeight)
                {
                    currentHeight = bin.Rectangle.Height;
                }

                bin.Rectangle.X = currentX;
                bin.Rectangle.Y = currentY;

                currentX += bin.Rectangle.Width;
            }
        }
        private static int CompareBins(Bin a, Bin b)
        {
            return randomBinding[a] - randomBinding[b];
        }
    }
}
