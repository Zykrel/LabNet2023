using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practica_1_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void enviar_button_Click(object sender, EventArgs e)
        {
         decimal  taxi1 = taxi_1.Value, taxi2 = taxi_2.Value, taxi3 = taxi_3.Value, taxi4 = taxi_4.Value, taxi5 = taxi_5.Value;
         decimal omnibus1 = omnibus_1.Value, omnibus2 = omnibus_2.Value, omnibus3 = omnibus_3.Value, omnibus4 = omnibus_4.Value, omnibus5 = omnibus_5.Value;
            string mensaje = "";

            List<TransportePublico> pasajeros = new List<TransportePublico>
            {
                new Omnibus((int)omnibus1),
                new Omnibus((int)omnibus2),
                new Omnibus((int)omnibus3),
                new Omnibus((int)omnibus4),
                new Omnibus((int)omnibus5),

                new Taxi((int)taxi1),
                new Taxi((int)taxi2),
                new Taxi((int)taxi3),
                new Taxi((int)taxi4),
                new Taxi((int)taxi5)


            };

            foreach (var item in pasajeros)
            {
                mensaje = mensaje + item.Mostrar() + "\n";
            }

            MessageBox.Show(mensaje);
        }

        private void limpiar_button_Click(object sender, EventArgs e)
        {
            taxi_1.Value = 0; taxi_2.Value = 0; taxi_3.Value = 0; taxi_4.Value = 0; taxi_5.Value = 0;
            omnibus_1.Value = 0; omnibus_2.Value = 0; omnibus_3.Value = 0; omnibus_4.Value = 0; omnibus_5.Value = 0;
        }
    }
}
