using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System.Pages
{
    public partial class StudentDataDisplay : Form
    {
        Student student;
        Parent parent;
        private string query;
        private static string id;
        WaitFunc wait = new WaitFunc();
        OpenNewPage openNewPage = new OpenNewPage();
        private Bitmap bitmap;
        private int pageNumber = 1;

        public StudentDataDisplay()
        {
            student = new Student();
            parent = new Parent();
            InitializeComponent();
            adjustColumnOrder();
            studentDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            studentDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            studentDataView.BackgroundColor = Home.foreColor;
            topPanel.BackColor = Home.foreColor;
            if (Pages.LoginInput.category.Equals("Administrator"))
            {
                studentDataView.DataSource = DataFromDb.getAllStudentData();
            }
            
            if(Pages.LoginInput.category.Equals("Class Teacher"))
            {
                studentDataView.DataSource = DataFromDb.getAllStudentDataForTeacher();
                searchCb.Items.RemoveAt(2);

                delete.Visible = false;
            }
            getTotalGendeView();

        }

        

        private void getTotalGendeView()
        {
            
            double totalMale = 0;
            double totalFemale = 0;
            foreach (DataGridViewRow item in studentDataView.Rows)
            {
                if (item.Cells["gender"].Value.ToString().Equals("Male") || item.Cells["gender"].Value.ToString().Equals("MALE"))
                {
                    totalMale++;

                }
                else
                {
                    totalFemale++;

                }
            }
            
            maleLbl.Text = totalMale.ToString();
            femaleLbl.Text = totalFemale.ToString();
        }

        private void adjustColumnOrder()
        {
            studentDataView.Columns["student_Id"].DisplayIndex = 0;
            studentDataView.Columns["full_name"].DisplayIndex = 1;
            studentDataView.Columns["age"].DisplayIndex = 3;
            studentDataView.Columns["_class"].DisplayIndex = 3;
            studentDataView.Columns["fees_details"].DisplayIndex = 6;
            studentDataView.Columns["gender"].DisplayIndex = 2;
            studentDataView.Columns["view"].DisplayIndex = 6;
            studentDataView.Columns["medicalReport"].DisplayIndex = 7;
            studentDataView.Columns["edit"].DisplayIndex = 8;
            studentDataView.Columns["delete"].DisplayIndex = 9;

            studentDataView.AutoGenerateColumns = false;
            searchCb.SelectedIndex = 0;
        }

        private void reloadDataBtn_Click(object sender, EventArgs e)
        {
            //student.show_data(studentDataView);
        }

        private void studentDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                DataGridViewRow row = studentDataView.Rows[e.RowIndex];
                id = row.Cells["student_Id"].Value.ToString();
                string parent_id = getParentIdFromSelectedRow();
                string name = row.Cells["full_name"].Value.ToString();


                if (studentDataView.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete " + name + "?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        wait.show();
                        
                        query = "DELETE FROM Fee WHERE student_id='" + id + "'";
                        DbClient.query_execute(query);

                        query = "DELETE FROM Student_marks WHERE student_id='" + id + "'";
                        DbClient.query_execute(query); 
                        
                        query = "DELETE FROM Student_result WHERE student_id='" + id + "'";
                        DbClient.query_execute(query);

                        query = "DELETE FROM Attendance WHERE student_id='" + id + "'";
                        DbClient.query_execute(query);
                        
                        query = "DELETE FROM Total_attendance WHERE student_id='" + id + "'";
                        DbClient.query_execute(query);
                        
                        query = "DELETE FROM KG_assessment WHERE student_id='" + id + "'";
                        DbClient.query_execute(query);
                        
                        query = "DELETE FROM Medical_report WHERE student_id='" + id + "'";
                        DbClient.query_execute(query);
                        
                        

                        studentDataView.Rows.RemoveAt(e.RowIndex);
                        student.delete(id);
                        parent.delete(parent_id);
                   
                        
                        DataFromDb.totalStudents = DbClient.query_executeScaler("SELECT COUNT(*) FROM Student");
                        
                        getTotalGendeView();
                        wait.close();
                        MessageBox.Show(name + " deleted from system");
                    }

                }

                if (studentDataView.Columns[e.ColumnIndex].Name == "view" && e.RowIndex >= 0)
                {
                    wait.show();
                    StudentDetail studentDetail = new StudentDetail();
                    studentDetail.Show();
                    Home home = (Home)Application.OpenForms["Home"];
                    home.Hide();
                    wait.close();
                }

                if (studentDataView.Columns[e.ColumnIndex].Name == "edit")
                {
                    //update data
                    wait.show();
                    openNewPage.OpenChildForm(new Pages.UpdateStudent(), showDataPanel);
                    wait.close();
                }
                
                if (studentDataView.Columns[e.ColumnIndex].Name == "medicalReport")
                {
                    wait.show();
                    openNewPage.OpenChildForm(new Pages.MedicalReport(), showDataPanel);
                    wait.close();
                }
            }catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        public static string getIdFromSelectedRow()
        {
            return id;
        }

        public string getParentIdFromSelectedRow()
        {
            try
            {
                //DbClient.connection_close();
                query = "SELECT parent_id FROM Student WHERE student_id='" + id + "' AND parent_id IS NOT NULL";
                string parent_id = "";
                System.Data.SqlClient.SqlDataReader reader0 = DbClient.query_reader(query);
                while (reader0.Read())
                {
                    parent_id = reader0["parent_id"].ToString();
                }
                reader0.Close();

                return parent_id;
            }
            catch (Exception ex)
            {
                //DbClient.connection_close();
                Console.WriteLine(ex);
                return null;

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(searchTextBox.Text))
            {
                try
                {
                    (studentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format(searchCb.Text + " LIKE '%{0}%'", searchTextBox.Text);
                    getTotalGendeView();
                    if (!String.IsNullOrEmpty(searchTextBox.Text) && searchCb.Text.Equals("Class"))
                    {
                        printBtn.Visible = true;
                    }
                    else
                    {
                        printBtn.Visible = false;
                        Console.WriteLine("vanish");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Search Again");
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                (studentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                printBtn.Visible = false;
                getTotalGendeView();
            }
        }

        private void refeshBtn_Click(object sender, EventArgs e)
        {
            wait.show();
            if (Pages.LoginInput.category.Equals("Administrator"))
            {
                DataFromDb.getAllStudent = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student");
                
                studentDataView.DataSource = DataFromDb.getAllStudentData();
                //MessageBox.Show("Student data refreshed");
                getTotalGendeView();

            }

            if (Pages.LoginInput.category.Equals("Class Teacher"))
            {
                DataFromDb.getAllStudentForTeacher = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student WHERE class_id='" + DataFromDb.class_id_teacher() + "'");
                
                studentDataView.DataSource = DataFromDb.getAllStudentDataForTeacher();
                //MessageBox.Show("Student data refreshed");
                getTotalGendeView();
            }
            wait.close();
        }


        private int currentPage = 1;
        private int totalPageCount = 0;
        private Font printFont;
        private Font printFontHead;

        private void printClass_PrintPage(object sender, PrintPageEventArgs e)
        {
            int rowHeight = studentDataView.Rows[0].Height;
            int rowsPerPage = e.MarginBounds.Height / rowHeight;
            int rowCount = studentDataView.Rows.Count;
            printFont = new Font("sans-sarif", 12, FontStyle.Regular);
            printFontHead = new Font("sans-sarif", 12, FontStyle.Bold);

            // Calculate the total number of pages
            totalPageCount = (int)Math.Ceiling((double)rowCount / rowsPerPage);

            // Set the starting row index and y coordinate
            int rowIndex = (currentPage - 1) * rowsPerPage;
            int y = e.MarginBounds.Top;

            //writings above table
            Rectangle topTextRect = new Rectangle(e.MarginBounds.Left, y, 700, rowHeight);
            string topText = "List for: " + studentDataView.Rows[1].Cells["_class"].Value;
            e.Graphics.DrawString(topText, printFont, Brushes.Black, topTextRect);
            y += rowHeight + 20;

            //Draw column headers
            for (int i = 0; i < 3; i++)
            {
                Rectangle cellRect = new Rectangle(e.MarginBounds.Left + i * 270, y, 270, rowHeight);
                string value;
                if (i == 0)
                {
                    value = studentDataView.Columns["full_name"].HeaderText;
                }
                else if (i == 1)
                {
                    value = studentDataView.Columns["gender"].HeaderText;
                    cellRect = new Rectangle(e.MarginBounds.Left + i * 380, y, 200, rowHeight);
                }
                else
                {
                    value = studentDataView.Columns["fees_details"].HeaderText; 
                    cellRect = new Rectangle(e.MarginBounds.Left + i * 280, y, 100, rowHeight);

                }

                e.Graphics.DrawString(value, printFontHead, Brushes.Black, cellRect);
            }
            y += rowHeight;

            // Draw the rows until the end of the page is reached
            while (rowIndex < rowCount && y + rowHeight <= e.MarginBounds.Bottom)
            {
                
                DataGridViewRow row = studentDataView.Rows[rowIndex];
                for (int i = 0; i < 3; i++)
                {
                    Rectangle cellRect = new Rectangle(e.MarginBounds.Left + i * 420, y, 420, rowHeight); 
                    string value;
                    if(i == 0)
                    {
                        value = (rowIndex+1).ToString() + ".   " + row.Cells["full_name"].FormattedValue.ToString();
                    }
                    else if(i == 1)
                    {
                        value = row.Cells["gender"].FormattedValue.ToString();
                        cellRect = new Rectangle(e.MarginBounds.Left + i * 380, y, 200, rowHeight);
                    }
                    else
                    {
                        value = row.Cells["fees_details"].FormattedValue.ToString();
                        cellRect = new Rectangle(e.MarginBounds.Left + i * 280, y, 100, rowHeight);
                    }

                    e.Graphics.DrawString(value, printFont, Brushes.Black, cellRect);
                }
                y += rowHeight;
                rowIndex++;
            }


            // If there are more pages, set the HasMorePages property to true
            if (currentPage < totalPageCount)
            {
                currentPage++;
                e.HasMorePages = true;
            }
            else
            {
                // Reset the current page and page count
                currentPage = 1;
                totalPageCount = 0;
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.DocumentName = "Student List Print";
                printDocument.PrintPage += printClass_PrintPage;

                // Show print preview dialog or print directly
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument;
                if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }


        private void studentDataView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            var grid = sender as DataGridView;
            var row_number = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(row_number, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }

}
