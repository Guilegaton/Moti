using AutoCodeSecond;
using MOTI_Vedkal_J.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOTI_Vedkal_J
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpBTN_Click(object sender, EventArgs e)
        {
            var login = LoginTB.Text;
            using (DBContext context = new DBContext())
            {
                if(!string.IsNullOrEmpty(login) && !context.LPRs.Any(f => f.Name == login))
                {
                    ErrorLB.Text = string.Empty;
                    context.LPRs.Add(new LPR() { Name = login });
                    context.SaveChanges();
                    var user = context.LPRs.SingleOrDefault(f => f.Name == login);
                    if(user != null)
                    {
                        Session.USER = user;
                    }
                }
                else if(context.LPRs.Any(f => f.Name == login))
                {
                    ErrorLB.Text = "*User with the same login are exist!";
                }
                else
                {
                    ErrorLB.Text = "*Incorrect login";
                }
            }
        }

        private void SignInBTN_Click(object sender, EventArgs e)
        {
            var login = LoginTB.Text;
            using (DBContext context = new DBContext())
            {
                var user = context.LPRs.SingleOrDefault(f => f.Name == login);
                if (!string.IsNullOrEmpty(login) && user != null)
                {
                    ErrorLB.Text = string.Empty;
                    Session.USER = user;
                }
                else if (context.LPRs.Any(f => f.Name == login))
                {
                    ErrorLB.Text = "*User with the same login are exist!";
                }
                else
                {
                    ErrorLB.Text = "*Incorrect login";
                }
            }
        }
    }
}
