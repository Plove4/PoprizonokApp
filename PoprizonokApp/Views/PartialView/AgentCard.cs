using PoprizonokApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoprizonokApp.Views.PartialView
{
    public partial class AgentCard : UserControl
    {
        public AgentCard()
        {
            InitializeComponent();
        }

        public void GenerateDateAgentCard(Agent agent)
        {
            if(agent.Logo != String.Empty)
            AgentpictureBox.ImageLocation = agent.Logo.Remove(0,1);
            TitleandTypeAgentLbl.Text = agent.AgentType.Title.ToString() + " | " + agent.Title.ToString();
            AgetPhoneLbl.Text = agent.Phone.ToString();
            AgentPriorityLbl.Text = "Приоритетность: " + agent.Priority.ToString();
            int qty = 0;
            foreach (ProductSale sale in agent.ProductSale)
            {
                if (sale.SaleDate.Year == 2019)
                {
                    qty += sale.ProductCount;
                }
            }
            SaleLbl.Text = qty.ToString() + " продаж за год";
            AgentDiscountLbl.Text = agent.AgentDiscount.ToString() + "%";
            if(agent.AgentDiscount > 25)
            AgentDiscountLbl.BackColor = Color.LightGreen;
            IDLbl.Text = agent.ID.ToString();
        }
    }
}
