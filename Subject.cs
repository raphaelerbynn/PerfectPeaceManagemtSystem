using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    public class Subject
    {
        private string subject_name;
        private int exam_total_marks;
        private int class_total_marks;
        private int exam_percentage;
        private int class_percentage;
        private int pass_marks;

        public Subject() { }

        public Subject(string subject_name, int exam_total_marks, int class_total_marks, int exam_percentage, int class_percentage, int pass_marks)
        {
            this.subject_name = subject_name;
            this.exam_total_marks = exam_total_marks;
            this.class_total_marks = class_total_marks;
            this.exam_percentage = exam_percentage;
            this.class_percentage = class_percentage;
            this.pass_marks = pass_marks;
        }

        public void insert_data()
        {
            string query = "INSERT INTO Subject(name, exam_total_marks, class_total_marks, exam_percentage, class_percentage, pass_marks) VALUES('"+subject_name+"', '"+exam_total_marks+"', '"+class_total_marks+"', '"+exam_percentage+"', '"+class_percentage+"', '"+pass_marks+"')";
            DbClient.query_execute(query);
        }

        public void show_data(DataGridView dataGridView)
        {
            string query = "SELECT subject_id, name, exam_total_marks, class_total_marks, exam_percentage, class_percentage, pass_marks FROM Subject";
            DbClient.dataGridFill(dataGridView, query);
        }

        public void delete(string id)
        {
            string query = "DELETE FROM Subject WHERE subject_id='" + id + "'";
            DbClient.query_execute(query);
        }
    }
}
