using System;
using System.Data;
using System.Linq;


namespace To_Do_list
{
    public partial class toDoList : Form
    {
        public toDoList()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;
        private void toDoList_Load(object sender, EventArgs e)
        {
            // columns 
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            dataGridView1.DataSource = todoList;
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            titletb.Text = "";
            descriptiontb.Text = "";
        }

        private void editbttn_Click(object sender, EventArgs e)
        {
            isEditing = true;

            titletb.Text = todoList.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptiontb.Text = todoList.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[dataGridView1.CurrentCell.RowIndex]["Title"] = titletb.Text;
                todoList.Rows[dataGridView1.CurrentCell.RowIndex]["Description"] = descriptiontb.Text;
            }
            else
            {
                todoList.Rows.Add(titletb.Text, descriptiontb.Text);
               
            }
            titletb.Text = "";
            descriptiontb.Text = "";
            isEditing = false;
        }
    }
}
