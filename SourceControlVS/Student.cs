using System;
using System.Collections.Generic;
using System.Text;

namespace SourceControlVS
{
    /// <summary>
    /// Represents an Individual Student
    /// </summary>
    class Student
    {
        /// <summary>
        /// The 9 digit Student Identification number
        /// </summary>
        public string StudentID { get; set; }

        /// <summary>
        /// Legal Student First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Legal Student Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email associated with the student
        /// </summary>
        public string Email { get; set; }
    }
}
