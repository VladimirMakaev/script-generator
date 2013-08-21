using System.Collections.Generic;
using EmbassyRegistration.Form.Engine.Models;

namespace EmbassyRegistration.Form.Engine.Factories
{
    public class GenderFactory
    {
        public static List<ListItem> GetGenders()
        {
            return new List<ListItem>
            {
                new ListItem
                {
                    Text = "Мужской",
                    Value = "M"
                },
                 new ListItem
                {
                    Text = "Женский",
                    Value = "F"
                }
            };
        }
    }
}
