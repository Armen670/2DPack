using System;
using System.Collections.Generic;

namespace Kursovayaa
{
    public class BinList : List<Bin>
    {
        private static readonly Random randomGenerator = new Random();

        public void GetBoundingBin(out int width, out int height) //получение прямоугольника площади
        {
            width = 0;
            height = 0;

            foreach (Bin bin in this)
            {
                int binRight = bin.Rectangle.X + bin.Rectangle.Width; //ширина
                int binBottom = bin.Rectangle.Y + bin.Rectangle.Height; //высота
                                                                        //отсчет занятой прямоугольниками площади
                if (binRight > width)
                {
                    width = binRight;
                }

                if (binBottom > height)
                {
                    height = binBottom;
                }
            }
        }

        public void Randomize(int count, int sizeMin, int sizeMax, int panelWidth, int panelHeight, out int unresolved) //задание прямоугольников
        {
            unresolved = 0; 

            if (count <= 0)
            {
                return;
            }

            //проверка мин значений, если не подходит, установить максимальные параметры панели

            sizeMin = (sizeMin < panelWidth ? sizeMin : panelWidth);
            sizeMax = (sizeMax < panelWidth ? sizeMax : panelWidth);

            int currentHeight = 0;
            int currentX = 0;
            int currentY = 0;

            for (int index = 0; index < count; index++)
            {
                int width = randomGenerator.Next(sizeMin, sizeMax);
                int height = randomGenerator.Next(sizeMin, sizeMax);

                if (currentY + height > panelHeight)
                {
                    unresolved++;
                }

                //новый уровень

                if (currentX + width > panelWidth)
                {
                    currentX = 0;
                    currentY += currentHeight;
                    currentHeight = 0;
                }

                if (height > currentHeight)
                {
                    currentHeight = height;
                }

                Bin bin = new Bin(currentX, currentY, width, height);
                this.Add(bin); //добавляем прямоугольник

                currentX += width;
            }
        }
    }
}
