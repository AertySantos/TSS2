using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho2
{
    class Elevador
    {
        private bool modo;//automatico ou manual
        private int andar;//onde esta o elevador
        public Elevador()
        {

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
