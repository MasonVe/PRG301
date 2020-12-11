using System;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {

        // Actor Count Test
        [Theory]
        [InlineData(2, 136795, "The Heat", 2013, 117)]
        [InlineData(3, 9798, "Enemy of the State", 1998, 132)]
        [InlineData(2, 44214, "Black Swan", 2010, 108)]
        [InlineData(8, 275, "Fargo", 1996, 98)]
        [InlineData(9, 286217, "The Martian", 2015, 141)]
        public void ActorsTest(int expected, int movieno, string title, int relyear, int runtime)
        {
            Movie movietest = new Movie(movieno, title, relyear, runtime);
            Actor actor1 = new Actor(147, "Michael Madsen");
            Actor actor2 = new Actor(192, "Morgan Freeman");
            Actor actor3 = new Actor(193, "Gene Hackman");
            Actor actor4 = new Actor(205, "Kirsten Dunst");
            Actor actor5 = new Actor(206, "Jim Carrey");

            if (movietest.RUNTIME > 120)
            {
                movietest.ACTORS.Add(actor1);
                movietest.ACTORS.Add(actor2);
                movietest.ACTORS.Add(actor3);
            }
            else
            {
                movietest.ACTORS.Add(actor4);
                movietest.ACTORS.Add(actor5);
            }
            Assert.Equal(expected, movietest.ACTORS.Count);
        }


        // Movie Age Test
        [Theory]
        [InlineData(7, 136795, "The Heat", 2013, 117)]
        [InlineData(22, 9798, "Enemy of the State", 1998, 132)]
        [InlineData(10, 44214, "Black Swan", 2010, 108)]
        [InlineData(45, 275, "Fargo", 1996, 98)]
        [InlineData(50, 286217, "The Martian", 2015, 141)]
        public void AgeTest(int expected, int movieno, string title, int relyear, int runtime)
        {
            Movie movietest = new Movie(movieno, title, relyear, runtime);
            Assert.Equal(expected, movietest.GetAge());
        }
    }
}