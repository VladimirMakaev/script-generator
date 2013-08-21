using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EmbassyRegistration.Form.Engine.Models;

namespace EmbassyRegistration.Form.App_Start
{
    public static class ListItemHelper
    {
        public static IEnumerable<SelectListItem> ToSelectList(List<ListItem> items)
        {
            return items.Select(item => new SelectListItem
            {
                Text = item.Text,
                Value = item.Value
            });
        }
    }
}