namespace To_Do_list
{
    partial class toDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            titletb = new TextBox();
            descriptiontb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            newbtn = new Button();
            editbttn = new Button();
            deletebtn = new Button();
            savebtn = new Button();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 81);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // titletb
            // 
            titletb.Location = new Point(12, 128);
            titletb.Name = "titletb";
            titletb.Size = new Size(851, 27);
            titletb.TabIndex = 1;
            // 
            // descriptiontb
            // 
            descriptiontb.Location = new Point(12, 193);
            descriptiontb.Name = "descriptiontb";
            descriptiontb.Size = new Size(851, 27);
            descriptiontb.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(851, 25);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(851, 25);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // newbtn
            // 
            newbtn.Location = new Point(12, 238);
            newbtn.Name = "newbtn";
            newbtn.Size = new Size(205, 29);
            newbtn.TabIndex = 5;
            newbtn.Text = "New";
            newbtn.UseVisualStyleBackColor = true;
            newbtn.Click += newbtn_Click;
            // 
            // editbttn
            // 
            editbttn.Location = new Point(233, 238);
            editbttn.Name = "editbttn";
            editbttn.Size = new Size(205, 29);
            editbttn.TabIndex = 6;
            editbttn.Text = " Edit";
            editbttn.UseVisualStyleBackColor = true;
            editbttn.Click += editbttn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(453, 238);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(205, 29);
            deletebtn.TabIndex = 7;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(664, 238);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(205, 29);
            savebtn.TabIndex = 8;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(12, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(851, 208);
            dataGridView1.TabIndex = 9;
            // 
            // toDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(875, 523);
            Controls.Add(dataGridView1);
            Controls.Add(savebtn);
            Controls.Add(deletebtn);
            Controls.Add(editbttn);
            Controls.Add(newbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descriptiontb);
            Controls.Add(titletb);
            Controls.Add(label1);
            Name = "toDoList";
            ShowIcon = false;
            Text = "To-Do list";
            Load += toDoList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titletb;
        private TextBox descriptiontb;
        private Label label2;
        private Label label3;
        private Button newbtn;
        private Button editbttn;
        private Button deletebtn;
        private Button savebtn;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
    }
}
