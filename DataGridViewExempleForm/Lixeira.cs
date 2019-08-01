using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExempleForm
{
    public partial class Lixeira : Form
    {
        public Lixeira()
        {
            InitializeComponent();
        }

        private void Lixeira_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            this.dataTable1TableAdapter.GetAllData(this.querysInnerJoinDataSet1.DataTable1);
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Carros'. Você pode movê-la ou removê-la conforme necessário.
           
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lixeiraGlobal = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExempleForm.QuerysInnerJoinDataSet1.DataTable1Row;

                switch (lixeiraGlobal.Tabela)
               {
                  
                case "carros":
                       {
                         this.carrosTableAdapter1.UpdateQuery(lixeiraGlobal.Id);
                       }
                       break;
                case "marcas":
                    {
                        this.marcasTableAdapter1.UpdateQuery(lixeiraGlobal.Id);
                    }
                    break;
                case "usuarios":
                    {
                        this.usuariosTableAdapter1.UpdateQuery(lixeiraGlobal.Id);
                    }
                    break;
                case "vendas":
                    {
                        this.vendasTableAdapter1.UpdateQuery(lixeiraGlobal.Id);
                    }
                    break;

                }
           this.carrosTableAdapter1.CostumInativeValues(this.querysInnerJoinDataSet1.Carros);

        }
    }
}
