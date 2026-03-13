using MaterialSkin.Controls;
using Salon.Controller;
using Salon.Models;
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
using System.Windows.Input;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Salon.View
{
    public partial class StylistForm : MaterialForm
    {
        private readonly MainForm _mainForm;
        private StylistModel _stylist;
        private bool _isSaving = false;
        private bool _isUpdating = false;
        public event EventHandler Added;
        public event EventHandler Updated;
        public StylistForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _isSaving = true;
            _mainForm = mainForm;
            dtp_day_of_birth.MaxDate = DateTime.Today;
            dtp_day_of_birth.MinDate = new DateTime(1900, 1, 1);
            LoadServices();
            LoadSpecialists();
            this.AcceptButton = btn_save;

        }
        public StylistForm(MainForm mainForm, StylistModel stylist)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _isUpdating = true;
            _mainForm = mainForm;
            _stylist = stylist;
            dtp_day_of_birth.MaxDate = DateTime.Today;
            dtp_day_of_birth.MinDate = new DateTime(1900, 1, 1);


            if (_stylist != null)
            {
                txt_first_name.Text = _stylist.firstName;
                txt_middle_name.Text = _stylist.middleName;
                txt_last_name.Text = _stylist.lastName;
                dtp_day_of_birth.Value = _stylist.birth_date;
                txt_contact.Text = _stylist.contactNumber;
                txt_email.Text = _stylist.email;
                txt_address.Text = _stylist.address;
            ;

                LoadServices(_stylist.stylist_id);
                LoadSpecialists(_stylist.stylist_id);
                btn_save.Visible = false;
                btn_update.Visible = true;

            }
            else
            {
                btn_save.Visible = true;
                btn_update.Visible = false;
            }

            this.AcceptButton = btn_update;
        }
        public void LoadServices(int stylist_id = 0) 
        {
            var repo = new CategoryRepository();
            var controller = new CategoryController(repo);
            var categories = controller.getAllCategory();

            chk_services.Items.Clear();
            var assignedIds = new List<int>();
            if (stylist_id > 0)
            {
                var stylistRepo = new StylistRepository();
                var stylistController = new StylistController(stylistRepo);
                assignedIds = stylistController.GetAssignedServiceIds(stylist_id);
            }

            foreach (var category in categories)
            {
                // Add service and check it if already assigned
                bool isAssigned = assignedIds.Contains(category.category_id);
                chk_services.Items.Add(category, isAssigned); // ✅ second param = checked or not
            }


        }
        public void LoadSpecialists(int stylist_id = 0) 
        {
            var repo = new SpecialistRepository();
            var controller = new SpecialistController(repo);
            var specialists = controller.GetAllSpecialists();

            int specialist_id = controller.GetSpecialistIdByStylistId(stylist_id);

        

            cmb_specialist.DisplayMember = "name";
            cmb_specialist.ValueMember = "specialist_id";


            cmb_specialist.DataSource = specialists;
          

          
            if (specialist_id > 0)
                cmb_specialist.SelectedValue = specialist_id; // ← preselect
            else
                cmb_specialist.SelectedIndex = -1; // ← nothing selected for Add




        }
        private void SaveSpecialists(int stylist_id)
        {
            var specialist_repo = new Stylist_Specialist_Repository();
            var specialist_controller = new Stylist_specialist_Controller(specialist_repo);

            int specialist_id = Convert.ToInt32(cmb_specialist.SelectedValue);

            if (_isSaving)
            {
            
                
                 specialist_controller.CreateStylistSpecialist(specialist_id, stylist_id);
                

                //foreach (var item in chk_services.CheckedItems)
                //{
                //    var specialist = (SpecialistModel)item;
                //    if (specialist != null)
                //    {
                //        specialist_controller.CreateStylistSpecialist(specialist.specialist_id, stylist_id);
                //    }

                //}
            }
            else if (_isUpdating) 
            {
              
             specialist_controller.UpdateStylistSpecialist(specialist_id, stylist_id);
                 
            }
               
           
        }

        private bool HasStylistChanges()
        {
            bool hasChanges = txt_first_name.Text != _stylist.firstName
                || txt_middle_name.Text != _stylist.middleName
                || txt_last_name.Text != _stylist.lastName
                || dtp_day_of_birth.Value != _stylist.birth_date
                || txt_contact.Text != _stylist.contactNumber
                || txt_email.Text != _stylist.email
                || txt_address.Text != _stylist.address
                || cmb_specialist.Text != _stylist.specialist;

            // Current checked services from CheckedListBox
            var currentServices = chk_services.CheckedItems
                .Cast<CategoryModel>()
                .Select(s => s.category_id)
                .ToHashSet();

            // ✅ Get original assigned service IDs using the correct method
            var stylistRepo = new StylistRepository();
            var stylistController = new StylistController(stylistRepo);
            var originalServices = stylistController
                .GetAssignedServiceIds(_stylist.stylist_id)
                .ToHashSet();

            // ✅ Compare both sets of service IDs
            if (!currentServices.SetEquals(originalServices))
                hasChanges = true;

            return hasChanges;
        }
        private int SaveStylist() 
        {
            var repo = new StylistRepository();
            var stylistController = new Controller.StylistController(repo);
            var stylist = new StylistModel 
            {
                firstName = txt_first_name.Text.Trim(),
                middleName = txt_middle_name.Text.Trim(),
                lastName = txt_last_name.Text.Trim(),
                birth_date = dtp_day_of_birth.Value,
                contactNumber = txt_contact.Text.Trim(),
                email = txt_email.Text.Trim(),
                address = txt_address.Text.Trim(),
     
                
                };
            int id = stylistController.Add(stylist);

            SaveSpecialists(id);
            AssignStylistToService(id);

           return id;
        }

        private bool UpdateStylist()
        {
            if (_stylist == null) return false;

            
            _stylist.firstName = txt_first_name.Text.Trim();
            _stylist.middleName = txt_middle_name.Text.Trim();
            _stylist.lastName = txt_last_name.Text.Trim();
            _stylist.birth_date = dtp_day_of_birth.Value;
            _stylist.contactNumber = txt_contact.Text.Trim();
            _stylist.email = txt_email.Text.Trim();
            _stylist.address = txt_address.Text.Trim();


            var repo = new StylistRepository();
            var stylistController = new Controller.StylistController(repo);
            SaveSpecialists(_stylist.stylist_id);
            AssignStylistToService(_stylist.stylist_id);
            return stylistController.Update(_stylist);
            
            
        }
        private async void RestoreStylist(int stylist_id) 
        {
            var _repo = new StylistRepository();
            var controller = new StylistController(_repo);
            bool is_restored = controller.restoreStylist(stylist_id);
            if (is_restored)
            {
                Added?.Invoke(this, EventArgs.Empty);
                _mainForm.DeleteDeletedRecord(stylist_id);
                MessageBox.Show("Stylist restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await  _mainForm.RefreshStylistAsync(1,25);
                this.Close();
            }



          
            }
        private int StylistIsDeactivated(string email) 
        {
            var _repo = new StylistRepository();
            var userController = new StylistController(_repo);
            int stylist_id = userController.GetEmail(txt_email.Text.Trim());

            return stylist_id;
            
            

        }
        private void IsAccountExists()
        {
       
     
                if (_isSaving)
                {
                 

                    if (SaveStylist() > 0)
                    {
                                            
                        Added?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show("Stylist added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _mainForm.LoadStylistTrackPanel();
               

                    }
                    else
                    {
                        MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_isUpdating)
                {
                    if (UpdateStylist())
                    {
                        Updated?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show("Stylist updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = txt_first_name.Text + " " + txt_last_name.Text;
                        Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Stylist", $"Created stylist {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        _mainForm.LoadStylistTrackPanel();
             
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            

        }
        private async  void btn_save_Click(object sender, EventArgs e)
        {


            // Run validation on UI thread
            if (!IsValid()) return;

            IsAccountExists();



            await _mainForm.RefreshStylistAsync(1, 25);

            this.Close();

        }

        private async void btn_update_Click(object sender, EventArgs e)
        {


            if (!IsValid()) return;
            if (!HasStylistChanges())
            {
                MessageBox.Show("No changes detected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;

            }

            IsAccountExists();



            var fullName = txt_first_name.Text + " " + txt_last_name.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Stylist", $"Updated stylist {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            await _mainForm.RefreshStylistAsync(1, 25);

            this.Close();
        }

        private bool IsValid()
        {
            var _repo = new StylistRepository();
            var userController = new StylistController(_repo);

            DateTime birthDate = dtp_day_of_birth.Value;
            int age = DateTime.Now.Year - birthDate.Year;
            int excludeId = _stylist?.stylist_id ?? 0;

            bool validated = true;
            int deactivated_stylist_id = StylistIsDeactivated(txt_email.Text);
            // First Name
            if (string.IsNullOrWhiteSpace(txt_first_name.Text))
            {
                errorProvider1.SetError(txt_first_name, "First name is required.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_first_name, "");
            }

    
          

            // Last Name
            if (string.IsNullOrWhiteSpace(txt_last_name.Text))
            {
                errorProvider1.SetError(txt_last_name, "Last name is required.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_last_name, "");
            }

            // Birth Date (basic check: not in the future)
            if (dtp_day_of_birth.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtp_day_of_birth, "Birth date cannot be in the future.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(dtp_day_of_birth, "");
            }

            string contact = txt_contact.Text.Trim();

            // Contact Number (numeric check)
            if (string.IsNullOrWhiteSpace(txt_contact.Text))
            {
                errorProvider1.SetError(txt_contact, "Valid contact number is required.");
                validated = false;
            }
            else if (!contact.All(char.IsDigit))
            {
                errorProvider1.SetError(txt_contact, "Contact number must contain digits only.");
                validated = false;
            }
            else if (!contact.StartsWith("09"))
            {
                errorProvider1.SetError(txt_contact, "Contact number must start with 09.");
                validated = false;
            }

            else if (!Validator.IsStylistPhoneExists(txt_contact, errorProvider1, "Contact number already exists.", excludeId))
            {
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_contact, "");
            }

            // Email (basic format check)
            if (string.IsNullOrWhiteSpace(txt_email.Text) || !txt_email.Text.Contains("@"))
            {
                errorProvider1.SetError(txt_email, "Valid email is required.");
                validated = false;
            }
            else if (deactivated_stylist_id > 0) 
            {
                // check deactivated FIRST before checking if username exists
                var result = MessageBox.Show("This stylist exists but is deleted. Do you want to restore it?",
                                "Restore Account",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    RestoreStylist(deactivated_stylist_id);
                }
                validated = false;
            }
            else if (!Validator.IsStylistEmailExists(txt_email, errorProvider1, "Email already exists.", excludeId))
            {
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_email, "");
            }

            // Address
            if (string.IsNullOrWhiteSpace(txt_address.Text))
            {
                errorProvider1.SetError(txt_address, "Address is required.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_address, "");
            }

            if (string.IsNullOrEmpty(cmb_specialist.Text)) 
            {
                errorProvider1.SetError(cmb_specialist, "Specialist is required.");
                validated = false;
            }

            // Services (CheckedListBox must have at least one checked item)
            if (chk_services.CheckedItems.Count == 0)
            {
                errorProvider1.SetError(chk_services, "Select at least one specialist.");
                validated = false;
            }
            else errorProvider1.SetError(chk_services, "");



            //Services(CheckedListBox must have at least one checked item)
            if (chk_services.CheckedItems.Count == 0)
            {
                errorProvider1.SetError(chk_services, "Select at least one service.");
                validated = false;
            }
            else errorProvider1.SetError(chk_services, "");

            //// REQUIRED AND MIN LENGTH FIELD
            //if (!Validator.IsRequiredTextField(txt_first_name, errorProvider1, "First name is required."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.IsMinimumLength(txt_first_name, errorProvider1, "First name must be at least 3 characters.", 3))
            //{
            //    validated = false;
            //}
            //// Allows letters, spaces, hyphens, apostrophes, accented characters
            //else if (!Validator.Pattern(txt_first_name, errorProvider1, @"^[A-Za-zÀ-ÿ'’\- ]+$", "First Name contains invalid characters."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.DisallowSpaces(txt_first_name, errorProvider1, "No Space Allowed"))
            //{
            //    validated = false;
            //}


            //if (!string.IsNullOrWhiteSpace(txt_middle_name.Text))
            //{
            //    if (!Validator.IsMinimumLength(txt_middle_name, errorProvider1, "Middle name must be at least 3 characters.", 3))
            //    {
            //        validated = false;
            //    }
            //    else if (!Validator.Pattern(txt_middle_name, errorProvider1, @"^[A-Za-z]+$", "Middle name should only contain letters."))
            //    {
            //        validated = false;
            //    }
            //    else if (!Validator.DisallowSpaces(txt_middle_name, errorProvider1, "No space allowed in middle name."))
            //    {
            //        validated = false;
            //    }
            //}


            //if (!Validator.IsRequiredTextField(txt_last_name, errorProvider1, "Last name is required."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.IsMinimumLength(txt_last_name, errorProvider1, "Last name must be at least 3 characters.", 3))
            //{
            //    validated = false;
            //}
            //else if (!Validator.Pattern(txt_last_name, errorProvider1, @"^[A-Za-z]+$", "Last name should only contain letters."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.DisallowSpaces(txt_last_name, errorProvider1, "No Space Allowed"))
            //{
            //    validated = false;
            //}

            //if (!Validator.IsRequired(txt_email, errorProvider1, "Email is required."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.IsValidEmail(txt_email, errorProvider1))
            //{
            //    validated = false;
            //}
            //else if (txt_email.Text.Count(c => c == '@') != 1)
            //{
            //    errorProvider1.SetError(txt_email, "Email must contain exactly one '@' symbol.");
            //    validated = false;
            //}
            //else if (!Validator.Pattern(
            //       txt_email,
            //       errorProvider1,
            //       @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            //       "Please enter a valid email address."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.DisallowSpaces(txt_email, errorProvider1, "No Space Allowed"))
            //{
            //    validated = false;
            //}




            //if (!Validator.IsRequiredTextField(txt_contact, errorProvider1, "Contact number is required."))
            //{
            //    validated = false;
            //}
            //else if (txt_contact.Text.Length != 11)
            //{
            //    errorProvider1.SetError(txt_contact, "Contact number must be exactly 11 digits.");
            //    validated = false;
            //}
            //else if (!txt_contact.Text.StartsWith("09"))
            //{
            //    errorProvider1.SetError(txt_contact, "Contact number should start with '09'.");
            //    validated = false;
            //}

            //else if (!Validator.IsValidPhone(txt_contact, errorProvider1))
            //{
            //    validated = false;
            //}



            //if (!Validator.IsAddressRequiredField(txt_address, errorProvider1, "Address is required."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.IsMinimumLength(txt_address, errorProvider1, "Address must be at least 10 characters.", 10))
            //{
            //    validated = false;
            //}
            //else if (!Validator.MultiLinePattern(txt_address, errorProvider1, @"^[A-Za-z0-9\s.,#-]+$", "Address contains invalid characters."))
            //{
            //    validated = false;
            //}





            if (birthDate > DateTime.Now.AddYears(-age))
            {
                age--;
            }

            if (age < 18)
            {
                errorProvider1.SetError(dtp_day_of_birth, "Must be 18+ years old.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(dtp_day_of_birth, "");
            }


            return validated;



        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StylistForm_Load(object sender, EventArgs e)
        {
   
       
        }

        private void txt_first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, etc.)
            if (char.IsControl(c))
                return;

            // Block space if it's the first character
            if (char.IsWhiteSpace(c) && txt != null && txt.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }

            // Allow only letters and spaces
            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
            {
                e.Handled = true;
            }
        }

        private void txt_middle_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, etc.)
            if (char.IsControl(c))
                return;

            // Block space if it's the first character
            if (char.IsWhiteSpace(c) && txt != null && txt.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }

            // Allow only letters and spaces
            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
            {
                e.Handled = true;
            }
        }

        private void txt_last_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, etc.)
            if (char.IsControl(c))
                return;

            // Block space if it's the first character
            if (char.IsWhiteSpace(c) && txt != null && txt.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }

            // Allow only letters and spaces
            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
            {
                e.Handled = true;
            }
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (char.IsControl(c))
                return;

            if (!char.IsDigit(c))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string allowed = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-";

            if (!char.IsControl(c) && !allowed.Contains(c))
                e.Handled = true;
        }

        private void txt_daily_wage_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Allow digits
            if (char.IsDigit(c))
                return;

            // Allow one decimal point, but not as the first character
            if (c == '.' && txt != null)
            {
                if (!txt.Text.Contains(".") && txt.Text.Length > 0)
                    return;

                e.Handled = true; // Block if already has a decimal or it's first character
                return;
            }

            // Block everything else
            e.Handled = true;
        }

        private void txt_first_name_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_middle_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_middle_name_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_last_name_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }



        private bool AssignStylistToService(int stylist_id)
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);

            bool assigned = false;

            if (_isSaving)
            {
                foreach (var category in chk_services.CheckedItems)
                {
                    var model = category as CategoryModel;
                    if (model != null)
                    {


                        controller.AssignService(stylist_id, model.category_id);
                        assigned = true;

                    }
                }


            }
            else if (_isUpdating)
            {
                // Get all existing assignments for this service
                var existingAssignments = controller.GetAssignedServiceIds(stylist_id).ToHashSet();
      
                foreach (var category in chk_services.Items)
                {
                    var model = category as CategoryModel;
                    if (model == null) continue;

                    bool isChecked = chk_services.CheckedItems.Contains(category);

                    if (isChecked && !existingAssignments.Contains(model.category_id))
                    {
                        
                       controller.AssignService(stylist_id, model.category_id);
                   
                        assigned = true;

                    }
                    else if(!isChecked && existingAssignments.Contains(model.category_id))
                    {
                       
                        controller.UnassignService(stylist_id, model.category_id);
                        assigned = true;

                    }
                }

             
            }

            return assigned;

        }
    }
}
