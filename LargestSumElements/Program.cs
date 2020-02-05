using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LargestSumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList arrayIn = new ArrayList();
                //int  i = 0;
                bool flag = true;
                string rta;
                int i;
                double oddSum = 0;
                double evenSum = 0;

                while (flag)
                {
                    Console.WriteLine("Digit a number:");
                    arrayIn.Add(Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Add another number: y/n");
                    rta = Console.ReadLine();
                    if (rta == "y")
                        continue;
                    else if (rta == "n")
                        flag = false;
                    else
                    {
                        Console.WriteLine("Digit 'y' for add another number or 'n' to calculate");
                        Console.WriteLine("Add another number: y/n");
                        rta = Console.ReadLine();
                    }
                }

                Console.WriteLine("Pick a number: ");
                double num = Convert.ToInt32(Console.ReadLine());
                for (i = 0; i < arrayIn.Count; i++)
                {



                    if (i % 2 == 0)
                    {
                        oddSum = oddSum + Convert.ToDouble(arrayIn[i]);

                    }
                    else
                        evenSum = evenSum + Convert.ToDouble(arrayIn[i]);


                }

                for (int j = 0; j < arrayIn.Count; j++)
                {
                    if (num == Convert.ToDouble(arrayIn[j]))
                    {
                        if (j % 2 == 0)
                        {
                            Console.WriteLine(oddSum);
                            break;
                        }

                        else
                        {
                            Console.WriteLine(evenSum);
                            break;
                        }



                    }
                }
                Console.ReadKey();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            

        }
    }
}
