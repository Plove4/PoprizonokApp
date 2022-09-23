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
        public AddEditAgentForm()
        {
            InitializeComponent();
        }

        private void AddEditAgentForm_Load(object sender, EventArgs e)
        {
            agentTypeBindingSource.DataSource = DBContext.Context.AgentType.ToList();
            foreach (AgentCard agentcart in MainForm.SelectedagentCards)
            {
                Agent agent = DBContext.Context.Agent.First(p => p.ID.ToString() == agentcart.IDLbl.Text);
                agentBindingSource.DataSource = agent;
            }
        }
    }
}
