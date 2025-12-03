using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class SuppliesReportDTO
    {
        public int ID { get; set; }
        public int ID_Supplier { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal TotalCost { get; set; }
        public string SupplierFullName { get; set; }
        public string CompanyName { get; set; }
        public string GoodsSummary { get; set; }
        public List<SuppliesDetailReportDTO> Details { get; set; } = new List<SuppliesDetailReportDTO>();
    }

    public class SuppliesDetailReportDTO
    {
        public int ID { get; set; }
        public int ID_Supply { get; set; }
        public string GoodsName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
    }
}
