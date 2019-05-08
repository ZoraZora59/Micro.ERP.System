namespace MicroERP.Web.Areas.System.Models
{
    public class MainIndexViewModel
    {
        public int TodoCount { get; set; }
        public int EmployeeCount { get; set; }
        public int UnderCheckCount { get; set; }
        public int OrderCount { get; set; }

    }
    public class TableViewModel
    {
        public int[] TNumbers { get; set; }
        public string[] TDate { get; set; }
    }
}