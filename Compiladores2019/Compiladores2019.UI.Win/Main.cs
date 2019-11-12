using System;
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
                MessageBox.Show("Hay Estados Iniciales que no se encuentran en la definición de estados", "Estados Iniciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("No se definieron Estados", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            bool lentro = false;
            lentro = (statesBegin.Count() > 1);// Adicionar la parte de la tabla de transiciones


            foreach (var item in transitions)
            {
                if (item.Value1.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value2.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value3.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value4.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value5.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value6.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value7.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value8.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value9.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value10.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value11.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value12.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value13.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value14.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value15.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value16.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value17.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value18.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value19.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
                if (item.Value20.Split(';').Length > 1)
                {
                    lentro = true;
                    break;
                }
            }

            if (!lentro) // Adicionar la parte de la tabla de transiciones
            {
                MessageBox.Show("Un AFND debe tener más de un estado de inicio o un Estado tenga mas de una transición", "AFND", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            bool lentro = false;
            string[] valores = e.FormattedValue.ToString().Split(';');
            foreach (string item in valores)
            {
                if (!string.IsNullOrEmpty(item.Trim()))
                {
                    if (states.Where(s => s == item).Count() == 0)
                    {
                        lentro = true;
                        break;
                    }
                }
            }
            if (lentro)
            {
                MessageBox.Show("Debe ingresar estados adecuados", "Estados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
