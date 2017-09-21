using System;

namespace ConsultaCEP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o CEP:");
            var cep = Console.ReadLine();

            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(cep);

                    Console.WriteLine("CEP:{0}", resultado.cep);
                    Console.WriteLine("Endereço:{0}", resultado.end);
                    Console.WriteLine("Complemento:{0}", resultado.complemento);
                    Console.WriteLine("Complemento2:{0}", resultado.complemento2);
                    Console.WriteLine("Bairro:{0}", resultado.bairro);
                    Console.WriteLine("Cidade:{0} - {1}", resultado.cidade, resultado.uf);

                    Console.ReadKey();
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um Erro:{0}", ex.Message);
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

        }
    }
}
