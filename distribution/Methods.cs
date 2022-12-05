using System;
using System.Collections.Generic;
using System.Linq;

namespace distribution
{
    internal class Methods
    {
        public static Random rand = new Random();
        //Метод Неймона
        public static double Neymon(double a, double b, double qMax, double left, double right, double betta)
        {
            double xN, yN;
            do
            {
                xN = left + (right - left)*rand.NextDouble();       //генерація координати Х
                yN = qMax*rand.NextDouble();                        //генерація координати У
            } while (Function(a, b, xN, betta) < yN);               //генерируємо до тих пір, доки точка не зпівпала з графіком
            return xN;                                              //точка потрапила, хаповнюємо координату Х
        }

        //Метод Метропоіса
        public static double Metropolis(double a, double b, double left, double right, double xM, double delta, double betta)
        {
            double xNext, pI;

            xNext = left + delta*(2*rand.NextDouble() - 1);           //генеруємо наступну точку от xM
            pI = Function(a, b, xNext, betta) /Function(a, b, xM, betta); //відношення функції наступної точки до початкової функції 

            if (pI > 1)               //якщо відношення більше 1
                xM = xNext;            //точка нам підходить, запам'ятовуємо її, щоб потім порахувати від нової

            if (rand.NextDouble() < pI)     //якщо відношення більше ГСВ
                xM = xNext;               //точка нам підходить, запам'ятовуємо її, щоб потім порахувати від нової

            return xM;                   //інакше, вертаємося до початкової точки
        }

        //віднімання дисперсії
        public static double Disp(List<double> myList, double summ)
        {
            double ds = 0, sqSum = 0;
            sqSum = myList.Sum(i => i*i);
            ds = Math.Sqrt(1.0/(myList.Count - 1)*(sqSum - myList.Count*Math.Pow(summ, 2)));

            return ds;
        }

        public static double Mean(List<double> myList)
        {
            return (myList.Sum()/myList.Count);
        }

        //метод зворотних ф.
        public static double Inverse(double A, double B, double st, double betta)
        {
            double x = rand.NextDouble();
            return InverseCDF(A, B, x, betta);
        }

        //зворотня функція
        private static double InverseCDF(double A, double B, double x, double betta)
        {
            double temp = Math.Pow((1 - Math.Pow(1 - x, 1 / B)), 1 / A);
            return temp;
        }

        public static double Factorial(double n)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial *= i;

            return factorial;
        }

        //Beta-distribution
        public static double Function(double a, double b, double x, double betta)
        {
            if (x == 0 && a < 1 && b < 1)
            {
                return ((1 / betta) * 1 * Math.Pow(1 - x, b - 1));
            }
            return ((1 / betta) * Math.Pow(x, a - 1) * Math.Pow(1 - x, b - 1));
        }
    }
}