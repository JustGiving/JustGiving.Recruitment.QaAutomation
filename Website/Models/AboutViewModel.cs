using System.Collections.Generic;
using System.Web.Mvc;

namespace JustGiving.Recruitment.QaAutomation.Website.Models
{
    public class AboutViewModel
    {
        public string SelectedListItem { get; set; }
        public List<SelectListItem> List { get; set; }

        public AboutViewModel()
        {
            List = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Item1", Value = "Item1"},
                    new SelectListItem {Text = "Item2", Value = "Item2"},
                    new SelectListItem {Text = "Item3", Value = "Item3"},
                    new SelectListItem {Text = "Item4", Value = "Item4"},
                    new SelectListItem {Text = "Item5", Value = "Item5", Selected = true},
                    new SelectListItem {Text = "Item6", Value = "Item6"},
                    new SelectListItem {Text = "Item7", Value = "Item7"},
                    new SelectListItem {Text = "Item8", Value = "Item8"},
                    new SelectListItem {Text = "Item9", Value = "Item9"},
                    new SelectListItem {Text = "ThisOne", Value = "Item10"}
                };
        }
    }
}