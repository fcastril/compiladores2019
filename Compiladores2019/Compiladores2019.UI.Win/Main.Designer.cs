namespace Compiladores2019.UI.Win
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSymbolsIN = new System.Windows.Forms.Label();
            this.txtSymbolsIN = new System.Windows.Forms.TextBox();
            this.txtStates = new System.Windows.Forms.TextBox();
            this.lblStates = new System.Windows.Forms.Label();
            this.txtStatesBegin = new System.Windows.Forms.TextBox();
            this.lblStatesBegin = new System.Windows.Forms.Label();
            this.txtAcceptations = new System.Windows.Forms.TextBox();
            this.lblAcceptations = new System.Windows.Forms.Label();
            this.btnValidacionAFND = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPaso01 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnNuevaTablaTransicion = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.lblExpresion = new System.Windows.Forms.Label();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(775, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Automata Finito No Deterministico (AFND) a  Automata Finito Deterministico (AFD)";
            // 
            // lblSymbolsIN
            // 
            this.lblSymbolsIN.AutoSize = true;
            this.lblSymbolsIN.Location = new System.Drawing.Point(18, 43);
            this.lblSymbolsIN.Name = "lblSymbolsIN";
            this.lblSymbolsIN.Size = new System.Drawing.Size(258, 13);
            this.lblSymbolsIN.TabIndex = 1;
            this.lblSymbolsIN.Text = "Simbolos de Entrada  [(;) Punto y Coma para Separar]";
            // 
            // txtSymbolsIN
            // 
            this.txtSymbolsIN.Location = new System.Drawing.Point(21, 59);
            this.txtSymbolsIN.Name = "txtSymbolsIN";
            this.txtSymbolsIN.Size = new System.Drawing.Size(278, 20);
            this.txtSymbolsIN.TabIndex = 2;
            // 
            // txtStates
            // 
            this.txtStates.Location = new System.Drawing.Point(21, 103);
            this.txtStates.Name = "txtStates";
            this.txtStates.Size = new System.Drawing.Size(278, 20);
            this.txtStates.TabIndex = 4;
            // 
            // lblStates
            // 
            this.lblStates.AutoSize = true;
            this.lblStates.Location = new System.Drawing.Point(18, 87);
            this.lblStates.Name = "lblStates";
            this.lblStates.Size = new System.Drawing.Size(199, 13);
            this.lblStates.TabIndex = 3;
            this.lblStates.Text = "Estados  [(;) Punto y Coma para Separar]";
            // 
            // txtStatesBegin
            // 
            this.txtStatesBegin.Location = new System.Drawing.Point(21, 149);
            this.txtStatesBegin.Name = "txtStatesBegin";
            this.txtStatesBegin.Size = new System.Drawing.Size(278, 20);
            this.txtStatesBegin.TabIndex = 6;
            this.txtStatesBegin.Validating += new System.ComponentModel.CancelEventHandler(this.txtStatesBegin_Validating);
            // 
            // lblStatesBegin
            // 
            this.lblStatesBegin.AutoSize = true;
            this.lblStatesBegin.Location = new System.Drawing.Point(18, 133);
            this.lblStatesBegin.Name = "lblStatesBegin";
            this.lblStatesBegin.Size = new System.Drawing.Size(252, 13);
            this.lblStatesBegin.TabIndex = 5;
            this.lblStatesBegin.Text = "Estado(s) Inicial(es)  [(;) Punto y Coma para Separar]";
            // 
            // txtAcceptations
            // 
            this.txtAcceptations.Location = new System.Drawing.Point(21, 198);
            this.txtAcceptations.Name = "txtAcceptations";
            this.txtAcceptations.Size = new System.Drawing.Size(278, 20);
            this.txtAcceptations.TabIndex = 8;
            this.txtAcceptations.Validating += new System.ComponentModel.CancelEventHandler(this.txtAcceptations_Validating);
            // 
            // lblAcceptations
            // 
            this.lblAcceptations.AutoSize = true;
            this.lblAcceptations.Location = new System.Drawing.Point(18, 182);
            this.lblAcceptations.Name = "lblAcceptations";
            this.lblAcceptations.Size = new System.Drawing.Size(276, 13);
            this.lblAcceptations.TabIndex = 7;
            this.lblAcceptations.Text = "Estado(s) de aceptación  [(;) Punto y Coma para Separar]";
            // 
            // btnValidacionAFND
            // 
            this.btnValidacionAFND.Enabled = false;
            this.btnValidacionAFND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidacionAFND.ForeColor = System.Drawing.Color.Blue;
            this.btnValidacionAFND.Location = new System.Drawing.Point(21, 253);
            this.btnValidacionAFND.Name = "btnValidacionAFND";
            this.btnValidacionAFND.Size = new System.Drawing.Size(278, 23);
            this.btnValidacionAFND.TabIndex = 9;
            this.btnValidacionAFND.Text = "¿ Es un AFND ?";
            this.btnValidacionAFND.UseVisualStyleBackColor = true;
            this.btnValidacionAFND.Click += new System.EventHandler(this.btnValidacionAFND_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(1166, 744);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.Green;
            this.btnGenerar.Location = new System.Drawing.Point(21, 224);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(278, 23);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.Text = "Generar Tabla de Transición";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(460, 366);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // btnPaso01
            // 
            this.btnPaso01.Enabled = false;
            this.btnPaso01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaso01.ForeColor = System.Drawing.Color.Orange;
            this.btnPaso01.Location = new System.Drawing.Point(21, 282);
            this.btnPaso01.Name = "btnPaso01";
            this.btnPaso01.Size = new System.Drawing.Size(278, 23);
            this.btnPaso01.TabIndex = 13;
            this.btnPaso01.Text = "Paso 01 - Normalizar Estados";
            this.btnPaso01.UseVisualStyleBackColor = true;
            this.btnPaso01.Click += new System.EventHandler(this.btnPaso01_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(318, 415);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(460, 323);
            this.dataGridView2.TabIndex = 14;
            // 
            // btnNuevaTablaTransicion
            // 
            this.btnNuevaTablaTransicion.Enabled = false;
            this.btnNuevaTablaTransicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaTablaTransicion.ForeColor = System.Drawing.Color.Purple;
            this.btnNuevaTablaTransicion.Location = new System.Drawing.Point(21, 311);
            this.btnNuevaTablaTransicion.Name = "btnNuevaTablaTransicion";
            this.btnNuevaTablaTransicion.Size = new System.Drawing.Size(278, 23);
            this.btnNuevaTablaTransicion.TabIndex = 15;
            this.btnNuevaTablaTransicion.Text = "Paso 02 - Llenar Nueva Tabla de Transición";
            this.btnNuevaTablaTransicion.UseVisualStyleBackColor = true;
            this.btnNuevaTablaTransicion.Click += new System.EventHandler(this.btnNuevaTablaTransicion_Click);
            // 
            // btnGraficar
            // 
            this.btnGraficar.Enabled = false;
            this.btnGraficar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.ForeColor = System.Drawing.Color.Salmon;
            this.btnGraficar.Location = new System.Drawing.Point(21, 340);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(278, 23);
            this.btnGraficar.TabIndex = 16;
            this.btnGraficar.Text = "Paso 02 - Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(784, 43);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(460, 695);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 17;
            this.picture.TabStop = false;
            // 
            // lblExpresion
            // 
            this.lblExpresion.AutoSize = true;
            this.lblExpresion.Enabled = false;
            this.lblExpresion.Location = new System.Drawing.Point(19, 372);
            this.lblExpresion.Name = "lblExpresion";
            this.lblExpresion.Size = new System.Drawing.Size(101, 13);
            this.lblExpresion.TabIndex = 18;
            this.lblExpresion.Text = "Expresión a Evaluar";
            // 
            // txtExpresion
            // 
            this.txtExpresion.Enabled = false;
            this.txtExpresion.Location = new System.Drawing.Point(21, 387);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(278, 20);
            this.txtExpresion.TabIndex = 19;
            this.txtExpresion.Validating += new System.ComponentModel.CancelEventHandler(this.txtExpresion_Validating);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 779);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.lblExpresion);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnNuevaTablaTransicion);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnPaso01);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnValidacionAFND);
            this.Controls.Add(this.txtAcceptations);
            this.Controls.Add(this.lblAcceptations);
            this.Controls.Add(this.txtStatesBegin);
            this.Controls.Add(this.lblStatesBegin);
            this.Controls.Add(this.txtStates);
            this.Controls.Add(this.lblStates);
            this.Controls.Add(this.txtSymbolsIN);
            this.Controls.Add(this.lblSymbolsIN);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Main";
            this.Text = "Compiladores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSymbolsIN;
        private System.Windows.Forms.TextBox txtSymbolsIN;
        private System.Windows.Forms.TextBox txtStates;
        private System.Windows.Forms.Label lblStates;
        private System.Windows.Forms.TextBox txtStatesBegin;
        private System.Windows.Forms.Label lblStatesBegin;
        private System.Windows.Forms.TextBox txtAcceptations;
        private System.Windows.Forms.Label lblAcceptations;
        private System.Windows.Forms.Button btnValidacionAFND;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPaso01;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnNuevaTablaTransicion;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label lblExpresion;
        private System.Windows.Forms.TextBox txtExpresion;
    }
}

