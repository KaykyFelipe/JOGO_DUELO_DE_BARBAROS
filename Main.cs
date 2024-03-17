// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  JogoBarbaro;


//EXEMPLO TESTE DOS METODOS NA MAIN

Barbaro Eduardo = new Barbaro();
Barbaro Kayky = new Barbaro();


Kayky.nome = "Felipe";
Eduardo.nome = "Professor Eduardo";

Kayky.status();
Kayky.upar();
Kayky.upar();
Kayky.upar();
Kayky.upar();
Kayky.upar();
Kayky.status();
Kayky.revigorar(18, 5);
Kayky.status();
Kayky.atacar(Eduardo);


