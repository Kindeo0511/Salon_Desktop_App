using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Util
{
    public partial class PaginationControl : UserControl
    {
        public event EventHandler<int> PageChanged;
        public int CurrentPage { get; private set; } = 1;
        public int TotalPages { get; private set; } = 1;
     
        public PaginationControl()
        {
            InitializeComponent();
        }

        public void SetTotalPages(int total) 
        {
            TotalPages = Math.Max(1, total);
         
            UpdateUI();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
            OnPageChanged();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1) 
            {
                CurrentPage-- ;
                OnPageChanged();
            }
           
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPages)
            {
                CurrentPage++;
                OnPageChanged();
            }

        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            CurrentPage = TotalPages;
            OnPageChanged();
        }
        private void OnPageChanged() 
        { 
            UpdateUI();
            PageChanged?.Invoke(this, CurrentPage);
        }
        private void UpdateUI()
        {
            lbl_current_pages.Text = $"{CurrentPage} / {TotalPages}";
            btn_first.Enabled = btn_prev.Enabled = CurrentPage > 1;
            btn_next.Enabled = btn_last.Enabled = CurrentPage < TotalPages;
        }
    }
}
