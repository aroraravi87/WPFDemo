using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppDemo_DTO.DashBoard;
using WpfAppDemo_Library.DAL.AccountDao.Interface;
using WpfAppDemo_Library.DAL.DashboardDao.Interface;
using WPFAppDemo_Library.Model;

namespace WpfAppDemo_Library.DAL.DashboardDao
{
    public class DashboardDao : IDashboardDao
    {

        public IList<SalesDTO> GetProductSales()
        {
            using (NorthwindEntities objNorthwind = new NorthwindEntities())
            {
                var querySet = objNorthwind.Orders
                    .Join(objNorthwind.Order_Details, o => o.OrderID, od => od.OrderID,
                        (o, od) => new { Order = o, Order_Detail = od })
                    .Select(m => new SalesDTO
                    {
                        Country = m.Order.ShipCountry,
                        Quantity = m.Order_Detail.Quantity,
                        UnitPrice = m.Order_Detail.UnitPrice,
                        TotalSales = (m.Order_Detail.Quantity * m.Order_Detail.UnitPrice),
                        Year = m.Order.OrderDate.Value.Year
                    }).ToList();
                IList<SalesDTO> result = querySet.GroupBy(m => new { m.Country, m.Year })
                                                .Select(x => new SalesDTO
                                                {
                                                    Country = x.Key.Country,
                                                    Quantity = x.Sum(m => m.Quantity),
                                                    TotalSales = x.Sum(m => m.TotalSales),
                                                    Year = x.Key.Year,
                                                }).OrderBy(x => x.Country).ToList();

                return result;
            }
        }

        public IList<ProductDTO> GetProductList()
        {
            using (NorthwindEntities objNorthwind = new NorthwindEntities())
            {
                IList<ProductDTO> result = objNorthwind.Orders
                    .Join(objNorthwind.Order_Details, o => o.OrderID, od => od.OrderID,
                        (o, od) => new { Order = o, Order_Detail = od })
                        .Join(objNorthwind.Products, od1 => od1.Order_Detail.ProductID, p => p.ProductID, (od1, p) => new { Order_Detail = od1, Product = p })
                        .GroupBy(x=>new { x.Order_Detail.Order_Detail.ProductID,x.Product.ProductName})
                    .Select(m => new ProductDTO
                    {
                        ProductID = m.Key.ProductID,
                        ProductName = m.Key.ProductName
                    }).OrderBy(x => x.ProductName).ToList();
                return result;
            }
        }
    }
}
