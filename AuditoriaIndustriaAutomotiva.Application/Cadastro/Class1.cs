//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AuditoriaIndustriaAutomotiva.Application.Cadastro
//{


//    public class NovoClienteApplicationService : ApplicationServiceBase, INovoClienteApplicationService
//    {
//        private readonly IClienteService _clienteService;

//        public NovoClienteApplicationService(IClienteService clienteService)
//        {
//            _clienteService = clienteService;
//        }
//        public ApplicationServiceResult<ClienteEntity> Inserir(ApplicationServiceParam<ClienteEntity> param)
//        {
//            if (param == null) throw new ArgumentNullException(nameof(param));

//            var entity = param.DataParam;

//            ApplicationServiceResult<ClienteEntity> result
//                 = new ApplicationServiceResult<ClienteEntity>(entity);
//            try
//            {
//                using (var transacao = new TransactionScope())
//                {


//                    _clienteService.Insert(entity);

//                    transacao.Complete();
//                }
//            }
//            catch (Exception)
//            {
//                //Log in future

//                result.AddMessage(Messages.UnexpectedError);

//                //Aqui o result.Success está false
//            }

//            return result;
//        }
//    }

//}
