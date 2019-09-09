/*
 * Author: Jeffrey Jordan
 * Date: 9/8/19
 * File: Cat.cs
 * Description: This file implements the Pet class for a concrete Cat object.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject
{
    class Cat : Pet
    {
        /*
    * Description:
    *   Constructor that passes in two strings and accesses the base 
    *   constructor. Sets name and species for the concrete object.
    *
    *
    * Inputs:
    *   String x: Holds the name of the animal.
    *   String y: Holds the species.
    *
    *
    * Return:
    *   None.
    */

        public Cat(string x, string y) : base(x, y)
        {

        }

        /*
    * Description:
    *   Overrides the base info function to print basic qualities of the animal.
    *
    *
    * Inputs:
    *   N/A
    *
    *
    * Return:
    *   None.
    */
        public override void info()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Species: " + Species);
        }

        /*
    * Description:
    *   Overrides the base play function to print basic play action.
    *
    *
    * Inputs:
    *   N/A
    *
    *
    * Return:
    *   None.
    */
        public override void play()
        {
            Console.WriteLine("The " + Species + " " + Name + " *..... Does nothing. It's a cat.*");
        }

        /*
    * Description:
    *   Overrides the base speak function to emulate animal speech.
    *
    *
    * Inputs:
    *   N/A
    *
    *
    * Return:
    *   None.
    */
        public override void speak()
        {
            Console.WriteLine(Name + " says " + "Tuna or no tricks\n");
        }
    }
}
