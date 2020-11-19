using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Practica_1811
{
    public partial class Form_Principal : Form
    {
        public delegate void Delegado(string cadena);
        public delegate void Delegado2(int valor);
        public event Delegado PasarTexto;
         
        Form_Secundario secundario = new Form_Secundario();
        Thread hilo;

        public Form_Principal()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_EnviarTexto_Click(object sender, EventArgs e)
        {
            string a = CuadroTexto.Text;
            secundario.Ejecutar(a);
        }

        public void Metodo(string dato)
        {      
            Form_Principal principal = new Form_Principal();
            principal.PasarTexto += new Form_Principal.Delegado(secundario.Ejecutar);
        }

        private void btn_CargarForm_Click(object sender, EventArgs e)
        {
            hilo = new Thread(Hilo);
            hilo.Start();

        }

        public void Hilo()
        {
            for(int i=BarraProgreso.Value; i<=BarraProgreso.Maximum; i++)
            {
                Delegado2 segundo = new Delegado2(Actualizar);
                this.Invoke(segundo, new object[] { i });
                Thread.Sleep(40);

                if (i == BarraProgreso.Maximum)
                {
                    MessageBox.Show("Abriendo form 2");
                    secundario.ShowDialog();
                }
   
            }

        }

        public void Actualizar(int valor)
        {
            BarraProgreso.Value = valor;
        }


    }
}