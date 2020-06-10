﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person
    /// </summary>
    public class PersonModel
    {
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
        /// The Primary cell phone number of the person
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
