using System.Collections;
using System.Collections.Generic;

namespace DesignPatternsTrain.Behavioral.Iterator
{
    public class DaysInMonthCollection: IEnumerable<MonthWithDays>
    {
        public IEnumerator<MonthWithDays> GetEnumerator()
        {
            return new DaysInMonthEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
