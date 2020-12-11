using System;

namespace WebAPI.models
{
    public class Actor
    {
        public int ACTORNO { get; set; }
        public string FULLNAME { get; set; }
        public string GIVENNAME { get; set; }
        public string SURNAME { get; set; }

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
