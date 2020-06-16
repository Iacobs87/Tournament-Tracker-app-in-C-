using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// First Name of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email Adrress of the person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }

    }
}
