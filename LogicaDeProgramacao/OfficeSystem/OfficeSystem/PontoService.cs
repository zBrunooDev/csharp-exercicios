using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSystem
{
    internal class PontoService
    {
        List<RegistroPonto> registroPontos = new List<RegistroPonto>();

        //  Criando o CRUD
        // -> Creat, Read, Update, Delete
        // Criando um objeto 
        public RegistroPonto CriarRegistro(Funcionario funcionario, DateTime entrada, DateTime saidaAlmoco, DateTime voltaAlmoco, DateTime saida)
        {
            return new RegistroPonto(funcionario)
            {
                Entrada = entrada,
                SaidaAlmoco = saidaAlmoco,
                VoltaAlmoco = voltaAlmoco,
                Saida = saida
            };
        }
        public void AdicionarPonto(RegistroPonto registroPonto)
        {
            registroPontos.Add(registroPonto);
        }
        
    }
}
