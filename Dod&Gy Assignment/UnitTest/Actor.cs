using System;

namespace UnitTest
{
    public class Actor
    {
        public int ACTORNO { get; set; }
        public string FULLNAME { get; set; }
        public string GIVENNAME { get; set; }
        public string SURNAME { get; set; }

        public Actor(int actno, string full)
        {
            this.ACTORNO = actno;
            this.FULLNAME = full;
        }

        public Actor()
        {
            setFullName();
        }
        public void setFullName()
        {
            FULLNAME = GIVENNAME + " " + SURNAME;
        }
    }
}
