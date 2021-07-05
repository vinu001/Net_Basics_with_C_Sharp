using System;

namespace session2
{
    class Program
    {
        static void Main(string[] args)
        {
           Program state = new Program();
            //state.GetApproval(15);
            //state.SwitchCase(19);
            //state.whileloop(1);
            //state.ForLoop(1);
            state.printstructure(0);
        }
             public void GetApproval(int age)
        {
            string str = string.Empty;
            if( age > 18)
            {
                   str = "Above 18";
            }
            else if (age != 10)
            {
             str = "Between 10 to 18";
            }
            else if (age > 5)
            {
                str = "other";
            }
           // return str;
           
        }
            public void SwitchCase(int age)
            {
                    string str = age.ToString();
                    switch(str)
                    {
                        case "18":
                        Console.WriteLine(18);
                        break;

                        case "15":
                        Console.WriteLine(15);
                        break;

                        default:
                        Console.WriteLine("other");
                        break;
                    }
            }

                public void whileloop(int num)
                {
                    while(num <10)
                    {
                    Console.WriteLine(num);
                    if(num == 6)
                    {
                        Console.WriteLine("In if block");
                        break;
                    }
                    num++;
                }
            }

            public void ForLoop(int num)
            {
                int[] arr =new int[5];

                for(int i=4;i>=num;i--)
                {
                    arr[i] = i;
                }
                foreach(int item in arr)
                {
                    Console.WriteLine(item);
                }
            }
            public void printstructure(int len)
            // ******
            // *****
            // ****
            // ***
            // **
            // *
            {
                    for( int i = 5; i >= len; i--)
                    {
                       
                        for(int j = 0 ; j <= i ; j++ )
                        {
                           // Console.WriteLine("i"+i);
                         // Console.WriteLine("j"+j);
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
            }

    }
}
