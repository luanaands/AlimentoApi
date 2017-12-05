using AlimentoAPI.Models;
using AlimentoAPI.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AlimentoAPI.Controllers
{

    [RoutePrefix("v1/Instituicao")]
    public class InstituicaoController : ApiController
    {
        public IInstituicaoServico instituicaoServico { get; set; }

        ///<summary>
        ///Retorna todas as instituicao
        ///</summary>
        ///<returns>Json dos elementos cadastrados em</returns>

        [Route("Obter")]
        [HttpGet]
        public object Obter()
        {
            try
            {
                return instituicaoServico.ListarTudo();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        ///<summary>
        ///Retorna instituicao  por ID
        ///</summary>
        ///<param name="id">Id da instituicao  </param>
        ///<returns>Json dos elementos cadastrados em alimento </returns>

        [Route("ObterPorId/{id}")]
        [HttpGet]
        public object Obter(int id)
        {
            try
            {
                return instituicaoServico.ObterPorID(id);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        ///<summary>
        ///Adiciona uma objecto
        ///</summary>
        ///<param name="instituicao">objecto a adicionar</param>
        ///<returns>Notificações sobre  operação realizada</returns>

        [HttpPost]
        [Route("Adicionar")]
        public object Adicionar(Instituicao objecto)
        {
            try
            {
                instituicaoServico.Adicionar(objecto);
                return objecto;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        ///<summary>
        ///Altera uma objecto
        ///</summary>
        ///<param name="alimento">objecto para alterar</param>
        ///<returns>Notificações sobre a operação realizada</returns>

        [HttpPut]
        [Route("Editar")]
        public object Editar(Instituicao objecto)
        {
            try
            {
                instituicaoServico.Editar(objecto);
                return objecto;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        ///<summary>
        ///Excluir objecto chave por ID
        ///</summary>
        ///<param name="id">Id da objecto chave</param>
        ///<returns>Notificações sobre a operação realizada</returns>

        [Route("Deletar/{id}")]
        [HttpDelete]
        public HttpResponseMessage Deletar(int id)
        {
            try
            {
                Instituicao objecto = instituicaoServico.ObterPorID(id);
                instituicaoServico.Deletar(objecto);
                return new HttpResponseMessage();
            }
            catch (System.Exception)
            {
                return new HttpResponseMessage { StatusCode = HttpStatusCode.InternalServerError };
            }
        }


    }
}
