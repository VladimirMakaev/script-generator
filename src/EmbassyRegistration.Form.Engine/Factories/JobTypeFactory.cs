using System.Collections.Generic;
using EmbassyRegistration.Form.Engine.Models;

namespace EmbassyRegistration.Form.Engine.Factories
{
    public static class JobTypeFactory
    {
        public static List<ListItem> GetJobTypes()
        {
            return new List<ListItem>
            {
                new ListItem {Text = "Административно-судебный служащий", Value = "35"},
                new ListItem {Text = "Артист", Value = "05"},
                new ListItem {Text = "Архитектор", Value = "02"},
                new ListItem {Text = "Банкир", Value = "06"},
                new ListItem {Text = "Без профессии", Value = "30"},
                new ListItem {Text = "Водитель", Value = "10"},
                new ListItem {Text = "Государственный служащий", Value = "15"},
                new ListItem {Text = "Духовное лицо, монахиня", Value = "09"},
                new ListItem {Text = "Журналист", Value = "21"},
                new ListItem {Text = "Информатик", Value = "17"},
                new ListItem {Text = "Иные", Value = "99"},
                new ListItem {Text = "Коммерсант", Value = "07"},
                new ListItem {Text = "Личный ассистент дипломата", Value = "34"},
                new ListItem {Text = "Медицинские профессии", Value = "22"},
                new ListItem {Text = "Менеджер", Value = "08"},
                new ListItem {Text = "Мода, косметика", Value = "26"},
                new ListItem {Text = "Моряк", Value = "23"},
                new ListItem {Text = "Научный исследователь", Value = "12"},
                new ListItem {Text = "Пенсионер", Value = "28"},
                new ListItem {Text = "Персонал дипломатической администрации", Value = "33"},
                new ListItem {Text = "Политик", Value = "16"},
                new ListItem {Text = "Полицейский, солдат", Value = "27"},
                new ListItem {Text = "Предприниматель, занятый собственным делом", Value = "25"},
                new ListItem {Text = "Ремесленник", Value = "03"},
                new ListItem {Text = "Спортсмен, тренер", Value = "29"},
                new ListItem {Text = "Студент, практикант, стажер", Value = "31"},
                new ListItem {Text = "Техник иной", Value = "20"},
                new ListItem {Text = "Умственный работник", Value = "14"},
                new ListItem {Text = "Учитель", Value = "13"},
                new ListItem {Text = "Фермер", Value = "01"},
                new ListItem {Text = "Физический работник", Value = "24"},
                new ListItem {Text = "Химик", Value = "19"},
                new ListItem {Text = "Член правления фирмы", Value = "36"},
                new ListItem {Text = "Электрик", Value = "18"},
                new ListItem {Text = "Юрист", Value = "04"}
            };
        }
    }
}


