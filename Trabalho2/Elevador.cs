using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho2
{
    class Elevador
    {
        private bool modo;//automatico ou manual
        private int andar;//onde esta o elevador

        List<Botao> bt = new List<Botao>();//lista de botoes

        public Elevador(int num, bool md, int a)
        {

            this.modo = md;
            this.andar = a;
            Botao bts = new Botao();
            int num2 = num;

            while(num2 > 0)
            {
                bt.Add(bts);//gera uma lista de botoes
                num--;
            }
            
        }

        public void SetModo(bool m)
        {
            this.modo = m;
        }

        public void SetAndar(int a)
        {
            this.andar = a;
        }

        public bool GetModo()
        {
            return this.modo;
        }

        public int GetAndar()
        {
            return this.andar;
        }

    }
}
