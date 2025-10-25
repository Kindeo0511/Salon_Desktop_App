using MaterialSkin.Controls;
using Salon.Controller;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Util
{
    public static class Validator
    {
        public static bool Pattern(MaterialTextBox tb, ErrorProvider ep, string pattern, string message)
        {
            string input = tb.Text.Trim();

            if (!Regex.IsMatch(input, pattern))
            {
                ep.SetError(tb, message);
                return false;
            }

            ep.SetError(tb, "");
            return true;
        }
        public static bool MultiLinePattern(MaterialMultiLineTextBox2 tb, ErrorProvider ep, string pattern, string message)
        {
            string input = tb.Text.Trim();

            if (!Regex.IsMatch(input, pattern))
            {
                ep.SetError(tb, message);
                return false;
            }

            ep.SetError(tb, "");
            return true;
        }
        public static bool IsMaximumLength(Control control, ErrorProvider ep, string message)
        {
            if (control is TextBox tb)
            {
                if (tb.TextLength > 50)
                {
                    ep.SetError(tb, message);
                    return false;
                }
                ep.SetError(control, "");
                return true;
            }



            ep.SetError(control, "");
            return true;
        }
        public static bool DisallowSpaces(MaterialTextBox tb, ErrorProvider ep, string message)
        {
            string rawText = tb.Text;

            if (rawText.Contains(" "))
            {
                ep.SetError(tb, message);
                return false;
            }

            tb.Text = rawText.Trim(); // Optional: clean up after validation
            ep.SetError(tb, "");
            return true;
        }

        public static bool IntOnly(MaterialTextBox tb, ErrorProvider ep, string requiredMessage, string spaceMessage, string invalidMessage, string invalidValue)
        {
            string rawText = tb.Text?.Trim();

            if (string.IsNullOrWhiteSpace(rawText))
            {
                ep.SetError(tb, requiredMessage);
                return false;
            }

            if (rawText.Contains(" "))
            {
                ep.SetError(tb, spaceMessage);
                return false;
            }

            if (!int.TryParse(rawText, out _))
            {
                ep.SetError(tb, invalidMessage);
                return false;
            }
            if (int.TryParse(rawText, out int value))
            {
                if (value <= 0)
                {
                    ep.SetError(tb, invalidValue);
                    return false;
                }
            }

            ep.SetError(tb, "");
            return true;
        }

        public static bool DecimalOnly(MaterialTextBox tb, ErrorProvider ep, string requiredMessage, string spaceMessage, string invalidMessage, string invalidValue)
        {
            string rawText = tb.Text?.Trim();

            if (string.IsNullOrWhiteSpace(rawText))
            { 
                ep.SetError(tb, requiredMessage);
                return false;
            }

            if (rawText.Contains(" "))
            {
                ep.SetError(tb, spaceMessage);
                return false;
            }

            if (!decimal.TryParse(rawText, out decimal value))
            {
                ep.SetError(tb, invalidMessage);
                return false;
            }

            // Check for more than 2 decimal places
            if (decimal.Round(value, 2) != value)
            {
                ep.SetError(tb, "Price must have no more than 2 decimal places.");
                return false;
            }

            if (value < 1.00m)
            {
                ep.SetError(tb, invalidValue);
                return false;
            }

            ep.SetError(tb, "");
            return true;
        }



        public static bool IsMinimumLength(Control control, ErrorProvider ep, string message, int size)
        {
            if (control is MaterialTextBox tb)
            {
       
                if (tb.TextLength < size)
                {
                    ep.SetError(tb, message);
                    return false;
                }
                ep.SetError(control, "");
                return true;
            }


            if (control is MaterialMultiLineTextBox2 mtb)
            {
                if (mtb.TextLength > 255)
                {
                    ep.SetError(mtb, message);
                    return false;
                }
                ep.SetError(control, "");
                return true;
            }


            ep.SetError(control, "");
            return true;
        }
        public static bool IsRequiredTextField(MaterialTextBox tb, ErrorProvider ep, string message)
        {
            string input = tb.Text?.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                ep.SetError(tb, message);
                return false;
            }

            ep.SetError(tb, "");
            return true;
        }
        public static bool IsRequiredTextField(MaterialTextBox2 tb, ErrorProvider ep, string message)
        {
            string input = tb.Text?.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                ep.SetError(tb, message);
                return false;
            }

            ep.SetError(tb, "");
            return true;
        }
        public static bool IsComboBoxSelected(MaterialComboBox cmb, ErrorProvider ep, string message)
        {
            if (cmb.SelectedIndex < 0)
            {
                ep.SetError(cmb, message);
                return false;
            }

            ep.SetError(cmb, "");
            return true;
        }

        public static bool IsAddressRequiredField(MaterialMultiLineTextBox2 tb, ErrorProvider ep, string message)
        {
            string input = tb.Text?.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                ep.SetError(tb, message);
                return false;
            }

            ep.SetError(tb, "");
            return true;
        }



        public static bool IsRequired(Control control, ErrorProvider ep, string message) 
        {
            if (control is NumericUpDown nud)
            {
                if (nud.Value == 0) 
                {
                    ep.SetError(control, message);
                    return false;
                }
            }
            else if (control is TextBox tb)
            {
               
                if (tb.Text == "0.00")
                {
                    ep.SetError(control, message);
                    return false;
                }
            }



            else
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    ep.SetError(control, message);
                    return false;
                }
            }

            ep.SetError(control, "");
            return true;

        }

        public static bool IsValidEmail(Control control, ErrorProvider ep)
        {
            var email = control.Text?.Trim();

            bool valid = !string.IsNullOrEmpty(email) &&
                         Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            ep.SetError(control, valid ? "" : "Invalid email format.");
            return valid;

        }
        public static bool IsValidPhone(Control control, ErrorProvider ep)
        {
            var phone = control.Text;
            bool valid = Regex.IsMatch(phone, @"^\+?\d{7,15}$");
            ep.SetError(control, valid ? "" : "Invalid phone number.");
            return valid;
        }

        public static bool IsTimeSelected(DateTimePicker picker, ErrorProvider ep, string message)
        {
            // Optional: define a default time to compare against
            var defaultTime = DateTime.Today; // or any fallback value

            if (picker.Value.TimeOfDay == defaultTime.TimeOfDay)
            {
                ep.SetError(picker, message);
                return false;
            }

            ep.SetError(picker, "");
            return true;
        }

        // USERS VALIDATION
        public static bool IsUserExists(Control control, ErrorProvider ep, string message, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false; // Let IsRequired handle the error

            var repo = new UserRepository();
            var controller = new UserController(repo);
            if (controller.GetUserExistsAsync(control.Text, id))
            {
                ep.SetError(control, message);
                return false;
            }

            ep.SetError(control, "");
            return true;
        }

        

        public static bool IsEmailExists(Control control, ErrorProvider ep, string message, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new UserRepository();
            var controller = new UserController(repo);
            if (controller.GetUserEmailExistsAsync(control.Text, id))
            {
                ep.SetError(control, message);
                return false;
            }

            ep.SetError(control, "");
            return true;

        }

        public static bool IsPhoneExists(Control control, ErrorProvider ep, string message, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new UserRepository();
            var controller = new UserController(repo);
            if (controller.GetUserNumberExistsAsync(control.Text, id))
            {
                ep.SetError(control, message);
                return false;
            }

            ep.SetError(control, "");
            return true;

        }
        // END OF USERS VALIDATION

        // STYLIST VALIDATION

        public static bool IsStylistEmailExists(Control control, ErrorProvider ep, string message, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            if (controller.GetEmailExists(control.Text, id))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }

        public static bool IsStylistPhoneExists(Control control, ErrorProvider ep, string message, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            if (controller.GetContactExists(control.Text, id))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }

        // END OF STYLIST VALIDATION

        // STYLIST SCHEDULE
        public static bool IsScheduleConflict(MaterialComboBox txt, ErrorProvider ep, string message, int stylist_id, TimeSpan start, TimeSpan end, int id)
        {
            var repo = new StylistSchedulesRepository();
            var controller = new StylistSchedulesController(repo);

            if (controller.GetIsScheduleConflict(stylist_id, txt.Text, start, end, id))
            {
                ep.SetError(txt, message);
                return false;
            }

            ep.SetError(txt, "");
            return true;
        }


        // END OF STYLIST SCHEDULE

        // STYLIST EXCEPTION SCHEDULE


        // not done yet in validation
        public static bool IsExScheduleExists(Control control, ErrorProvider ep, string message, int stylist_id, int id, DateTime date)
        {
            var repo = new ExceptionSchedulesRepository();
            var controller = new ExceptionSchedulesController(repo);

            if (controller.GetIsExceptionScheduleConflict(stylist_id, date, id))
            {
                ep.SetError(control, message);
                return false;
            }

            ep.SetError(control, "");
            return true;
        }


        // not done yet stylist exceptio nvdalition

        // CUSTOMER VALIDATION

        public static bool IsCustomerEmailExists(Control control, ErrorProvider ep, string message, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            if (controller.CheckEmailExists(control.Text, id))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }

        public static bool IsCustomerPhoneExists(Control control, ErrorProvider ep, string message, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            if (controller.CheckContactExists(control.Text, id))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }

        // END CUSTOMER VALIDATION

        // SUPPLIER VALIDATION
        public static bool IsSupplierEExists(Control control, ErrorProvider ep, string message, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new SupplierRepository();
            var controller = new SupplierController(repo);
            if (controller.CheckSupplierExists(control.Text, id))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }

        public static bool IsSupplierEmailExists(Control control, ErrorProvider ep, string message, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;


            var repo = new SupplierRepository();
            var controller = new SupplierController(repo);
            if (controller.CheckEmailExists(control.Text, id))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }

        public static bool IsSupplierPhoneExists(Control control, ErrorProvider ep, string message, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new SupplierRepository();
            var controller = new SupplierController(repo);
            if (controller.CheckContactExists(control.Text, id))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }

        // END OF SUPPLIER

        // CATEGORY VALIDATION
        public static bool IsCategoryExists(Control control, ErrorProvider ep, string message,string type, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new CategoryRepository();
            var controller = new CategoryController(repo);
            if (controller.CheckCategoryExists(control.Text, type, id))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }

        // END OF CATEGORY


        // SUBCATEGORY VALIDATION

        public static bool IsSubCategoryExists(Control control, ErrorProvider ep, string message, int category_id, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new SubCategoryRepository();
            var controller = new SubCategoryController(repo);
            if (controller.CheckSubCategoryExists(control.Text, category_id, id))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }

        // END OF SUBCATEGORY

        // PRODUCT VALIDATION
        public static bool IsProductExists(Control control, ErrorProvider ep, string message, int category_id, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            if (controller.CheckProductExists(control.Text, category_id, id))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }
        // END OF  PRODUCT

        // SERVICE VALIDATION

        public static bool IsServicesExists(Control control, ErrorProvider ep, string message, int scid, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            if (controller.CheckServiceExists(control.Text, scid, id))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }

        // END OF SERVICE

        // SERVICE PRODUCT USAGE VALIDATION
        public static bool IsProductUsageExists(Control control, ErrorProvider ep, string message, int pid,int sid, int excludeId)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            if (controller.ProductUsageExists(pid,sid, excludeId))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }

        // END OF SERVICE PRODUCT USAGE


        // SERVICE PRODUCT PRICE VALIDATION
        public static bool IsProductPriceExists(Control control, ErrorProvider ep, string message, int pid, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new ServicePriceRepository();
            var controller = new ServicePriceController(repo);
            if (controller.CheckServicePriceExists(pid, id))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }

        // END OF SERVICE PRODUCT PRICE


        // DISCOUNT VALIDATION
        public static bool IsDiscountExists(Control control, ErrorProvider ep, string message, string discount_type,string code, decimal rate, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new DiscountRepository();
            var controller = new DiscountController(repo);
            if (controller.CheckDiscountExists(discount_type, code, rate, id))
            {
                ep.SetError(control, message);
                return false;
            }
            ep.SetError(control, "");
            return true;
        }

        // END OF DISCOUNT

        public static bool MinLength(Control control, ErrorProvider ep, int length, string message)
        {

            bool valid = control.Text.Length >= length;
            ep.SetError(control, valid ? "" : message);
            return valid;
        }

        public static bool ValidateSupplierName(string value, Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Supplier name should not be empty.");
                return false;
            }

            if (value.Length < 2)
            {
                errorProvider.SetError(control, "Supplier name should be at least 2 characters long.");
                return false;
            }

            if (value != value.Trim())
            {
                errorProvider.SetError(control, "Supplier name should not start or end with a space.");
                return false;
            }

            // Allows letters, digits, and spaces only
            if (!Regex.IsMatch(value, @"^[A-Za-z0-9 ]+$"))
            {
                errorProvider.SetError(control, "Supplier name should only contain letters, numbers, and spaces.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }

        public static bool ValidateContactNumber(string value, Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Contact number should not be empty.");
                return false;
            }

            if (!Regex.IsMatch(value, @"^09\d{9}$"))
            {
                errorProvider.SetError(control, "Contact number must start with '09' and be exactly 11 digits long.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }


        public static bool ValidateEmail(string value, Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Email address should not be empty.");
                return false;
            }

            if (value.Contains(" "))
            {
                errorProvider.SetError(control, "Email address should not contain spaces.");
                return false;
            }

            if (value.Count(c => c == '@') != 1)
            {
                errorProvider.SetError(control, "Email address must contain exactly one '@' symbol.");
                return false;
            }

            if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider.SetError(control, "Please enter a valid email address.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }

        public static bool ValidateAddress(string value, Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Address should not be empty.");
                return false;
            }

            // Allows letters, digits, space, comma, period, dash, hash
            if (!Regex.IsMatch(value, @"^[A-Za-z0-9\s.,#-]+$"))
            {
                errorProvider.SetError(control, "Address contains invalid characters.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }

        public static bool ValidateCategoryName(string value, Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Category name should not be empty.");
                return false;
            }

            if (value.Length < 2)
            {
                errorProvider.SetError(control, "Category name should be at least 2 characters long.");
                return false;
            }

            if (value != value.Trim())
            {
                errorProvider.SetError(control, "Category name should not start or end with a space.");
                return false;
            }

            // Allows letters, digits, and spaces only
            if (!Regex.IsMatch(value, @"^[A-Za-z0-9 ]+$"))
            {
                errorProvider.SetError(control, "Category name should only contain letters, numbers, and spaces.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }

        public static bool ValidateCategoryType(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedIndex < 0 || string.IsNullOrWhiteSpace(comboBox.Text))
            {
                errorProvider.SetError(comboBox, "Please select a category type.");
                return false;
            }

            errorProvider.SetError(comboBox, "");
            return true;
        }
        public static bool ValidateSubCategoryName(string value, Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Sub-Category name should not be empty.");
                return false;
            }

            if (value.Length < 2)
            {
                errorProvider.SetError(control, "Sub-Category name should be at least 2 characters long.");
                return false;
            }

            if (value != value.Trim())
            {
                errorProvider.SetError(control, "Sub-Category name should not start or end with a space.");
                return false;
            }

            // Allows only letters, digits, and spaces
            if (!Regex.IsMatch(value, @"^[A-Za-z0-9 ]+$"))
            {
                errorProvider.SetError(control, "Sub-Category name should only contain letters, numbers, and spaces.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }
        public static bool ValidateSubCategoryType(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedIndex < 0 || string.IsNullOrWhiteSpace(comboBox.Text))
            {
                errorProvider.SetError(comboBox, "Please select a sub-category type.");
                return false;
            }

            errorProvider.SetError(comboBox, "");
            return true;
        }
        public static bool ValidateProductName(string value, Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Product name should not be empty.");
                return false;
            }

            if (value.Length < 2)
            {
                errorProvider.SetError(control, "Product name should be at least 2 characters long.");
                return false;
            }

            if (value != value.Trim())
            {
                errorProvider.SetError(control, "Product name should not start or end with a space.");
                return false;
            }

            if (!Regex.IsMatch(value, @"^[A-Za-z0-9 ]+$"))
            {
                errorProvider.SetError(control, "Product name should only contain letters, numbers, and spaces.");
                return false;
            }

         

            errorProvider.SetError(control, "");
            return true;
        }
        public static bool ValidateBrandName(string value, Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Brand name should not be empty.");
                return false;
            }

            if (value.Length < 2)
            {
                errorProvider.SetError(control, "Brand name should be at least 2 characters long.");
                return false;
            }

            if (!Regex.IsMatch(value, @"^[A-Za-z0-9 ]+$"))
            {
                errorProvider.SetError(control, "Brand name should only contain letters, numbers, and spaces.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }
        public static bool ValidateProductCategory(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedIndex < 0 || string.IsNullOrWhiteSpace(comboBox.Text))
            {
                errorProvider.SetError(comboBox, "Please select a product category.");
                return false;
            }

            errorProvider.SetError(comboBox, "");
            return true;
        }
        public static bool ValidateUnitType(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedIndex < 0)
            {
                errorProvider.SetError(comboBox, "Please select a unit type.");
                return false;
            }

            errorProvider.SetError(comboBox, "");
            return true;
        }


        public static bool ValidateUnitVolume(string value, Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Unit volume should not be empty.");
                return false;
            }

            if (value.Contains(" "))
            {
                errorProvider.SetError(control, "Unit volume should not contain spaces.");
                return false;
            }

            if (!Regex.IsMatch(value, @"^\d+$"))
            {
                errorProvider.SetError(control, "Please enter a valid numeric value for unit volume.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }
        public static bool ValidateUsageType(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedIndex < 0 || string.IsNullOrWhiteSpace(comboBox.Text))
            {
                errorProvider.SetError(comboBox, "Please select a usage type.");
                return false;
            }

            errorProvider.SetError(comboBox, "");
            return true;
        }
        public static bool ValidateServiceName(string value, Control control, ErrorProvider errorProvider, Func<string, bool> isDuplicateCheck)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Service name should not be empty.");
                return false;
            }

            if (value.Length < 2)
            {
                errorProvider.SetError(control, "Service name should be at least 2 characters long.");
                return false;
            }

            if (value != value.Trim())
            {
                errorProvider.SetError(control, "Service name should not start or end with a space.");
                return false;
            }

            if (!Regex.IsMatch(value, @"^[A-Za-z0-9 ]+$"))
            {
                errorProvider.SetError(control, "Service name should only contain letters, numbers, and spaces.");
                return false;
            }

            if (isDuplicateCheck(value))
            {
                errorProvider.SetError(control, "Service name already exists. Please enter a different name.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }
        public static bool ValidateServiceStatus(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedIndex < 0 || string.IsNullOrWhiteSpace(comboBox.Text))
            {
                errorProvider.SetError(comboBox, "Please select a service status.");
                return false;
            }

            errorProvider.SetError(comboBox, "");
            return true;
        }
        public static bool ValidateServiceCategory(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedIndex < 0 || string.IsNullOrWhiteSpace(comboBox.Text))
            {
                errorProvider.SetError(comboBox, "Please select a category for this service.");
                return false;
            }

            errorProvider.SetError(comboBox, "");
            return true;
        }
        public static bool ValidateDuration(NumericUpDown control, ErrorProvider errorProvider)
        {
            int value = (int)control.Value;

            if (value <= 0)
            {
                errorProvider.SetError(control, "Duration should be greater than 0.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }

        public static bool ValidateUsageAmount(string value, Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Usage amount should not be empty.");
                return false;
            }

            if (value.Contains(" "))
            {
                errorProvider.SetError(control, "Usage amount should not contain spaces.");
                return false;
            }

            // Accepts whole numbers or decimals (e.g., 5, 5.25)
            if (!Regex.IsMatch(value, @"^\d+(\.\d+)?$"))
            {
                errorProvider.SetError(control, "Usage amount should only contain numbers.");
                return false;
            }

            if (decimal.TryParse(value, out decimal amount))
            {
                if (amount <= 0)
                {
                    errorProvider.SetError(control, "Usage amount should be greater than 0.");
                    return false;
                }
            }
            else
            {
                errorProvider.SetError(control, "Please enter a valid usage amount.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }
        public static bool ValidateUnitPerVolume(string value, Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Unit per volume should not be empty.");
                return false;
            }

            // Must be a number followed immediately by letters (e.g., 5ml, 10g)
            if (!Regex.IsMatch(value, @"^[0-9]+[A-Za-z]+$"))
            {
                errorProvider.SetError(control, "Unit per volume should not contain special symbols or spaces between the number and unit.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }
        public static bool ValidateDeliveredDate(DateTimePicker control, ErrorProvider errorProvider)
        {
            DateTime selected = control.Value.Date;
            DateTime today = DateTime.Today;

            if (selected == DateTime.MinValue)
            {
                errorProvider.SetError(control, "Delivered date should not be empty.");
                return false;
            }

            if (selected > today)
            {
                errorProvider.SetError(control, "Delivered date cannot be a future date.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }

        public static bool ValidateExpirationDate(DateTimePicker expiration, DateTimePicker delivered, ErrorProvider errorProvider)
        {
            DateTime exp = expiration.Value.Date;
            DateTime del = delivered.Value.Date;

            if (exp == DateTime.MinValue)
            {
                errorProvider.SetError(expiration, "Expiration date should not be empty.");
                return false;
            }

            if (exp < del)
            {
                errorProvider.SetError(expiration, "Expiration date should not be earlier than the delivery date.");
                return false;
            }

            errorProvider.SetError(expiration, "");
            return true;
        }
        public static bool ValidateSupplier(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedIndex < 0 || string.IsNullOrWhiteSpace(comboBox.Text))
            {
                errorProvider.SetError(comboBox, "Supplier is required before adding an item.");
                return false;
            }

            errorProvider.SetError(comboBox, "");
            return true;
        }
        public static bool ValidateProduct(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedIndex < 0 || string.IsNullOrWhiteSpace(comboBox.Text))
            {
                errorProvider.SetError(comboBox, "Product selection is required.");
                return false;
            }

            errorProvider.SetError(comboBox, "");
            return true;
        }
        public static bool ValidateInvoice(string value, Control control, ErrorProvider errorProvider, Func<string, bool> isDuplicateCheck)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Invoice should not be empty.");
                return false;
            }

            if (!Regex.IsMatch(value, @"^[A-Za-z0-9-]+$"))
            {
                errorProvider.SetError(control, "Invoice should only contain letters, numbers, and hyphens.");
                return false;
            }

            if (isDuplicateCheck(value))
            {
                errorProvider.SetError(control, "Invoice number already exists. Please enter a different one.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }

        public static bool ValidateQuantity(string value, Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, "Quantity should not be empty.");
                return false;
            }

            if (!Regex.IsMatch(value, @"^[1-9]\d*$"))
            {
                errorProvider.SetError(control, "Quantity must be a positive whole number.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }

        public static bool ValidateDecimalValue(string value, Control control, ErrorProvider errorProvider, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorProvider.SetError(control, $"{fieldName} should not be empty.");
                return false;
            }

            if (value.Contains(" ") || !Regex.IsMatch(value, @"^\d+(\.\d+)?$"))
            {
                errorProvider.SetError(control, $"{fieldName} should only contain numbers and decimals.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }
        public static bool ValidateNotes(string value, Control control, ErrorProvider errorProvider)
        {
            if (value.Length > 255)
            {
                errorProvider.SetError(control, "Notes should not exceed 255 characters.");
                return false;
            }

            if (!Regex.IsMatch(value, @"^[A-Za-z0-9\s.,-]*$"))
            {
                errorProvider.SetError(control, "Notes should not contain special symbols.");
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }
        public static bool ValidateSellingPrice(string value, Control control, ErrorProvider errorProvider)
        {
            return ValidateDecimalValue(value, control, errorProvider, "Selling price");
        }
        public static bool ValidateVAT(string vatText, Control control, ErrorProvider ep)
        {
            vatText = vatText.Trim();

            if (string.IsNullOrWhiteSpace(vatText))
            {
                ep.SetError(control, "VAT is required.");
                return false;
            }

            // Ensure it's a valid integer
            if (!int.TryParse(vatText, out int vat))
            {
                ep.SetError(control, "VAT must be a whole number. Example: 12 for 12%.");
                return false;
            }

            // Check range
            if (vat < 0 || vat > 100)
            {
                ep.SetError(control, "VAT must be between 0 and 100.");
                return false;
            }

            ep.SetError(control, "");
            return true;
        }

        public static bool ValidateDiscount(string discountText, Control control, ErrorProvider ep)
        {
            discountText = discountText.Trim();

            // Check for empty input
            if (string.IsNullOrWhiteSpace(discountText))
            {
                ep.SetError(control, "Discount is required.");
                return false;
            }

            // Check for spaces
            if (discountText.Contains(" "))
            {
                ep.SetError(control, "Discount should not contain spaces.");
                return false;
            }

            // Check for letters or symbols using regex
            if (!Regex.IsMatch(discountText, @"^\d+(\.\d+)?$"))
            {
                ep.SetError(control, "Discount must be a positive number or decimal only. No letters or symbols allowed.");
                return false;
            }

            // Parse and validate numeric range
            if (!decimal.TryParse(discountText, out decimal discount) || discount < 0 || discount > 100)
            {
                ep.SetError(control, "Discount must be between 0 and 100.");
                return false;
            }

            ep.SetError(control, "");
            return true;
        }


        public static bool ValidatePromoCode(string promoText, Control control, ErrorProvider ep)
        {
            promoText = promoText.Trim();

            if (string.IsNullOrWhiteSpace(promoText))
            {
                ep.SetError(control, "Promo code is required.");
                return false;
            }

            if (promoText.Contains(" "))
            {
                ep.SetError(control, "Promo code should not contain spaces.");
                return false;
            }

            // Check for non-alphanumeric characters
            if (!Regex.IsMatch(promoText, @"^[a-zA-Z0-9]+$"))
            {
                ep.SetError(control, "Promo code must contain only letters and numbers. No symbols allowed.");
                return false;
            }

            ep.SetError(control, "");
            return true;
        }

    }

}
