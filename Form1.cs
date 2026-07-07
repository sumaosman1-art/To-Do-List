using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFromFile();
            CompletedAndPending();
        }
     void LoadFromFile()
        {
            string filepath = "ToDoList.txt";
            if (!System.IO.File.Exists(filepath))
                return;
            try
            {
                chbl.Items.Clear();
                foreach (string line in System.IO.File.ReadAllLines(filepath))
                {
                    if (String.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        string task = parts[0].Trim();
                        string Status = parts[1].Trim();
                        if (string.IsNullOrWhiteSpace(task))
                            continue;
                        int index = chbl.Items.Add(task);
                        // if (CheckedStatus.ToLower() == "Checked".ToLower())
                        if (Status.Equals("Checked", StringComparison.OrdinalIgnoreCase))
                            chbl.SetItemChecked(index, true);

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Unexpected Error:{ex.Message}", "Error");
            }

        }
        void SavetoFile()
        {
            
            string filepath = "ToDoList.txt";
            try
            {
                List<string> lines = new List<string>();
                for (int i = 0; i < chbl.Items.Count; i++)
                {
                    string Task = chbl.Items[i].ToString();
                    bool IsChecked = chbl.GetItemChecked(i);
                    string Status = IsChecked ? "Checked" : "UnChecked";
                    lines.Add($"{Task}|{Status}");
                }
                System.IO.File.WriteAllLines(filepath, lines);
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Unexpected Error {ex.Message}","Error");
            }

        }
        
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAddTask.Text))
            { MessageBox.Show("No Task To Add");
                return;
            }
            for(int i = chbl.Items.Count - 1; i >= 0; i--)
            {
                if (tbAddTask.Text.ToLower() == chbl.Items[i].ToString().ToLower())
                {
                    MessageBox.Show("Task already existed");
                    tbAddTask.Clear();
                    
                    return;
                }
            }
            
             chbl.Items.Add(tbAddTask.Text);
                tbAddTask.Clear();
            CompletedAndPending();


        }
        void CompletedAndPending()
        {
            int count = chbl.CheckedItems.Count;
            
            tbCompleted.Text=count.ToString();
            tbPending.Text= (chbl.Items.Count - count).ToString();
            
        }
        private void btnRemoveCheckedTasks_Click(object sender, EventArgs e)
        {
            for(int i = chbl.CheckedItems.Count-1;i>=0;i--)
            {
                chbl.Items.RemoveAt(i);
            }
            CompletedAndPending();

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
           
                chbl.Items.Clear();
            CompletedAndPending();


        }

       

        private void chbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompletedAndPending();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavetoFile();
        }
    }
}
