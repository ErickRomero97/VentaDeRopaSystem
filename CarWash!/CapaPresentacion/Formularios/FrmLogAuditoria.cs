﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System;

namespace CapaPresentacion
{
    public partial class FrmLogAuditoria : Form
    {
        public FrmLogAuditoria()
        {
            InitializeComponent();
        }

        private void FrmLogAuditoria_Load(object sender, EventArgs e)
        {
            MostrarAuditoria();
        }
        private void MostrarAuditoria()
        {
            CNAudiLog mostrarA = new CNAudiLog();
            dgvAuditoria.DataSource = mostrarA.MostrarAuditoria().Tables["MostrarTodoAuditoria"];
        }
    }
}
