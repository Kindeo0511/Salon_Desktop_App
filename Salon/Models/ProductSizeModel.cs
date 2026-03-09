using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class ProductSizeModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _product_size_id;
        public int product_size_id
        {
            get => _product_size_id;
            set { _product_size_id = value; OnPropertyChanged(nameof(product_size_id)); }
        }

        private int _product_id;
        public int product_id
        {
            get => _product_id;
            set { _product_id = value; OnPropertyChanged(nameof(product_id)); }
        }

        private string _product_name;
        public string product_name
        {
            get => _product_name;
            set { _product_name = value; OnPropertyChanged(nameof(product_name)); }
        }

        private string _size_label;
        public string size_label
        {
            get => _size_label;
            set { _size_label = value; OnPropertyChanged(nameof(size_label)); }
        }

        private int _content;
        public int content
        {
            get => _content;
            set { _content = value; OnPropertyChanged(nameof(content)); }
        }

        private decimal _selling_price;
        public decimal selling_price
        {
            get => _selling_price;
            set { _selling_price = value; OnPropertyChanged(nameof(selling_price)); }
        }

        private decimal _cost_price;
        public decimal cost_price
        {
            get => _cost_price;
            set { _cost_price = value; OnPropertyChanged(nameof(cost_price)); }
        }

        private int _is_deleted;
        public int is_deleted
        {
            get => _is_deleted;
            set { _is_deleted = value; OnPropertyChanged(nameof(is_deleted)); }
        }
    
    }
}
