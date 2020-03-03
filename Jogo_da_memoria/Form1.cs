using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_memoria
{
    public partial class Form1 : Form
    {
        //Inicia um objeto pque sera utilizado para escolher entre os incones aleatorios.
        Random random = new Random();

        //Lista para armazenar os incones aleatorios
        //Cada caracteres representa um incone diferente (na fonte Webdings)
        //Há um par de cada
        List<string> icones = new List<string>() 
        {
         "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
        };

        //Uma função para atribuir os incones aleatorios aos 16 label's
        private void AtribuirIcones()
        {
            //Para cada um dos controles inseridos no layout(4x4) ele irá fazer uma ação
            foreach (Control control in tlpJogo.Controls)
            {
                Label iconeLabel = control as Label; //Define o control como Label 
                if (iconeLabel != null) //Verifica se a atribuoção acima ocorreu
                {
                    int randomNumber = random.Next(icones.Count); //Seleciona um numero inteiro entre 1 em icones.Count(16 no caso)
                    iconeLabel.Text = icones[randomNumber]; //Atribui ele à um icone
                    // iconLabel.ForeColor = iconLabel.BackColor; //Coloca sua cor igual a do label, para que o usuario não veja.
                    icones.RemoveAt(randomNumber); //O retira da lista, para que não se repita.
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            AtribuirIcones(); //Atribui os icones aleatorios no entrypoint da aplicação
        }


    }
}
