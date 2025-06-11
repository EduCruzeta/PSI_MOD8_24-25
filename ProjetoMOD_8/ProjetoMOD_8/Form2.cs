using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMOD_8
{
    public partial class Form2 : Form
    {
        List<string> pedidosRecebidos;

        // função para calcular o total de cada pedido

        private void CalcularTotal(string mesa)
        {
            float total = 0;
            float precofloat = 0;

            foreach (string pedido in pedidosRecebidos)
            {
                if (pedido.StartsWith(mesa))
                {
                    // "Mesa 3 - Pizza - 5.00"
                    // Dividir por partes " - " para obter as partes
                    string[] partespedido = pedido.Split(" | ");

                    for (int i = 1; i < partespedido.Length + 1; i++)
                    {
                        string[] partes = partespedido[i - 1].Split(" - ");
                        if (partes.Length == 3)
                        {
                            string preco = partes[2]; // "5.00"

                            float.TryParse(preco, out precofloat);
                            total += precofloat;
                        }
                    }
                }
            }

            TB_total.Text = total.ToString("C2"); // colocar moeda €
        }
        public Form2(List<string> listaPedidos)
        {
            InitializeComponent();
            pedidosRecebidos = listaPedidos;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_pedidos.Items.Clear();
            string mesaSelecionada = CB_mesas.Text;

            foreach (string pedido in pedidosRecebidos)
            {
                if (pedido.StartsWith(mesaSelecionada))
                {
                    string[] partespedido = pedido.Split(" | ");

                    for (int i = 1; i < partespedido.Length + 1; i++)
                    {
                        string[] partes = partespedido[i - 1].Split(" - ");
                        if (partes.Length == 3)
                        {

                            string mostarPedido = $"{partes[1]} - {partes[2]}€";

                            LB_pedidos.Items.Add(mostarPedido);
                        }
                    }
                }
            }

            CalcularTotal(mesaSelecionada);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splashscreen mostrar = new splashscreen();

            if (CB_mesas.Text == "")
            {
                MessageBox.Show("Selecione uma mesa.");
                return;
            }

            string mesaSelecionada = CB_mesas.Text;

            for (int i = pedidosRecebidos.Count - 1; i >= 0; i--)
            {
                if (pedidosRecebidos[i].Contains(mesaSelecionada))
                {
                    pedidosRecebidos.RemoveAt(i);
                }

            }

            LB_pedidos.Items.Clear();

            TB_total.Text = "0,00€";

            mostrar.ShowDialog();
                
            









        }
    }
}
