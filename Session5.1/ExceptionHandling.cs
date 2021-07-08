using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5._1
{
    class ExceptionHandling
    {
        public static void GetAddition (string a, string b)
        {
            try
            {
                int aInt = Convert.ToInt32(a);
                int bInt = Convert.ToInt32(b);

                Console.WriteLine("Division is " + (aInt / bInt));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("error In Divide By zero :" + e.Message);
               
            }
            catch(Exception e)
            {
                Console.WriteLine("error : " + e.Message);
               
            }

            finally
            {
                Console.WriteLine("In finally block");
            }
        }
    }
}
