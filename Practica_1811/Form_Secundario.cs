using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1811
{
    public partial class Form_Secundario : Form
    {
        
        public Form_Secundario()
        {
            InitializeComponent();
        }

        public void Ejecutar(string dato)
        {
            Texto_Recibido.Text = dato;
        }

    }
}