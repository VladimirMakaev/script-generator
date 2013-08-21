using System.Collections.Generic;

namespace EmbassyRegistration.Form.Engine.Models
{
    public class ApplicationModel
    {
        public PersonalInfo PersonalInfo
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

            PersonalInfo = new PersonalInfo();
            JobInfo = new JobInfo();
        }
    }
}