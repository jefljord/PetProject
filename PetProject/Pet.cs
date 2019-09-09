/*
 * Author: Jeffrey Jordan
 * Date: 9/8/19
 * File: Pet.cs
 * Description: This file is the abstract parent class for all pet objects.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject
{
    public abstract class Pet
    {
        private string name; // a variable to hold an animal name
        public string Name { get { return name; } } // allows child classes to access private variables

        private string species; // a variable to hold an animal species
        public string Species { get { return species; } } // allows child classes to access private variables

        /*
    * Description:
    *   Constructor that passes in two strings.
    *   Stores name and species.
    *
    *
    * Inputs:
    *   String name: Holds the name of the animal.
    *   String species: Holds the species.
    *
    *
    * Return:
    *   None.
    */
        public Pet(string name, string species)
        {
            this.name = name;
            this.species = species;
        }
        /*
    * Description:
    *   Void method to be accessed by concrete classes. 
    *   Causes a pet object to speak.
    *
    * Inputs:
    *   
    *
    * Return:
    *   None.
    */
        public abstract void speak();

        /*
    * Description:
    *   Void method to be accessed by concrete classes. 
    *   Causes a pet object to play.
    *
    * Inputs:
    *   
    *
    * Return:
    *   None.
    */
        public abstract void play();

        /*
    * Description:
    *   Void method to be accessed by concrete classes. 
    *   Displays info about the pet object.
    *
    * Inputs:
    *   
    *
    * Return:
    *   None.
    */
        public abstract void info();

    }
}

