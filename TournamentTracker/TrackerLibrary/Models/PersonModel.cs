﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {

        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the first name of the person.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents the last name of the person.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents the email of the person.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Represents the cell phone of the person.
        /// </summary>
        public string CellphoneNumber { get; set; }

        public PersonModel()
        {

        }


        public PersonModel(string FirstName, string LastName, string Email = null, string CellphoneNumber = null)
        {
            this.FirstName= FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.CellphoneNumber = CellphoneNumber;

        }


        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }



    }
}
