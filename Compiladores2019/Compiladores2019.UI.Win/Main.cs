﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using Compiladores2019.Common;

namespace Compiladores2019.UI.Win
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private List<string> states => Lista(txtStates.Text.Split(';'));
        private List<string> statesBegin => Lista(txtStatesBegin.Text.Split(';'));
        private List<string> acceptations => Lista(txtAcceptations.Text.Split(';'));
        private List<string> symbolsIn => Lista(txtSymbolsIN.Text.Split(';'));
        private List<itemGrid> transitions { get; set; }

        private List<string> Lista(string[] data)
        {
            List<string> ret = new List<string>();

            foreach (string item in data)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    ret.Add(item.Trim());
                }
            }
            return ret;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtStatesBegin_Validating(object sender, CancelEventArgs e)
        {
            int conteo = 0;
            foreach (string item in statesBegin)
            {
                conteo = states.Where(s => s == item).Count();
                if (conteo == 0)
                {
                    break;
                }
            }
            if (conteo == 0)
            {
                MessageBox.Show("Hay Estados Iniciales que no se encuentran en la definición de estados","Estados Iniciales",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAcceptations_Validating(object sender, CancelEventArgs e)
        {
            int conteo = 0;
            foreach (string item in acceptations)
            {
                conteo = states.Where(s => s == item).Count();
                if (conteo == 0)
                {
                    break;
                }
            }
            if (conteo == 0)
            {
                MessageBox.Show("Hay Estados Iniciales que no se encuentran en la definición de estados", "Estados Iniciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validación que para un AFND 
            if (symbolsIn.Count() <= 0)
            {
                MessageBox.Show("No se definieron Símbolos de Entrada", "Símbolos de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (states.Count() <= 0)
            {
                MessageBox.Show("No se definieron Estados","Estado",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (statesBegin.Count() <= 0)
            {
                MessageBox.Show("No se definieron Estados de Inicio", "Estados de Inicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (acceptations.Count() <= 0)
            {
                MessageBox.Show("No se definieron Estados de Aceptación", "Estados de Aceptación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (statesBegin.Count() == 1 ) // Adicionar la parte de la tabla de transiciones
            {
                MessageBox.Show("Un AFND debe tener más de un estado de inicio o un Estado tenga mas de una transición","AFND",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            transitions = new List<itemGrid>(); 
            foreach (var item in states)
            {
                itemGrid ig = new itemGrid();
                ig.State = item;
                transitions.Add(ig);
            }
            dataGridView1.DataSource = transitions;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].ReadOnly = true;

            for (int i = 1; i <= 20; i++)
            {
                dataGridView1.Columns[i].Visible = false;
               
            }
            int j = 1;
            foreach (var item in symbolsIn)
            {
                dataGridView1.Columns[j].HeaderText = item;
                dataGridView1.Columns[j].Visible = true;
                j++;
            }

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {


        }
    }
}
