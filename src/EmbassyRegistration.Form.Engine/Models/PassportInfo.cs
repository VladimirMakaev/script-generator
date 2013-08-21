using System;

namespace EmbassyRegistration.Form.Engine.Models
{
    public class PassportInfo
    {
        public string PersonalNumber
        {
            get;
            set;
        }

        public string PasportNumber
        {
            get;
            set;
        }

        public DateTime PassportStartDate
        {
            get;
            set;
        }

        public DateTime PassportEndDate
        {
            get;
            set;
        }

        public string IssuedBy
        {
            get; set;
        }
    }
}