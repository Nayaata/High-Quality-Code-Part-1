namespace TaskOneClass123
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        const int Max_Count = 6;

        public class Conversion
        {
            public static void isConvertedToString(bool isString)
            {
                string convertedToString = isString.ToString();
                Console.WriteLine(convertedToString);
            }
        }

        public static void Main()
        {
            Conversion newConversion = new Conversion();
            bool isString = true;

            newConversion.isConvertedToString(isString); //true
        }
    }
}
