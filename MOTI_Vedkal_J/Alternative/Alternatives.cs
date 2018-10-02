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
    public partial class Alternatives : Form
    {
        private DBContext _context;
        public Alternatives()
        {
            InitializeComponent();
            _context = new DBContext();
            var alternativesNames = from f in _context.Alternatives
                                    select f.Name;
            AlternativesCB.Items.AddRange(alternativesNames.ToArray());

        }

        private void AlternativesCB_TextChanged(object sender, EventArgs e)
        {
            var choosenAlternative = AlternativesCB.Text;
            var alternative = _context.Alternatives.SingleOrDefault(f => f.Name == choosenAlternative);
            if (alternative != null)
            {
                DataTable table = new DataTable();
                var columnNames = from f in alternative.Vectors
                                  select new DataColumn(f.Mark.Criterion.Name);
                table.Columns.AddRange(columnNames.ToArray());

                var columnValues = from f in alternative.Vectors
                                   select f.Mark.Name;
                table.Rows[0].ItemArray = columnValues.ToArray();

            }
        }
    }
}
