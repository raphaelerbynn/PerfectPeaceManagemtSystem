using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System.Pages
{
    public partial class Loading : Form
    {
        private string category = LoginInput.category;

        public Loading()
        {
            InitializeComponent();
            BackColor = Login.foreColor;
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            if (category.Equals("Administrator"))
            {
                int workNumber = 15;
                DataFromDb.getAllStudent = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getAllTeacher = DbClient.dataSource("SELECT teacher_id,phone,gender, email, (SELECT name FROM Class WHERE Class.class_id=Teacher.class_id) AS class, [f_name]+' '+[l_name] AS name FROM Teacher WHERE category='Teaching'");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getAllWeeklyReport = DbClient.dataSource("SELECT teacher_id, date, (SELECT [f_name]+' '+[l_name] FROM Teacher WHERE Teacher.teacher_id=Teachers_weekly_report.teacher_id) AS name, class, week, FORMAT(date, 'dd-MM-yyyy') AS dateF FROM Teachers_weekly_report GROUP BY teacher_id, class, week, date");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getAllNonTeacher = DbClient.dataSource("SELECT teacher_id,gender, phone,email, staff_position, [f_name]+' '+[l_name] AS name FROM Teacher WHERE category='Non-Teaching'");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getAllStudent = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getAllClass = DbClient.dataSource("SELECT class_id, name, section, capacity, fees, teacher_id, (SELECT [f_name]+' '+[l_name] FROM Teacher WHERE Teacher.teacher_id=Class.teacher_id) AS teacher FROM Class");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getExpenses = DbClient.dataSource("SELECT expense_id, expense, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Expense");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getFeedingFee = DbClient.dataSource("SELECT feeding_fee_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Feeding_fee");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getBusFee = DbClient.dataSource("SELECT bus_fee_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Bus_fee");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getExtraClasses = DbClient.dataSource("SELECT extra_classes_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Extra_classes");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getSalaryBase = DbClient.dataSource("SELECT *, amount AS net_amount, amount AS gross_amount FROM Salary");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getEmployeeSalary = DbClient.dataSource("SELECT teacher_id, [f_name] + ' ' +[l_name] AS name, email, " +
                                                "(SELECT [title]+'('+[rank]+')' AS position FROM Salary WHERE Salary.salary_id=(SELECT salary_id FROM Employee_salary WHERE Employee_salary.teacher_id=Teacher.teacher_id)) " +
                                                "AS salary_base FROM Teacher");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getSalaryPayment = DbClient.dataSource("SELECT salary_payment_id, name, amount, net, salary_date, payment_method, FORMAT(date_paid, 'dd-MMM-yyyy') AS date_paid FROM Salary_payment");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getFees = DbClient.dataSource("SELECT fee_id, student_id, paid, remaining, payment_mode, FORMAT(date_paid, 'dd-MMM-yyyy') AS date_paid, term, (SELECT [f_name]+' '+[l_name] AS name FROM Student WHERE Student.student_id=Fee.student_id) AS student, (SELECT class FROM Student WHERE Student.student_id=Fee.student_id) AS class FROM Fee");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getSubject = DbClient.dataSource("SELECT subject_id, name, exam_total_marks, class_total_marks, exam_percentage, class_percentage, pass_marks FROM Subject");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
            }
            else if (category.Equals("Class Teacher"))
            {
                DataFromDb.getAllWeeklyReport = DbClient.dataSource("SELECT teacher_id, date, (SELECT [f_name]+' '+[l_name] FROM Teacher WHERE Teacher.teacher_id=Teachers_weekly_report.teacher_id) AS name, class, week, FORMAT(date, 'dd-MM-yyyy') AS dateF FROM Teachers_weekly_report GROUP BY teacher_id, class, week, date");
                i += 40;
                DataFromDb.getAllStudentForTeacher = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student WHERE class_id='" + DataFromDb.class_id_teacher() + "'");
                
                for(i=40; i<99; i++)
                {
                    backgroundWorker.ReportProgress(i);
                }
            }
            else
            {
                int workNumber = 7;
                DataFromDb.getExpenses = DbClient.dataSource("SELECT expense_id, expense, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Expense");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getFeedingFee = DbClient.dataSource("SELECT feeding_fee_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Feeding_fee");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getExtraClasses = DbClient.dataSource("SELECT extra_classes_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Extra_classes");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getBusFee = DbClient.dataSource("SELECT bus_fee_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Bus_fee");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getSalaryBase = DbClient.dataSource("SELECT *, amount AS net_amount, amount AS gross_amount FROM Salary");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getEmployeeSalary = DbClient.dataSource("SELECT teacher_id, [f_name] + ' ' +[l_name] AS name, email, " +
                                                "(SELECT [title]+'('+[rank]+')' AS position FROM Salary WHERE Salary.salary_id=(SELECT salary_id FROM Employee_salary WHERE Employee_salary.teacher_id=Teacher.teacher_id)) " +
                                                "AS salary_base FROM Teacher");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getSalaryPayment = DbClient.dataSource("SELECT salary_payment_id, name, amount, net, salary_date, payment_method, FORMAT(date_paid, 'dd-MMM-yyyy') AS date_paid FROM Salary_payment");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
                DataFromDb.getFees = DbClient.dataSource("SELECT fee_id, student_id, paid, remaining, payment_mode, FORMAT(date_paid, 'dd-MMM-yyyy') AS date_paid, term, (SELECT [f_name]+' '+[l_name] AS name FROM Student WHERE Student.student_id=Fee.student_id) AS student, (SELECT class FROM Student WHERE Student.student_id=Fee.student_id) AS class FROM Fee");
                i += 100 / workNumber;
                backgroundWorker.ReportProgress(i);
            }
            DataFromDb.getAllEvent = DbClient.dataSource("SELECT event_id, name, description, FORMAT(date, 'dd-MM-yyyy') AS date, CONVERT(VARCHAR(10), CAST(time AS TIME), 0) AS time FROM Event");
            backgroundWorker.ReportProgress(100);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressLbl.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}

