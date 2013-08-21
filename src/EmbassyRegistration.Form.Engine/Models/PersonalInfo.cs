using System;
using System.Collections.Generic;
using EmbassyRegistration.Form.Engine.Factories;

namespace EmbassyRegistration.Form.Engine.Models
{
    public class PersonalInfo
    {
        public string LastName
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public DateTime? DateOfBirth
        {
            get;
            set;
        }

        public string BithPlace
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }

        public string MaritalStatus
        {
            get;
            set;
        }

        public List<ListItem> Genders
        {
            get; set;
        }

        public List<ListItem> MartialStatusList
        {
            get;
            set;
        }

        public PersonalInfo()
        {
            Genders = GenderFactory.GetGenders();
            MartialStatusList = MartialStatusFactory.GetStatusList();
        }
    }
}