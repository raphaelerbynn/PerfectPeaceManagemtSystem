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
        private static string fee_id;
        private static bool printFromData;
        private static bool confirmPassword;

        public static void setStudentIdReceipt(string student_id)
        {
            student_id_receipt = student_id;
        }

        public static string getStudentIdReceipt()
        {
            return student_id_receipt;
        }

        public static void setFeeId(string feeId)
        {
            fee_id = feeId;
        }

        public static string getFeeId()
        {
            return fee_id;
        }

        public static void setFromTableReceiptQuery(bool printFromFormValue)
        {
            printFromData = printFromFormValue;
        }

        public static bool getFromTableReceiptQuery()
        {
            return printFromData;
        }

        public static void setConfirmPassword(bool confirmation)
        {
            confirmPassword = confirmation;
        }

        public static bool getConfirmedPassword()
        {
            return confirmPassword;
        }
    }
}
