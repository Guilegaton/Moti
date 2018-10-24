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

namespace MOTI_Vedkal_J.Alternative
{
    public partial class Create : Form
    {
        private DBContext _conetxt;
        private List<Criterion> _criterias;
        private int _index;
        private DataTypeForCriteria _type;

        public Create()
        {
            InitializeComponent();
            _conetxt = new DBContext();
            _criterias = _conetxt.Criteria.ToList();
            _index = 0;
            SetValueType();
        }

        private void SetValueType()
        {
            if(_criterias[_index].EdIzmer == DataTypeForCriteria.Flag.ToString())
            {
                ValueCHB.Visible = true;
                _type = DataTypeForCriteria.Flag;
            }
            else if(_criterias[_index].EdIzmer == DataTypeForCriteria.Number.ToString())
            {
                ValueNUM.Visible = true;
                _type = DataTypeForCriteria.Number;
            }
            else if(_criterias[_index].EdIzmer == DataTypeForCriteria.Text.ToString())
            {
                ValueTB.Visible = true;
                _type = DataTypeForCriteria.Text;
            }
            if(_index + 1 == _criterias.Count)
            {
                NextBTN.Text = "End";
            }
        }

        private void NextBTN_Click(object sender, EventArgs e)
        {
            switch (_type)
            {
                case DataTypeForCriteria.Text:
                    var mark = new Mark() {
                        n
                    }
                    break;
                case DataTypeForCriteria.Flag:
                    break;
                case DataTypeForCriteria.Number:
                    break;
            }
        }
    }
}
