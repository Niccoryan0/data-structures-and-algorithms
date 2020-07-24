using System;
using System.Text;
using System.Xml.XPath;
using StacksAndQueues;

namespace FIFOAnimalShelter.Classes
{
    public class Shelter : Queue<Animal>
    {
        public Node<Animal> Front { get; set; }
        public Node<Animal> Rear { get; set; }

        public Shelter()
        {
            Rear = Front;
        }
        /// <summary> 
        /// Add a new animal to the shelter
        /// </summary>
        /// <param name="pet">Pet to be added</param>
        public void Enqueue(Animal pet)
        {
            Node<Animal> animal = new Node<Animal>(pet);

            if (Front == null)
            {
                Front = animal;
                Rear = animal;
            }
            else
            {
                Rear.Next = animal;
                Rear = animal;
            }
        }

        /// <summary>
        /// Removes an animal of specified type from the shelter.
        /// </summary>
        /// <param name="type">Type of pet desired</param>
        /// <returns>First pet in Shelter of specified type.</returns>
        public Animal Dequeue(string type)
        {
            Node<Animal> temp = Front;
            do
            {
                if (temp.Value.Species == type)
                {
                    Animal result = temp.Value;
                    temp = temp.Next;
                    return result;
                }
                else
                {
                    Temp.Dequeue();
                }
            } while (Front != temp);
            return TheShelter.Dequeue();
        }

    }
}
