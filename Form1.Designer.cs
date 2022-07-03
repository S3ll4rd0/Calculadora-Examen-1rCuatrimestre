namespace ExamenANSR
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Operaciones = new System.Windows.Forms.ListBox();
            this.botonImprimirOps = new System.Windows.Forms.Button();
            this.botonImprimirResult = new System.Windows.Forms.Button();
            this.botonParentesisIzq = new System.Windows.Forms.Button();
            this.botonParentesisDer = new System.Windows.Forms.Button();
            this.botonCambioSigno = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.botonCambioPro = new System.Windows.Forms.Button();
            this.pantallaCalculadora = new System.Windows.Forms.Label();
            this.botonComa = new System.Windows.Forms.Button();
            this.botonSuma = new System.Windows.Forms.Button();
            this.botonIgual = new System.Windows.Forms.Button();
            this.botonBorradoParcial = new System.Windows.Forms.Button();
            this.botonBorradoTotal = new System.Windows.Forms.Button();
            this.botonRaizCuadrada = new System.Windows.Forms.Button();
            this.botonDividir = new System.Windows.Forms.Button();
            this.botonMultiplicar = new System.Windows.Forms.Button();
            this.botonResta = new System.Windows.Forms.Button();
            this.boton1PartidoX = new System.Windows.Forms.Button();
            this.botonPorcentaje = new System.Windows.Forms.Button();
            this.botonXElevadoY = new System.Windows.Forms.Button();
            this.botonRaizSqr = new System.Windows.Forms.Button();
            this.botonDelete = new System.Windows.Forms.Button();
            this.botonPotencia2 = new System.Windows.Forms.Button();
            this.pantallaCalculadora1 = new System.Windows.Forms.Label();
            this.pantallaCalculadora2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Operaciones
            // 
            this.Operaciones.FormattingEnabled = true;
            this.Operaciones.ItemHeight = 16;
            this.Operaciones.Location = new System.Drawing.Point(428, 28);
            this.Operaciones.Name = "Operaciones";
            this.Operaciones.Size = new System.Drawing.Size(260, 388);
            this.Operaciones.TabIndex = 1;
            // 
            // botonImprimirOps
            // 
            this.botonImprimirOps.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonImprimirOps.Location = new System.Drawing.Point(428, 425);
            this.botonImprimirOps.Name = "botonImprimirOps";
            this.botonImprimirOps.Size = new System.Drawing.Size(260, 50);
            this.botonImprimirOps.TabIndex = 2;
            this.botonImprimirOps.Text = "Imprimir ultimas operaciones";
            this.botonImprimirOps.UseVisualStyleBackColor = true;
            this.botonImprimirOps.Click += new System.EventHandler(this.botonImprimirOps_Click);
            // 
            // botonImprimirResult
            // 
            this.botonImprimirResult.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonImprimirResult.Location = new System.Drawing.Point(428, 482);
            this.botonImprimirResult.Name = "botonImprimirResult";
            this.botonImprimirResult.Size = new System.Drawing.Size(260, 50);
            this.botonImprimirResult.TabIndex = 3;
            this.botonImprimirResult.Text = "Resultado ultimas operaciones";
            this.botonImprimirResult.UseVisualStyleBackColor = true;
            this.botonImprimirResult.Click += new System.EventHandler(this.botonImprimirResult_Click);
            // 
            // botonParentesisIzq
            // 
            this.botonParentesisIzq.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonParentesisIzq.ForeColor = System.Drawing.Color.Green;
            this.botonParentesisIzq.Location = new System.Drawing.Point(29, 251);
            this.botonParentesisIzq.Name = "botonParentesisIzq";
            this.botonParentesisIzq.Size = new System.Drawing.Size(60, 40);
            this.botonParentesisIzq.TabIndex = 4;
            this.botonParentesisIzq.Text = "(";
            this.botonParentesisIzq.UseVisualStyleBackColor = true;
            this.botonParentesisIzq.Visible = false;
            this.botonParentesisIzq.Click += new System.EventHandler(this.botonParentesisDer_Click);
            // 
            // botonParentesisDer
            // 
            this.botonParentesisDer.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonParentesisDer.ForeColor = System.Drawing.Color.Green;
            this.botonParentesisDer.Location = new System.Drawing.Point(106, 251);
            this.botonParentesisDer.Name = "botonParentesisDer";
            this.botonParentesisDer.Size = new System.Drawing.Size(60, 40);
            this.botonParentesisDer.TabIndex = 5;
            this.botonParentesisDer.Text = ")";
            this.botonParentesisDer.UseVisualStyleBackColor = true;
            this.botonParentesisDer.Visible = false;
            this.botonParentesisDer.Click += new System.EventHandler(this.botonParentesisIzq_Click);
            // 
            // botonCambioSigno
            // 
            this.botonCambioSigno.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCambioSigno.ForeColor = System.Drawing.Color.Green;
            this.botonCambioSigno.Location = new System.Drawing.Point(183, 251);
            this.botonCambioSigno.Name = "botonCambioSigno";
            this.botonCambioSigno.Size = new System.Drawing.Size(60, 40);
            this.botonCambioSigno.TabIndex = 6;
            this.botonCambioSigno.Text = "+/-";
            this.botonCambioSigno.UseVisualStyleBackColor = true;
            this.botonCambioSigno.Visible = false;
            this.botonCambioSigno.Click += new System.EventHandler(this.botonCambioSigno_Click);
            // 
            // boton7
            // 
            this.boton7.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton7.Location = new System.Drawing.Point(29, 297);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(60, 40);
            this.boton7.TabIndex = 7;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = true;
            this.boton7.Click += new System.EventHandler(this.boton7_Click);
            // 
            // boton8
            // 
            this.boton8.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton8.Location = new System.Drawing.Point(106, 297);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(60, 40);
            this.boton8.TabIndex = 8;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = true;
            this.boton8.Click += new System.EventHandler(this.boton8_Click);
            // 
            // boton9
            // 
            this.boton9.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton9.Location = new System.Drawing.Point(183, 297);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(60, 40);
            this.boton9.TabIndex = 9;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = true;
            this.boton9.Click += new System.EventHandler(this.boton9_Click);
            // 
            // boton4
            // 
            this.boton4.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton4.Location = new System.Drawing.Point(29, 343);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(60, 40);
            this.boton4.TabIndex = 10;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = true;
            this.boton4.Click += new System.EventHandler(this.boton4_Click);
            // 
            // boton5
            // 
            this.boton5.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton5.Location = new System.Drawing.Point(106, 343);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(60, 40);
            this.boton5.TabIndex = 11;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = true;
            this.boton5.Click += new System.EventHandler(this.boton5_Click);
            // 
            // boton6
            // 
            this.boton6.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton6.Location = new System.Drawing.Point(183, 343);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(60, 40);
            this.boton6.TabIndex = 12;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = true;
            this.boton6.Click += new System.EventHandler(this.boton6_Click);
            // 
            // boton1
            // 
            this.boton1.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(29, 389);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(60, 40);
            this.boton1.TabIndex = 13;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(106, 389);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(60, 40);
            this.boton2.TabIndex = 14;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton3
            // 
            this.boton3.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.Location = new System.Drawing.Point(183, 389);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(60, 40);
            this.boton3.TabIndex = 15;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // boton0
            // 
            this.boton0.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton0.Location = new System.Drawing.Point(29, 435);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(137, 40);
            this.boton0.TabIndex = 16;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = true;
            this.boton0.Click += new System.EventHandler(this.boton0_Click);
            // 
            // botonCambioPro
            // 
            this.botonCambioPro.Font = new System.Drawing.Font("Imprint MT Shadow", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCambioPro.Location = new System.Drawing.Point(29, 492);
            this.botonCambioPro.Name = "botonCambioPro";
            this.botonCambioPro.Size = new System.Drawing.Size(350, 40);
            this.botonCambioPro.TabIndex = 17;
            this.botonCambioPro.Text = "Cambiar de Normal a Pro";
            this.botonCambioPro.UseVisualStyleBackColor = true;
            this.botonCambioPro.Click += new System.EventHandler(this.botonCambioPro_Click);
            // 
            // pantallaCalculadora
            // 
            this.pantallaCalculadora.BackColor = System.Drawing.Color.White;
            this.pantallaCalculadora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pantallaCalculadora.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantallaCalculadora.Location = new System.Drawing.Point(29, 28);
            this.pantallaCalculadora.Name = "pantallaCalculadora";
            this.pantallaCalculadora.Size = new System.Drawing.Size(350, 150);
            this.pantallaCalculadora.TabIndex = 18;
            this.pantallaCalculadora.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // botonComa
            // 
            this.botonComa.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonComa.Location = new System.Drawing.Point(183, 435);
            this.botonComa.Name = "botonComa";
            this.botonComa.Size = new System.Drawing.Size(60, 40);
            this.botonComa.TabIndex = 19;
            this.botonComa.Text = ",";
            this.botonComa.UseVisualStyleBackColor = true;
            this.botonComa.Click += new System.EventHandler(this.botonComa_Click);
            // 
            // botonSuma
            // 
            this.botonSuma.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSuma.ForeColor = System.Drawing.Color.Green;
            this.botonSuma.Location = new System.Drawing.Point(253, 435);
            this.botonSuma.Name = "botonSuma";
            this.botonSuma.Size = new System.Drawing.Size(60, 40);
            this.botonSuma.TabIndex = 20;
            this.botonSuma.Text = "+";
            this.botonSuma.UseVisualStyleBackColor = true;
            this.botonSuma.Click += new System.EventHandler(this.botonSuma_Click);
            // 
            // botonIgual
            // 
            this.botonIgual.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIgual.ForeColor = System.Drawing.Color.Green;
            this.botonIgual.Location = new System.Drawing.Point(319, 389);
            this.botonIgual.Name = "botonIgual";
            this.botonIgual.Size = new System.Drawing.Size(60, 86);
            this.botonIgual.TabIndex = 21;
            this.botonIgual.Text = "=";
            this.botonIgual.UseVisualStyleBackColor = true;
            this.botonIgual.Click += new System.EventHandler(this.botonIgual_Click);
            // 
            // botonBorradoParcial
            // 
            this.botonBorradoParcial.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorradoParcial.ForeColor = System.Drawing.Color.Red;
            this.botonBorradoParcial.Location = new System.Drawing.Point(319, 297);
            this.botonBorradoParcial.Name = "botonBorradoParcial";
            this.botonBorradoParcial.Size = new System.Drawing.Size(60, 40);
            this.botonBorradoParcial.TabIndex = 24;
            this.botonBorradoParcial.Text = "CE";
            this.botonBorradoParcial.UseVisualStyleBackColor = true;
            this.botonBorradoParcial.Click += new System.EventHandler(this.botonBorradoParcial_Click);
            // 
            // botonBorradoTotal
            // 
            this.botonBorradoTotal.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorradoTotal.ForeColor = System.Drawing.Color.Red;
            this.botonBorradoTotal.Location = new System.Drawing.Point(319, 251);
            this.botonBorradoTotal.Name = "botonBorradoTotal";
            this.botonBorradoTotal.Size = new System.Drawing.Size(60, 40);
            this.botonBorradoTotal.TabIndex = 25;
            this.botonBorradoTotal.Text = "C";
            this.botonBorradoTotal.UseVisualStyleBackColor = true;
            this.botonBorradoTotal.Click += new System.EventHandler(this.botonBorradoTotal_Click);
            // 
            // botonRaizCuadrada
            // 
            this.botonRaizCuadrada.Font = new System.Drawing.Font("Imprint MT Shadow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRaizCuadrada.ForeColor = System.Drawing.Color.Green;
            this.botonRaizCuadrada.Location = new System.Drawing.Point(319, 343);
            this.botonRaizCuadrada.Name = "botonRaizCuadrada";
            this.botonRaizCuadrada.Size = new System.Drawing.Size(60, 40);
            this.botonRaizCuadrada.TabIndex = 26;
            this.botonRaizCuadrada.Text = "Mod";
            this.botonRaizCuadrada.UseVisualStyleBackColor = true;
            this.botonRaizCuadrada.Click += new System.EventHandler(this.botonModulo_Click);
            // 
            // botonDividir
            // 
            this.botonDividir.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDividir.ForeColor = System.Drawing.Color.Green;
            this.botonDividir.Location = new System.Drawing.Point(253, 297);
            this.botonDividir.Name = "botonDividir";
            this.botonDividir.Size = new System.Drawing.Size(60, 40);
            this.botonDividir.TabIndex = 27;
            this.botonDividir.Text = "/";
            this.botonDividir.UseVisualStyleBackColor = true;
            this.botonDividir.Click += new System.EventHandler(this.botonDividir_Click);
            // 
            // botonMultiplicar
            // 
            this.botonMultiplicar.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMultiplicar.ForeColor = System.Drawing.Color.Green;
            this.botonMultiplicar.Location = new System.Drawing.Point(253, 343);
            this.botonMultiplicar.Name = "botonMultiplicar";
            this.botonMultiplicar.Size = new System.Drawing.Size(60, 40);
            this.botonMultiplicar.TabIndex = 28;
            this.botonMultiplicar.Text = "X";
            this.botonMultiplicar.UseVisualStyleBackColor = true;
            this.botonMultiplicar.Click += new System.EventHandler(this.botonMultiplicar_Click);
            // 
            // botonResta
            // 
            this.botonResta.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonResta.ForeColor = System.Drawing.Color.Green;
            this.botonResta.Location = new System.Drawing.Point(253, 389);
            this.botonResta.Name = "botonResta";
            this.botonResta.Size = new System.Drawing.Size(60, 40);
            this.botonResta.TabIndex = 29;
            this.botonResta.Text = "-";
            this.botonResta.UseVisualStyleBackColor = true;
            this.botonResta.Click += new System.EventHandler(this.botonResta_Click);
            // 
            // boton1PartidoX
            // 
            this.boton1PartidoX.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1PartidoX.ForeColor = System.Drawing.Color.Green;
            this.boton1PartidoX.Location = new System.Drawing.Point(29, 205);
            this.boton1PartidoX.Name = "boton1PartidoX";
            this.boton1PartidoX.Size = new System.Drawing.Size(60, 40);
            this.boton1PartidoX.TabIndex = 30;
            this.boton1PartidoX.Text = "1/x";
            this.boton1PartidoX.UseVisualStyleBackColor = true;
            this.boton1PartidoX.Visible = false;
            this.boton1PartidoX.Click += new System.EventHandler(this.boton1PartidoX_Click);
            // 
            // botonPorcentaje
            // 
            this.botonPorcentaje.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPorcentaje.ForeColor = System.Drawing.Color.Green;
            this.botonPorcentaje.Location = new System.Drawing.Point(106, 205);
            this.botonPorcentaje.Name = "botonPorcentaje";
            this.botonPorcentaje.Size = new System.Drawing.Size(60, 40);
            this.botonPorcentaje.TabIndex = 31;
            this.botonPorcentaje.Text = "%";
            this.botonPorcentaje.UseVisualStyleBackColor = true;
            this.botonPorcentaje.Visible = false;
            this.botonPorcentaje.Click += new System.EventHandler(this.botonPorcentaje_Click);
            // 
            // botonXElevadoY
            // 
            this.botonXElevadoY.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonXElevadoY.ForeColor = System.Drawing.Color.Green;
            this.botonXElevadoY.Location = new System.Drawing.Point(183, 205);
            this.botonXElevadoY.Name = "botonXElevadoY";
            this.botonXElevadoY.Size = new System.Drawing.Size(60, 40);
            this.botonXElevadoY.TabIndex = 32;
            this.botonXElevadoY.Text = "x^y";
            this.botonXElevadoY.UseVisualStyleBackColor = true;
            this.botonXElevadoY.Visible = false;
            this.botonXElevadoY.Click += new System.EventHandler(this.botonXElevadoY_Click);
            // 
            // botonRaizSqr
            // 
            this.botonRaizSqr.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRaizSqr.ForeColor = System.Drawing.Color.Green;
            this.botonRaizSqr.Location = new System.Drawing.Point(253, 205);
            this.botonRaizSqr.Name = "botonRaizSqr";
            this.botonRaizSqr.Size = new System.Drawing.Size(60, 40);
            this.botonRaizSqr.TabIndex = 33;
            this.botonRaizSqr.Text = "Raiz";
            this.botonRaizSqr.UseVisualStyleBackColor = true;
            this.botonRaizSqr.Visible = false;
            this.botonRaizSqr.Click += new System.EventHandler(this.botonRaizSqr_Click);
            // 
            // botonDelete
            // 
            this.botonDelete.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDelete.ForeColor = System.Drawing.Color.Red;
            this.botonDelete.Location = new System.Drawing.Point(253, 251);
            this.botonDelete.Name = "botonDelete";
            this.botonDelete.Size = new System.Drawing.Size(60, 40);
            this.botonDelete.TabIndex = 34;
            this.botonDelete.Text = "DEL";
            this.botonDelete.UseVisualStyleBackColor = true;
            this.botonDelete.Click += new System.EventHandler(this.botonDelete_Click);
            // 
            // botonPotencia2
            // 
            this.botonPotencia2.Font = new System.Drawing.Font("Imprint MT Shadow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPotencia2.ForeColor = System.Drawing.Color.Green;
            this.botonPotencia2.Location = new System.Drawing.Point(319, 205);
            this.botonPotencia2.Name = "botonPotencia2";
            this.botonPotencia2.Size = new System.Drawing.Size(60, 40);
            this.botonPotencia2.TabIndex = 35;
            this.botonPotencia2.Text = "x^2";
            this.botonPotencia2.UseVisualStyleBackColor = true;
            this.botonPotencia2.Visible = false;
            this.botonPotencia2.Click += new System.EventHandler(this.botonPotencia2_Click);
            // 
            // pantallaCalculadora1
            // 
            this.pantallaCalculadora1.BackColor = System.Drawing.Color.White;
            this.pantallaCalculadora1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pantallaCalculadora1.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantallaCalculadora1.Location = new System.Drawing.Point(29, 28);
            this.pantallaCalculadora1.Name = "pantallaCalculadora1";
            this.pantallaCalculadora1.Size = new System.Drawing.Size(350, 70);
            this.pantallaCalculadora1.TabIndex = 36;
            this.pantallaCalculadora1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.pantallaCalculadora1.Visible = false;
            // 
            // pantallaCalculadora2
            // 
            this.pantallaCalculadora2.BackColor = System.Drawing.Color.White;
            this.pantallaCalculadora2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pantallaCalculadora2.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantallaCalculadora2.Location = new System.Drawing.Point(29, 108);
            this.pantallaCalculadora2.Name = "pantallaCalculadora2";
            this.pantallaCalculadora2.Size = new System.Drawing.Size(350, 70);
            this.pantallaCalculadora2.TabIndex = 37;
            this.pantallaCalculadora2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.pantallaCalculadora2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.pantallaCalculadora2);
            this.Controls.Add(this.pantallaCalculadora1);
            this.Controls.Add(this.botonPotencia2);
            this.Controls.Add(this.botonDelete);
            this.Controls.Add(this.botonRaizSqr);
            this.Controls.Add(this.botonXElevadoY);
            this.Controls.Add(this.botonPorcentaje);
            this.Controls.Add(this.boton1PartidoX);
            this.Controls.Add(this.botonResta);
            this.Controls.Add(this.botonMultiplicar);
            this.Controls.Add(this.botonDividir);
            this.Controls.Add(this.botonRaizCuadrada);
            this.Controls.Add(this.botonBorradoTotal);
            this.Controls.Add(this.botonBorradoParcial);
            this.Controls.Add(this.botonIgual);
            this.Controls.Add(this.botonSuma);
            this.Controls.Add(this.botonComa);
            this.Controls.Add(this.pantallaCalculadora);
            this.Controls.Add(this.botonCambioPro);
            this.Controls.Add(this.boton0);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.boton9);
            this.Controls.Add(this.boton8);
            this.Controls.Add(this.boton7);
            this.Controls.Add(this.botonCambioSigno);
            this.Controls.Add(this.botonParentesisDer);
            this.Controls.Add(this.botonParentesisIzq);
            this.Controls.Add(this.botonImprimirResult);
            this.Controls.Add(this.botonImprimirOps);
            this.Controls.Add(this.Operaciones);
            this.Name = "Form1";
            this.Text = "Calculadora (by Antonio Nicolás Salmerón Rubio)";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox Operaciones;
        private System.Windows.Forms.Button botonImprimirOps;
        private System.Windows.Forms.Button botonImprimirResult;
        private System.Windows.Forms.Button botonParentesisIzq;
        private System.Windows.Forms.Button botonParentesisDer;
        private System.Windows.Forms.Button botonCambioSigno;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Button botonCambioPro;
        private System.Windows.Forms.Label pantallaCalculadora;
        private System.Windows.Forms.Button botonComa;
        private System.Windows.Forms.Button botonSuma;
        private System.Windows.Forms.Button botonIgual;
        private System.Windows.Forms.Button botonBorradoParcial;
        private System.Windows.Forms.Button botonBorradoTotal;
        private System.Windows.Forms.Button botonRaizCuadrada;
        private System.Windows.Forms.Button botonDividir;
        private System.Windows.Forms.Button botonMultiplicar;
        private System.Windows.Forms.Button botonResta;
        private System.Windows.Forms.Button boton1PartidoX;
        private System.Windows.Forms.Button botonPorcentaje;
        private System.Windows.Forms.Button botonXElevadoY;
        private System.Windows.Forms.Button botonRaizSqr;
        private System.Windows.Forms.Button botonDelete;
        private System.Windows.Forms.Button botonPotencia2;
        private System.Windows.Forms.Label pantallaCalculadora1;
        private System.Windows.Forms.Label pantallaCalculadora2;
    }
}

