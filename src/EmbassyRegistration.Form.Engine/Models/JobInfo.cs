using System.Collections.Generic;
using EmbassyRegistration.Form.Engine.Factories;

namespace EmbassyRegistration.Form.Engine.Models
{
    public class JobInfo
    {
        public string JobType
        {
            get; set;
        }

        public List<ListItem> JobTypes
        {
            get; set;
        }

        public Address Address
        {
            get; set;
        }

        public JobInfo()
        {
            JobTypes = JobTypeFactory.GetJobTypes();
        }
    }
}