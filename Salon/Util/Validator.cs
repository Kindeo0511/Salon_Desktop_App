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
       
        public static bool IsRequired(Control control, ErrorProvider ep, string message) 
        {
            if (control is NumericUpDown nud)
            {
                if (nud.Value == 0) // or use a threshold like nud.Value <= 0
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
        public static bool IsScheduleConflict(Control[] controls, ErrorProvider ep, string message, int stylist_id, TimeSpan start, TimeSpan end, int id)
        {
            var repo = new StylistSchedulesRepository();
            var controller = new StylistSchedulesController(repo);

            if (controller.GetIsScheduleConflict(stylist_id, controls[0].Text, start, end, id))
            {
                foreach (var ctrl in controls)
               
                    ep.SetError(ctrl, message);
      
                return false;
            }

            foreach (var ctrl in controls)
                ep.SetError(ctrl, "");
            return true;
        }

        // END OF STYLIST SCHEDULE

        // STYLIST EXCEPTION SCHEDULE


        // not done yet in validation
         public static bool IsExScheduleConflict(Control[] controls, ErrorProvider ep, string message, int stylist_id, TimeSpan start, TimeSpan end, int id)
        {
            var repo = new ExceptionSchedulesRepository();
            var controller = new ExceptionSchedulesController(repo);
            DateTime date = ((DateTimePicker)controls[0]).Value;
            if (controller.GetIsExceptionScheduleConflict(stylist_id, date, start, end, id))
            {
                foreach (var ctrl in controls)
               
                    ep.SetError(ctrl, message);
      
                return false;
            }

            foreach (var ctrl in controls)
                ep.SetError(ctrl, "");
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
        public static bool IsProductUsageExists(Control control, ErrorProvider ep, string message, int pid, int id)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;

            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            if (controller.CheckProductUsageExists(pid, id))
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


    }
}
