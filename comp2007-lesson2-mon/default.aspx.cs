using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace comp2007_lesson2_mon
{
    public partial class _default : System.Web.UI.Page
    {
        public int x;

        protected void Page_Load(object sender, EventArgs e)
        {
            //add code here
            //only increment x if being reloaded
            if(!IsPostBack)
            {
                x = 0;
                x++;
                lblX.Text = x.ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //get current count of x from label
            x=Convert.ToInt32(lblX.Text);
            x++;

            //increment the lael value by 1 or write x back to the label
            lblX.Text = x.ToString();

            //copy value here
            lblFirstname.Text = txtFirstname.Text;

            //also copy to literal
            ltlFirstname.Text = txtFirstname.Text;

            //remove from textox
            txtFirstname.Text = "";
        }

        protected void btnSelections_Click(object sender, EventArgs e)
        {
            //show the selected countries in the literal control
            ltlFirstname.Text = ddlCountry.SelectedValue + " " + ddlCountry.SelectedItem.Text;

            //first clear literal for toppings
            ltlToppings.Text = "";
            //loop through the toppings and print out selected toppings
            foreach(ListItem item in cblToppings.Items)
            {
                if(item.Selected)
                {
                    ltlToppings.Text += item.Text + " ";
                }
            }
        }
    }
}