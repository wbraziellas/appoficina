using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lm.Oficina.Controller;

namespace lm.Oficina
{
    public partial class FrmPrincipal : Form
    {
        #region Propriedades

        private DadosServicoController _dadosServicoController;
        private DadosServicoController dadosServicoController
        {
            get { return _dadosServicoController ?? (_dadosServicoController = new DadosServicoController()); }
            set { }
        }

        #endregion


        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dadosServicoController.ObterServicosEmAberto();
        }

        private void edtLocalizaOS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void commandBarItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
