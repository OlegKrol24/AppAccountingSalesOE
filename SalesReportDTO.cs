using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class SalesReportDTO
    {
        public int ID { get; set; }
        public DateTime SaleDate { get; set; }
        public string CustomerFullName { get; set; }
        public string EmployeeFullName { get; set; }
        public decimal TotalAmount { get; set; }
        public string GoodsSummary { get; set; }
        public List<SalesDetailReportDTO> Details { get; set; } = new List<SalesDetailReportDTO>();
    }

    public class SalesDetailReportDTO
    {
        public int ID { get; set; }
        public string GoodsName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
