using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liebre_y_Tortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Carrera leonardo = new Tortuga();//De las tortugas Ninja
        Carrera bugsBunny = new Liebre();//no es una liebre, pero se me vino a la mente
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            string cadTortuga = "";
            string cadLiebre = "";
            int y = 0;
            int x = 0;
            while(leonardo.posision < 80 && bugsBunny.posision < 80)//mientras tortuga y liebre sean menores a 80 se ejecutara la accion
            {
                leonardo.posision += leonardo.Run();//activa Run de la clase Carrera, pero de su propia clase, en este caso, tortuga, se modifica por lo que esta escrita en su clase
                bugsBunny.posision += bugsBunny.Run();//lo mismo de arriba
                cadTortuga += x++ + "----" + leonardo.posision + "\r\n";
                cadLiebre += y++ + "----" + bugsBunny.posision + "\r\n";
            }
            textBox1.Text = cadTortuga; //imprime todo en la txt de tortuga
            textBox2.Text = cadLiebre; //imprime tod en la txt de liebre

            if (leonardo.posision >= 80 && bugsBunny.posision < 80)//si la posision de tortuga llega primero a 80
                lblWinner.Text = "Gana la Tortuga";
            else if (leonardo.posision >= 80 && bugsBunny.posision >= 80)//si tortuga y liebre llegaron o pasaron 80
                lblWinner.Text = "DRAW";
            else//de lo contrario a estas
                lblWinner.Text = "Gana la Liebre";

        }
    }
}
