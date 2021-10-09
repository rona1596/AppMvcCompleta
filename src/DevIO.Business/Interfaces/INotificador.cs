using DevIO.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Interfaces
{
    public interface INotificador
    {
        //Verificar se existe notificação
        bool TemNotificacao();
        //Obter uma lista de notificações
        List<Notificacao> ObterNotificacoes();
        //Manipular uma notificação quando for lançada
        void Handle(Notificacao notificacao);
    }
}
