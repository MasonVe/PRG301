using System;
using System.Collections.Generic;

namespace UnitTest
{
    public class Movie
    {
        public int MOVIENO;
        public string TITLE { get; set; }
        public int RELYEAR { get; set; }
        public int RUNTIME { get; set; }

        public List<Actor> ACTORS = new List<Actor>();
        
        public Movie(int movieno, string title, int relyear, int runtime)
        {
            this.MOVIENO = movieno;
            this.TITLE = title;
            this.RELYEAR = relyear;
            this.RUNTIME = runtime;
            ACTORS = new List<Actor>();
        }
    
        public int NumActors()
        {
            return ACTORS.Count;
        }

        public int GetAge()
        {
            int age;
            int currentyear = DateTime.Today.Year;

            age = currentyear - this.RELYEAR;

            return age;
        }
    }
}