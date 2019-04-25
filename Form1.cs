using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2
{
    public partial class Form1 : Form
    {
        private MessageBoxButtons tipoDeBoton = MessageBoxButtons.OK;
        public Form1()
        {
            InitializeComponent();
        }

        private void tipodeBoton_CheckedChange(object sender, EventArgs e)
        {
            if (sender == radioButton1)
                tipoDeBoton = MessageBoxButtons.OK;
            else if (sender == radioButton2)
                tipoDeBoton = MessageBoxButtons.OKCancel;
            else if (sender == radioButton3)
                tipoDeBoton = MessageBoxButtons.YesNo;
            else if (sender == radioButton4)
                tipoDeBoton = MessageBoxButtons.YesNoCancel;
            else if (sender == radioButton5)
                tipoDeBoton = MessageBoxButtons.RetryCancel;
            else
                tipoDeBoton = MessageBoxButtons.AbortRetryIgnore;

    
        }private MessageBoxIcon tipoDelIcono = MessageBoxIcon.Error;

        private void tipoDelIncono_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButton7)//display error icon
                tipoDelIcono = MessageBoxIcon.Information;
            else if (sender == radioButton8)
                tipoDelIcono = MessageBoxIcon.Exclamation;
            else if (sender == radioButton9)
                tipoDelIcono = MessageBoxIcon.Question;
            else
                tipoDelIcono = MessageBoxIcon.Error;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Mensaje a desplegar", "Titulo de la ventana", tipoDeBoton, tipoDelIcono);

            switch (result)
            {
                case DialogResult.OK: label2.Text = "Slecciono ok.";
                    break;
                case DialogResult.Cancel: label2.Text = "Selecciono Yes";
                    break;
                case DialogResult.No:  label2.Text = "Selecciono Ignore";
                    break;
                case DialogResult.Abort: label2.Text = "Selecciono Abort";
                    break;
                case DialogResult.Retry: label2.Text = "Selecciono Retry";
                    break;
            }
                
        }
    }
}
