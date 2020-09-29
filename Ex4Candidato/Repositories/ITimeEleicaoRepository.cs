using Ex4Candidato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4Candidato.Repositories
{
    interface ITimeEleicaoRepository
    {
        public IList<TimeEleicao> ListaTodosTimes();
        public TimeEleicao BuscarTimePorId(int id);
        public void IserirTime(TimeEleicao timeEleicao);
        TimeEleicao GetById(int id);
        TimeEleicao GetById(int id);
        TimeEleicao GetById(int id);
        void Dispose();
        IList<TimeEleicao> GetAll();
        TimeEleicao GetById(int id);
    }
}
