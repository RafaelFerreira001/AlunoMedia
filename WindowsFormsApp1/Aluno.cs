using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Aluno
    {
        public string RA;
        public string Nome;
        public double n1;
        public double n2;
        public double n3;
        public double n4;
        public double media;
        public string situacao;


        public void CalcMedia()
        {

            this.media = ((this.n1 * 2) + (this.n2 * 3) + (this.n3 * 2) + (this.n4 * 3)) / 10;

        }



        public void defSituacao()
        {
            if (this.media < 4)
            {
                this.situacao = "reprovado";

            }
            else if (this.media < 6)
            {
                this.situacao = "recuperação";

            }
            else
            {
                this.situacao = "Aprovado";
            }
        }


    }
}