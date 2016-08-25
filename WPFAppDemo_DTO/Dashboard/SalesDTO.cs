using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAppDemo_DTO.DashBoard
{
    public class SalesDTO : IDisposable
    {
        public string Country { get; set; }

        public long Quantity { get; set; }

        public decimal UnitPrice { get; set; }
        public decimal TotalSales { get; set; }

        public long Year { get; set; }

        public ObservableCollection<long> YearCollection { get; set; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
