using Compiladores2019.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;

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
        private StringBuilder grafo { get; set; }
        private string file => "imagen";

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
            return ret.OrderBy(x => x).ToList();
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
                if (txtAcceptations.Text.Contains(ig.State))
                    ig.Result = 1;
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
            column = new DataGridViewColumn();
            column.HeaderText = "0: Rechaza/ 1: Acepta";
            column.DataPropertyName = "Result";
            column.Name = "Result";
            column.Visible = true;
            column.ReadOnly = true;
            column.CellTemplate = cell;
            dataGridView1.Columns.Add(column);


            dataGridView1.DataSource = transitions;
            btnValidacionAFND.Enabled = true;

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            bool lentro = false;
            if (dataGridView1.Columns.Count != e.ColumnIndex + 1)
            {
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
            }
            if (lentro)
            {
                MessageBox.Show("Debe ingresar estados válidos", "Estados", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            AFD.Add(addAFD);
            Type type = typeof(itemGrid);

            System.Reflection.PropertyInfo[] listaPropiedades = type.GetProperties();
            foreach (System.Reflection.PropertyInfo propiedad in listaPropiedades)
            {
                if (propiedad.Name != "State" && propiedad.Name != "Result")
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
            column = new DataGridViewColumn();
            column.HeaderText = "0: Rechaza / 1: Acepta";
            column.DataPropertyName = "Result";
            column.Name = "Result";
            column.Visible = true;
            column.ReadOnly = true;
            column.CellTemplate = cell;
            dataGridView2.Columns.Add(column);

            dataGridView2.DataSource = AFD;
            btnNuevaTablaTransicion.Enabled = true;
        }
        private void Llenar(string value)
        {
            itemGrid ret = new itemGrid();
            itemGrid comparador = AFD.Where(a => a.State == value).FirstOrDefault();
            if (comparador == null)
            {
                ret.State = value;
                if (ret.State != string.Empty)
                {
                    if (ret.State.Contains(txtAcceptations.Text.Trim()))
                    {
                        ret.Result = 1;
                    }
                }
                AFD.Add(ret);
                string nval = string.Empty;
                if (value.Contains(";"))
                {
                    foreach (string v in value.Split(';').OrderBy(x => x))
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
                    foreach (string v in value.Split(';').OrderBy(x => x))
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
                            foreach (var v in val.Split(';').OrderBy(x => x))
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
                            foreach (var v in val.Split(';').OrderBy(x => x))
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

        private void btnNuevaTablaTransicion_Click(object sender, EventArgs e)
        {
            itemGrid ret = new itemGrid();
            foreach (var item in AFD)
            {
                string value = string.Empty;
                if (item.State != string.Empty)
                {
                    if (!item.State.Contains(";"))
                    {
                        ret = transitions.Where(t => t.State == item.State).FirstOrDefault();

                        item.Value1 = ret.Value1 == string.Empty ? "ERROR" : ret.Value1;
                        item.Value2 = ret.Value2 == string.Empty ? "ERROR" : ret.Value2;
                        item.Value3 = ret.Value3 == string.Empty ? "ERROR" : ret.Value3;
                        item.Value4 = ret.Value4 == string.Empty ? "ERROR" : ret.Value4;
                        item.Value5 = ret.Value5 == string.Empty ? "ERROR" : ret.Value5;
                        item.Value6 = ret.Value6 == string.Empty ? "ERROR" : ret.Value6;
                        item.Value7 = ret.Value7 == string.Empty ? "ERROR" : ret.Value7;
                        item.Value8 = ret.Value8 == string.Empty ? "ERROR" : ret.Value8;
                        item.Value9 = ret.Value9 == string.Empty ? "ERROR" : ret.Value9;
                        item.Value10 = ret.Value10 == string.Empty ? "ERROR" : ret.Value10;
                        item.Value11 = ret.Value11 == string.Empty ? "ERROR" : ret.Value11;
                        item.Value12 = ret.Value12 == string.Empty ? "ERROR" : ret.Value12;
                        item.Value13 = ret.Value13 == string.Empty ? "ERROR" : ret.Value13;
                        item.Value14 = ret.Value14 == string.Empty ? "ERROR" : ret.Value14;
                        item.Value15 = ret.Value15 == string.Empty ? "ERROR" : ret.Value15;
                        item.Value16 = ret.Value16 == string.Empty ? "ERROR" : ret.Value16;
                        item.Value17 = ret.Value17 == string.Empty ? "ERROR" : ret.Value17;
                        item.Value18 = ret.Value18 == string.Empty ? "ERROR" : ret.Value18;
                        item.Value19 = ret.Value19 == string.Empty ? "ERROR" : ret.Value19;
                        item.Value20 = ret.Value20 == string.Empty ? "ERROR" : ret.Value20;
                    }
                    else
                    {
                        item.Value1 = AsignarValores(item.State, 1);
                        item.Value2 = AsignarValores(item.State, 2);
                        item.Value3 = AsignarValores(item.State, 3);
                        item.Value4 = AsignarValores(item.State, 4);
                        item.Value5 = AsignarValores(item.State, 5);
                        item.Value6 = AsignarValores(item.State, 6);
                        item.Value7 = AsignarValores(item.State, 7);
                        item.Value8 = AsignarValores(item.State, 8);
                        item.Value9 = AsignarValores(item.State, 9);
                        item.Value10 = AsignarValores(item.State, 10);
                        item.Value11 = AsignarValores(item.State, 11);
                        item.Value12 = AsignarValores(item.State, 12);
                        item.Value13 = AsignarValores(item.State, 13);
                        item.Value14 = AsignarValores(item.State, 14);
                        item.Value15 = AsignarValores(item.State, 15);
                        item.Value16 = AsignarValores(item.State, 16);
                        item.Value17 = AsignarValores(item.State, 17);
                        item.Value18 = AsignarValores(item.State, 18);
                        item.Value19 = AsignarValores(item.State, 19);
                        item.Value20 = AsignarValores(item.State, 20);

                    }
                }
                else
                {
                    item.State = "ERROR";
                    item.Value1 = "ERROR";
                    item.Value2 = "ERROR";
                }
                if (txtAcceptations.Text.Contains(item.State))
                {
                    item.Result = 1;
                }
            }

            Limpiar();

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

            int i = 0;
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
            column = new DataGridViewColumn();
            column.HeaderText = "0: Rechaza / 1: Acepta";
            column.DataPropertyName = "Result";
            column.Name = "Result";
            column.Visible = true;
            column.ReadOnly = true;
            column.CellTemplate = cell;
            dataGridView2.Columns.Add(column);

            dataGridView2.DataSource = AFD;
            btnGraficar.Enabled = true;
        }

        private void Limpiar()
        {
            foreach (var item in AFD)
            {
                item.State = item.State.Replace(";", "");
                item.Value1 = item.Value1.Replace(";", "");
                item.Value2 = item.Value2.Replace(";", "");
                item.Value3 = item.Value3.Replace(";", "");
                item.Value4 = item.Value4.Replace(";", "");
                item.Value5 = item.Value5.Replace(";", "");
                item.Value6 = item.Value6.Replace(";", "");
                item.Value7 = item.Value7.Replace(";", "");
                item.Value8 = item.Value8.Replace(";", "");
                item.Value9 = item.Value9.Replace(";", "");
                item.Value10 = item.Value10.Replace(";", "");
                item.Value11 = item.Value11.Replace(";", "");
                item.Value12 = item.Value12.Replace(";", "");
                item.Value13 = item.Value13.Replace(";", "");
                item.Value14 = item.Value14.Replace(";", "");
                item.Value15 = item.Value15.Replace(";", "");
                item.Value16 = item.Value16.Replace(";", "");
                item.Value17 = item.Value17.Replace(";", "");
                item.Value18 = item.Value18.Replace(";", "");
                item.Value19 = item.Value19.Replace(";", "");
                item.Value20 = item.Value20.Replace(";", "");
            }
        }

        private string AsignarValores(string state, int Value)
        {
            itemGrid ret = new itemGrid();
            string value = string.Empty;
            string Valor = string.Empty;
            foreach (var states in state.Split(';').OrderBy(x => x))
            {
                Valor = string.Empty;
                ret = transitions.Where(t => t.State == states).FirstOrDefault();
                value += value != string.Empty ? ";" : "";
                switch (Value)
                {
                    case 1:
                        Valor = ret.Value1;
                        break;
                    case 2:
                        Valor = ret.Value2;
                        break;
                    case 3:
                        Valor = ret.Value3;
                        break;
                    case 4:
                        Valor = ret.Value4;
                        break;
                    case 5:
                        Valor = ret.Value5;
                        break;
                    case 6:
                        Valor = ret.Value6;
                        break;
                    case 7:
                        Valor = ret.Value7;
                        break;
                    case 8:
                        Valor = ret.Value8;
                        break;
                    case 9:
                        Valor = ret.Value9;
                        break;
                    case 10:
                        Valor = ret.Value10;
                        break;
                    case 11:
                        Valor = ret.Value11;
                        break;
                    case 12:
                        Valor = ret.Value12;
                        break;
                    case 13:
                        Valor = ret.Value13;
                        break;
                    case 14:
                        Valor = ret.Value14;
                        break;
                    case 15:
                        Valor = ret.Value15;
                        break;
                    case 16:
                        Valor = ret.Value16;
                        break;
                    case 17:
                        Valor = ret.Value17;
                        break;
                    case 18:
                        Valor = ret.Value18;
                        break;
                    case 19:
                        Valor = ret.Value19;
                        break;
                    case 20:
                        Valor = ret.Value20;
                        break;
                    default:
                        Valor = "ERROR";
                        break;
                }
                value += Valor;
            }
            return (value == string.Empty ? "ERROR" : value);
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            GenerarGrafico();
            if (File.Exists($"{file}.png"))
            {
                picture.Image = new System.Drawing.Bitmap($"{file}.png");
            }
        }

        private void GenerarGrafico()
        {
            grafo = new StringBuilder();
            string rdot = $"{file}.dot";
            string rpng = $"{file}.png";
            if (File.Exists($"{file}.dot"))
                File.Delete($"{file}.dot");
            if (File.Exists($"{file}.png"))
                File.Delete($"{file}.png");
            grafo.Append(GenerarDatosGraph());
            GenerarDOT(rdot, rpng);

        }
        private void GenerarDOT(string rdot, string rpng)
        {
            File.WriteAllText(rdot, grafo.ToString());
            string comandoDot = $"dot.exe -Tpng {rdot} -o {rpng}";
            var procStart = new System.Diagnostics.ProcessStartInfo("cmd", "/C" + comandoDot);
            var proc = new System.Diagnostics.Process();
            proc.StartInfo = procStart;
            proc.Start();
            proc.WaitForExit();
        }
        private string GenerarDatosGraph()
        {
            //armar el archivo de texto

            string data = "";
            foreach (var value in AFD)
            {
                if (string.IsNullOrEmpty(data))
                {
                    data = $"start -> {value.State} ; {Environment.NewLine}";

                }
                if (value.Result == 1)
                {
                    data += $"{value.State} [peripheries=2] ; {Environment.NewLine}";
                }
                int CantidadSymbols = txtSymbolsIN.Text.Split(';').Count();
                string[] symbols = txtSymbolsIN.Text.Split(';');
                int i = 0;
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value1} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value2} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value3} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value4} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value5} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value6} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value7} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value8} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value9} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value10} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value11} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value12} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value13} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value14} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value15} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value16} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value17} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value18} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value19} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";
                i++;
                if (CantidadSymbols >= i)
                    data += $"{value.State} -> {value.Value20} [label=\"{symbols[i-1]}\"] ; {Environment.NewLine}";

            }
            return "digraph G {" + data + "}";

        }
    }
}
