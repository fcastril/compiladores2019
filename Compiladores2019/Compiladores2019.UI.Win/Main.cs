using Compiladores2019.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

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
        private List<itemGrid> AFD { get; set; }

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

        private void btnValidacionAFND_Click(object sender, EventArgs e)
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
                string value = "";
                Type type = typeof(itemGrid);

                System.Reflection.PropertyInfo[] listaPropiedades = type.GetProperties();
                foreach (System.Reflection.PropertyInfo propiedad in listaPropiedades)
                {
                    if (propiedad.Name != "State")
                    {
                        value = propiedad.GetValue(item).ToString();
                        if (value.Split(';').Length > 1)
                        {
                            lentro = true;
                            break;
                        }
                    }
                    if (lentro)
                    {
                        break;
                    }
                }
                if (lentro)
                {
                    break;
                }


                //if (item.Value1.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value2.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value3.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value4.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value5.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value6.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value7.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value8.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value9.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value10.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value11.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value12.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value13.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value14.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value15.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value16.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value17.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value18.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value19.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
                //if (item.Value20.Split(';').Length > 1)
                //{
                //    lentro = true;
                //    break;
                //}
            }

            if (!lentro) // Adicionar la parte de la tabla de transiciones
            {
                MessageBox.Show("NO! Un AFND debe tener más de un estado de inicio o un Estado tenga mas de una transición", "AFND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Si! Correcto es un AFND", "AFND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPaso01.Enabled = true;
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            transitions = new List<itemGrid>();
            int i = 0;
            foreach (var item in states)
            {
                itemGrid ig = new itemGrid();
                ig.State = item;
                transitions.Add(ig);
                i++;
            }

            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            DataGridViewColumn column = new DataGridViewColumn();
            column.HeaderText = "Estados";
            column.DataPropertyName = "State";
            column.Name = "State";
            column.Visible = true;
            column.ReadOnly = true;
            column.CellTemplate = cell;
            dataGridView1.Columns.Add(column);

            i = 0;
            foreach (var item in symbolsIn)
            {
                i++;
                column = new DataGridViewColumn();
                column.DataPropertyName = $"Value{i}";
                column.Name = $"Value{i}";
                column.HeaderText = item;
                column.Visible = true;
                column.ReadOnly = false;
                column.CellTemplate = cell;
                dataGridView1.Columns.Add(column);
            }
            dataGridView1.DataSource = transitions;
            btnValidacionAFND.Enabled = true;

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

        private void btnPaso01_Click(object sender, EventArgs e)
        {
            // recorrer matriz y crear la nueva con los estados de AFDN
            AFD = new List<itemGrid>();
            int i = 0;
            string value = "";

            // Primero en Linea
            // Verificar inicio
            value = txtStatesBegin.Text;
            itemGrid comparador = transitions.Where(a => a.State == value).FirstOrDefault();
            itemGrid addAFD = new itemGrid();
            addAFD.State = comparador.State;
            value = comparador.Value1;

            AFD.Add(addAFD);
            Type type = typeof(itemGrid);

            System.Reflection.PropertyInfo[] listaPropiedades = type.GetProperties();
            foreach (System.Reflection.PropertyInfo propiedad in listaPropiedades)
            {
                if (propiedad.Name != "State")
                {
                    value = propiedad.GetValue(comparador).ToString();
                    if (value != string.Empty)
                    {
                        Llenar(value);
                    }
                }
            }

            //Llenar(comparador.Value1);

            dataGridView2.Columns.Clear();
            dataGridView2.AutoGenerateColumns = false;
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            DataGridViewColumn column = new DataGridViewColumn();
            column.HeaderText = "Estados";
            column.DataPropertyName = "State";
            column.Name = "State";
            column.Visible = true;
            column.ReadOnly = true;
            column.CellTemplate = cell;
            dataGridView2.Columns.Add(column);

            i = 0;
            foreach (var item in symbolsIn)
            {
                i++;
                column = new DataGridViewColumn();
                column.DataPropertyName = $"Value{i}";
                column.Name = $"Value{i}";
                column.HeaderText = item;
                column.Visible = true;
                column.ReadOnly = false;
                column.CellTemplate = cell;
                dataGridView2.Columns.Add(column);
            }
            dataGridView2.DataSource = AFD;
        }
        private void Llenar(string value)
        {
            itemGrid ret = new itemGrid();
            itemGrid comparador = AFD.Where(a => a.State == value).FirstOrDefault();
            if (comparador == null)
            {
                ret.State = value;
                AFD.Add(ret);
                string nval = string.Empty;
                if (value.Contains(";"))
                {
                    foreach (string v in value.Split(';'))
                    {
                        if (v != string.Empty)
                        {
                            ret = transitions.Where(t => t.State == v).FirstOrDefault();
                            if (ret.Value1 != string.Empty)
                            {
                                nval += nval.Length > 0 ? ";" : "";
                                nval += $"{ret.Value1}";
                            }
                        }
                    }
                    //     nval = nval == string.Empty ? "ERROR" : nval;
                    if (AFD.Where(c => c.State == nval).Count() == 0)
                    {
                        Llenar(nval);
                    }
                    nval = string.Empty;
                    foreach (string v in value.Split(';'))
                    {
                        if (v != string.Empty)
                        {
                            ret = transitions.Where(t => t.State == v).FirstOrDefault();
                            if (ret.Value2 != string.Empty)
                            {
                                nval += nval.Length > 0 ? ";" : "";
                                nval += $"{ret.Value2}";
                            }
                        }
                    }
                    //   nval = nval == string.Empty ? "ERROR" : nval;
                    if (AFD.Where(c => c.State == nval).Count() == 0)
                    {
                        Llenar(nval);
                    }

                }
                else
                {
                    if (value != string.Empty)
                    {
                        ret = transitions.Where(a => a.State == value).FirstOrDefault();
                        string val = ret.Value1.Trim();
                        if (val.Contains(";"))
                        {
                            nval = string.Empty;
                            foreach (var v in val.Split(';'))
                            {

                                if (v != string.Empty)
                                {
                                    ret = transitions.Where(t => t.State == v).FirstOrDefault();
                                    if (ret.Value1 != string.Empty)
                                    {
                                        nval += nval.Length > 0 ? ";" : "";
                                        nval += $"{ret.Value1}";
                                    }
                                }
                            }
                            //         nval = nval == string.Empty ? "ERROR" : nval;
                            if (AFD.Where(c => c.State == nval).Count() == 0)
                            {
                                Llenar(nval);
                            }

                            nval = string.Empty;
                            foreach (var v in val.Split(';'))
                            {

                                if (v != string.Empty)
                                {
                                    ret = transitions.Where(t => t.State == v).FirstOrDefault();
                                    if (ret.Value2 != string.Empty)
                                    {
                                        nval += nval.Length > 0 ? ";" : "";
                                        nval += $"{ret.Value2}";
                                    }
                                }
                            }
                            // nval = nval == string.Empty ? "ERROR" : nval;
                            if (AFD.Where(c => c.State == nval).Count() == 0)
                            {
                                Llenar(nval);
                            }

                        }
                        else
                        {
                            //val = val == string.Empty ? "ERROR" : val;
                            if (AFD.Where(c => c.State == val).Count() == 0)
                            {
                                Llenar(val);
                            }
                        }
                    }
                }
                //val = ret.Value2.Trim();
                //val = val == string.Empty ? "ERROR" : val;
                //if (AFD.Where(c => c.State == val).Count() == 0)
                //{
                //    Llenar(val);
                //}
            }
        }
    }
}
