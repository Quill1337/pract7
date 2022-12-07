using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp7_9_
{
    internal class Time : Triad
    {
        /// <summary>
        /// Использовать класс Triad (тройка нечетных чисел).  Определить производный класс Time с полями: час, минута и секунда.  Определить полный набор методов сравнения моментов времени.
        /// </summary>


        public int Seconds
        {
            get => _first;
            set
            {
                if(value > 60)
                {
                    throw new ArgumentException("Секунды должны быть меньше 60");
                }
                _first = value;
            }
        }

        public int Minutes
        {
            get => _second;
            set
            {
                if(value > 60)
                {
                    throw new ArgumentException("Минуты должны быть меньше 60");
                }
                _second = value;
            }
        }
        public int Hours
        {
            get => _third;
            set
            {
                if(value > 60)
                {
                    throw new ArgumentException("Часы должны быть меньше 60");
                }
                _third = value;
            }
        }
        public static bool operator >(Time firstTriad, Time secondTriad)
        {
            return firstTriad.Seconds > secondTriad.Seconds && firstTriad.Minutes > secondTriad.Minutes && firstTriad.Hours > secondTriad.Hours;
        }
        public static bool operator <(Time firstTriad, Time secondTriad)
        {
            return firstTriad.Seconds < secondTriad.Seconds && firstTriad.Minutes < secondTriad.Minutes && firstTriad.Hours < secondTriad.Hours;
        }

        public static bool operator >=(Time firstTriad, Time secondTriad)
        {
            return firstTriad.Seconds >= secondTriad.Seconds && firstTriad.Minutes >= secondTriad.Minutes && firstTriad.Hours >= secondTriad.Hours;
        }
        public static bool operator <=(Time firstTriad, Time secondTriad)
        {
            return firstTriad.Seconds <= secondTriad.Seconds && firstTriad.Minutes <= secondTriad.Minutes && firstTriad.Hours <= secondTriad.Hours;
        }
    }
}
