using PoprizonokApp.Models;
using PoprizonokApp.Utilities;
using PoprizonokApp.Views.PartialView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoprizonokApp.Views
{
    public partial class AddEditAgentForm : Form
    {
        Agent agent { get; set; } = null;
        public AddEditAgentForm(Agent current)
        {
            InitializeComponent();
            if (current != null)
            {
                agent = current;
            }
            else
            {
                agent = new Agent()
                {
                    Logo = @"..\..\Resources\picture.png"
                };
            }
        }

        private void AddEditAgentForm_Load(object sender, EventArgs e)
        {
            agentTypeBindingSource.DataSource = DBContext.Context.AgentType.ToList();
            if (agent != null)
            {
                if (agent.Logo == null)
                    logoPictureBox.ImageLocation = @"..\..\Resources\picture.png";
                else
                    logoPictureBox.ImageLocation = agent.Logo;

                agentBindingSource.Add(agent);
            }
            else
            {
                agentBindingSource.AddNew();
            }
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            if (String.IsNullOrWhiteSpace(addressTextBox.Text)
                || String.IsNullOrEmpty(directorNameTextBox.Text)
                || String.IsNullOrEmpty(emailTextBox.Text)
                || String.IsNullOrEmpty(iNNTextBox.Text)
                || String.IsNullOrEmpty(kPPTextBox.Text)
                || String.IsNullOrEmpty(phoneTextBox.Text)
                || String.IsNullOrEmpty(priorityTextBox.Text)
                || String.IsNullOrEmpty(titleTextBox1.Text))
                builder.AppendLine("Все поля должны быть заполнены");

            if(builder.Length > 0)
            {
                MessageBox.Show(builder.ToString(),"",)
            }

            if (agent.ID == 0)
            {
                DBContext.Context.Agent.Add(agent);
            }

            try
            {
                DBContext.Context.SaveChanges();
                MessageBox.Show("Данные успешно сохранены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Deletbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить данную запись?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DBContext.Context.Agent.Remove(agent);
                    DBContext.Context.SaveChanges();
                    MessageBox.Show("Данные успешно удалены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult= DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
    }
}
