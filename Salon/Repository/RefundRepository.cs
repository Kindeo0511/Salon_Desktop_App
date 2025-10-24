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
    public class RefundRepository : IRefund
    {
        public IEnumerable<RefundModel> SelectedServices(int appointment_id) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT 
                    sn.serviceName AS Services,
                    MAX(spr.selling_price) AS selling_price
                FROM tbl_appointment a
                LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
                LEFT JOIN tbl_servicesname sn ON aps.serviceName_id = sn.serviceName_id
                LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
                LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
                WHERE a.appointment_id = @appointment_id
                GROUP BY sn.serviceName;";

                return con.Query<RefundModel>(sql, new { appointment_id}).ToList();
            }
        }

        public IEnumerable<RefundModel> Refunds() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT 
                        sn.serviceName AS Service_Name,
                        spr.selling_price AS Original_Price,
                        r.refund_amount,
                        r.refund_method,
                        r.refund_reason,
                        r.refund_timestamp,
                        r.refunded_by
                    FROM tbl_refund r
                    LEFT JOIN tbl_appointment a ON r.appointment_id = a.appointment_id
                    LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
                    LEFT JOIN tbl_servicesname sn ON aps.serviceName_id = sn.serviceName_id
                    LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
                    LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
                    GROUP BY a.appointment_id
                    ";
                return con.Query<RefundModel>(sql).ToList();
            }
        }

        public async Task<IEnumerable<RefundModel>> RefundsAsync() 
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                        sn.serviceName AS Service_Name,
                        spr.selling_price AS Original_Price,
                        r.refund_amount,
                        r.refund_method,
                        r.refund_reason,
                        r.refund_timestamp,
                        r.refunded_by
                    FROM tbl_refund r
                    LEFT JOIN tbl_appointment a ON r.appointment_id = a.appointment_id
                    LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
                    LEFT JOIN tbl_servicesname sn ON aps.serviceName_id = sn.serviceName_id
                    LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
                    LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
                    GROUP BY a.appointment_id
                    ";
                var result = await con.QueryAsync<RefundModel>(sql);

                return result.ToList();
            }
        }
        public IEnumerable<RefundModel> Refunds(DateTime start, DateTime end)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                        sn.serviceName AS Service_Name,
                        spr.selling_price AS Original_Price,
                        r.refund_amount,
                        r.refund_method,
                        r.refund_reason,
                        r.refund_timestamp,
                        r.refunded_by
                    FROM tbl_refund r
                    LEFT JOIN tbl_appointment a ON r.appointment_id = a.appointment_id
                    LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
                    LEFT JOIN tbl_servicesname sn ON aps.serviceName_id = sn.serviceName_id
                    LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
                    LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
                    WHERE r.refund_timestamp BETWEEN @start AND @end
                    GROUP BY a.appointment_id
                    ";
                return con.Query<RefundModel>(sql, new { start, end}).ToList();
            }
        }

        public async Task<IEnumerable<RefundModel>> RefundsAsync(DateTime start, DateTime end) 
        {

            using (var con = Database.GetConnection())
            {
                var sql = @"SELECT 
                        sn.serviceName AS Service_Name,
                        spr.selling_price AS Original_Price,
                        r.refund_amount,
                        r.refund_method,
                        r.refund_reason,
                        r.refund_timestamp,
                        r.refunded_by
                    FROM tbl_refund r
                    LEFT JOIN tbl_appointment a ON r.appointment_id = a.appointment_id
                    LEFT JOIN tbl_appointment_services aps ON a.appointment_id = aps.appointment_id
                    LEFT JOIN tbl_servicesname sn ON aps.serviceName_id = sn.serviceName_id
                    LEFT JOIN tbl_service_product spd ON spd.service_id = sn.serviceName_id
                    LEFT JOIN tbl_service_price spr ON spr.service_product_id = spd.service_product_id
                    WHERE r.refund_timestamp BETWEEN @start AND @end
                    GROUP BY a.appointment_id
                    ";
                var result = await con.QueryAsync<RefundModel>(sql, new { start, end });

                return result.ToList();
            }
        }

        public void Add(RefundModel model) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"INSERT INTO tbl_refund (transaction_id, appointment_id, refund_amount, refund_method, refund_reason, refunded_by, refund_timestamp)
                            VALUES (@transaction_id, @appointment_id, @refund_amount, @refund_method, @refund_reason, @refunded_by, @refund_timestamp)";
                con.Execute(sql, model);
            }
        }
    }
}
