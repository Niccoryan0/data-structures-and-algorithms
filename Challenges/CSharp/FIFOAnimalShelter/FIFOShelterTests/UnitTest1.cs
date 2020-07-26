using System;
using Xunit;
using FIFOAnimalShelter.Classes;
using StacksAndQueues;

namespace AnimalShelterTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueueDogToShelter()
        {
            Shelter shelter = new Shelter();
            Dog dog = new Dog("Henry");
            shelter.Enqueue(dog);


            Assert.Equal(dog, shelter.Animals.Peek());
        }

        [Fact]
        public void CanDequeueDogFromShelter()
        {
            Shelter shelter = new Shelter();
            Dog dog = new Dog("Henry");
            shelter.Enqueue(dog);

            Animal result = shelter.Dequeue("Dog");

            Assert.Equal(dog, result);
        }

        [Fact]
        public void CanEnqueueCatToShelter()
        {

            Shelter shelter = new Shelter();
            Cat cat = new Cat("Moe");

            shelter.Enqueue(cat);

            Assert.Equal(cat, shelter.Animals.Peek());
        }

        [Fact]
        public void CanDequeueCatFromShelter()
        {

            Shelter shelter = new Shelter();
            Cat cat = new Cat("Moe");

            shelter.Enqueue(cat);

            Animal result = shelter.Dequeue("Cat");


            Assert.Equal(cat, result);
        }

        [Fact]
        public void CanFindAnimalInShelter()
        {
            Shelter shelter = new Shelter();
            Cat cat = new Cat("Moe");
            Cat cat2 = new Cat("Moe2");
            Cat cat3 = new Cat("Moe3");


            Dog dog = new Dog("Henry");


            shelter.Enqueue(cat);
            shelter.Enqueue(cat2);
            shelter.Enqueue(dog);
            shelter.Enqueue(cat3);


            Animal result = shelter.Dequeue("Dog");


            Assert.Equal(dog, result);
        }
    }
}