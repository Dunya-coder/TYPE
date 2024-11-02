using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {/*Val-baholash*/
            short shortResult, shortVal = 4;

            int integerVal = 67;

            long longResult;

            float floatVal = 10.5F;

            double doubleResult, doubleVal = 99.999;

            string stringReasult, stringVal = "17";

            bool boolVal = true;

            doubleResult = floatVal * shortVal;

            Console.WriteLine("yashirin ,->double:{0}*{1}->{2}", floatVal, shortVal, doubleResult);
            shortResult = (short)floatVal;//floatdan qiymat short turga o'zgartirildi
            Console.WriteLine("aniq ->short:{0}->{1}", floatVal, shortResult);

            Console.WriteLine(stringReasult = Convert.ToString(boolVal));//bool turdagini stringga o'tkazvotti
            stringReasult = Convert.ToString(boolVal) + Convert.ToString(doubleVal);//va double ni ham srttringga o'girib umumiy string hosil qildi
            Console.WriteLine(stringReasult);

            Console.WriteLine(Convert.ToInt32(stringVal));

            longResult = integerVal + Convert.ToInt32(stringVal);

            Console.WriteLine("mix ->long:{0}+{1}->{2}", integerVal, stringVal, longResult);//int turga string ni intga almasshtirib qo'shildi

            Console.ReadKey();
        }
    }
}
