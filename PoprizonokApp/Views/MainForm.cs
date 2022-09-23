using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoprizonokApp.Models;
using PoprizonokApp.Utilities;
using PoprizonokApp.Views.PartialView;
using PoprizonokApp.Views;

namespace PoprizonokApp
{
    public partial class MainForm : Form
    {
        public static List<Agent> agents = new List<Agent>();
        public static List<AgentCard> SelectedagentCards = new List<AgentCard>();
        public MainForm()
        {
            InitializeComponent();
            agents = DBContext.Context.Agent.ToList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GenerateAgentCartList(agents);
            var allType = DBContext.Context.AgentType.Select(a => a.Title.ToString()).ToList();
            allType.Insert(0, "Все типы");
            FiltrComboBox.DataSource = allType;
            FiltrComboBox.SelectedIndex = 0;
            SortComboBox.SelectedIndex = 0;
            FilteredCart();
        }

        private void GenerateAgentCartList (List<Agent> agent)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Agent a in agent)
            {
                AgentCard card = new AgentCard();
                card.GenerateDateAgentCard(a);
                flowLayoutPanel1.Controls.Add(card);

                card.DoubleClick += Card_DoubleClick;
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            AgentCard card = sender as AgentCard;
            SelectedagentCards.Add(card);
            AddEditAgentForm agentForm = new AddEditAgentForm();
            DialogResult result = agentForm.ShowDialog();

        }

        private void FilteredCart()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Agent> updatecart = DBContext.Context.Agent.ToList();

            if (!string.IsNullOrEmpty(SearchTextBox.Text) && SearchTextBox.Text != "Введите для поиска:")
            {
                updatecart = updatecart.Where(p => p.Title.ToLower().Contains(SearchTextBox.Text.ToLower())
                || p.Phone.Contains(SearchTextBox.Text.ToString())
                || p.Email.Contains(SearchTextBox.Text.ToString())
                ).ToList();
            }
            if (FiltrComboBox.SelectedIndex > 0)
            {
                updatecart = updatecart.Where(p => p.AgentType.Title == FiltrComboBox.Text.ToString()).ToList();
            }
            switch (SortComboBox.SelectedIndex)
            {
                case 1:
                    if (checkBox1.Checked)
                        updatecart = updatecart.OrderBy(p => p.Title).ToList();
                    else
                        updatecart = updatecart.OrderByDescending(p => p.Title).ToList();
                    break;
                case 2:
                    if (checkBox1.Checked)
                        updatecart = updatecart.OrderBy(p => p.AgentDiscount).ToList();
                    else
                        updatecart=updatecart.OrderByDescending(p => p.AgentDiscount).ToList();
                    break;
                case 3:
                    if (checkBox1.Checked)
                        updatecart = updatecart.OrderBy(p => p.Priority).ToList();
                    else
                       updatecart = updatecart.OrderByDescending(p => p.Priority).ToList();
                    break;
            }

            GenerateAgentCartList (updatecart);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "Введите для поиска:" && !string.IsNullOrEmpty(SearchTextBox.Text))
            FilteredCart();
        }

        private void FiltrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilteredCart();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilteredCart();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(SortComboBox.SelectedIndex != 0)
            FilteredCart();
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if(SearchTextBox.Text == "Введите для поиска:")
            {
                SearchTextBox.Text = String.Empty;
                SearchTextBox.ForeColor = Color.Black;
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if(SearchTextBox.Text == String.Empty)
            {
                SearchTextBox.Text = "Введите для поиска:";
                SearchTextBox.ForeColor = Color.Gainsboro;
            }
        }
    }
}
