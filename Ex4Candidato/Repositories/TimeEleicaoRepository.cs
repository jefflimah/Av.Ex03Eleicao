using Ex4Candidato.Models;
using Ex4Candidato.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4Candidato.Repositories
{
    public class TimeEleicaoRepository : ITimeEleicaoRepository
    {
        private IList<TimeEleicao> listaTimeEleicao = new List<TimeEleicao>();

        public TimeEleicaoRepository()
        {
            listaTimeEleicao.Add(new TimeEleicao() { id = 1111, nomeCandidato = "Bolso", partido = "Aliança pelo Brasil", numero = 17, foto = "bolso.png", cargo = "Presidencia" });
            listaTimeEleicao.Add(new TimeEleicao() { id = 2222, nomeCandidato = "Haddad", partido = "Partido dos Trabalhadores", numero = 13, foto = "hadd.png", cargo = "Presidencia" });
        }

        public TimeEleicao BuscarTimePorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public IList<TimeEleicao> GetAll()
        {
            return listaTimeEleicao;
        }
        public TimeEleicao GetById(int id)
        {
            return listaTimeEleicao.Where(x => x.id == id).FirstOrDefault();
        }
        public void insert(TimeEleicao obj)
        {
            var validator = new TimeEleicaoValidator();
            var result = validator.Validate(obj);
            if (result.IsValid)
                listaTimeEleicao.Add(obj);
            else
                throw new Exception(result.Errors.FirstOrDefault().ToString());
        }

        public void IserirTime(TimeEleicao timeEleicao)
        {
            throw new NotImplementedException();
        }

        public IList<TimeEleicao> ListaTodosTimes()
        {
            throw new NotImplementedException();
        }

        public void remove(int id)
        {
            var filtroTimeEleicao = listaTimeEleicao.Where(x => x.id ==).FirstOrDefault;
            listaTimeEleicao.Remove(filtroTimeEleicao);
        }
    }
}
