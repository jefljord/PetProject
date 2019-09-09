/*
 * Author: Jeffrey Jordan
 * Date: 9/8/19
 * File: Program.cs
 * Description: The main driver class for the Pet program.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopBreak = true; // a bool to break out of a loop.
            int choice; // stores the number users select from menu.

            menu m = new menu(); // creates a new menu object.
            m.printMenu(); // calls the menu print function
            choice = Convert.ToInt32(Console.ReadLine()); // reads in the number as an int

            while (loopBreak)
            {
                if (choice == 1)
                {
                    Dog d = new Dog("gus", "dog"); // creates a Dog objects and calls the constructor
                    d.info(); // calling each override
                    d.play();
                    d.speak();
                    m.printMenu();
                    choice = Convert.ToInt32(Console.ReadLine());
                }

                if (choice == 2)
                {
                    Cat c = new Cat("felix", "cat"); // creates a Cat objects and calls the constructor
                    c.info();
                    c.play();
                    c.speak();
                    m.printMenu();
                    choice = Convert.ToInt32(Console.ReadLine());
                }

                if (choice == 3)
                {
                    Falcon f = new Falcon("Ajax", "hawk"); // creates a Falcon objects and calls the constructor
                    f.info();
                    f.play();
                    f.speak();
                    m.printMenu();
                    choice = Convert.ToInt32(Console.ReadLine());
                }

                if (choice == 4)
                {
                    loopBreak = false; // ends the loop.
                }
            }
        }
    }
}
