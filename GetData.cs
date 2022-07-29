using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Peace_System
{
    internal class GetData
    {
        private static string student_id_receipt;

        public static void setStudentIdReceipt(string student_id)
        {
            student_id_receipt = student_id;
        }

        public static string getStudentIdReceipt()
        {
            return student_id_receipt;
        }
    }
}
