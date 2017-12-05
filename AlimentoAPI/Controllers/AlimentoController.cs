using AlimentoAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AlimentoAPI.Servico.Interface;
using System.Net.Http;
using System.Net;

namespace AlimentoAPI.Controllers
{
    [RoutePrefix("v1/Alimento")]
    public class AlimentoController : ApiController
    {
        public IAlimentoServico alimentoService {get; set;}

        ///<summary>
        ///Retorna todas as alimento
        ///</summary>
        ///<returns>Json dos elementos cadastrados em</returns>
       
        [Route("Obter")]
        [HttpGet]
        public object Obter()
        {
            try
            {
                return alimentoService.ListarTudo();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        ///<summary>
        ///Retorna alimento  por ID
        ///</summary>
        ///<param name="id">Id da alimento  </param>
        ///<returns>Json dos elementos cadastrados em alimento </returns>
        
        [Route("ObterPorId/{id}")]
        [HttpGet]
        public object Obter(int id)
        {
            try
            {
                return alimentoService.ObterPorID(id);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        ///<summary>
        ///Adiciona uma alimento chave
        ///</summary>
        ///<param name="alimento">alimento a adicionar</param>
        ///<returns>Notificações sobre  operação realizada</returns>
       
        [HttpPost]
        [Route("Adicionar")]
        public object Adicionar(Alimento alimento)
        {
            try
            {
                alimentoService.Adicionar(alimento);
                return alimento;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        ///<summary>
        ///Altera uma alimento
        ///</summary>
        ///<param name="alimento">alimento para alterar</param>
        ///<returns>Notificações sobre a operação realizada</returns>
        
        [HttpPut]
        [Route("Editar")]
        public object Editar(Alimento palavraChave)
        {
            try
            {
                alimentoService.Editar(palavraChave);
                return palavraChave;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        ///<summary>
        ///Excluir alimento chave por ID
        ///</summary>
        ///<param name="id">Id da alimento chave</param>
        ///<returns>Notificações sobre a operação realizada</returns>
        
        [Route("Deletar/{id}")]
        [HttpDelete]
        public HttpResponseMessage Deletar(int id)
        {
            try
            {
                Alimento alimento = alimentoService.ObterPorID(id);
                alimentoService.Deletar(alimento);
                return new HttpResponseMessage();
            }
            catch (System.Exception)
            {
                return new HttpResponseMessage { StatusCode = HttpStatusCode.InternalServerError };
            }
        }
    }
}