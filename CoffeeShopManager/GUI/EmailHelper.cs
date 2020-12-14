using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace GUI
{
    public static class EmailHelper
    {
        public static bool ValidateEmail(string email)
        {
            try
            {
                var mail = new MailAddress(email);
                if (email.TrimEnd() == mail.Address && email.LastIndexOf(".") > email.IndexOf("@") && email.LastIndexOf(".") < email.TrimEnd().Length - 1)
                {
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
