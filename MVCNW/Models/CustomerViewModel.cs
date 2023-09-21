using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCNW.Models
{
    public class CustomerViewModel
    {
        public int id { get; set; }
        public List<SelectListItem> orderList;



        public CustomerViewModel(List<string> order)
        {



            orderList = new List<SelectListItem>();



            foreach (var item in order)
            {
                orderList.Add(new SelectListItem { Text = item, Value = item });
            }
        }
    }
}
