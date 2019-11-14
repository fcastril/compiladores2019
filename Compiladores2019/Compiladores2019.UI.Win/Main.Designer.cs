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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo.Location = new System.Drawing.Point(18, 14);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1133, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Automata Finito No Deterministico (AFND) a  Automata Finito Deterministico (AFD)";
            // 
            // lblSymbolsIN
            // 
            this.lblSymbolsIN.AutoSize = true;
            this.lblSymbolsIN.Location = new System.Drawing.Point(27, 66);
            this.lblSymbolsIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSymbolsIN.Name = "lblSymbolsIN";
            this.lblSymbolsIN.Size = new System.Drawing.Size(387, 20);
            this.lblSymbolsIN.TabIndex = 1;
            this.lblSymbolsIN.Text = "Simbolos de Entrada  [(;) Punto y Coma para Separar]";
            // 
            // txtSymbolsIN
            // 
            this.txtSymbolsIN.Location = new System.Drawing.Point(32, 91);
            this.txtSymbolsIN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSymbolsIN.Name = "txtSymbolsIN";
            this.txtSymbolsIN.Size = new System.Drawing.Size(415, 26);
            this.txtSymbolsIN.TabIndex = 2;
            // 
            // txtStates
            // 
            this.txtStates.Location = new System.Drawing.Point(32, 158);
            this.txtStates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStates.Name = "txtStates";
            this.txtStates.Size = new System.Drawing.Size(415, 26);
            this.txtStates.TabIndex = 4;
            // 
            // lblStates
            // 
            this.lblStates.AutoSize = true;
            this.lblStates.Location = new System.Drawing.Point(27, 134);
            this.lblStates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStates.Name = "lblStates";
            this.lblStates.Size = new System.Drawing.Size(298, 20);
            this.lblStates.TabIndex = 3;
            this.lblStates.Text = "Estados  [(;) Punto y Coma para Separar]";
            // 
            // txtStatesBegin
            // 
            this.txtStatesBegin.Location = new System.Drawing.Point(32, 229);
            this.txtStatesBegin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatesBegin.Name = "txtStatesBegin";
            this.txtStatesBegin.Size = new System.Drawing.Size(415, 26);
            this.txtStatesBegin.TabIndex = 6;
            this.txtStatesBegin.Validating += new System.ComponentModel.CancelEventHandler(this.txtStatesBegin_Validating);
            // 
            // lblStatesBegin
            // 
            this.lblStatesBegin.AutoSize = true;
            this.lblStatesBegin.Location = new System.Drawing.Point(27, 205);
            this.lblStatesBegin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatesBegin.Name = "lblStatesBegin";
            this.lblStatesBegin.Size = new System.Drawing.Size(379, 20);
            this.lblStatesBegin.TabIndex = 5;
            this.lblStatesBegin.Text = "Estado(s) Inicial(es)  [(;) Punto y Coma para Separar]";
            // 
            // txtAcceptations
            // 
            this.txtAcceptations.Location = new System.Drawing.Point(32, 305);
            this.txtAcceptations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAcceptations.Name = "txtAcceptations";
            this.txtAcceptations.Size = new System.Drawing.Size(415, 26);
            this.txtAcceptations.TabIndex = 8;
            this.txtAcceptations.Validating += new System.ComponentModel.CancelEventHandler(this.txtAcceptations_Validating);
            // 
            // lblAcceptations
            // 
            this.lblAcceptations.AutoSize = true;
            this.lblAcceptations.Location = new System.Drawing.Point(27, 280);
            this.lblAcceptations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcceptations.Name = "lblAcceptations";
            this.lblAcceptations.Size = new System.Drawing.Size(412, 20);
            this.lblAcceptations.TabIndex = 7;
            this.lblAcceptations.Text = "Estado(s) de aceptación  [(;) Punto y Coma para Separar]";
            // 
            // btnValidacionAFND
            // 
            this.btnValidacionAFND.Enabled = false;
            this.btnValidacionAFND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidacionAFND.ForeColor = System.Drawing.Color.Blue;
            this.btnValidacionAFND.Location = new System.Drawing.Point(32, 389);
            this.btnValidacionAFND.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValidacionAFND.Name = "btnValidacionAFND";
            this.btnValidacionAFND.Size = new System.Drawing.Size(417, 35);
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
            this.btnCancelar.Location = new System.Drawing.Point(1749, 638);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.Green;
            this.btnGenerar.Location = new System.Drawing.Point(32, 345);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(417, 35);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.Text = "Generar Tabla de Transición";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(690, 563);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // btnPaso01
            // 
            this.btnPaso01.Enabled = false;
            this.btnPaso01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaso01.ForeColor = System.Drawing.Color.Orange;
            this.btnPaso01.Location = new System.Drawing.Point(32, 434);
            this.btnPaso01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPaso01.Name = "btnPaso01";
            this.btnPaso01.Size = new System.Drawing.Size(417, 35);
            this.btnPaso01.TabIndex = 13;
            this.btnPaso01.Text = "Paso 01 - Normalizar Estados";
            this.btnPaso01.UseVisualStyleBackColor = true;
            this.btnPaso01.Click += new System.EventHandler(this.btnPaso01_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1176, 66);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(690, 563);
            this.dataGridView2.TabIndex = 14;
            // 
            // btnNuevaTablaTransicion
            // 
            this.btnNuevaTablaTransicion.Enabled = false;
            this.btnNuevaTablaTransicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaTablaTransicion.ForeColor = System.Drawing.Color.Purple;
            this.btnNuevaTablaTransicion.Location = new System.Drawing.Point(32, 479);
            this.btnNuevaTablaTransicion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevaTablaTransicion.Name = "btnNuevaTablaTransicion";
            this.btnNuevaTablaTransicion.Size = new System.Drawing.Size(417, 35);
            this.btnNuevaTablaTransicion.TabIndex = 15;
            this.btnNuevaTablaTransicion.Text = "Paso 02 - Llenar Nueva Tabla de Transición";
            this.btnNuevaTablaTransicion.UseVisualStyleBackColor = true;
            this.btnNuevaTablaTransicion.Click += new System.EventHandler(this.btnNuevaTablaTransicion_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1880, 692);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Compiladores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
    }
}

