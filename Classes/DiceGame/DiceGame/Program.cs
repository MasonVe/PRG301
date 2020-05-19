using System;
using System.Collections.Generic;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Die d1 = new Die();
            Die d2 = new Die(12);
            Die d3 = new Die(20);

            List<Die> diceList1 = new List<Die>();
            diceList1.Add(d1);
            diceList1.Add(d2);
            diceList1.Add(d3);


            List<Die> diceList2 = new List<Die>();
            diceList2.Add(d2);

            Person p1 = new Person("Willam Wallace", diceList1);
            Person p2 = new Person("Joan of Arc", diceList2);

            Console.WriteLine(p1.name);
            Console.WriteLine(p1.dice.Count);

            Console.WriteLine(p2.name);
            Console.WriteLine(p2.dice.Count);
            p2.AddNewDie(18);
            Console.WriteLine(p2.dice.Count);


            for (int i =0; i <20; i++)
            {
                Console.WriteLine(p1.RollDie(4));
            }


        }
    }


    class Die
    {
        public int NumSides;


        public Die(int numofsides) {

            this.NumSides = numofsides;
        }

        public Die()
        {
            this.NumSides = 6;
        }

        public int Roll()
        {

            Random rand = new Random();
            int roll = rand.Next(1, (this.NumSides + 1));
            return roll;
        }

    }

    class Person
    {
        public string name;
        public List<Die> dice;

        public Person(string name, List<Die> dice)
        {
            this.name = name;
            this.dice = dice;
        }

        public Person()
        {
            this.name = "John Doe";
            this.dice = new List<Die>();
        }



        /// <summary>
        /// Rolls a specified die from the Dice List. If die is out of range, will return -1.
        /// </summary>
        /// <param name="die">indexing starts at 0</param>
        /// <returns></returns>
        public int RollDie(int die)
        {
            int roll = -1;

            if (die > 0 && die < dice.Count){
                roll = dice[die].Roll();
            }
            return roll;

        }

        /// <summary>
        /// Roll all of the player's dice once and return the total.
        /// </summary>
        /// <returns></returns>
        public int RollAllDice()
        {
            return 0;
        }

        public void AddNewDie(int sides)
        {

            Die d = new Die(sides);
            this.dice.Add(d);

        }

    }

}
