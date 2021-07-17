using System;

namespace Student
{
    public class StudentDB
    {
        private string name;
        public string MyName {
            get { return name; }
            set { name = value; } 
        }

        protected double total(int mark1, int mark2, int mark3, int mark4, int mark5)
        {
            var total = mark1 + mark2 + mark3 + mark4 + mark5;
            return total;
        }    


    }

}
