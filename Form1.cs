using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_RAº6322036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Consumo> list_Consumo = new List<Consumo>();

        private void limpar()
        {
            txt_Cliente.Text = null;
            txt_Quarto.Text = null;
            txt_Frigobar.Text = null;
            txt_Restaurante.Text = null;
        }
        
        

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Consumo obj_Consumo = new Consumo();

            obj_Consumo.Cliente = txt_Cliente.Text;
            obj_Consumo.Quarto = txt_Quarto.Text;
            obj_Consumo.Frigobar = double.Parse(txt_Frigobar.Text);
            obj_Consumo.Restaurante = double.Parse(txt_Frigobar.Text);

            list_Consumo.Add(obj_Consumo);

            limpar();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            int encontrar = 0;

            for (int i = 0; i < list_Consumo.Count; i++)
            {
                if (txt_Cliente.Text.Equals(list_Consumo[i].Cliente))
                { 
                    txt_Quarto.Text = list_Consumo[i].Quarto;
                    txt_Frigobar.Text =  list_Consumo[i].Frigobar.ToString();
                    txt_Restaurante.Text = list_Consumo[i].Restaurante.ToString();

                    encontrar = 1;
                    break;
                }
            }
            if (encontrar == 0)
            {
                MessageBox.Show("Cliente não encontrado!");

                limpar();
            }
        }
    }
}
