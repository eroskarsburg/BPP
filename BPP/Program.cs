using BPP.Aula9.StrategySystem.Context;
using BPP.Aula9.StrategySystem.Strategy.TiposPagamento;
using BPP.Aula9.TemplateMethod;
using BPP.Aula9.TemplateMethod.CreditMethod;
using BPP.Aula9.TemplateMethod.DebitMethod;
using BPP.Aula9.TemplateMethod.PIXMethod;
using BPP.Observer;
using BPP.ProxyMethod;
using System;

namespace BPP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DatabaseOperationImplement databaseOperationImplement = new DatabaseOperationImplement();
            DatabaseOperationProxy databaseOperationProxy = new DatabaseOperationProxy(databaseOperationImplement);

            databaseOperationProxy.Update();


            //Console.WriteLine("Operação com PIX:");
            //Client.ClientCode(new PIX());

            //Console.Write("\n");

            //Console.WriteLine("Operação com CRÉDITO:");
            //Client.ClientCode(new Credit());

            //Console.Write("\n");

            //Console.WriteLine("Operação com DÉBITO:");
            //Client.ClientCode(new Debit());

            //DevListener devListener = new DevListener();
            //SecretariaListener secretariaListener = new SecretariaListener();
            //Telefone telefone = new Telefone();
            //telefone.AdicionarListener(devListener);
            //telefone.AdicionarListener(secretariaListener);

            //while (true)
            //{
            //    Console.WriteLine("-----------------");
            //    Console.WriteLine("Digite a mensagem: ");
            //    string mensagem = Console.ReadLine();
            //    if (mensagem == "sair")
            //    {
            //        break;
            //    }
            //    telefone.mensagem = mensagem;
            //    Console.WriteLine("-----------------\n");
            //}
        }
    }
}
