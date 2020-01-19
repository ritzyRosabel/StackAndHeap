using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndHeap
{
   public class BirthYear
    {

        public int age { get; set; }// stored in the heap and is globally accessible
        public string firstName { get; set; }
        public   BirthYear(string FirstName, int Age)
        {
            firstName = FirstName;
            age = Age;
        }
        public void AddYear()//stored in the stack
        {
            int result = 1;//stored in stack
            int now = result; ;//stored in stack

            Console.WriteLine(result);
            Console.WriteLine(now);
            age += result;
            result++;
            now = 4; ;//becomes 4 instead of carrying te same value as result
            Console.WriteLine(result);
            Console.WriteLine(now);
        }
        public void  DisplayResult()//stored in the stack
            {
            Console.WriteLine(" my name is {0}", firstName);
            Console.WriteLine(" i am {0}", age);

            }
        }
    }
