using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_entradas
{
    public partial class Form3 : Form
    {
        // construtor
        public Form3(string mensagem)
        {
            InitializeComponent();
            lb_mensagem.Text = mensagem;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
