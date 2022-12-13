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
using System.Net.Mail;
using System.Net;
using System.IO;

namespace Perfect_Peace_System.Pages
{
    public partial class PaySlip : Form
    {
        private string email;
        private string employeeId = Payroll.getPaymentNameId();
        private string query;
        readonly PrintDocument printdoc = new PrintDocument();
        readonly PrintPreviewDialog printPreview = new PrintPreviewDialog();

        public PaySlip()
        {
            InitializeComponent();
            fillLabels();
            bgPanel.BackColor = Home.foreColor;
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
                    email = reader["email"].ToString();
                    contactLbl.Text = reader["phone"].ToString();
                    staffIdLbl.Text = "PPS"+reader["teacher_id"].ToString();
                    ssnitLbl.Text = reader["ssnit_number"].ToString();
                    tinLbl.Text = reader["tin_number"].ToString();
                    bankLbl.Text = reader["bank"].ToString();
                    accountNumLbl.Text = reader["account_number"].ToString();
                    categoryLbl.Text = reader["category"].ToString();

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
            e.Graphics.DrawImage(bitMap, new Rectangle((printdoc.DefaultPageSettings.PaperSize.Width - payslipPanel.Width) / 2, 0, payslipPanel.Width, payslipPanel.Height));
        }

        private void addToPaymentBtn_Click(object sender, EventArgs e)
        {
            amountPaidLbl.Text = "GHc "+amountPaidTb.Text;
            salaryMonthLbl.Text = salaryMonthPk.Text;
            modeOfPaymentLbl.Text = modeOfPaymentCb.Text;
        }

        private void sendEmailAfterPayment(MailAddress to, MailAddress from, string amount)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                /*string template = File.ReadAllText("../email/payment_template.html");
                template = template.Replace("{name}", empNameLbl.Text);
                template = template.Replace("{month}", salaryMonthLbl.Text);
                template = template.Replace("{date}", datePaidLbl.Text);
                template = template.Replace("{mode}", modeOfPaymentLbl.Text);
                template = template.Replace("{amount}", amountPaidLbl.Text);*/

                string template = 
                    "----------------------------------------------\n" +
                    "                  PAYMENT MADE                \n" +
                    "----------------------------------------------\n" +
                    "Hi, "+empNameLbl.Text+",\n" +
                    "Montly payment for "+salaryMonthLbl.Text+"\n" +
                    "paid on "+datePaidLbl.Text+" using " +modeOfPaymentLbl.Text+"\n\n" +
                    "PAYMENT DETAILS     \n" +
                    "----------------------\n" +
                    "Amount: " + amountPaidLbl.Text +"\n" +
                    "Date: " + datePaidLbl.Text +"\n" +
                    "Mode: " + modeOfPaymentLbl.Text +"\n\n" +
                    "Thank you for making Perfect\n" +
                    "Peace a great organization.\n" +
                    "-----------------------------------------------";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                // smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("perfectpeacepreparatoryschool@gmail.com", "wufspbppaqsntywu");

                MailMessage mail = new MailMessage();
                mail.From = from;
                mail.To.Add(to);
                mail.Subject = "Salary Payment";
                
                mail.IsBodyHtml = false;
                mail.Body = template;
                //mail.Body = "Payment made of an amount of" + amountPaidLbl.Text;

                //smtp.Port = 587;
                //smtp.Host = "smtp.gmail.com";
                //smtp.EnableSsl = true;
                //smtp.UseDefaultCredentials = false;
                //smtp.Credentials = new NetworkCredential("erbynn1234@gmail.com", "mountain500000");
                //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(mail);
                MessageBox.Show("Email Sent to Employee");
                //.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err: " + ex.Message);
            }
            
        }

        private void savePaymentBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                query = "INSERT INTO Salary_payment (name, amount, net, salary_date, payment_method, date_paid) " +
                    "VALUES('"+empNameLbl.Text+"', '"+amountPaidTb.Text+"', '"+netSalaryLbl.Text+"', '"+salaryMonthLbl.Text+"', '"+modeOfPaymentLbl.Text+"', '"+DateTime.Today+"')";
                DbClient.query_execute(query);

                MessageBox.Show("Payment Saved");

                MailAddress to = new MailAddress(email);
                MailAddress from = new MailAddress("perfectpeacepreparatoryschool@gmail.com", "PERFECT PEACE PREPARATORY SCHOOL");
                sendEmailAfterPayment(to, from, amountPaidLbl.Text);

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

        private void tB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


    }
}
