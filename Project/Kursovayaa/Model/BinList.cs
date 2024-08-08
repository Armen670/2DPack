using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Kursovayaa
{
    public class BinList : List<Bin>
    {
        private static readonly Random randomGenerator = new Random();

        /* public void AddSerializedBins(string serializedBins) //добавление прямоугольника извне
     {
       // Принимает ввод в виде "(X, Y, W, H), (X, Y, W, H)"

       Regex regex = new Regex("\\((.*?)\\)"); //регулярное выражение
       MatchCollection binMatches = regex.Matches(serializedBins);

      //поиск совпадений регулярного выражения

       foreach (Match binMatch in binMatches)
       {
         string serializedValues = binMatch.Groups[1].ToString();
         string[] stringValues = serializedValues.Split(',');

         if (stringValues.Length != 4)
         {
           continue;
         }

         int[] values = new int[4];
         bool success = true;

         for (int index = 0; index < 4; index++)
         {
           bool result = Int32.TryParse(stringValues[index], out values[index]); //возвращает, удачно ли выполнена операция
           if (!result)
           {
             success = false;
             break;
           }
         }
         if (!success)
         {
           continue;
         }
                 Bin bin = new Bin(values[0], values[1], values[2], values[3]);
         this.Add(bin); //добавляем прямоугольник
       }
     }*/

        public void GetBoundingBin(out int width, out int height) //получение прямоугольника
        {
            width = 0;
            height = 0;

            foreach (Bin bin in this)
            {
                int binRight = bin.Rectangle.X + bin.Rectangle.Width; //ширина
                int binBottom = bin.Rectangle.Y + bin.Rectangle.Height; //высота
                                                                        //отсчет занятой площади
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

        public void Randomize(int count, int sizeMin, int sizeMax, int panelWidth, int panelHeight, out int unresolved)
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
                //проверки

                if (currentY + height > panelHeight)
                {
                    unresolved++;
                }
                else
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
