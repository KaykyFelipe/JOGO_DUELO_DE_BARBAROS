using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoBarbaro
{
    internal class Barbaro
    {

        public string nome = "Desconhecido";
        public int vida = 34, energia = 10, maxVida = 34, maxEnergia = 10, nivel = 1, vitalidade = 23, forca = 25, destreza = 15, inteligencia = 17, maxMana = 34, mana = 10;


        public void status()
        {

            Console.WriteLine($"Nome:{nome}");
            Console.WriteLine($"Vida:{vida}");
            Console.WriteLine($"energia:{energia}");
            Console.WriteLine($"maxVida:{maxVida}");
            Console.WriteLine($"maxEnergia:{maxEnergia}");
            Console.WriteLine($"nivel:{nivel}");
            Console.WriteLine($"forca:{forca}");
            Console.WriteLine($"vitalidade:{vitalidade}");
            Console.WriteLine($"inteligencia:{inteligencia}");
            Console.WriteLine($"destreza:{destreza}\n\n\n");

        }


        public void upar()
        {

            nivel += 1;
            forca += 5;
            vitalidade += 3;
            energia += 2;
            inteligencia += 1;
            destreza += 2;
            maxVida += vitalidade * 3 / 2;
            Console.WriteLine("Barbaro Upado!!\n\n");

        }

        public void revigorar(int vida_vl, int mana_vl)
        {

            vida += vida_vl * 2 / 3;

            if (vida <= maxVida)
            {
                Console.WriteLine("Vida Revigorada!!\n\n");

            }
            else
            {
                Console.WriteLine("Sua Vida não pode ultrapassar a Vida Maxima\n\n");
                vida = vida - vida_vl * 2 / 3;

            }

            mana += mana_vl * 1 / 3;

            if (mana <= maxMana)
            {
                Console.WriteLine("Mana Revigorada!!\n\n");

            }
            else
            {
                Console.WriteLine("Sua Mana não pode ultrapassar a Mana Maxima\n\n");
                mana = mana - mana_vl * 1 / 3;

            }
        }


        public void atacar(Barbaro barbaro_alvo)
        {
            barbaro_alvo.vida -= forca / 2 + destreza / 3 + inteligencia / 5;
            barbaro_alvo.mana -= 2;

            if (barbaro_alvo.mana < 2)
            {
                Console.WriteLine("Mana insuficiente para executar o ataque!!\n\n");
                barbaro_alvo.vida += forca / 2 + destreza / 3 + inteligencia / 5;
            }
            else
            {
                Console.WriteLine("Ataque executado!!\n\n");
            }

            if (barbaro_alvo.vida <= 0) {
                Console.WriteLine($"Barbaro {barbaro_alvo.nome} foi ABATIDO!!");
            }
        }
    }
}
