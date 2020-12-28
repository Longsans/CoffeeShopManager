using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BUS;
using System.Windows.Forms;

namespace GUI
{
    public class EmployeeExistHelper
    {
        BUS_Employee busEmp = new BUS_Employee();

        public void CheckExistence(DTO_Employee emp)
        {
            try
            {
                if (busEmp.GetEmployeeInfoAndManagerId(emp.Id, emp.Shop.ID) == null)
                {
                    throw new Exception("An error occurred, please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
