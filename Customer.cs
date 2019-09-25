using System;

namespace OOP_Introduction
{
    class Customer : Person
    {
        public string studentNumber;
        public Person Advisor;

        /// <summary>
        /// Default constructor attempt 1
        /// </summary>
        public Customer()
        {
            CustomerNumber = "U1234";
            FirstName = "Pankaj";
        }

        /// <summary>
        /// Default constructor that uses inheritance
        /// </summary>
        //public Student() : base()
        //{
        //  studentNumber = "U1234";
        //}
    }
}