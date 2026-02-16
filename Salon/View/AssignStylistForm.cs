using MaterialSkin.Controls;
using Salon.Controller;
using Salon.Repository;
using Salon.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Salon.View
{
    public partial class AssignStylistForm : MaterialForm
    {
        public AssignStylistForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void LoadStylist(int id)
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            var stylist = controller.GetStylistSpecialistById(id);

            cmb_stylist.DataSource = null;
            cmb_stylist.ValueMember = "stylist_id";
            cmb_stylist.DisplayMember = "FullName";

            cmb_stylist.DataSource = stylist;
            cmb_stylist.SelectedIndex = -1;
        }
    }
}
