using Dapper;
using Laundry.Data;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public class ServicePriceRepository :IServicePrice
    {
        public IEnumerable<ServicePriceModel> GetAllServicePrice() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT tbl_service_price.pricing_id, tbl_servicesname.serviceName, tbl_service_product.service_product_id, tbl_service_price.product_cost, tbl_service_price.stylist_cost, tbl_service_price.overhead_cost, tbl_service_price.total_cost, tbl_service_price.selling_price, tbl_service_price.vat_amount	, tbl_service_price.net_price, tbl_service_price.net_profit, tbl_service_price.gross_profit, tbl_service_price.profit_percent
                            FROM tbl_service_price
                            LEFT JOIN tbl_service_product 
                            ON tbl_service_product.service_product_id = tbl_service_price.service_product_id
                            LEFT JOIN tbl_servicesname
                            ON tbl_servicesname.serviceName_id = tbl_service_product.service_id;";
                return con.Query<ServicePriceModel>(sql).ToList();
            }
        }

        public ServicePriceModel GetServicePrice(int SelectedServiceNameID)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                    sp.selling_price,
                    sp.vat_amount,
                    sp.net_price
                FROM tbl_service_price sp
                JOIN tbl_service_product sprod ON sprod.service_product_id = sp.service_product_id
                WHERE sprod.service_id = @SelectedServiceNameID;";
                return con.Query<ServicePriceModel>(sql, new { SelectedServiceNameID  = SelectedServiceNameID }).FirstOrDefault();
            }
        }

        public void AddServicePrice(ServicePriceModel servicePrice) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_service_price (service_product_id, product_cost, stylist_cost, overhead_cost, total_cost, selling_price, vat_amount, net_price, net_profit, gross_profit, profit_percent)
                            VALUES (@service_product_id, @product_cost, @stylist_cost, @overhead_cost, @total_cost, @selling_price, @vat_amount, @net_price, @net_profit, @gross_profit, @profit_percent)";
                con.Execute(sql, servicePrice);
            }
        }
        public void UpdateServicePrice(ServicePriceModel servicePrice) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_service_price
                        SET service_product_id = @service_product_id,
                            product_cost = @product_cost,
                            stylist_cost = @stylist_cost,
                            overhead_cost = @overhead_cost,
                            total_cost = @total_cost,
                            selling_price = @selling_price,
                            vat_amount = @vat_amount,
                            net_price = @net_price,
                            net_profit = @net_profit,
                            gross_profit = @gross_profit,
                            profit_percent = @profit_percent
                        WHERE pricing_id = @pricing_id";
                con.Execute(sql, servicePrice);
            }
        }
        public void DeleteServicePrice(int id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = "DELETE FROM tbl_service_price WHERE pricing_id = @id";
                con.Execute(sql, new { id = id});
            }
        }
    }
}
