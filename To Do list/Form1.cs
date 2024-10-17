using System;
using System.Data;
using System.Linq;


namespace To_Do_list
{

    public class Task
    {
        public string title { get; set; }
        public string description { get; set; }
    }
    public partial class toDoList : Form
    {
        public toDoList()
        {
            InitializeComponent();
        }

        List<Task> t = new List<Task>();
        BindingSource bindingSource = new BindingSource();
        bool isEditing = false;
        private void toDoList_Load(object sender, EventArgs e)
        {
           
            bindingSource.DataSource = t;
            dataGridView1.DataSource = bindingSource;
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            titletb.Text = "";
            descriptiontb.Text = "";
            
        }

        private void editbttn_Click(object sender, EventArgs e)
        {
           if(dataGridView1.CurrentCell != null)
            {

                isEditing = true;

                titletb.Text = t[dataGridView1.CurrentCell.RowIndex].title;
                descriptiontb.Text = t[dataGridView1.CurrentCell.RowIndex].description;
            }
            else
            {
                MessageBox.Show("please select a row to edit");
            }
            
  
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if( dataGridView1.CurrentCell != null)
                {
                    t.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                    bindingSource.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("please select a row to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(titletb.Text) || (string.IsNullOrEmpty(descriptiontb.Text))) {  
                MessageBox.Show("Please fill in both blanks");

            }

            

            if (isEditing)
            {
                
                t[dataGridView1.CurrentCell.RowIndex].title = titletb.Text;
                t[dataGridView1.CurrentCell.RowIndex].description = descriptiontb.Text;

            }
            else
            {
                Task newTask = new Task
                {
                    title = titletb.Text,
                    description = descriptiontb.Text
                };
                t.Add(newTask);

            }


            titletb.Text = "";
            descriptiontb.Text = "";
            isEditing = false;

            bindingSource.ResetBindings(false);
        }
        // that's all
    }
}
