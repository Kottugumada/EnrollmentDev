using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace OMAPDev.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

       [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Company Name is Required")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
        ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "JumpStart is Required")]
        public string JumpStart { get; set; }

        [Required(ErrorMessage = "Marketting Manager is Required")]
        public string MarkettingManager { get; set; }
        public string AdditionalInfo { get; set; }

        public bool IsEULA{ get; set; }
        public string Self
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
                    "api/Enrollment/{0}", this.EnrollmentId);
            }
            set { }
        }
    }
}