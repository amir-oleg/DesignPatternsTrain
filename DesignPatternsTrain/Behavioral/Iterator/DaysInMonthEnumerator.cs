using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatternsTrain.Behavioral.Iterator
{
    public class DaysInMonthEnumerator: IEnumerator<MonthWithDays>
    {
        private int _year = 1;
        private byte _month = 0;

        public bool MoveNext()
        {
            _month++;
            if (_month > 12)
            {
                _month = 1;
                _year++;
            }
            return _year < 5;
        }

        public void Reset()
        {
            _year = 1;
            _month = 0;
        }

        public MonthWithDays Current => new MonthWithDays()
        {
            Date = $"{_year.ToString().PadLeft(4, '0')} - {_month}",
            Days = DateTime.DaysInMonth(_year, _month)
        };

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
