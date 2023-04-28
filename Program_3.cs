/* C#, lesson_40  15.04.2023																																					
																																					
Task № 3:																																					
Порахувати, скільки разів кожне слово зустрічається в заданому тексті. 																																					
Результат записати до колекції Dictionary<TKey, TValue>																																					
*/
//--------------------------------------------------------------------------------------------------------																																					
using System;
using System.Globalization;
using System.Collections.Generic;
using static System.Console;
namespace Lesson_40
{

    //--------------------------------------------------------------------------------------------------------																																					
    class Program
    {
        static void Main(string[] args)
        {
            string text; int index;
            do                          // загальний цикл програми																																					
            {
                Console.Write("\n\nEnter your text: ");	            // введення рядка																																				
                text = Console.ReadLine();

                string[] words = text.Split(' ', ',', '.', ':', '!', '?', ':', ';', '-', '\t'); // перетворення рядка в масив слів без розділових знаків																																				

                //foreach(var word in words)																																					
                //{																																					
                //    Console.WriteLine(word);																																					
                //}

                for (int i = 0; i < words.Length; i++)		// цикл для видалення пробілів з масиву слів
                {
                    if (words[i] == "")
                    {
                        for (int j = i; j < words.Length - 1; j++)
                        {
                            words[j] = words[j + 1];
                        }
                        Array.Resize(ref words, words.Length - 1);
                        i--; // пройти ще раз на випадок якщо два пробіли підряд
                    }
                }

                for (int i = 0; i < words.Length; i++)	    // приведення всіх слів в нижній регістр																																				
                {
                    words[i] = words[i].ToLower();
                }

                Dictionary<string, int> table = new Dictionary<string, int>();              // оголошення словника																																	

                for (int i = 0; i < words.Length; i++)							// цикл для перебору слів в масиві																														
                {
                    if (table.ContainsKey(words[i]))							// якщо слово зустрічається в словнику - value збільшується на 1																														
                        table[words[i]]++; 																																				
                    else
                        table.Add(words[i], 1);									// інашке добавляється нова пара в словник - слово і початкова кількість																												
                }

                Console.WriteLine();
                foreach (KeyValuePair<string, int> word in table)				// цикл для виведення кількості слів в консоль																																	
                {
                    Console.WriteLine($"word \"{word.Key}\" - {word.Value} time(s)");
                }
                Console.WriteLine();

//--------------------------------------------------------------------------------------------------------																																					

                // продовжити ?																																					
                Console.Write("\n\nDo you want to continue? ('1' for 'yes'): ");
                index = Convert.ToInt32(Console.ReadLine());

            } while (index == 1);
        }
    }
}
