using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECU.BussinessLogic;

namespace ECU
{
    public partial class UsuarioFRM : Form
    {
        public UsuarioFRM()
        {
            InitializeComponent();
        }

        private void UsuarioFRM_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = UsuarioBL._Instance.SelectAll();
        }
    }
}
