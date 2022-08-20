using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Peace_System
{
    internal class DataFromDb
    {
        private static string query;

        //----------for admin
        //student data
        public static DataTable getAllStudent;
        public static DataTable getAllStudentData()
        {
            return getAllStudent;
        }

        //teacher data
        public static DataTable getAllTeacher;
        public static DataTable getAllTeacherData()
        {
            return getAllTeacher;
        }
        
        public static DataTable getAllNonTeacher;
        public static DataTable getAllNonTeacherData()
        {
            return getAllNonTeacher;
        }

        //event data
        public static DataTable getAllEvent;
        public static DataTable getAllEventData()
        {
            return getAllEvent;
        }
        
        //parent data
        public static DataTable getAllParent;
        public static DataTable getAllParentData()
        {
            return getAllParent;
        }

        //class data
        public static DataTable getAllClass;
        public static DataTable getAllClassData()
        {
            return getAllClass;
        }

        public static SqlDataReader allClassReader;
        public static SqlDataReader allClassReaderData()
        {
            return allClassReader;
        }



        //---------for teacher
        //teacher class id
        public static string class_id_teacher()
        {
            string class_id = "";
            query = "SELECT class_id FROM Class WHERE teacher_id='" + Pages.LoginInput.teacher_id + "'";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                class_id = reader["class_id"].ToString();
            }
            reader.Close();
            return class_id;
        }

        //student data
        public static DataTable getAllStudentForTeacher;
        public static DataTable getAllStudentDataForTeacher()
        {
            return getAllStudentForTeacher;
        }
        

        //------------for accountant
        //account data
        public static DataTable getExpenses;
        public static DataTable getExpensesData()
        {
            return getExpenses;
        }

        public static DataTable getFeedingFee;
        public static DataTable getFeedingFeeData()
        {
            return getFeedingFee;
        }
        
        public static DataTable getExtraClasses;
        public static DataTable getExtraClassesData()
        {
            return getExtraClasses;
        }
        
        //payroll
        public static DataTable getSalaryBase;
        public static DataTable getSalaryBaseData()
        {
            return getSalaryBase;
        }
        
        public static DataTable getEmployeeSalary;
        public static DataTable getEmployeeSalaryData()
        {
            return getEmployeeSalary;
        }
        
        public static DataTable getSalaryPayment;
        public static DataTable getSalaryPaymentData()
        {
            return getSalaryPayment;
        }

        //fees
        public static DataTable getFees;
        public static DataTable getFeesData()
        {
            return getFees;
        }



    }
}
