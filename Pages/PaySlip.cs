using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Perfect_Peace_System.Pages
{
    public partial class PaySlip : Form
    {
        private string employeeId = Payroll.getPaymentNameId();
        private string query;
        readonly PrintDocument printdoc = new PrintDocument();
        readonly PrintPreviewDialog printPreview = new PrintPreviewDialog();

        public PaySlip()
        {
            InitializeComponent();
            fillLabels();
            Console.WriteLine(employeeId);
        }

        private void fillLabels()
        {
            try
            {
                double totalAllowance = 0;
                double totalDeductions = 0;
                double salaryAmount = 0;
                string salary_id = "";

                query = "SELECT * FROM Teacher WHERE teacher_id='"+employeeId+"'";
                SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    empNameLbl.Text = reader["f_name"].ToString() + " " + reader["l_name"].ToString();
                    emailLbl.Text = reader["email"].ToString();
                    contactLbl.Text = reader["phone"].ToString();
                    staffIdLbl.Text = reader["staff_id"].ToString();
                    ssnitLbl.Text = reader["ssnit"].ToString();
                    tinLbl.Text = reader["tin"].ToString();
                    bankLbl.Text = reader["bank"].ToString();
                    accountNumLbl.Text = reader["account_number"].ToString();
                }
                reader.Close();

                query = "SELECT salary_id FROM Employee_salary WHERE teacher_id='" + employeeId + "'";
                reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    salary_id = reader["salary_id"].ToString();
                }
                reader.Close();
                
                query = "SELECT * FROM Salary WHERE salary_id='" + salary_id + "'";
                reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    positionLbl.Text = reader["title"].ToString();
                    rankLbl.Text = reader["rank"].ToString();
                    actualSalaryLbl.Text = "GHc "+reader["amount"].ToString();
                    salaryAmount = double.Parse(reader["amount"].ToString());
                }
                reader.Close();
              
                //allowances
                query = "SELECT * FROM Allowance WHERE salary_id='" + salary_id + "'";
                reader = DbClient.query_reader(query);
                int counter = 0;
                while (reader.Read())
                {
                    if (counter == 0)
                    {
                        allowanceLbl1.Text =  reader["title"].ToString() + "  -  GHc " + reader["amount"].ToString();
                    }
                    else if(counter == 1)
                    {
                        allowanceLbl2.Text = reader["title"].ToString() + "  -  Ghc " + reader["amount"].ToString();
                    }
                    else if(counter == 2)
                    {
                        allowanceLbl3.Text = reader["title"].ToString() + "  -  Ghc " + reader["amount"].ToString();
                    }
                    else if(counter == 3)
                    {
                        allowanceLbl4.Text = reader["title"].ToString() + "  -  Ghc " + reader["amount"].ToString();
                    }
                    else if(counter == 4)
                    {
                        allowanceLbl5.Text = reader["title"].ToString() + "  -  Ghc " + reader["amount"].ToString();
                    }
                    else
                    {
                        allowanceLbl6.Text = reader["title"].ToString() + "  -  GHc " + reader["amount"].ToString();
                    }
                    totalAllowance += double.Parse(reader["amount"].ToString());
                    counter++;
                }
                reader.Close();
                totalAllowanceLbl.Text = "Ghc "+totalAllowance.ToString();
                
                //deductions
                query = "SELECT * FROM Deductions WHERE salary_id='" + salary_id + "'";
                reader = DbClient.query_reader(query);
                counter = 0;
                while (reader.Read())
                {
                    if (counter == 0)
                    {
                        deductionLbl1.Text =  reader["title"].ToString() + "  -  GHc " + reader["amount"].ToString();
                    }
                    else if(counter == 1)
                    {
                        deductionLbl2.Text = reader["title"].ToString() + "  -  Ghc " + reader["amount"].ToString();
                    }
                    else if(counter == 2)
                    {
                        deductionLbl3.Text = reader["title"].ToString() + "  -  Ghc " + reader["amount"].ToString();
                    }
                    else if(counter == 3)
                    {
                        deductionLbl4.Text = reader["title"].ToString() + "  -  Ghc " + reader["amount"].ToString();
                    }
                    else if(counter == 4)
                    {
                        deductionLbl5.Text = reader["title"].ToString() + "  -  Ghc " + reader["amount"].ToString();
                    }
                    else
                    {
                        deductionLbl6.Text = reader["title"].ToString() + "  -  GHc " + reader["amount"].ToString();
                    }
                    totalDeductions += double.Parse(reader["amount"].ToString());
                    counter++;
                }
                reader.Close();
                totalDeductionsLbl.Text = "Ghc "+totalDeductions.ToString();

                //gross and net
                grossSalaryLbl.Text = "Ghc "+(salaryAmount + totalAllowance).ToString();
                netSalaryLbl.Text = "Ghc "+((salaryAmount + totalAllowance) - totalDeductions).ToString();
                datePaidLbl.Text = DateTime.Now.ToString("dd MMMM, yyyy");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Print()
        {
            PrinterSettings ps = new PrinterSettings();
            //reportCardPanel = panel;
            //getPrintArea(panel);
            printPreview.Document = printdoc;
            printdoc.PrintPage += new PrintPageEventHandler(printdoc_printPage);
            ((Form)printPreview).Size = new Size(950, 539);
            printPreview.ShowDialog();
        }

        private void printdoc_printPage(object sender, PrintPageEventArgs e)
        {
            var bitMap = ControlPrinter.ScrollableControlToBitmap(this.payslipPanel, true, true);
            e.Graphics.DrawImage(bitMap, new Rectangle(0, 0, payslipPanel.Width, payslipPanel.Height));
        }

        private void addToPaymentBtn_Click(object sender, EventArgs e)
        {
            amountPaidLbl.Text = "GHc "+amountPaidTb.Text;
            salaryMonthLbl.Text = salaryMonthPk.Text;
            modeOfPaymentLbl.Text = modeOfPaymentCb.Text;
        }

        private void savePaymentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                query = "INSERT INTO Salary_payment (name, amount, net, salary_date, payment_method, date_paid)" +
                    "VALUES('"+empNameLbl.Text+"', '"+amountPaidTb.Text+"', '"+netSalaryLbl.Text+"', '"+salaryMonthLbl.Text+"', '"+modeOfPaymentLbl.Text+"', '"+DateTime.Today+"')";
                DbClient.query_execute(query);

                MessageBox.Show("Payment Saved");
                string message = "Do you want to print PaySlip?";
                MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "", deleteAction);
                if (result == DialogResult.Yes)
                {
                    Print();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
