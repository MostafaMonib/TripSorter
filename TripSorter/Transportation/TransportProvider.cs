using JourneySorterAssembly.Locator;
using System;
using System.Text;

namespace JourneySorterAssembly.Transportation
{

    /// <summary>
    /// Developed By : mostafa.monib@gmail.com mostafa monib
    /// </summary>
    public abstract class TransportProvider
    {

        /// <summary>
        /// The name company
        /// </summary>
        private String nameCompany;

        /// <summary>
        /// The foundation year
        /// </summary>
        private DateTime foundationYear;

        /// <summary>
        /// The number of employees
        /// </summary>
        private int numOfEmployees;

        /// <summary>
        /// The headquarters
        /// </summary>
        private Location headquarters;


        /// <summary>
        /// Initializes a new instance of the <see cref="TransportProvider"/> class.
        /// </summary>
        protected TransportProvider()
        {
            nameCompany = "";
            foundationYear = DateTime.Now;
            numOfEmployees = 0;
            headquarters = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransportProvider"/> class.
        /// </summary>
        /// <param name="nameCompany">The name company.</param>
        /// <param name="foundationYear">The foundation year.</param>
        /// <param name="numOfEmployees">The number of employees.</param>
        /// <param name="headquarters">The headquarters.</param>
        protected TransportProvider(String nameCompany, DateTime foundationYear, int numOfEmployees, Location headquarters)
        {
            this.nameCompany = nameCompany;
            this.foundationYear = foundationYear;
            this.numOfEmployees = numOfEmployees;
            this.headquarters = headquarters;
        }

        /// <summary>
        /// Gets the name of the company.
        /// </summary>
        /// <returns></returns>
        public String GetCompanyName()
        {
            return nameCompany;
        }

        /// <summary>
        /// Sets the name of the company.
        /// </summary>
        /// <param name="nameCompany">The name company.</param>
        protected void SetCompanyName(String nameCompany)
        {
            this.nameCompany = nameCompany;
        }

        /// <summary>
        /// Gets the foundation year.
        /// </summary>
        /// <returns></returns>
        protected DateTime GetFoundationYear()
        {
            return foundationYear;
        }

        /// <summary>
        /// Sets the foundation year.
        /// </summary>
        /// <param name="foundationYear">The foundation year.</param>
        protected void SetFoundationYear(DateTime foundationYear)
        {
            this.foundationYear = foundationYear;
        }

        /// <summary>
        /// Gets the number employees.
        /// </summary>
        /// <returns></returns>
        protected int GetNumEmployees()
        {
            return numOfEmployees;
        }

        /// <summary>
        /// Sets the number employees.
        /// </summary>
        /// <param name="numOfEmployees">The number of employees.</param>
        protected void SetNumEmployees(int numOfEmployees)
        {
            this.numOfEmployees = numOfEmployees;
        }

        /// <summary>
        /// Gets the head quarters.
        /// </summary>
        /// <returns></returns>
        protected Location GetHeadQuarters()
        {
            return headquarters;
        }

        /// <summary>
        /// Sets the head quarters.
        /// </summary>
        /// <param name="headquarters">The headquarters.</param>
        protected void SetHeadQuarters(Location headquarters)
        {
            this.headquarters = headquarters;
        }

        /// <summary>
        /// Gets the more information.
        /// </summary>
        /// <returns></returns>
        protected String GetMoreInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("The Provider ").Append(GetCompanyName()).Append(" It was founded in ")
                .Append(string.Format("MMM d yyyy", GetFoundationYear()));
            return sb.ToString();
        }

    }
}