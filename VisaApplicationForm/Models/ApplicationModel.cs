using System;
using System.Collections.Generic;

namespace VisaApplicationForm.Models
{
    public class ApplicationModel
    {
        public string LastName
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public DateTime? DateOfBirth
        {
            get; set;
        }

        public string BithPlace
        {
            get; set;
        }

        public string Gender
        {
            get; set;
        }

        public string MaritalStatus
        {
            get; set;
        }

        public PassportInfo PassportInfo
        {
            get; set;
        }

        public Address Address
        {
            get; set;
        }

        public JobInfo JobInfo
        {
            get; set;
        }

        public List<RangeInfo> PreviousVisas
        {
            get; set;
        }

        public RangeInfo VisaDates
        {
            get; set;
        }

        public ApplicationModel()
        {
            PreviousVisas = new List<RangeInfo>
            {
                new RangeInfo()
            };
        }
    }
}