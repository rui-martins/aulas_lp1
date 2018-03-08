using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_class
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta, pergunta;

            Console.WriteLine("Pergunta-me algo!");

            while (true)
            {
                pergunta = Console.ReadLine();
                if (pergunta == "EXIT")
                {
                    break;
                }
                switch (pergunta)
                {
                    case "Como te chamas?":
                        resposta = "Rui";
                        break;
                    case "Que idade tens?":
                        resposta = "22";
                        break;
                    case "De onde és?":
                        resposta = "Bobadela";
                        break;
                    default:
                        resposta = "Não te sei responder a isso";
                        break;
                }
                Console.WriteLine(resposta);
                    
            }

        }
    }
}
