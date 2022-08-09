using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System.Pages
{
    internal class Fees
    {
        private string student_id;
        private string class_id;
        private string amntWords;
        private string term;
        private string payment_mode;
        private double total;
        private double amount;
        private double balance;
        private DateTime date_paid;

        private string query;

        public Fees() { }

        public Fees(string student_id, string class_id, double total, double amount, double balance, string payment_mode, string amntWords, string term, DateTime date_paid) 
        { 
            this.student_id = student_id;
            this.class_id = class_id;
            this.total = total;
            this.amount = amount;
            this.balance = balance;
            this.payment_mode = payment_mode;
            this.amntWords = amntWords;
            this.term = term;
            this.date_paid = date_paid;
        }

        public void insert_data()
        {
            query = "INSERT INTO Fee(student_id, class_id, total, paid, remaining, payment_mode, amount_in_words, term, date_paid) VALUES('"+student_id+"', '"+class_id+"', '"+total+"', '"+amount+"', '"+balance+"', '"+payment_mode+"', '"+amntWords+"', '"+term+"', '"+date_paid+"')";
            DbClient.query_execute(query);
        }

        public void show_data(DataGridView dataGridView)
        {
            string query = "SELECT fee_id, student_id, paid, remaining, payment_mode, FORMAT(date_paid, 'dd-MMM-yyyy') AS date_paid, term, CAST(student_id AS VARCHAR(50)) AS student, CAST(class_id AS VARCHAR(50)) AS class FROM Fee";
            DbClient.dataGridFill(dataGridView, query);
        }
    }
}
