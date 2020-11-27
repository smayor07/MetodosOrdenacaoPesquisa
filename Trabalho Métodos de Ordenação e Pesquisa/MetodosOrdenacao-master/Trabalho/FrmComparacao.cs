using MetodosOrdenacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class FrmComparacao : Form
    {
        public FrmComparacao()
        {
            InitializeComponent();
            Lista = new List<int>();
        }
        private bool JaGerou { get; set; }
        private bool Ordenado { get; set; }

        private List<int> ListaAuxiliar { get; set; }

        private List<int> Lista { get; set; }

        int C = 0;

        private void GeraNumeros()
        {
            var r = new Random();
            o = int.Parse(numericUpDown1.Value.ToString());
            if (o <= 0) return;
            dataGridView1.ColumnCount = o;

            dataGridView1.RowCount = o;
            for (int i = 0; i < o; i++)
            {
                for (int j = 0; j < o; j++)
                {
                    Lista.Add(r.Next(1, 1000));
                }
            }
            CarregaGrid(Lista);
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            GeraNumeros();
            if (o <= 0) return;
            btGerar.Enabled = false;
            VerificaBloqueiaCalcular();
        }
        private int o { get; set; }

        private void VerificaBloqueiaCalcular()
        {
            if (!JaGerou || Ordenado)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;

            }


        }

        private void FrmComparacao_Load(object sender, EventArgs e)
        {
            JaGerou = false;
            btnDesord.Enabled = button1.Enabled = false;
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            Ordenado = true;
            ListaAuxiliar = new List<int>(Lista);
            var t1 = DateTime.Now;
            SelectSort.Sort(ListaAuxiliar);
            var t2 = DateTime.Now;
            label1.Text = "Select Sort  " + (t2 - t1).Milliseconds.ToString() + " ms";
            CarregaGrid(ListaAuxiliar);
            VerificaBloqueiaCalcular();
            btnDesord.Enabled = true;
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            Ordenado = true;
            ListaAuxiliar = new List<int>(Lista);
            var t1 = DateTime.Now;
            QuickSort.Sort(ListaAuxiliar);
            var t2 = DateTime.Now;
            label3.Text = "Quick Sort  " + (t2 - t1).Milliseconds.ToString() + " ms";
            CarregaGrid(ListaAuxiliar);
            VerificaBloqueiaCalcular();
            btnDesord.Enabled = true;
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            Ordenado = true;
            ListaAuxiliar = new List<int>(Lista);
            var t1 = DateTime.Now;
            BubbleSort.Sort(ListaAuxiliar);
            var t2 = DateTime.Now;
            label2.Text = "Bubble Sort  " + (t2 - t1).Milliseconds.ToString() + " ms";
            CarregaGrid(ListaAuxiliar);
            VerificaBloqueiaCalcular();
            btnDesord.Enabled = true;
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            Ordenado = true;
            ListaAuxiliar = new List<int>(Lista);
            var t1 = DateTime.Now;
            ShellSort.Sort(ListaAuxiliar);
            var t2 = DateTime.Now;
            label4.Text = "Shell Sort  " + (t2 - t1).Milliseconds.ToString() + " ms";
            CarregaGrid(ListaAuxiliar);
            VerificaBloqueiaCalcular();
            btnDesord.Enabled = true;

        }

        private void btnDesord_Click(object sender, EventArgs e)
        {
            Ordenado = false;

            CarregaGrid(Lista);
            VerificaBloqueiaCalcular();
            btnDesord.Enabled = false;

        }

        private void CarregaGrid(List<int> Lista)
        {
            int z = 0;
            for (int i = 0; i < o; i++)
            {
                for (int j = 0; j < o; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Lista[z++];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Ordenado = true;
                ListaAuxiliar = new List<int>(Lista);
                var t1 = DateTime.Now;
                SelectSort.Sort(ListaAuxiliar);
                var t2 = DateTime.Now;
                label1.Text = "Select Sort  " + (t2 - t1).Milliseconds.ToString() + " ms";
                CarregaGrid(ListaAuxiliar);
                VerificaBloqueiaCalcular();
                btnDesord.Enabled = true;
                radioButton1.Enabled = false;
                C++;
            }
            else if (radioButton2.Checked)
            {
                Ordenado = true;
                ListaAuxiliar = new List<int>(Lista);
                var t1 = DateTime.Now;
                BubbleSort.Sort(ListaAuxiliar);
                var t2 = DateTime.Now;
                label2.Text = "Bubble Sort  " + (t2 - t1).Milliseconds.ToString() + " ms";
                CarregaGrid(ListaAuxiliar);
                VerificaBloqueiaCalcular();
                btnDesord.Enabled = true;
                radioButton2.Enabled = false;
                C++;
            }
            else if (radioButton3.Checked)
            {
                Ordenado = true;
                ListaAuxiliar = new List<int>(Lista);
                var t1 = DateTime.Now;
                QuickSort.Sort(ListaAuxiliar);
                var t2 = DateTime.Now;
                label3.Text = "Quick Sort  " + (t2 - t1).Milliseconds.ToString() + " ms";
                CarregaGrid(ListaAuxiliar);
                VerificaBloqueiaCalcular();
                btnDesord.Enabled = true;
                radioButton3.Enabled = false;
                C++;
            }
            else if (radioButton4.Checked)
            {
                Ordenado = true;
                ListaAuxiliar = new List<int>(Lista);
                var t1 = DateTime.Now;
                ShellSort.Sort(ListaAuxiliar);
                var t2 = DateTime.Now;
                label4.Text = "Shell Sort  " + (t2 - t1).Milliseconds.ToString() + " ms";
                CarregaGrid(ListaAuxiliar);
                VerificaBloqueiaCalcular();
                btnDesord.Enabled = true;
                radioButton4.Enabled = false;
                C++;
            }
            else if (radioButton5.Checked)
            {
                Ordenado = true;
                ListaAuxiliar = new List<int>(Lista);
                var t1 = DateTime.Now;
                ListaAuxiliar = MergeSortC.MergeSorted(ListaAuxiliar.ToArray());
                var t2 = DateTime.Now;
                label6.Text = "Merge Sort  " + (t2 - t1).Milliseconds.ToString() + " ms";
                CarregaGrid(ListaAuxiliar);
                VerificaBloqueiaCalcular();
                btnDesord.Enabled = true;
                radioButton5.Enabled = false;
                C++;
            }

            if (!(radioButton1.Enabled && radioButton2.Enabled && radioButton3.Enabled && radioButton4.Enabled))
                button1.Enabled = false;
            if (C == 4)
                btnSair.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}

