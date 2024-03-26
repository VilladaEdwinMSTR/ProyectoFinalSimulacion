using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Individual
{
    public partial class frmInicio : Form
    {
        List<Semilla> lista = new List<Semilla>();
        Semilla g;
        frmPruebas pruebas = new frmPruebas();
        frmProblema problema = new frmProblema();
        //Arreglo para guardar numeros
        public float[] Ri = new float[2000]; 
        float Z2 = 0, Za = 0;
        string[] res = new string[2000];
        int[] poker = new int[12];
        int AD, AE, OP, TE, FE;
        float[] numeros = { 0.11232F, 0.23335F, 0.56789F, 0.55674F, 0.29238F
        , 0.00238F, 0.45672F, 0.89605F, 0.75763F, 0.25555F, 0.12122F, 0.88888F};

        int TodosDiferentes = 0, UnPar = 0, DosPares = 0, TresIguales = 0
        , TresPar = 0, CuatroIguales = 0, TodosIguales = 0;

        bool error = false;
        //public class Semilla
        //{
        //    //creacion de campos
        //    public float X0, Xn, a, c, m, N, Res, modulo;
        //    public float Ri;
        //}
        public void GenerarObjeto()
        {
            g = new Semilla();
            g.X0 = float.Parse(txtSemilla.Text);
            g.a = float.Parse(txtA.Text);
            g.c = float.Parse(txtC.Text);
            g.m = float.Parse(txtM.Text);
        }
        public void GenerarNumeros()
        {
            //numeros.tablaResultados.Clear();
            tblNumeros.Rows.Clear();
            //numeros.tblPseudo.ClearSelection();
            lista.Clear();

            //valor semilla de la que se basaran nuestros numeros
            float x0 = g.X0;
            int n = 0;
            for (int i = 0; i < 2000; i++)
            {
                //si es el primero numero generado entonces 
                if (i == 0)
                {
                    //contador inicia en 1
                    g.N = i + 1;
                    //se recibe nuestra semilla
                    g.Xn = g.X0;
                    //formula de nuestro metodo congruencial mixto
                    g.Res = (g.a * g.Xn) + g.c;
                    //obtenemos el modulo del resultado anterior
                    g.modulo = g.Res % g.m;
                    //lo dividimos entre nuestra constante m y le restamos 1 al resultado
                    g.Ri = g.modulo / g.m;

                    lista.Add(g);

                    //Agrega valores a las filas de la tabla
                    n = tblNumeros.Rows.Add();
                    tblNumeros.Rows[n].Cells[0].Value = n + 1;
                    tblNumeros.Rows[n].Cells[1].Value = lista[n].Ri.ToString("N5");

                    Ri[i] = g.Ri;
                }
                else
                {
                    GenerarObjeto();
                    //contador inicia en 1
                    g.N = i + 1;
                    //se recibe nuestra semilla
                    g.Xn = lista[i - 1].modulo;
                    //formula de nuestro metodo congruencial mixto
                    g.Res = (g.a * g.Xn) + g.c;
                    //obtenemos el modulo del resultado anterior
                    g.modulo = g.Res % g.m;
                    //lo dividimos entre nuestra constante m y le restamos 1 al resultado
                    g.Ri = g.modulo / g.m;

                    lista.Add(g);

                    //Agrega valores a las filas de la tabla
                    n = tblNumeros.Rows.Add();
                    tblNumeros.Rows[n].Cells[0].Value = n + 1;
                    tblNumeros.Rows[n].Cells[1].Value = lista[n].Ri.ToString("N5");

                    Ri[i] = g.Ri;
                }
            }
        }
        public frmInicio()
        {
            InitializeComponent();
        }
        private void Val(TextBox txt, ErrorProvider er, CancelEventArgs c)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txt.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                c.Cancel = true;
                txt.Select(0, txt.Text.Length);
                er.SetError(txt, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
        }
        private void txtSemilla_TextChanged(object sender, EventArgs e)
        {
            TamOriginal();
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtSemilla.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                error1.SetError(txtSemilla, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtSemilla, "");
            }
        }

        private void txtSemilla_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtSemilla, "");
        }

        private void txtSemilla_Validating(object sender, CancelEventArgs e)
        {
            Val(txtSemilla, error1, e);
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            TamOriginal();
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtA.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                error1.SetError(txtA, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtA, "");
            }
        }

        private void txtA_Validated(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtA.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                error1.SetError(txtA, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtA, "");
            }
        }

        private void txtA_Validating(object sender, CancelEventArgs e)
        {
            Val(txtA, error1, e); 
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            error = false;
            TamOriginal();
            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtC.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                error1.SetError(txtC, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtC, "");
            }
        }

        private void txtC_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtSemilla, "");

        }

        private void txtC_Validating(object sender, CancelEventArgs e)
        {
            Val(txtM, error1, e);
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            problema.ShowDialog();
            this.Show();
        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {
            error = false;
            TamOriginal();
            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtM.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (!char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                error1.SetError(txtM, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtM, "");
            }
        }

        private void txtM_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtSemilla, "");
        }

        private void txtM_Validating(object sender, CancelEventArgs e)
        {
            Val(txtM, error1, e);
        }

        private void rb10_Click(object sender, EventArgs e)
        {
            TamOriginal();
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            TamOriginal();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Los número que se encuentran en pantalla\nson los recomendado para la " +
                "generación\nde números pesudo-aleatorios", "\t\tDATO");
            rb5.Checked = true;
            TamOriginal();
        }

        //Metodo para volver a tamaño original
        public void TamOriginal()
        {
            btnCerrar.Location = new Point(305, 12);
            Width = 350;
            Height = 400;
            lblTitulo.Location = new Point(64, 12);
            btnPruebas.Visible = false;
            btnContinuar.Visible = false;
        }

        //Metodo para actualizar tamaño
        public void TamActualizar()
        {
            btnCerrar.Location = new Point(539, 12);
            Width = 600;
            Height = 425;
            lblTitulo.Location = new Point(190, 12);
        }
        bool aprobados = false;
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (error)
            {
                MessageBox.Show("Verifique que los datos sean validos");
            }
            else if (txtSemilla.Text == "" || txtA.Text == "" || txtC.Text == "" || txtM.Text == "")
            {
                MessageBox.Show("Verifique que no haya espacios en blanco");
            }
            else
            {
                btnPruebas.Visible = true;
                TodosDiferentes = 0; UnPar = 0; DosPares = 0; TresIguales = 0;
                TresPar = 0; CuatroIguales = 0; TodosIguales = 0;
                GenerarObjeto();
                TamActualizar();
                if (rb10.Checked == true)
                {
                    Za = 1.645F;
                    Z2 = 6.2514F;
                }
                else if (rb5.Checked == true)
                {
                    Za = 1.96F;
                    Z2 = 7.8147F;
                }
                GenerarNumeros();
                Realizar_PruebaPromedios();
                Realizar_PruebaFrecuencia();
                Realizar_PruebaPoker();
                ImprimirPoker();
                if (pruebas.lblResFrecuencia.Text == "La prueba NO ha sido acreditada" ||
                    pruebas.lblResProme.Text == "La prueba NO ha sido acreditada" ||
                    pruebas.lblResPoker.Text == "La prueba NO ha sido acreditada")
                {
                    MessageBox.Show("Los numeros pseudoaleatorios NO\n estan distribuidos uniformemente\nIngrese otros valores");
                    aprobados = false;
                }
                else
                {
                    MessageBox.Show("Los numeros pseudoaleatorios estan \ndistribuidos uniformemente");
                    aprobados = true;
                }
                if (aprobados)
                {
                    btnContinuar.Visible = true;
                }
            }
            problema.RecibirNumeros(Ri, g);
        }

        public void Realizar_PruebaPromedios()
        {
            float promedio = 0;
            double Zo;

            for (int i = 0; i < lista.Count; i++)
            {
                promedio += lista[i].Ri;
            }

            //Primera formula
            pruebas.lblRi.Text = promedio.ToString();
            pruebas.lbln.Text = lista.Count.ToString();
            pruebas.lbln.Location = new Point((pruebas.lblRi.Right - pruebas.lblRi.Width / 2) - (pruebas.lbln.Width / 2), 75);
            pruebas.pnFormula.Size = new Size(pruebas.lblRi.Width, 1);

            promedio = (promedio / lista.Count);

            pruebas.lblResPromedio.Text = " = " + promedio.ToString();
            pruebas.lblResPromedio.Location = new Point(pruebas.lblRi.Location.X + pruebas.lblRi.Width, 66);

            //Segunda formula
            pruebas.lblZoSuperior.Text = $"({promedio} - 0.50) · √({lista.Count})";
            pruebas.pnZo.Size = new Size(pruebas.lblZoSuperior.Width, 1);
            pruebas.lblZoInferior.Location = new Point((pruebas.lblZoSuperior.Right - pruebas.lblZoSuperior.Width / 2) - (pruebas.lblZoInferior.Width / 2), 133);

            Zo = (((promedio - 0.50F) * Math.Sqrt(lista.Count)) / Math.Sqrt(1F / 12F));

            if (Zo < 0) { Zo *= -1; }

            pruebas.lblZoRes1.Text = $"= {Zo:N5}";
            pruebas.lblZoRes1.Location = new Point(pruebas.lblZoSuperior.Location.X + pruebas.lblZoSuperior.Width, 121);
            pruebas.lblSigPromedios.Text = $"Significancia\r\nZa = {Za}";


            if (Zo <= Za)
            {
                //pruebas.lblSigPromedios.Text = $"Significancia\r\nZa = {Za}";
                pruebas.lblResProme.Text = "La prueba ha sido acreditada";

            }
            else
            {
                pruebas.lblResProme.Text = "La prueba NO ha sido acreditada";
            }

            pruebas.lblResProme.Location = new Point((pruebas.Width / 2) - pruebas.lblResProme.Width / 2, 164);
        }

        public void Realizar_PruebaFrecuencia()
        {
            int N1 = 0, N2 = 0, N3 = 0, N4 = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Ri >= 0 && lista[i].Ri < 0.25)
                {
                    N1++;

                }
                else if (lista[i].Ri >= 0.25 && lista[i].Ri < 0.50)
                {
                    N2++;
                }
                else if (lista[i].Ri >= 0.50 && lista[i].Ri < 0.75)
                {
                    N3++;
                }
                else if (lista[i].Ri >= 0.75 && lista[i].Ri <= 1.00)
                {
                    N4++;
                }
            }

            //VALORES DE TABLA
            pruebas.txtFO1.Text = N1.ToString();
            pruebas.txtFO2.Text = N2.ToString();
            pruebas.txtFO3.Text = N3.ToString();
            pruebas.txtFO4.Text = N4.ToString();

            float FE = lista.Count / 4F;

            pruebas.txtFE1.Text = FE.ToString();
            pruebas.txtFE2.Text = FE.ToString();
            pruebas.txtFE3.Text = FE.ToString();
            pruebas.txtFE4.Text = FE.ToString();

            //DATOS DE PRUEBA
            pruebas.lblNo_valores.Text = lista.Count.ToString();
            pruebas.lblNo_grupos.Text = "n = 4";

            pruebas.lblNo_valores.Text = "N = " + lista.Count.ToString();
            pruebas.pnformulaFe.Size = new Size(pruebas.lblNformula.Width, 1);
            //pruebas.lblgruposFormula.Location = new Point((pruebas.lblNformula.Right - pruebas.lblNformula.Width / 2) - (pruebas.lblgruposFormula.Width / 2), 360);



            double Xo = (Math.Pow(N1 - FE, 2) / FE) + (Math.Pow(N2 - FE, 2) / FE) +
                (Math.Pow(N3 - FE, 2) / FE) + (Math.Pow(N4 - FE, 2) / FE);
            pruebas.lblSigFrecuencia.Text = $"Significancia\r\nZa = {Z2}";
            pruebas.lblZoRes2.Text = $"= {Xo:N5}";

            if (Xo <= Z2)
            {
                pruebas.lblResFrecuencia.Text = "La prueba ha sido acreditada";
            }
            else
            {
                pruebas.lblResFrecuencia.Text = "La prueba NO ha sido acreditada";
            }
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            this.Hide();
            pruebas.ShowDialog();
            this.Show();
        }
        public void Realizar_PruebaPoker()
        {
            AD = 0;
            OP = 0;
            TE = 0;
            FE = 0;
            AE = 0;

            TodosDiferentes = 0;
            UnPar = 0;
            DosPares = 0;
            TresIguales = 0;
            TresPar = 0;
            CuatroIguales = 0;
            TodosIguales = 0;

            int m = 0;
            //Ciclo para recorrer numeros aleatorios
            for (int numActual = 0; numActual < Ri.Length; numActual++)
            {
                int poss = 0;
                string num = Ri[numActual].ToString("N5");

                //Esto divide las palabras con el split recorriendo carácter por carácter
                num.Split(new char[] { ' ' });

                //Areglo de caracteres
                char[] n = new char[7];

                //Este bucle recorrera el string que contiene el numero
                foreach (char caracter in num)
                {
                    n[poss] = caracter;
                    poss++;
                }

                //Indicadores de si el numero ya fue analizado o no
                bool uno = false, dos = false, tres = false, cuatro = false;
                //Ciclo para recorrer Arreglo del numero separado en caracteres
                for (int i = 2; i < n.Length; i++)
                {
                    int Cont = 0;

                    if (i == 2)
                    {
                        if (n[i] == n[3] && uno == false)
                        {
                            Cont++;
                            uno = true;
                        }
                        if (n[i] == n[4] && dos == false)
                        {
                            Cont++;
                            dos = true;
                        }
                        if (n[i] == n[5] && tres == false)
                        {
                            Cont++;
                            tres = true;
                        }
                        if (n[i] == n[6] && cuatro == false)
                        {
                            Cont++;
                            cuatro = true;
                        }
                    }
                    if (i == 3)
                    {
                        if (n[i] == n[4] && dos == false)
                        {
                            Cont++;
                            dos = true;
                        }
                        if (n[i] == n[5] && tres == false)
                        {
                            Cont++;
                            tres = true;
                        }
                        if (n[i] == n[6] && cuatro == false)
                        {
                            Cont++;
                            cuatro = true;
                        }
                    }
                    if (i == 4)
                    {
                        if (n[i] == n[5] && tres == false)
                        {
                            Cont++;
                            tres = true;
                        }
                        if (n[i] == n[6] && cuatro == false)
                        {
                            Cont++;
                            cuatro = true;
                        }
                    }
                    if (i == 5)
                    {
                        if (n[i] == n[6] && cuatro == false)
                        {
                            Cont++;
                            cuatro = true;
                        }
                    }
                    if (Cont == 0)
                    {
                        AD++;
                    }
                    if (Cont == 1)
                    {
                        //un par
                        OP++;
                    }
                    if (Cont == 2)
                    {
                        //una tercia
                        TE++;
                    }
                    if (Cont == 3)
                    {
                        FE++;
                    }
                    if (Cont == 4)
                    {
                        //Todos iguales
                        res[numActual] = " Todos iguales"; //AE
                        AE++;
                        TodosIguales++;
                        break;
                    }
                }
                //m = tblPseudo.Rows.Add();
                if (AD == 5)
                {
                    res[numActual] = " Todos Diferentes";
                    TodosDiferentes++;
                }
                if (OP == 1 && TE == 0)
                {
                    res[numActual] = " Un Par";
                    UnPar++;
                }
                if (OP == 2)
                {
                    res[numActual] = " Dos Pares";
                    DosPares++;
                }
                if (OP == 1 && TE == 1)
                {
                    res[numActual] = " Tres Iguales y Un Par";
                    TresPar++;
                }
                if (TE == 1 && OP == 0)
                {
                    res[numActual] = " Tres Iguales";
                    TresIguales++;
                }
                if (FE >= 1)
                {
                    res[numActual] = " Cuatro iguales"; //FE
                    CuatroIguales++;
                }
                AD = 0;
                OP = 0;
                TE = 0;
                FE = 0;
                AE = 0;
                m++;
            }
        }

        public void ImprimirPoker()
        {
            float[] FE = new float[7];
            int[] FO = new int[7];
            double[] Xi = new double[7];
            float result = 0;
            double[] Pevetno = { 0.30240, 0.50400, 0.10800, 0.07200, 0.00900, 0.00450, 0.00010 };
            //pruebas.lblResultXi.Text = "";
            //for(int i = 0; i < 7; i++)
            //{
            //    Xi[i] = 0;
            //}


            FO[0] = TodosDiferentes;
            FE[0] = 0.30240F * 2000F;
            result = FO[0] - FE[0];
            Xi[0] = (Math.Pow(result, 2) / FE[0]);
            pruebas.txtTDfo.Text = "" + FO[0];
            pruebas.txtTDpe.Text = "" + Pevetno[0];
            pruebas.txtTDfe.Text = "" + FE[0];
            pruebas.txtXi1.Text = "" + Xi[0].ToString("N5"); 

            FO[1] = UnPar;
            FE[1] = 0.50400F * 2000F;
            result = FO[1] - FE[1];
            Xi[1] = (Math.Pow(result, 2) / FE[1]);
            pruebas.txtUPfo.Text = "" + FO[1];
            pruebas.txtUPpe.Text = "" + Pevetno[1];
            pruebas.txtUPfe.Text = "" + FE[1];
            pruebas.txtXi2.Text = "" + Xi[1].ToString("N5"); 

            FO[2] = DosPares;
            FE[2] = 0.10800F * 2000F;
            result = FO[2] - FE[2];
            Xi[2] = (Math.Pow(result, 2) / FE[2]);
            pruebas.txtDPfo.Text = "" + FO[2];
            pruebas.txtDPpe.Text = "" + Pevetno[2];
            pruebas.txtDPfe.Text = "" + FE[2];
            pruebas.txtXi3.Text = "" + Xi[2].ToString("N5"); 

            FO[3] = TresIguales;
            FE[3] = 0.07200F * 2000F;
            result = FO[3] - FE[3];
            Xi[3] = (Math.Pow(result, 2) / FE[3]);
            pruebas.txtTIfo.Text = "" + FO[3];
            pruebas.txtTIpe.Text = "" + Pevetno[3];
            pruebas.txtTIfe.Text = "" + FE[3];
            pruebas.txtXi4.Text = "" + Xi[3].ToString("N5");

            FO[4] = TresPar;
            FE[4] = 0.00900F * 2000F;
            result = FO[4] - FE[4];
            Xi[4] = (Math.Pow(result, 2) / FE[4]);
            pruebas.txtTIPfo.Text = "" + FO[4];
            pruebas.txtTIPpe.Text = "" + Pevetno[4];
            pruebas.txtTIPfe.Text = "" + FE[4];
            pruebas.txtXi5.Text = "" + Xi[4].ToString("N5"); ;

            FO[5] = CuatroIguales;
            FE[5] = 0.00450F * 2000F;
            result = FO[5] - FE[5];
            Xi[5] = (Math.Pow(result, 2) / FE[5]);
            pruebas.txtCIfo.Text = "" + FO[5];
            pruebas.txtCIpe.Text = "" + Pevetno[5];
            pruebas.txtCIfe.Text = "" + FE[5];
            pruebas.txtXi6.Text = "" + Xi[5].ToString("N5"); ;

            FO[6] = TodosIguales;
            FE[6] = 0.00010F * 2000F;
            result = FO[6] - FE[6];
            Xi[6] = (Math.Pow(result, 2) / FE[6]);
            pruebas.txtTDIfo.Text = "" + FO[6];
            pruebas.txtTDIpe.Text = "" + Pevetno[6];
            pruebas.txtTDIfe.Text = "" + FE[6];
            pruebas.txtXi7.Text = "" + Xi[6].ToString("N5");

            pruebas.lblResultFo.Text = "" + (FO[6] + FO[5] + FO[4] + FO[3] + FO[2] + FO[1] + FO[0]);
            pruebas.lblresultPe.Text = "" + (Pevetno[6] + Pevetno[5] + Pevetno[4] + Pevetno[3] + Pevetno[2] + Pevetno[1] + Pevetno[0]);
            pruebas.lblResultFe.Text = "" + (FE[6] + FE[5] + FE[4] + FE[3] + FE[2] + FE[1] + FE[0]);
            pruebas.lblResultXi.Text = "" + (Xi[6] + Xi[5] + Xi[4] + Xi[3] + Xi[2] + Xi[1] + Xi[0]).ToString("N5");

            if(rb10.Checked == true)
            {
                pruebas.lblSigPok.Text = "" + 10.6446F;
            }
            else if (rb5.Checked == true)
            {
                pruebas.lblSigPok.Text = "" + 12.5916F;
            }
            float Zo = float.Parse(pruebas.lblResultXi.Text);
            float Za = float.Parse(pruebas.lblSigPok.Text);
            if (Zo <= Za)
            {
                pruebas.lblResPoker.Text = "La prueba ha sido acreditada";
            }
            else
            {
                pruebas.lblResPoker.Text = "La prueba NO ha sido acreditada";
            }
        }
    }
    public class Semilla
    {
        //creacion de campos
        public float X0, Xn, a, c, m, N, Res, modulo;
        public float Ri;
    }
}
