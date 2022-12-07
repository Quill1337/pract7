using System;

namespace WPFApp7_9_
{
    internal class Triad
    {
        protected int _first, _second, _third;
        public int First
        {
            get => _first;
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException("Число должно быть нечетным");
                }
                _first = value;
            }
        }
        public int Second
        {
            get => _second;
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException("Число должно быть нечетным");
                }
                _second = value;
            }
        }
        public int Third
        {
            get => _third;
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException("Число должно быть нечетным");
                }
                _third = value;
            }
        }

        /// Сравнивает две тройки чисел
        public bool Compare(Triad firstValue, Triad secondValue)
        {
            return First == firstValue.First && firstValue.First == secondValue.First && Second == firstValue.Second && firstValue.Second == secondValue.Second && Third == firstValue.Third && firstValue.Third == secondValue.Third;
        }

        /// Сравнивает три тройки чисел
        public bool Compare(Triad firstValue, Triad secondValue, Triad thirdValue)
        {
            return First == firstValue.First && firstValue.First == secondValue.First && secondValue.First == thirdValue.First && Second == firstValue.Second && firstValue.Second == secondValue.Second && secondValue.Second == thirdValue.Second && Third == firstValue.Third && firstValue.Third == secondValue.Third && secondValue.Third == thirdValue.Third;
        }

        public static bool operator true(Triad triad1)
        {
            return triad1.First % 2 != 0 && triad1.Second % 2 != 0 && triad1.Third % 2 != 0;
        }
        public static bool operator false(Triad triad1)
        {
            return triad1.First % 2 == 0 && triad1.Second % 2 == 0 && triad1.Third % 2 == 0;
        }
        public static bool operator !=(Triad triad1, Triad triad2)
        {
            return triad1.First != triad2.First && triad1.Second != triad2.Second && triad1.Third != triad2.Third;
        }
        public static bool operator ==(Triad triad1, Triad triad2)
        {
            return triad1.First == triad2.First && triad1.First == triad2.Second && triad1.Third == triad2.Third;
        }
    }
}
