using Interface3.Entities;
using Interface3.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Contract = int.Parse(txtNumber.Text);
                DateTime ContractDate = dtmPayment.Value;
                double Value = Convert.ToDouble(txtValue.Text);
                int Ins = Convert.ToInt32(cbInstallments.Text);
                
                DataContract dataContract = new DataContract(Contract, ContractDate);
                ResultValue resultValue = new ResultValue(Value, Ins);
                ReciboService reciboService = new ReciboService(new JurosSimplesService());

                /// ListView das Parcelas
                for (var i = 0; i < Ins; i++)// Linhas
                {
                    ListViewItem newList = new ListViewItem(Convert.ToString(Contract));
                        
                    newList.SubItems.Add(Convert.ToString(ContractDate.AddMonths(i)));
                    newList.SubItems.Add(Convert.ToString(Value));
                    newList.SubItems.Add(Convert.ToString(reciboService.JurosValue(resultValue)[i].ToString()));
                    listValueInstallments.Items.Add(newList);
                }
            }
            catch (Exception erro) {
                MessageBox.Show(erro.ToString() + " Um erro ocorreu, Talvez voçê não tenha digitado algum dado ou digitou algum com o Tipo incorreto, favor verificar...");
            }
        }
    }
}