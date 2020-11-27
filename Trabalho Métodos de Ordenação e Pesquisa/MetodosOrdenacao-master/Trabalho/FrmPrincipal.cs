using MetodosOrdenacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public List<int> ListaInteiros { get; set; }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (ListaInteiros.Count == 0) return;
            int tag = 0;
            foreach(Control r in groupBox1.Controls)
            {
                if( r is RadioButton && ((RadioButton)r).Checked)
                {
                    tag = int.Parse(r.Tag.ToString());
                }
            }

            switch(tag)
            {
                case 1: SelectSort.Sort(ListaInteiros); break;
                case 2: BubbleSort.Sort(ListaInteiros); break;
                case 3: QuickSort.Sort(ListaInteiros);  break;
                case 4: ShellSort.Sort(ListaInteiros);  break;
                case 5: ListaInteiros = MergeSortC.MergeSorted(ListaInteiros.ToArray());break;
            }

            CarregaGrid();
            btnOrdenar.Enabled = false;

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string caminho = caminho = openFileDialog1.FileName;
            openFileDialog1.Dispose();

            ListaInteiros = new List<int>();


            string line;

            StreamReader file = new StreamReader(caminho);

            while ((line = file.ReadLine()) != null)
            {
                ListaInteiros.Add(int.Parse(line));
            }

            CarregaGrid();
        }

        private void CarregaGrid()
        {
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = ListaInteiros.Count;
            
            for(int i = 0; i < ListaInteiros.Count; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = ListaInteiros[i];
            }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            var frm = new FrmComparacao();
            frm.Show();
        
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string caminho = caminho = openFileDialog1.FileName;
            openFileDialog1.Dispose();

            ListaInteiros = new List<int>();


            string line;

            StreamReader file = new StreamReader(caminho);

            while ((line = file.ReadLine()) != null)
            {
                ListaInteiros.Add(int.Parse(line));
            }

            CarregaGrid();
            btnOrdenar.Enabled = true;
        }

        private void validaçãoDeAlgoritimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmComparacao();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }
    }
}
