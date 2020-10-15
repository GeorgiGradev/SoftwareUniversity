using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            int counter = 0;
            int greenLightSec = int.Parse(Console.ReadLine());
            int freeWindowSec = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "green" && queue.Count > 0)
                {
                    int tempGreenLightSec = greenLightSec;
                    while (true)
                    {
                        string car = queue.Peek();
                        if (car.Length < tempGreenLightSec)
                        {
                            queue.Dequeue();
                            tempGreenLightSec -= car.Length;
                            counter++;

                        }
                        else if (car.Length == tempGreenLightSec)
                        {
                            queue.Dequeue();
                            counter++;
                            break;

                        }
                        else if (car.Length > tempGreenLightSec)
                        {
                            int timeLeft = freeWindowSec + tempGreenLightSec;
                            if (timeLeft >= car.Length)
                            {
                                queue.Dequeue();
                                counter++;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {car[timeLeft]}.");
                                return;
                            }
                        }
                        if (queue.Count == 0)
                        {
                            break;
                        }
                    }
                }
                else if (input == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{counter} total cars passed the crossroads.");
                    break;
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
        }
    }
}
