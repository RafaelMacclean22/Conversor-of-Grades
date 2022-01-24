using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_of_Grades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas Seguro que quieres salir?", "Medidas",
               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Resolver() {

            if (txtIngreso.Text != "")
            {
                double dato = Convert.ToDouble(txtIngreso.Text);

                int Tipo1 = cbTipodeTemp.SelectedIndex;
                int Tipo2 = cbTipoAConvertir.SelectedIndex;   
                
                /* 
                                                               
                                                                 Celsius      = 0
                                                                 Fahrenheit   = 1
                                                                 Kelvin       = 2

                                                               */

                switch (Tipo1)
                {
                    case 0:

                        if (Tipo2 == 0) txtResult.Text = dato.ToString();


                        if (Tipo2 == 1) txtResult.Text = (dato * 1.8 + 32).ToString() ;


                        if (Tipo2 == 2) txtResult.Text = (dato +273.15).ToString();

                    break;

                    case 1:

                        if (Tipo2 == 0) txtResult.Text =((dato - 32) /  1.8).ToString();


                        if (Tipo2 == 1) txtResult.Text = dato.ToString();


                        if (Tipo2 == 2) txtResult.Text = (((dato - 32) / 1.8) + 273.15).ToString();
                 

                        break;

                    case 2:

                        if (Tipo2 == 0) txtResult.Text = (dato - 273.15).ToString();


                        if (Tipo2 == 1) txtResult.Text = ((dato - 273.15) * 1.8 + 32).ToString();


                        if (Tipo2 == 2) txtResult.Text = dato.ToString();
          

                        break;

                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Resolver();
        }

        private void txtIngreso_TextChanged(object sender, EventArgs e)
        {
            Resolver();
        }

        private void cbTipodeTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resolver();
        }

        private void cbTipoAConvertir_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resolver();
        }
    }
}
