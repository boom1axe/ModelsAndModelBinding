using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;

namespace ModelsAndModelBinding.Models
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    public class Student
    {
        
        public int StudentID { get; set; }
        /// <summary>
        /// The legal First then last name
        /// ex. James Bond
        /// </summary>
        public String FullName { get; set; }
        public String ProgramOfChoice { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String homeAddress { get; set; }
    }
}
