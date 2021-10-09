using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Business.Models
{
    //Classe mãe, todas entidades derivam dessa classe
    //Abstract - Não pode ser instanciada e sim herdada
    public  abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        //Protected - 
        public Guid Id { get; set; }
    }
}
