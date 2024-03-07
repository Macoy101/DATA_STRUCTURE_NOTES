using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_STRUCTURE_NOTES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = new int[5]; //To declare an Array
            List<int> numList = new List<int>(); //To declare a List

            numArr.Length(); -> 5
            numList.Count(); -> 0

            numArr[0] = 7; // To access the index numArr[0]; -> 7
            numList.Add(7); // To access the List numList[0]; -> 7


            //Array Version
            int[] numArr = new int[5];
            for (int x = 0; x < numArr.Length; x++)
                numArr[x] = x;


            List<int> numList = new List<int>(); //To declare a List
            //example
            for (int x = 0; x < 5; x++) /* 0  |0|
                                         * 1  |0|1|
                                         * 2  |0|1|2|
                                         * 3  |0|1|2|3|                                        
                                         * 4  |0|1|2|3|4| <- Output
                                        */
            {
                numList.Add(x);
            }

            //To use .Remove
            numList.Remove(2); //This removes the value 2 from the index
            | 0 | 1 | 3 | 4 |

            numList.Add(2); //This adds the value to the index, (It only adds at the end of the index)
            | 0 | 1 | 3 | 4 | 2 |

            numList[4] = 3; //Changes the value of the 4th index from 2 to 3
            | 0 | 1 | 3 | 4 | 3 |

            numList.Remove(3); //1. Removes the first detected value of 3
            | 0 | 1 | 4 | 3 |

            numList.RemoveAll(3); //2. Removes all index that has a value of 3
            | 0 | 1 | 4 |

            numList[2] = 8; //Changes the value of the 2nd index from 4 to 8
            | 0 | 1 | 8 | 3 |

            numList[0] = 8; //Changes the value of the 0 index from 0 to 8
            numList.Add(783); //This adds the value to the index, (It only adds at the end of the index)
            | 8 | 1 | 8 | 3 | 783

            numList.RemoveAt(4);
            | 8 | 1 | 8 | 3 | //Removes the 4th Index(4)

            numList.RemoveAt(1); //Removes the 1st Index(1)
            | 8 | 8 | 3 |

            numList.Insert(1, 74);
            | 8 | 74 | 8 | 3 |

            numList.Contains(7); //It finds the value 7 from the given index which 7 is not available
            false

            numList.Contains(8);
            true

            numList.IndexOf(8); //Finds the first index that has a value of 8
            0

            numList.IndexOf(2); //Finds the first index that has a value of 2 but 2 is not in any index so it will automatically be -1
            -1


            if (numList.Contains(74)) //If the Index contains the value of 74 it will get the the index of the value 74
            {
                Console.WriteLine(numList.IndexOf(74));
            }


        }
    }
}
