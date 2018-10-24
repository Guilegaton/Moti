using AutoCodeSecond;
using MOTI_Vedkal_J.Models;
using MOTI_Vedkal_J.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOTI_Vedkal_J.Criteria
{
    public partial class AddCriteria : Form
    {
        

        public AddCriteria()
        {
            InitializeComponent();
            TypeCB.DataSource = new List<string>() { DataTypeForCriteria.Flag.ToString(), DataTypeForCriteria.Number.ToString(), DataTypeForCriteria.Text.ToString() };
            TypeCB.SelectedIndex = 1;
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            ErrorLB.Text = string.Empty;
            if (!string.IsNullOrEmpty(NameLB.Text) && !string.IsNullOrEmpty(TypeCB.Text) && !string.IsNullOrEmpty(UnitTB.Text))
            {
                using (var context = new DBContext())
                {
                    var newCriteria = new Criterion() {
                        Name = NameTB.Text,
                        Type = TypeCB.Text,
                        EdIzmer = UnitTB.Text
                    };
                    if(!context.Criteria.Any(f => f.Name == NameTB.Text))
                    {
                        context.Criteria.Add(newCriteria);
                        context.SaveChanges();
                        Close();
                    }
                    else
                    {
                        ErrorLB.Text = "Current criteria are exist";
                    }
                }
            }
            else
            {
                ErrorLB.Text = "IncorrectData";
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
