using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExamenANSR
{
    public partial class Form1 : Form
    {
        private String pantalla;
        private String[] operacionesGuardadas = new string[20];
        private String[] resultadosGuardados = new string[20];
        private double[] operadores = new double[50];
        private double operadorTemporal;
        private double resultadoTemporal;
        private int btnSuma = 0;
        private int btnResta = 0;
        private int btnDiv = 0;
        private int btnMulti = 0;
        private int btnMod = 0;
        private double operador1;
        private double operador2;
        private double resultado;
        private int contadorOperaciones;
        private int ProfesionalActivado;
        private String textoPantallaCalcu1;

        public Form1()
        {
            InitializeComponent();
        }

        private void botonCambioPro_Click(object sender, EventArgs e)
        {
            if (boton1PartidoX.Visible == true)
            {
                boton1PartidoX.Visible = false;
                botonParentesisIzq.Visible = false;
                botonParentesisDer.Visible = false;
                botonCambioSigno.Visible = false;
                botonPorcentaje.Visible = false;
                botonXElevadoY.Visible = false;
                botonRaizSqr.Visible = false;
                botonPotencia2.Visible = false;
                pantallaCalculadora1.Visible = false;
                pantallaCalculadora2.Visible = false;
                pantallaCalculadora.Visible = true;
                ProfesionalActivado = 0;
            }
            else
            {
                boton1PartidoX.Visible = true;
                botonParentesisIzq.Visible = true;
                botonParentesisDer.Visible = true;
                botonCambioSigno.Visible = true;
                botonPorcentaje.Visible = true;
                botonXElevadoY.Visible = true;
                botonRaizSqr.Visible = true;
                botonPotencia2.Visible = true;
                pantallaCalculadora1.Visible = true;
                pantallaCalculadora2.Visible = true;
                pantallaCalculadora.Visible = false;
                ProfesionalActivado = 1;
            }
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (pantallaCalculadora.Text == "")
                {
                    pantallaCalculadora.Text = "0";
                }
                else
                {
                    pantallaCalculadora.Text = pantallaCalculadora.Text + "0";
                }
            }
            else
            {
                if (pantallaCalculadora2.Text == "")
                {
                    pantallaCalculadora2.Text = "0";
                }
                else
                {
                    pantallaCalculadora2.Text = pantallaCalculadora2.Text + "0";
                }
            }
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (pantallaCalculadora.Text == "")
                {
                    pantallaCalculadora.Text = "1";
                }
                else
                {
                    pantallaCalculadora.Text = pantallaCalculadora.Text + "1";
                }
            }
            else
            {
                if (pantallaCalculadora2.Text == "")
                {
                    pantallaCalculadora2.Text = "1";
                }
                else
                {
                    pantallaCalculadora2.Text = pantallaCalculadora2.Text + "1";
                }
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (pantallaCalculadora.Text == "")
                {
                    pantallaCalculadora.Text = "2";
                }
                else
                {
                    pantallaCalculadora.Text = pantallaCalculadora.Text + "2";
                }
            }
            else
            {
                if (pantallaCalculadora2.Text == "")
                {
                    pantallaCalculadora2.Text = "2";
                }
                else
                {
                    pantallaCalculadora2.Text = pantallaCalculadora2.Text + "2";
                }
            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (pantallaCalculadora.Text == "")
                {
                    pantallaCalculadora.Text = "3";
                }
                else
                {
                    pantallaCalculadora.Text = pantallaCalculadora.Text + "3";
                }
            }
            else
            {
                if (pantallaCalculadora2.Text == "")
                {
                    pantallaCalculadora2.Text = "3";
                }
                else
                {
                    pantallaCalculadora2.Text = pantallaCalculadora2.Text + "3";
                }
            }
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (pantallaCalculadora.Text == "")
                {
                    pantallaCalculadora.Text = "4";
                }
                else
                {
                    pantallaCalculadora.Text = pantallaCalculadora.Text + "4";
                }
            }
            else
            {
                if (pantallaCalculadora2.Text == "")
                {
                    pantallaCalculadora2.Text = "4";
                }
                else
                {
                    pantallaCalculadora2.Text = pantallaCalculadora2.Text + "4";
                }
            }
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (pantallaCalculadora.Text == "")
                {
                    pantallaCalculadora.Text = "5";
                }
                else
                {
                    pantallaCalculadora.Text = pantallaCalculadora.Text + "5";
                }
            }
            else
            {
                if (pantallaCalculadora2.Text == "")
                {
                    pantallaCalculadora2.Text = "5";
                }
                else
                {
                    pantallaCalculadora2.Text = pantallaCalculadora2.Text + "5";
                }
            }
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (pantallaCalculadora.Text == "")
                {
                    pantallaCalculadora.Text = "6";
                }
                else
                {
                    pantallaCalculadora.Text = pantallaCalculadora.Text + "6";
                }
            }
            else
            {
                if (pantallaCalculadora2.Text == "")
                {
                    pantallaCalculadora2.Text = "6";
                }
                else
                {
                    pantallaCalculadora2.Text = pantallaCalculadora2.Text + "6";
                }
            }
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (pantallaCalculadora.Text == "")
                {
                    pantallaCalculadora.Text = "7";
                }
                else
                {
                    pantallaCalculadora.Text = pantallaCalculadora.Text + "7";
                }
            }
            else
            {
                if (pantallaCalculadora2.Text == "")
                {
                    pantallaCalculadora2.Text = "7";
                }
                else
                {
                    pantallaCalculadora2.Text = pantallaCalculadora2.Text + "7";
                }
            }
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (pantallaCalculadora.Text == "")
                {
                    pantallaCalculadora.Text = "8";
                }
                else
                {
                    pantallaCalculadora.Text = pantallaCalculadora.Text + "8";
                }
            }
            else
            {
                if (pantallaCalculadora2.Text == "")
                {
                    pantallaCalculadora2.Text = "8";
                }
                else
                {
                    pantallaCalculadora2.Text = pantallaCalculadora2.Text + "8";
                }
            }
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (pantallaCalculadora.Text == "")
                {
                    pantallaCalculadora.Text = "9";
                }
                else
                {
                    pantallaCalculadora.Text = pantallaCalculadora.Text + "9";
                }
            }
            else
            {
                if (pantallaCalculadora2.Text == "")
                {
                    pantallaCalculadora2.Text = "9";
                }
                else
                {
                    pantallaCalculadora2.Text = pantallaCalculadora2.Text + "9";
                }
            }
        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            if (pantallaCalculadora.Text == "")
            {
                if (pantallaCalculadora.Text == "+")
                {
                    pantallaCalculadora.Text = "+";
                }
                else
                {
                    pantallaCalculadora.Text = "+";
                }

            }
            else
            {
                operador1 = Convert.ToDouble(pantallaCalculadora.Text);
                pantallaCalculadora.Text = "";
                pantallaCalculadora.Text = "+";
                btnSuma = 1;
            }
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            if (pantallaCalculadora.Text == "")
            {
                if (pantallaCalculadora.Text == "-")
                {
                    pantallaCalculadora.Text = "-";
                }
                else
                {
                    pantallaCalculadora.Text = "-";
                }

            }
            else
            {
                operador1 = Convert.ToDouble(pantallaCalculadora.Text);
                pantallaCalculadora.Text = "";
                pantallaCalculadora.Text = "-";
            }
            btnResta = 1;
        }

        private void botonMultiplicar_Click(object sender, EventArgs e)
        {
            if (pantallaCalculadora.Text == "")
            {
                if (pantallaCalculadora.Text == "*")
                {
                    pantallaCalculadora.Text = "*";
                }
                else
                {
                    pantallaCalculadora.Text = "*";
                }

            }
            else
            {
                operador1 = Convert.ToDouble(pantallaCalculadora.Text);
                pantallaCalculadora.Text = "";
                pantallaCalculadora.Text = "*";
            }
            btnMulti = 1;
        }

        private void botonDividir_Click(object sender, EventArgs e)
        {
            if (pantallaCalculadora.Text == "")
            {
                if (pantallaCalculadora.Text == "/")
                {
                    pantallaCalculadora.Text = "/";
                }
                else
                {
                    pantallaCalculadora.Text = "/";
                }

            }
            else
            {
                operador1 = Convert.ToDouble(pantallaCalculadora.Text);
                pantallaCalculadora.Text = "";
                pantallaCalculadora.Text = "/";
            }
            btnDiv = 1;
        }

        private void botonModulo_Click(object sender, EventArgs e)
        {
            if (pantallaCalculadora.Text == "")
            {
                if (pantallaCalculadora.Text == "%")
                {
                    pantallaCalculadora.Text = "%";
                }
                else
                {
                    pantallaCalculadora.Text = "%";
                }

            }
            else
            {
                operador1 = Convert.ToDouble(pantallaCalculadora.Text);
                pantallaCalculadora.Text = "";
                pantallaCalculadora.Text = "%";
            }
            btnMod = 1;
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (pantallaCalculadora.Text == "")
                {
                    operador2 = 0;
                    if (btnSuma == 1)
                    {
                        resultado = operador1 + operador2;
                        pantallaCalculadora.Text = Convert.ToString(resultado);
                        btnSuma = 0;
                        operador1 = 0; operador2 = 0;
                    }
                    if (btnResta == 1)
                    {
                        resultado = operador1 - operador2;
                        pantallaCalculadora.Text = Convert.ToString(resultado);
                        btnResta = 0;
                        operador1 = 0; operador2 = 0;
                    }
                    if (btnMulti == 1)
                    {
                        resultado = operador1 * operador2;
                        pantallaCalculadora.Text = Convert.ToString(resultado);
                        btnMulti = 0;
                        operador1 = 0; operador2 = 0;
                    }
                    if (btnDiv == 1)
                    {
                        resultado = operador1 / operador2;
                        pantallaCalculadora.Text = Convert.ToString(resultado);
                        btnDiv = 0;
                        operador1 = 0; operador2 = 0;
                    }
                    if (btnMod == 1)
                    {
                        resultado = operador1 % operador2;
                        pantallaCalculadora.Text = Convert.ToString(resultado);
                        btnMod = 0;
                        operador1 = 0; operador2 = 0;
                    }
                }
                else
                {
                    if (btnSuma == 1)
                    {
                        operador2 = Convert.ToDouble(getOperador2());
                        resultado = operador1 + operador2;
                        pantallaCalculadora.Text = Convert.ToString(resultado);
                        btnSuma = 0;
                        operador1 = 0; operador2 = 0;
                    }
                    if (btnResta == 1)
                    {
                        operador2 = Convert.ToDouble(getOperador2());
                        resultado = operador1 - operador2;
                        pantallaCalculadora.Text = Convert.ToString(resultado);
                        btnResta = 0;
                        operador1 = 0; operador2 = 0;
                    }
                    if (btnMulti == 1)
                    {
                        operador2 = Convert.ToDouble(getOperador2());
                        resultado = operador1 * operador2;
                        pantallaCalculadora.Text = Convert.ToString(resultado);
                        btnMulti = 0;
                        operador1 = 0; operador2 = 0;
                    }
                    if (btnDiv == 1)
                    {
                        operador2 = Convert.ToDouble(getOperador2());
                        resultado = operador1 / operador2;
                        pantallaCalculadora.Text = Convert.ToString(resultado);
                        btnDiv = 0;
                        operador1 = 0; operador2 = 0;
                    }
                    if (btnMod == 1)
                    {
                        operador2 = Convert.ToDouble(getOperador2());
                        resultado = operador1 % operador2;
                        pantallaCalculadora.Text = Convert.ToString(resultado);
                        btnMod = 0;
                        operador1 = 0; operador2 = 0;
                    }
                }
            }
            else
            {

            }

        }

        private void getOperacion()
        {
            if (contadorOperaciones < 21)
            {
                operacionesGuardadas[contadorOperaciones] = pantallaCalculadora1.Text;
                resultadosGuardados[contadorOperaciones] = Convert.ToString(resultadoTemporal);
                Operaciones.Items.Add(operacionesGuardadas[contadorOperaciones]);
                contadorOperaciones++;
            }
            else
            {
                String[] opTemp = new String[20];
                String[] resTemp = new String[20];
                for (int i = 0; i < 19; i++)
                {
                    opTemp[i] = operacionesGuardadas[i + 1];
                    operacionesGuardadas[i] = opTemp[i];
                    resTemp[i] = resultadosGuardados[i + 1];
                    resultadosGuardados[i] = resTemp[i];
                }
                operacionesGuardadas[19] = pantallaCalculadora1.Text;
                resultadosGuardados[19] = Convert.ToString(resultadoTemporal);
                for (int i = 0; i < 20; i++)
                {
                    Operaciones.Items.Clear();
                    Operaciones.Items.Add(operacionesGuardadas[i]);
                }
            }
        }

        private String getOperador2()
        {
            string texto = pantallaCalculadora.Text;
            string operadorRt = "";
            char[] cifras = new char[pantallaCalculadora.Text.Length];
            for (int i = 0; i < cifras.Length; i++)
            {
                cifras[i] = texto[i];
            }
            for (int i = 1; i < cifras.Length; i++)
            {
                operadorRt += cifras[i];
            }
            return operadorRt;
        }

        private String getOperadorNuevo()
        {
            string texto = pantallaCalculadora2.Text;
            string operadorRt = "";
            char[] cifras = new char[pantallaCalculadora2.Text.Length];
            for (int i = 0; i < cifras.Length; i++)
            {
                cifras[i] = texto[i];
            }
            for (int i = 1; i < cifras.Length; i++)
            {
                operadorRt += cifras[i];
            }
            return operadorRt;
        }

        private void botonCambioSigno_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(pantallaCalculadora2.Text) > 0)
            {
                operadorTemporal = Convert.ToDouble(pantallaCalculadora2.Text);
                operadorTemporal = operadorTemporal - (2 * operadorTemporal);
                pantallaCalculadora2.Text = Convert.ToString(operadorTemporal);
            }
            else if (Convert.ToDouble(pantallaCalculadora2.Text) < 0)
            {
                operadorTemporal = Convert.ToDouble(pantallaCalculadora2.Text);
                operadorTemporal = operadorTemporal + (2 * operadorTemporal);
                pantallaCalculadora2.Text = Convert.ToString(operadorTemporal);
            }
        }

        private void botonParentesisDer_Click(object sender, EventArgs e)
        {
            pantallaCalculadora2.Text += ")";
        }

        private void botonParentesisIzq_Click(object sender, EventArgs e)
        {
            pantallaCalculadora2.Text += "(";
        }

        private void boton1PartidoX_Click(object sender, EventArgs e)
        {

        }

        private void botonPorcentaje_Click(object sender, EventArgs e)
        {

        }

        private void botonXElevadoY_Click(object sender, EventArgs e)
        {

        }

        private void botonRaizSqr_Click(object sender, EventArgs e)
        {
            operadorTemporal = Convert.ToDouble(pantallaCalculadora2.Text);
            operadorTemporal = Math.Sqrt(operadorTemporal);

        }

        private void botonPotencia2_Click(object sender, EventArgs e)
        {
            
        }

        private void botonDelete_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (operador1 == 0)
                {
                    string textoBorrarOp1 = pantallaCalculadora.Text;
                    string textoConDelete = "";
                    char[] cifrasBorrarOp1 = new char[textoBorrarOp1.Length];
                    for (int i = 0; i < textoBorrarOp1.Length; i++)
                    {
                        cifrasBorrarOp1[i] = textoBorrarOp1[i];
                    }
                    for (int i = 0; i < (textoBorrarOp1.Length - 1); i++)
                    {
                        textoConDelete += cifrasBorrarOp1[i];
                        pantallaCalculadora.Text = textoConDelete;
                    }
                }
                else if (operador2 == 0)
                {
                    string textoBorrarOp2 = pantallaCalculadora.Text;
                    string textoConDelete = "";
                    char[] cifrasBorrarOp2 = new char[textoBorrarOp2.Length];
                    for (int i = 0; i < textoBorrarOp2.Length; i++)
                    {
                        cifrasBorrarOp2[i] = textoBorrarOp2[i];
                    }
                    for (int i = 0; i < (textoBorrarOp2.Length - 1); i++)
                    {
                        textoConDelete += cifrasBorrarOp2[i];
                        pantallaCalculadora.Text = textoConDelete;
                    }
                }
            }
            else
            {
                string textoBorrarOperador = pantallaCalculadora2.Text;
                string textoConDelete = "";
                char[] cifrasBorrarOperador = new char[textoBorrarOperador.Length];
                for (int i = 0; i < textoBorrarOperador.Length; i++)
                {
                    cifrasBorrarOperador[i] = textoBorrarOperador[i];
                }
                for (int i = 0; i < (textoBorrarOperador.Length - 1); i++)
                {
                    textoConDelete += textoBorrarOperador[i];
                    pantallaCalculadora2.Text = textoConDelete;
                }
            }
        }

        private void botonBorradoTotal_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                operador1 = 0;
                operador2 = 0;
                pantallaCalculadora.Text = "";
            }
            else
            {
                for (int i = 0; i < operadores.Length; i++)
                {
                    operadores[i] = 0;
                    textoPantallaCalcu1 = "";
                    pantallaCalculadora1.Text = textoPantallaCalcu1;
                    pantallaCalculadora2.Text = "0";
                }
            }
        }

        private void botonBorradoParcial_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (Convert.ToString(operador1) != "")
                {
                    operador1 = 0;
                    pantallaCalculadora.Text = "";
                }
                else
                {
                    ;
                    pantallaCalculadora.Text = "";
                }
                if (Convert.ToString(operador2) != "")
                {
                    operador2 = 0;
                    pantallaCalculadora.Text = "";
                }
                else
                {
                    ;
                    pantallaCalculadora.Text = "";
                }
            }
            else
            {
                operadorTemporal = 0;
                pantallaCalculadora2.Text = "";
            }
        }

        private void botonComa_Click(object sender, EventArgs e)
        {
            if (ProfesionalActivado == 0)
            {
                if (this.pantallaCalculadora.Text.Contains('.') == false)
                {
                    this.pantallaCalculadora.Text = this.pantallaCalculadora.Text + ".";
                }
            }
            else
            {
                if (this.pantallaCalculadora2.Text.Contains('.') == false)
                {
                    this.pantallaCalculadora2.Text = this.pantallaCalculadora2.Text + ".";
                }
            }
        }

        private void botonImprimirOps_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"c:\users\operaciones.txt");
            //file.WriteLine("Operaciones: " + a + c + b + "=" + this.pantalla.Text);
            file.Close();
        }


        private void botonImprimirResult_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"c:\users\resultados.txt");
            //file.WriteLine("Operaciones: " + a + c + b + "=" + this.pantalla.Text);
            file.Close();
        }
    }
}
