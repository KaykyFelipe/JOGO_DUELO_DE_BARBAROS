// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  JogoBarbaro;


//EXEMPLO TESTE DOS METODOS NA MAIN

Barbaro Bruno = new Barbaro();
Barbaro Felipe = new Barbaro();


Felipe.nome = "Felipe";
Bruno.nome = "Bruno";

Felipe.status();
Felipe.upar();
Felipe.upar();
Felipe.upar();
Felipe.upar();
Felipe.upar();
Felipe.status();
Felipe.revigorar(20, 5);
Felipe.status();
Felipe.atacar(Bruno);


