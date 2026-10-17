using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Abstracao
{
    internal class explicacao
    {
        /*
         * ABSTRACAO : ESCONDER O QUE UMA CLASSE FAZ
         * 
         * PROBLEMA DE ACOPLAMENTO -> UM CODIGO/SISTEMA ONDE ESTA TUDO LIGADO
         * SE TUDO ESTA LIGADO, SE VOCE MUDA UMA COISA, VOCE PRECISA MUDAR TUDO.
         * EXEMPLO :
         * FINALIZAR -> EnviarPushNotification, EnviarSms, EnviarEmail
         * 
         * O MAIOR INIMIGO DO ACOMPLAMENTO É A ABSTRACAO
         * FINALIZAR - NOTIFICADOR ( INTERFACE)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * */
    }
}
internal interface INotificador
{
    void Enviar(string mensagem);
}
public class Email : INotificador
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Email disparado: {mensagem}");
    }
}
//Notificacao SMS

internal interface Imensageador
{
    void Mensageiro(string mensagem);
}
public class Mensageamento : Imensageador
{
    public void Mensageiro(string mensagem)
    {
        Console.WriteLine($"A Mensagem Disparada pelo Mensageiro é {mensagem}");
    }
}