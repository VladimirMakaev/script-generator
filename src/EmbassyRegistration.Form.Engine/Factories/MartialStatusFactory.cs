using System.Collections.Generic;
using EmbassyRegistration.Form.Engine.Models;

namespace EmbassyRegistration.Form.Engine.Factories
{
    public static class MartialStatusFactory
    {
        public static List<ListItem> GetStatusList()
        {
            return new List<ListItem>
            {
                new ListItem{Text = "Холост/не замужем", Value = "KP"},
                new ListItem{Text = "Женат/Замужем", Value = "ZZ"},
                new ListItem{Text = "не проживает с супругой", Value = "SP"},
                new ListItem{Text = "Разведен/-а", Value = "RR"},
                new ListItem{Text = "Вдовец/Вдова", Value = "WW"},
                new ListItem{Text = "Другой", Value = "IN"}
            };
        }
    }
}
