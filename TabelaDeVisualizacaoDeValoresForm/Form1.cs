using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaDeVisualizacaoDeValoresForm.Model;

namespace TabelaDeVisualizacaoDeValoresForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Contrac> listContracs = new List<Contrac>();
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            listContracs.Add(new Contrac()
            {
                Id = listContracs.Count,
                Value = new Random().Next(100),
                DatInc = DateTime.Now
            });

            BlindList();
        }
        private void BlindList()
        {
            var newList = new List<Contrac>();

            foreach (Contrac item in listContracs)
                newList.Add(new Contrac()
                {
                    Id = item.Id,
                    Value = item.Value,
                    DatInc = item.DatInc
                });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listContracs;

        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                var collumId = dataGridView1.Rows[e.RowIndex].Cells[0];
                var collValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                switch (e.ColumnIndex)
                {
                    case 0: {
                               MessageBox.Show("Não é possivel ajustar esta coluna.");           
                            } break;
                    case 1:
                        { 
                            #region First Column
                            if (MessageBox.Show("Deseja realmente ajustar este valor?"
                                               , "Edição"
                                               , MessageBoxButtons.YesNo
                                               , MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                listContracs.FirstOrDefault(x =>
                                x.Id == (int)collumId.Value).Value = (int)collValue.Value;
                                }
                            #endregion
                        } break;
                    case 2: {
                            #region Second Column
                            var dialogResult = MessageBox.Show("Deseja realmente ajustar este valor?"
                                                  , "Edição"
                                                  , MessageBoxButtons.YesNo
                                                  , MessageBoxIcon.Question);
                                if (dialogResult == DialogResult.Yes)
                            {
                                var dataInformada = DateTime.Parse(collValue.Value.ToString());
                                if (dataInformada <= DateTime.Now)
                                    listContracs.FirstOrDefault(x =>
                                    x.Id == (int)collumId.Value).DatInc = DateTime.Parse(collValue.Value.ToString());
                                else
                                    MessageBox.Show("Não foi possivel alterar o registro da data");   
                                
                            }else if (dialogResult == DialogResult.No)
                            {
                                //TODO: Codigo para quando o mesmo não realizar a operação corretamente
                            }
                            #endregion
                        } break;
                }
            }
            BlindList();
        }
    }
}
