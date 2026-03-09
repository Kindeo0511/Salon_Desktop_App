using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class ServiceProductUsageModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _service_product_id;
        public int service_product_id
        {
            get => _service_product_id;
            set { _service_product_id = value; OnPropertyChanged(nameof(service_product_id)); }
        }

        private int _service_id;
        public int service_id
        {
            get => _service_id;
            set { _service_id = value; OnPropertyChanged(nameof(service_id)); }
        }

        private string _brand;
        public string brand
        {
            get => _brand;
            set { _brand = value; OnPropertyChanged(nameof(brand)); }
        }

        private int _product_id;
        public int product_id
        {
            get => _product_id;
            set { _product_id = value; OnPropertyChanged(nameof(product_id)); }
        }

        private int _product_size_id;
        public int product_size_id
        {
            get => _product_size_id;
            set { _product_size_id = value; OnPropertyChanged(nameof(product_size_id)); }
        }

        private string _size_label;
        public string size_label
        {
            get => _size_label;
            set { _size_label = value; OnPropertyChanged(nameof(size_label)); }
        }

        private string _serviceName;
        public string serviceName
        {
            get => _serviceName;
            set { _serviceName = value; OnPropertyChanged(nameof(serviceName)); }
        }

        private string _product_name;
        public string product_name
        {
            get => _product_name;
            set { _product_name = value; OnPropertyChanged(nameof(product_name)); }
        }

        private string _unit_type;
        public string unit_type
        {
            get => _unit_type;
            set { _unit_type = value; OnPropertyChanged(nameof(unit_type)); }
        }

        private double _unit_per_volume;
        public double unit_per_volume
        {
            get => _unit_per_volume;
            set { _unit_per_volume = value; OnPropertyChanged(nameof(unit_per_volume)); }
        }

        private double _total_usage_amount;
        public double total_usage_amount
        {
            get => _total_usage_amount;
            set { _total_usage_amount = value; OnPropertyChanged(nameof(total_usage_amount)); }
        }

        private int _qty_required;
        public int qty_required
        {
            get => _qty_required;
            set { _qty_required = value; OnPropertyChanged(nameof(qty_required)); }
        }

        private string _usage_type;
        public string usage_type
        {
            get => _usage_type;
            set { _usage_type = value; OnPropertyChanged(nameof(usage_type)); }
        }

        private decimal _total_cost;
        public decimal total_cost
        {
            get => _total_cost;
            set { _total_cost = value; OnPropertyChanged(nameof(total_cost)); }
        }

        private int _duration;
        public int duration
        {
            get => _duration;
            set { _duration = value; OnPropertyChanged(nameof(duration)); }
        }

        private int _is_deleted;
        public int is_deleted
        {
            get => _is_deleted;
            set { _is_deleted = value; OnPropertyChanged(nameof(is_deleted)); }
        }
    }
}