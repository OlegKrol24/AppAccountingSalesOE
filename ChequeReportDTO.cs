using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class ChequeReportDTO
    {
        public string CustomerFullName { get; set; } = "Роздрібний покупець";
        public string EmployeeFullName { get; set; } = "Касир";
        public decimal TotalAmount { get; set; }
        public List<ChequeDetailDTO> Details { get; set; } = new List<ChequeDetailDTO>();
    }

    [Serializable]
    public class ChequeDetailDTO
    {
        public int ID { get; set; }
        public string GoodsName { get; set; } = "";
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
