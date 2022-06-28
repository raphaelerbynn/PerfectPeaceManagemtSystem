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

namespace Perfect_Peace_System.Pages
{
    public partial class FeePaying : Form
    {
        OpenNewPage openNewPage = new OpenNewPage();
        Fees fees;
        public static string totalAmnt;
        public static string remainingAmnt;
        public static string paidAmnt;
        public static string name;
        public static string _class;
        public static string mode;
        public static string term;
        public static string amntWords;

        private string student_id = "";
        private string class_id = "";
        private string alreadyPaidAmt = "0";

        private string query;

        public FeePaying()
        {
            InitializeComponent();
            fillCombos();
            
            
        }

        private void amntTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //amntTb.Text = string.Format("{0:#,###.00}", double.Parse(amntTb.Text));
                if (!string.IsNullOrEmpty(amntTb.Text))
                {
                    
                    double total = double.Parse(totalAmntLbl.Text);
                    
                    remainAmntLbl.Text = (total - (double.Parse(amntTb.Text) + double.Parse(alreadyPaidAmt))).ToString();
                    paidAmntLbl.Text = (double.Parse(alreadyPaidAmt) + double.Parse(amntTb.Text)).ToString();
                }
                else
                {
                    remainAmntLbl.Text = (double.Parse(totalAmntLbl.Text) - double.Parse(alreadyPaidAmt)).ToString();
                    paidAmntLbl.Text = alreadyPaidAmt;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        

        private void amntTb_KeyPress(object sender, KeyPressEventArgs e)
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

        

        private void payFeesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                totalAmnt = totalAmntLbl.Text.ToString();
                paidAmnt = amntTb.Text.ToString();
                remainingAmnt = remainAmntLbl.Text.ToString();
                name = student_nameCb.Text.ToString();
                term = termCb.Text.ToString();
                mode = modeOfPaymentCb.Text.ToString();

                if (paidAmnt.Contains("."))
                {
                    amntWords = Converter.NumberToWords(decimal.Parse(amntTb.Text), "ghana cedis") + " pesewas";
                }
                else
                {
                    amntWords = Converter.NumberToWords(decimal.Parse(amntTb.Text), "ghana cedis") + " ghana cedis";
                }

                if (String.IsNullOrWhiteSpace(student_nameCb.Text) | String.IsNullOrWhiteSpace(amntTb.Text))
                {
                    MessageBox.Show("Name/Amount paid can't be empty");
                    return;
                }

                fees = new Fees(student_id, class_id, double.Parse(totalAmnt), double.Parse(paidAmnt), double.Parse(remainingAmnt), mode, DateTime.Today);
                fees.insert_data();
                query = "UPDATE Student SET fees_paid='"+paidAmntLbl.Text+"', fees_owing='"+remainAmntLbl.Text+"' WHERE student_id='"+student_id+"'";
                DbClient.query_execute(query);


                openNewPage.OpenChildForm(new Pages.FeeReceipt(), feePanel);

            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.ToString()); 
            }
        }

        private void fillCombos()
        {
            string getNameQuery = "SELECT CASE WHEN m_name IS NOT NULL THEN f_name+' '+m_name+' '+l_name ELSE f_name+' '+l_name END AS name FROM Student";
            DbClient.query_reader(student_nameCb, getNameQuery);
            
        }

        private void getStudentDetailsBtn_Click(object sender, EventArgs e)
        { 
            query = "SELECT * FROM Student WHERE CONCAT(f_name,' ',m_name,' ',l_name)='"+student_nameCb.Text+"'";
            System.Data.SqlClient.SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                student_id = reader["student_id"].ToString();
                class_id = reader["class_id"].ToString();
                classLbl.Text = reader["class"].ToString();
                _class = reader["class"].ToString();
                alreadyPaidAmt = reader["fees_paid"].ToString();
            }
            reader.Close();

            query = "SELECT * FROM Class WHERE name='"+_class+"'";
            reader = DbClient.query_reader(query);
            while (reader.Read())
            {
               totalAmntLbl.Text  = reader["fees"].ToString();
            }
            reader.Close();

            remainAmntLbl.Text = (double.Parse(totalAmntLbl.Text) - double.Parse(alreadyPaidAmt)).ToString();
            paidAmntLbl.Text = alreadyPaidAmt;
        }

        private void student_nameCb_TextUpdate(object sender, EventArgs e)
        {

        }

        private void student_nameCb_TextChanged(object sender, EventArgs e)
        {
            foreach (string item in student_nameCb.Items)
            {
                //.WriteLine(item + " " + student_nameCb.Text);
                if (student_nameCb.Text.ToString() == item)
                {
                    getStudentDetailsBtn.Enabled = true;
                    break;
                }
                else
                {
                    getStudentDetailsBtn.Enabled = false;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
