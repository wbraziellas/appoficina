﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lm.Oficina.DTO;
using lm.Oficina.Domain;

namespace Controller
{
    public class DadosServicoController
    {
        #region Propriedades

        private DadosServicoRepository _dadosServicoRespository;
        private DadosServicoRepository dadosServicoRepository
        {
            get { return _dadosServicoRespository ?? (_dadosServicoRespository = new DadosServicoRepository()); }
        }

        #endregion

        public List<DadosServicoDTO> ObterServicosEmAberto()
        {
            return dadosServicoRepository.SelecionarServico();
        }
    }
}