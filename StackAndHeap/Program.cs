using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndHeap
{
    class Program
    {
   // i need to go over this again i dont understand what i did here. If this code works, then it was writen by Rosabel Olugbenga. If it doesn't, then i can only say one thing  "IT IS WHAT IT IS".
        static void Main(string[] args)
        {
            //Think of the Stack as a series of boxes stacked one on top of the next.  We keep track of what's going on in our application by stacking another box on top every time we call a method (called a Frame).  We can only use what's in the top box on the stack.  When we're done with the top box (the method is done executing) we throw it away and proceed to use the stuff in the previous box on the top of the stack. The Heap is similar except that its purpose is to hold information (not keep track of execution most of the time) so anything in our Heap can be accessed at any time.
            //The Stack is self-maintaining, meaning that it basically takes care of its own memory management.  When the top box is no longer used, it's thrown out.  The Heap, on the other hand, has to worry about Garbage collection (GC) - which deals with how to keep the Heap clean 
            //The Stack is more or less responsible for keeping track of what's executing in our code (or what's been "called").  The Heap is more or less responsible for keeping track of our objects 
            

            BirthYear birthYear = new BirthYear("opemipo",14); //Reference to birthyear stored in the stack although birth year it self is stored in the heap
            birthYear.AddYear();//makes changes my adding a year to age in the heap
            birthYear.DisplayResult();//display the values
            Console.ReadLine();
        }
    }
}
