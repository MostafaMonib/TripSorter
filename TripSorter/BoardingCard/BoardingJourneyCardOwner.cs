using System;

namespace JourneySorterAssembly.JourneyHelper
{

    /// <summary>
    /// Represents the owner and owner of a boarding pass
    /// 
    /// Developed By : mostafa.monib@gmail.com
    /// 
    /// </summary>
    public class BoardingJourneyCardOwner
    {

        /// <summary>
        /// The name
        /// </summary>
        private String name;
        /// <summary>
        /// The first name
        /// </summary>
        private String firstName;
        /// <summary>
        /// The age
        /// </summary>
        private int age;

        /// <summary>
        /// Initializes a new instance of the <see cref="BoardingJourneyCardOwner"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="age">The age.</param>
        public BoardingJourneyCardOwner(String name, String firstName, int age)
        {
            this.name = name;
            this.firstName = firstName;
            this.age = age;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoardingJourneyCardOwner"/> class.
        /// </summary>
        public BoardingJourneyCardOwner()
        {
            name = "";
            firstName = "";
            age = 0;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public String GetName()
        {
            return name;
        }

        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="name">The name.</param>
        public void SetName(String name)
        {
            this.name = name;
        }

        /// <summary>
        /// Gets the first name.
        /// </summary>
        /// <returns>String</returns>
        public String GetFirstName()
        {
            return firstName;
        }

        /// <summary>
        /// Sets the first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        public void SetFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        /// <summary>
        /// Gets the age.
        /// </summary>
        /// <returns>Int</returns>
        public int GetAge()
        {
            return age;
        }

        /// <summary>
        /// Sets the age.
        /// </summary>
        /// <param name="age">The age.</param>
        public void SetAge(int age)
        {
            this.age = age;
        }

    }
}