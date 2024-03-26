using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proyecto_Final_Individual
{
    public partial class frmProblema : Form
    {
        bool error = false;

        //CLASE INTERVALOS 
        public class Intervals
        {
            public string nombre;
            public float distribucion;
            public float limInf;
            public float limSup;
        }
        //Lista para guardar los intervalos y datos del tematicas y ciudades
        List<Intervals> tematicas = new List<Intervals>();
        List<Intervals> ciudades = new List<Intervals>();

        Intervals tema;
        Intervals ciudad;

        frmIntervalos frmIntervalos = new frmIntervalos();

        int rapidos = 0, league = 0, jurassic = 0, star = 0, cartel = 0, halo = 0;
        int tijuana = 0, cdmx = 0, ciudJuarez = 0, gdlj = 0, mntry = 0, zapo = 0, 
            hermo = 0, salti = 0, can = 0, culi = 0;
        //asignacion de resultados al problema
        private string LimitesTematicas(float num_muestra)
        {
            if (num_muestra >= tematicas[0].limInf && num_muestra <= tematicas[0].limSup)
            {
                rapidos++;
                //return 1;
                return "Rápidos y Furiosos";
            }
            else if (num_muestra >= tematicas[1].limInf && num_muestra <= tematicas[1].limSup)
            {
                league++;
                return "League of Legends";
                //return 2;
            }
            else if (num_muestra >= tematicas[2].limInf && num_muestra <= tematicas[2].limSup)
            {
                halo++;
                return "Halo";
                //return 3;
            }
            else if (num_muestra >= tematicas[3].limInf && num_muestra <= tematicas[3].limSup)
            {
                jurassic++;
                return "Jurassic World";
                //return 4;
            }
            else if(num_muestra >= tematicas[4].limInf && num_muestra <= tematicas[4].limSup)
            {
                star++;
                return "Star Wars";
                //return 5;
            }
            else
            {
                cartel++;
                return "Cartel de Santa";
            }
        }
        public void RellenarListaTematicas()
        {
            tema = new Intervals();
            tema.nombre = "Rápidos y Furiosos";
            tema.distribucion = temRapi;
            tema.limInf = 0;
            tema.limSup = tema.limInf + tema.distribucion;
            tematicas.Add(tema);

            tema = new Intervals();
            tema.nombre = "League of Legends";
            tema.distribucion = temLeague;
            tema.limInf = tematicas[0].limSup;
            tema.limSup = tema.limInf + tema.distribucion;
            tematicas.Add(tema);

            tema = new Intervals();
            tema.nombre = "Halo";
            tema.distribucion = temHalo;
            tema.limInf = tematicas[1].limSup;
            tema.limSup = tema.limInf + tema.distribucion;
            tematicas.Add(tema);

            tema = new Intervals();
            tema.nombre = "Jurassic World";
            tema.distribucion = temJura;
            tema.limInf = tematicas[2].limSup;
            tema.limSup = tema.limInf + tema.distribucion;
            tematicas.Add(tema);

            tema = new Intervals();
            tema.nombre = "Star Wars";
            tema.distribucion = temStar;
            tema.limInf = tematicas[3].limSup;
            tema.limSup = tema.limInf + tema.distribucion;
            tematicas.Add(tema);


            tema = new Intervals();
            tema.nombre = "Cartel de Santa";
            tema.distribucion = temCartel;
            tema.limInf = tematicas[4].limSup;
            tema.limSup = tema.limInf + tema.distribucion;
            tematicas.Add(tema);
        }

        public void RellenarListaCiudades()
        {
            ciudad = new Intervals();
            ciudad.nombre = "Tijuana";
            ciudad.distribucion = cdTij;
            ciudad.limInf = 0;
            ciudad.limSup = ciudad.limInf + ciudad.distribucion;
            ciudades.Add(ciudad);

            ciudad = new Intervals();
            ciudad.nombre = "Ciudad de México";
            ciudad.distribucion = cdMexico;
            ciudad.limInf = ciudades[0].limSup;
            ciudad.limSup = ciudad.limInf + ciudad.distribucion;
            ciudades.Add(ciudad);

            ciudad = new Intervals();
            ciudad.nombre = "Ciudad Juárez";
            ciudad.distribucion = cdJuarez;
            ciudad.limInf = ciudades[1].limSup;
            ciudad.limSup = ciudad.limInf + ciudad.distribucion;
            ciudades.Add(ciudad);

            ciudad = new Intervals();
            ciudad.nombre = "Guadalajara";
            ciudad.distribucion = cdGuada;
            ciudad.limInf = ciudades[2].limSup;
            ciudad.limSup = ciudad.limInf + ciudad.distribucion;
            ciudades.Add(ciudad);

            ciudad = new Intervals();
            ciudad.nombre = "Monterrey";
            ciudad.distribucion = cdMonte;
            ciudad.limInf = ciudades[3].limSup;
            ciudad.limSup = ciudad.limInf + ciudad.distribucion;
            ciudades.Add(ciudad);

            ciudad = new Intervals();
            ciudad.nombre = "Zapopan";
            ciudad.distribucion = cdZapo;
            ciudad.limInf = ciudades[4].limSup;
            ciudad.limSup = ciudad.limInf + ciudad.distribucion;
            ciudades.Add(ciudad);

            ciudad = new Intervals();
            ciudad.nombre = "Hermosillo";
            ciudad.distribucion = cdHermo;
            ciudad.limInf = ciudades[5].limSup;
            ciudad.limSup = ciudad.limInf + ciudad.distribucion;
            ciudades.Add(ciudad);

            ciudad = new Intervals();
            ciudad.nombre = "Saltillo";
            ciudad.distribucion = cdSalt;
            ciudad.limInf = ciudades[6].limSup;
            ciudad.limSup = ciudad.limInf + ciudad.distribucion;
            ciudades.Add(ciudad);

            ciudad = new Intervals();
            ciudad.nombre = "Cancún";
            ciudad.distribucion = cdCancun;
            ciudad.limInf = ciudades[7].limSup;
            ciudad.limSup = ciudad.limInf + ciudad.distribucion;
            ciudades.Add(ciudad);

            ciudad = new Intervals();
            ciudad.nombre = "Culiacán";
            ciudad.distribucion = cdCuliacan;
            ciudad.limInf = ciudades[8].limSup;
            ciudad.limSup = ciudad.limInf + ciudad.distribucion;
            ciudades.Add(ciudad);
        }
        public void CargarLimitesEnListas()
        {
            RellenarListaTematicas();
            RellenarListaCiudades();
        }
        private void btnInterval_Click(object sender, EventArgs e)
        {
            ////Limpia las filas de las tablas de animales y de agua
            //frmIntervalos.tblTema.Rows.Clear();
            //frmIntervalos.tblCiudad.Rows.Clear();

            ////Limpiar las listas de animales y agua
            //tematicas.Clear();
            //ciudades.Clear();

            //CargarLimitesEnListas();

            for (int i = 0; i < tematicas.Count; i++)
            {
                int n = frmIntervalos.tblTema.Rows.Add();
                frmIntervalos.tblTema.Rows[n].Cells[0].Value = tematicas[i].nombre;
                frmIntervalos.tblTema.Rows[n].Cells[1].Value = tematicas[i].distribucion;
                frmIntervalos.tblTema.Rows[n].Cells[2].Value = tematicas[i].limInf;
                frmIntervalos.tblTema.Rows[n].Cells[3].Value = tematicas[i].limSup;
            }
            for (int i = 0; i < ciudades.Count; i++)
            {
                int m = frmIntervalos.tblCiudad.Rows.Add();
                frmIntervalos.tblCiudad.Rows[m].Cells[0].Value = ciudades[i].nombre;
                frmIntervalos.tblCiudad.Rows[m].Cells[1].Value = ciudades[i].distribucion;
                frmIntervalos.tblCiudad.Rows[m].Cells[2].Value = ciudades[i].limInf;
                frmIntervalos.tblCiudad.Rows[m].Cells[3].Value = ciudades[i].limSup;
            }
            frmIntervalos.ShowDialog();
        }

        private void MostrarIntervalos(object sender, EventArgs e)
        {
            frmIntervalos.Show();
        }

        private void txtRapidos_TextChanged_1(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtRapidos.Text)
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
                error1.SetError(txtRapidos, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtRapidos, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtRapidos_Validated_1(object sender, EventArgs e)
        {
            error1.SetError(txtRapidos, "");
        }

        private void txtRapidos_Validating_1(object sender, CancelEventArgs e)
        {
            Val(txtRapidos, error1, e);
        }

        private void txtLeague_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtLeague.Text)
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
                error1.SetError(txtLeague, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtLeague, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtHalo_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtHalo.Text)
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
                error1.SetError(txtHalo, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtHalo, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtJurassic_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtJurassic.Text)
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
                error1.SetError(txtJurassic, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtJurassic, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStar_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtStar.Text)
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
                error1.SetError(txtStar, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtStar, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtStar_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtStar, "");
        }

        private void txtCartel_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtCartel.Text)
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
                error1.SetError(txtCartel, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtCartel, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtTij_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtCartel.Text)
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
                error1.SetError(txtTij, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtTij, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtCdmx_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtCdmx.Text)
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
                error1.SetError(txtCdmx, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtCdmx, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtCj_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtCj.Text)
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
                error1.SetError(txtCj, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtCj, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtGdlj_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtGdlj.Text)
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
                error1.SetError(txtGdlj, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtGdlj, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtMntry_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtMntry.Text)
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
                error1.SetError(txtMntry, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtMntry, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtZapo_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtZapo.Text)
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
                error1.SetError(txtZapo, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtZapo, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtHermo_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtHermo.Text)
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
                error1.SetError(txtHermo, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtHermo, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtSalt_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtSalt.Text)
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
                error1.SetError(txtSalt, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtSalt, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtCan_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtCan.Text)
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
                error1.SetError(txtCan, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtCan, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtCulia_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtCulia.Text)
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
                error1.SetError(txtCulia, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtCulia, "");
            }
            btnInterval.Visible = false;
            btnResolver.Visible = false;
        }

        private void txtLeague_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtLeague, "");
        }

        private void txtHalo_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtHalo, "");
        }

        private void txtJurassic_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtJurassic, "");
        }

        private void txtCartel_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtCartel, "");
        }

        private void txtTij_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtTij, "");
        }

        private void txtCdmx_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtCdmx, "");
        }

        private void txtCj_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtCj, "");
        }

        private void txtGdlj_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtGdlj, "");
        }

        private void txtMntry_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtMntry, "");
        }

        private void txtZapo_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtZapo, "");
        }

        private void txtHermo_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtHermo, "");
        }

        private void txtSalt_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtSalt, "");
        }

        private void txtCan_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtCan, "");
        }

        private void txtCulia_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtCulia, "");
        }

        private void txtLeague_Validating(object sender, CancelEventArgs e)
        {
            Val(txtLeague, error1, e);
        }

        private void txtHalo_Validating(object sender, CancelEventArgs e)
        {
            Val(txtHalo, error1, e);
        }

        private void txtJurassic_Validating(object sender, CancelEventArgs e)
        {
            Val(txtJurassic, error1, e);
        }

        private void txtStar_Validating(object sender, CancelEventArgs e)
        {
            Val(txtStar, error1, e);
        }

        private void txtCartel_Validating(object sender, CancelEventArgs e)
        {
            Val(txtCartel, error1, e);
        }

        private void txtTij_Validating(object sender, CancelEventArgs e)
        {
            Val(txtTij, error1, e);
        }

        private void txtCdmx_Validating(object sender, CancelEventArgs e)
        {
            Val(txtCdmx, error1, e);
        }

        private void txtCj_Validating(object sender, CancelEventArgs e)
        {
            Val(txtCj, error1, e);
        }

        private void txtGdlj_Validating(object sender, CancelEventArgs e)
        {
            Val(txtGdlj, error1, e);
        }

        private void txtMntry_Validating(object sender, CancelEventArgs e)
        {
            Val(txtMntry, error1, e);
        }

        private void txtZapo_Validating(object sender, CancelEventArgs e)
        {
            Val(txtZapo, error1, e);
        }

        private void txtHermo_Validating(object sender, CancelEventArgs e)
        {
            Val(txtHermo, error1, e);
        }

        private void txtSalt_Validating(object sender, CancelEventArgs e)
        {
            Val(txtSalt, error1, e);
        }

        private void txtCan_Validating(object sender, CancelEventArgs e)
        {
            Val(txtCan, error1, e);
        }

        private void txtCulia_Validating(object sender, CancelEventArgs e)
        {
            Val(txtCulia, error1, e);
        }

        private string LimitesCiudades(float num_muestra)
        {

            if (num_muestra >= ciudades[0].limInf && num_muestra <= ciudades[0].limSup)
            {
                tijuana++;
                return "Tijuana";
            }
            else if (num_muestra >= ciudades[1].limInf && num_muestra <= ciudades[1].limSup)
            {
                cdmx++; //mas peligroso
                return "Ciudad de México";

            }
            else if (num_muestra >= ciudades[2].limInf && num_muestra <= ciudades[2].limSup)
            {
                ciudJuarez++;
                return "Ciudad Juárez";
            }
            else if (num_muestra >= ciudades[3].limInf && num_muestra <= ciudades[3].limSup)
            {
                gdlj++;
                return "Guadalajara";
            }
            else if (num_muestra >= ciudades[4].limInf && num_muestra <= ciudades[4].limSup)
            {
                mntry++;
                return "Monterrey";
            }
            else if (num_muestra >= ciudades[5].limInf && num_muestra <= ciudades[5].limSup)
            {
                zapo++;
                return "Zapopan";
            }
            else if(num_muestra >= ciudades[5].limInf && num_muestra <= ciudades[5].limSup)
            {
                hermo++;
                return "Hermosillo";
            }
            else if (num_muestra >= ciudades[5].limInf && num_muestra <= ciudades[5].limSup)
            {
                salti++;
                return "Saltillo";
            }
            else if (num_muestra >= ciudades[5].limInf && num_muestra <= ciudades[5].limSup)
            {
                can++;
                return "Cancún";
            }
            else
            {
                culi++;
                return "Culiacán";
            }
        }
        public frmProblema()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void TamOriginal()
        {
            Size = new Size(714, 531);
        }
        private void frmProblema_Load(object sender, EventArgs e)
        {
            TamOriginal();
        }
        
        public float ConvertirNum(float datoCapturado)
        {
            return (100000 * datoCapturado * 0.02F);
        }
        public float[] RiA = new float[2000];
        Semilla g;
        public void RecibirNumeros(float[]Ri, Semilla g)
        {
            for(int i = 0; i < 2000; i++)
            {
                RiA[i] = Ri[i];
            }
            this.g = g;
        }
        
        float consTij = 0, consCuli = 0, consCan = 0, consSalt = 0, consGuada = 0, consCdmx = 0;
        float consJuarez = 0, consMont = 0, consZapo = 0, consHermo = 0;

        public void Tam()
        {
            Size = new Size(714,900);
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            tblResultados.Rows.Clear();

            consTij = 0; consCuli = 0; consCan = 0; consSalt = 0; consZapo = 0;
            consJuarez = 0; consHermo = 0; consGuada = 0; consCdmx = 0; consMont = 0;

            consTij = ConvertirNum(cdTij);
            consCuli = ConvertirNum(cdCuliacan);
            consCan = ConvertirNum(cdCancun);    
            consSalt = ConvertirNum(cdSalt);
            consZapo = ConvertirNum(cdZapo);
            consJuarez = ConvertirNum(cdJuarez);
            consHermo = ConvertirNum(cdHermo);
            consGuada = ConvertirNum(cdGuada);
            consCdmx = ConvertirNum(cdMexico);
            consMont = ConvertirNum(cdMonte);

            Seleccion();
            Resolver();
        }
        int contador = 0;

        public class Consumidores
        {
            public int numeroConsumidor;
            public string eleccion;
        }
        Consumidores consumidor;
        List<Consumidores> consum = new List<Consumidores>();

        int contaRapidoTij = 0, contaLeagueTij = 0, contaHaloTij = 0, contaJurassicTij = 0, contaStarTij = 0, contaCartelTij = 0;
        int contaRapidoCdmx = 0, contaLeagueCdmx = 0, contaHaloCdmx = 0, contaJurassicCdmx = 0, contaStarCdmx = 0, contaCartelCdmx = 0;
        int contaRapidoCj = 0, contaLeagueCj = 0, contaHaloCj = 0, contaJurassicCj = 0, contaStarCj = 0, contaCartelCj = 0;
        int contaRapidoGdl = 0, contaLeagueGdl = 0, contaHaloGdl = 0, contaJurassicGdl = 0, contaStarGdl = 0, contaCartelGdl = 0;
        int contaRapidoMnt = 0, contaLeagueMnt = 0, contaHaloMnt = 0, contaJurassicMnt = 0, contaStarMnt = 0, contaCartelMnt = 0;
        int contaRapidoZap = 0, contaLeagueZap = 0, contaHaloZap = 0, contaJurassicZap = 0, contaStarZap = 0, contaCartelZap = 0;
        int contaRapidoHer = 0, contaLeagueHer = 0, contaHaloHer = 0, contaJurassicHer = 0, contaStarHer = 0, contaCartelHer = 0;
        int contaRapidoSal = 0, contaLeagueSal = 0, contaHaloSal = 0, contaJurassicSal = 0, contaStarSal = 0, contaCartelSal = 0;
        int contaRapidoCan = 0, contaLeagueCan = 0, contaHaloCan = 0, contaJurassicCan = 0, contaStarCan = 0, contaCartelCan = 0;
        int contaRapidoCul = 0, contaLeagueCul = 0, contaHaloCul = 0, contaJurassicCul = 0, contaStarCul = 0, contaCartelCul = 0;
        public void Seleccion()
        {
            contaRapidoTij = 0; contaLeagueTij = 0; contaHaloTij = 0; contaJurassicTij = 0; contaStarTij = 0; contaCartelTij = 0;
            contaRapidoCdmx = 0; contaLeagueCdmx = 0; contaHaloCdmx = 0; contaJurassicCdmx = 0; contaStarCdmx = 0; contaCartelCdmx = 0;
            contaRapidoCj = 0; contaLeagueCj = 0; contaHaloCj = 0; contaJurassicCj = 0; contaStarCj = 0; contaCartelCj = 0;
            contaRapidoGdl = 0; contaLeagueGdl = 0; contaHaloGdl = 0; contaJurassicGdl = 0; contaStarGdl = 0; contaCartelGdl = 0;
            contaRapidoMnt = 0; contaLeagueMnt = 0; contaHaloMnt = 0; contaJurassicMnt = 0; contaStarMnt = 0; contaCartelMnt = 0;
            contaRapidoZap = 0;  contaLeagueZap = 0; contaHaloZap = 0; contaJurassicZap = 0; contaStarZap = 0; contaCartelZap = 0;
            contaRapidoHer = 0; contaLeagueHer = 0; contaHaloHer = 0; contaJurassicHer = 0; contaStarHer = 0; contaCartelHer = 0;
            contaRapidoSal = 0; contaLeagueSal = 0; contaHaloSal = 0; contaJurassicSal = 0; contaStarSal = 0; contaCartelSal = 0;
            contaRapidoCan = 0; contaLeagueCan = 0; contaHaloCan = 0; contaJurassicCan = 0; contaStarCan = 0; contaCartelCan = 0;
            contaRapidoCul = 0; contaLeagueCul = 0; contaHaloCul = 0; contaJurassicCul = 0; contaStarCul = 0; contaCartelCul = 0;
            contador = 0;
            for (int i = 0; i < Math.Round(consTij); i++)
            {
                if (RiA[i] >= 0 && RiA[i] < tematicas[0].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Rápidos y Furiosos";
                    consum.Add(consumidor);
                    contaRapidoTij++;
                }
                else if(RiA[i] >= tematicas[0].limSup && RiA[i] < tematicas[1].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "League of Legends";
                    consum.Add(consumidor);
                    contaLeagueTij++;
                }
                else if(RiA[i] >= tematicas[1].limSup && RiA[i] < tematicas[2].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Halo";
                    consum.Add(consumidor);
                    contaHaloTij++;
                }
                else if (RiA[i] >= tematicas[2].limSup && RiA[i] < tematicas[3].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Jurassic World";
                    consum.Add(consumidor);
                    contaJurassicTij++;
                }
                else if (RiA[i] >= tematicas[3].limSup && RiA[i] < tematicas[4].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Star Wars";
                    consum.Add(consumidor);
                    contaStarTij++;
                }
                else
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Cartel de Santa";
                    consum.Add(consumidor);
                    contaCartelTij++;
                }
                contador++;
            }
            int conta2 = contador;
            for (int i = conta2; i < conta2 + Math.Round(consCan); i++)
            {
                if (RiA[i] >= 0 && RiA[i] < tematicas[0].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Rápidos y Furiosos";
                    consum.Add(consumidor);
                    contaRapidoCan++;
                }
                else if (RiA[i] >= tematicas[0].limSup && RiA[i] < tematicas[1].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "League of Legends";
                    consum.Add(consumidor);
                    contaLeagueCan++;
                }
                else if (RiA[i] >= tematicas[1].limSup && RiA[i] < tematicas[2].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Halo";
                    consum.Add(consumidor);
                    contaHaloCan++;
                }
                else if (RiA[i] >= tematicas[2].limSup && RiA[i] < tematicas[3].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Jurassic World";
                    consum.Add(consumidor);
                    contaJurassicCan++;
                }
                else if (RiA[i] >= tematicas[3].limSup && RiA[i] < tematicas[4].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Star Wars";
                    consum.Add(consumidor);
                    contaStarCan++;
                }
                else
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Cartel de Santa";
                    consum.Add(consumidor);
                    contaCartelCan++;
                }
                contador++;
            }
            int conta3 = contador;
            for (int i = conta3; i < conta3 + consCdmx; i++)
            {
                if (RiA[i] >= 0 && RiA[i] < tematicas[0].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Rápidos y Furiosos";
                    consum.Add(consumidor);
                    contaRapidoCdmx++;
                }
                else if (RiA[i] >= tematicas[0].limSup && RiA[i] < tematicas[1].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "League of Legends";
                    consum.Add(consumidor);
                    contaLeagueCdmx++;
                }
                else if (RiA[i] >= tematicas[1].limSup && RiA[i] < tematicas[2].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Halo";
                    consum.Add(consumidor);
                    contaHaloCdmx++;
                }
                else if (RiA[i] >= tematicas[2].limSup && RiA[i] < tematicas[3].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Jurassic World";
                    consum.Add(consumidor);
                    contaJurassicCdmx++;
                }
                else if (RiA[i] >= tematicas[3].limSup && RiA[i] < tematicas[4].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Star Wars";
                    consum.Add(consumidor);
                    contaStarCdmx++;
                }
                else
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Cartel de Santa";
                    consum.Add(consumidor);
                    contaCartelCdmx++;
                }
                contador++;
            }
            int conta4 = contador;
            for (int i = conta4; i < conta4 + consCuli; i++)
            {
                if (RiA[i] >= 0 && RiA[i] < tematicas[0].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Rápidos y Furiosos";
                    consum.Add(consumidor);
                    contaRapidoCul++;
                }
                else if (RiA[i] >= tematicas[0].limSup && RiA[i] < tematicas[1].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "League of Legends";
                    consum.Add(consumidor);
                    contaLeagueCul++;
                }
                else if (RiA[i] >= tematicas[1].limSup && RiA[i] < tematicas[2].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Halo";
                    consum.Add(consumidor);
                    contaHaloCul++;
                }
                else if (RiA[i] >= tematicas[2].limSup && RiA[i] < tematicas[3].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Jurassic World";
                    consum.Add(consumidor);
                    contaJurassicCul++;
                }
                else if (RiA[i] >= tematicas[3].limSup && RiA[i] < tematicas[4].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Star Wars";
                    consum.Add(consumidor);
                    contaStarCul++;
                }
                else
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Cartel de Santa";
                    consum.Add(consumidor);
                    contaCartelCul++;
                }
                contador++;
            }
            int conta5 = contador;
            for (int i = conta5; i < conta5 + consGuada; i++)
            {
                if (RiA[i] >= 0 && RiA[i] < tematicas[0].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Rápidos y Furiosos";
                    consum.Add(consumidor);
                    contaRapidoGdl++;
                }
                else if (RiA[i] >= tematicas[0].limSup && RiA[i] < tematicas[1].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "League of Legends";
                    consum.Add(consumidor);
                    contaLeagueGdl++;
                }
                else if (RiA[i] >= tematicas[1].limSup && RiA[i] < tematicas[2].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Halo";
                    consum.Add(consumidor);
                    contaHaloGdl++;
                }
                else if (RiA[i] >= tematicas[2].limSup && RiA[i] < tematicas[3].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Jurassic World";
                    consum.Add(consumidor);
                    contaJurassicGdl++;
                }
                else if (RiA[i] >= tematicas[3].limSup && RiA[i] < tematicas[4].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Star Wars";
                    consum.Add(consumidor);
                    contaStarGdl++;
                }
                else
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Cartel de Santa";
                    consum.Add(consumidor);
                    contaCartelGdl++;
                }
                contador++;
            }
            int conta6 = contador;
            for (int i = conta6; i < conta6 + consHermo; i++)
            {
                if (RiA[i] >= 0 && RiA[i] < tematicas[0].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Rápidos y Furiosos";
                    consum.Add(consumidor);
                    contaRapidoHer++;
                }
                else if (RiA[i] >= tematicas[0].limSup && RiA[i] < tematicas[1].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "League of Legends";
                    consum.Add(consumidor);
                    contaLeagueHer++;
                }
                else if (RiA[i] >= tematicas[1].limSup && RiA[i] < tematicas[2].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Halo";
                    consum.Add(consumidor);
                    contaHaloHer++;
                }
                else if (RiA[i] >= tematicas[2].limSup && RiA[i] < tematicas[3].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Jurassic World";
                    consum.Add(consumidor);
                    contaJurassicHer++;
                }
                else if (RiA[i] >= tematicas[3].limSup && RiA[i] < tematicas[4].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Star Wars";
                    consum.Add(consumidor);
                    contaStarHer++;
                }
                else
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Cartel de Santa";
                    consum.Add(consumidor);
                    contaCartelHer++;
                }
                contador++;
            }
            int conta7 = contador;
            for (int i = conta7; i < conta7 + consJuarez; i++)
            {
                if (RiA[i] >= 0 && RiA[i] < tematicas[0].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Rápidos y Furiosos";
                    consum.Add(consumidor);
                    contaRapidoCj++;
                }
                else if (RiA[i] >= tematicas[0].limSup && RiA[i] < tematicas[1].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "League of Legends";
                    consum.Add(consumidor);
                    contaLeagueCj++;
                }
                else if (RiA[i] >= tematicas[1].limSup && RiA[i] < tematicas[2].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Halo";
                    consum.Add(consumidor);
                    contaHaloCj++;
                }
                else if (RiA[i] >= tematicas[2].limSup && RiA[i] < tematicas[3].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Jurassic World";
                    consum.Add(consumidor);
                    contaJurassicCj++;
                }
                else if (RiA[i] >= tematicas[3].limSup && RiA[i] < tematicas[4].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Star Wars";
                    consum.Add(consumidor);
                    contaStarCj++;
                }
                else
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Cartel de Santa";
                    consum.Add(consumidor);
                    contaCartelCj++;
                }
                contador++;
            }
            int conta8 = contador;
            for (int i = conta8; i < conta8 + consMont; i++)
            {
                if (RiA[i] >= 0 && RiA[i] < tematicas[0].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Rápidos y Furiosos";
                    consum.Add(consumidor);
                    contaRapidoMnt++;
                }
                else if (RiA[i] >= tematicas[0].limSup && RiA[i] < tematicas[1].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "League of Legends";
                    consum.Add(consumidor);
                    contaLeagueMnt++;
                }
                else if (RiA[i] >= tematicas[1].limSup && RiA[i] < tematicas[2].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Halo";
                    consum.Add(consumidor);
                    contaHaloMnt++;
                }
                else if (RiA[i] >= tematicas[2].limSup && RiA[i] < tematicas[3].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Jurassic World";
                    consum.Add(consumidor);
                    contaJurassicMnt++;
                }
                else if (RiA[i] >= tematicas[3].limSup && RiA[i] < tematicas[4].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Star Wars";
                    consum.Add(consumidor);
                    contaStarMnt++;
                }
                else
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Cartel de Santa";
                    consum.Add(consumidor);
                    contaCartelMnt++;
                }
                contador++;
            }
            int conta9 = contador;
            for (int i = conta9; i < conta9 + consSalt; i++)
            {
                if (RiA[i] >= 0 && RiA[i] < tematicas[0].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Rápidos y Furiosos";
                    consum.Add(consumidor);
                    contaRapidoSal++;
                }
                else if (RiA[i] >= tematicas[0].limSup && RiA[i] < tematicas[1].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "League of Legends";
                    consum.Add(consumidor);
                    contaLeagueSal++;
                }
                else if (RiA[i] >= tematicas[1].limSup && RiA[i] < tematicas[2].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Halo";
                    consum.Add(consumidor);
                    contaHaloSal++;
                }
                else if (RiA[i] >= tematicas[2].limSup && RiA[i] < tematicas[3].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Jurassic World";
                    consum.Add(consumidor);
                    contaJurassicSal++;
                }
                else if (RiA[i] >= tematicas[3].limSup && RiA[i] < tematicas[4].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Star Wars";
                    consum.Add(consumidor);
                    contaStarSal++;
                }
                else
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Cartel de Santa";
                    consum.Add(consumidor);
                    contaCartelSal++;
                }
                contador++;
            }
            int conta10 = contador;
            for (int i = conta10; i < conta10 + consZapo; i++)
            {
                if (RiA[i] >= 0 && RiA[i] < tematicas[0].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Rápidos y Furiosos";
                    consum.Add(consumidor);
                    contaRapidoZap++;
                }
                else if (RiA[i] >= tematicas[0].limSup && RiA[i] < tematicas[1].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "League of Legends";
                    consum.Add(consumidor);
                    contaLeagueZap++;
                }
                else if (RiA[i] >= tematicas[1].limSup && RiA[i] < tematicas[2].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Halo";
                    consum.Add(consumidor);
                    contaHaloZap++;
                }
                else if (RiA[i] >= tematicas[2].limSup && RiA[i] < tematicas[3].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Jurassic World";
                    consum.Add(consumidor);
                    contaJurassicZap++;
                }
                else if (RiA[i] >= tematicas[3].limSup && RiA[i] < tematicas[4].limSup)
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Star Wars";
                    consum.Add(consumidor);
                    contaStarZap++;
                }
                else
                {
                    consumidor = new Consumidores();
                    consumidor.numeroConsumidor = i+1;
                    consumidor.eleccion = "Cartel de Santa";
                    consum.Add(consumidor);
                    contaCartelZap++;
                }
                contador++;
            }
        }

        public void Resolver()
        {
            tblResultados.Rows.Clear();
            
                int n = tblResultados.Rows.Add();
                string tem = "";
                string numCons = "";
                for (int i = 0; i < 25/*consTij*/; i++)
                {
                    tem += "" + RiA[i] + " " + consum[i].eleccion + "\r\n";
                    numCons += "" + consum[i].numeroConsumidor + "\r\n";
                }
                tblResultados.Rows[0].Cells[0].Value = "Tijuana";
                tblResultados.Rows[0].Cells[1].Value = numCons;
                tblResultados.Rows[0].Cells[2].Value = tem;
                string conta = "";
                conta = "Rápidos y Furiosos = " + contaRapidoTij + "\r\nLeague of Legends = " + contaLeagueTij
                    + "\r\nHalo = " + contaHaloTij + "\r\nJurassic World = " + contaJurassicTij + "\r\nStar Wars = " + contaStarTij
                    + "\r\nCartel de Santa = " + contaCartelTij;
                tblResultados.Rows[0].Cells[3].Value = conta;
                if (contaRapidoTij > contaJurassicTij && contaRapidoTij > contaLeagueTij && contaRapidoTij > contaHaloTij
                    && contaRapidoTij > contaStarTij && contaRapidoTij > contaCartelTij)
                {
                    tblResultados.Rows[0].Cells[4].Value = "Al combo de la ciudad de Tijuana se\nle asignara la temática de Rápidos y Furiosos";
                }
                else if (contaLeagueTij > contaJurassicTij && contaLeagueTij > contaRapidoTij && contaLeagueTij > contaHaloTij
                    && contaLeagueTij > contaStarTij && contaLeagueTij > contaCartelTij)
                {
                    tblResultados.Rows[0].Cells[4].Value = "Al combo de la ciudad de Tijuana se\nle asignara la temática de League of Legends";
                }
                else if (contaHaloTij > contaJurassicTij && contaHaloTij > contaRapidoTij && contaHaloTij > contaLeagueTij
                    && contaHaloTij > contaStarTij && contaHaloTij > contaCartelTij)
                {
                    tblResultados.Rows[0].Cells[4].Value = "Al combo de la ciudad de Tijuana se\nle asignara la temática de Halo";
                }
                else if (contaJurassicTij > contaLeagueTij && contaJurassicTij > contaRapidoTij && contaJurassicTij > contaHaloTij
                   && contaJurassicTij > contaStarTij && contaJurassicTij > contaCartelTij)
                {
                    tblResultados.Rows[0].Cells[4].Value = "Al combo de la ciudad de Tijuana se\nle asignara la temática de Jurassic World";
                }
                else if (contaStarTij > contaJurassicTij && contaStarTij > contaRapidoTij && contaStarTij > contaHaloTij
                   && contaStarTij > contaLeagueTij && contaStarTij > contaCartelTij)
                {
                    tblResultados.Rows[0].Cells[4].Value = "Al combo de la ciudad de Tijuana se\nle asignara la temática de Star Wars";
                }
                else if(contaCartelTij > contaJurassicTij && contaCartelTij > contaRapidoTij && contaCartelTij > contaHaloTij
                   && contaCartelTij > contaLeagueTij && contaCartelTij > contaStarTij)
                {
                    tblResultados.Rows[0].Cells[4].Value = "Al combo de la ciudad de Tijuana se\nle asignara la temática de Cartel de Santa";
                }
                else
                {
                tblResultados.Rows[0].Cells[4].Value = "Debido a los empates entre temáticas, se\nasignara una temática seleccionada al azar entre" +
                    "\nlas temáticas que tuvieron empates";
                }
            
                n = tblResultados.Rows.Add();
                tem = "";
                numCons = "";
                for (int i = 0; i < 25/*consTij*/; i++)
                {
                    tem += "" + RiA[i] + " " + consum[i].eleccion + "\r\n";
                    numCons += "" + consum[i].numeroConsumidor + "\r\n";
                }
                tblResultados.Rows[1].Cells[0].Value = "Ciudad de México";
                tblResultados.Rows[1].Cells[1].Value = numCons;
                tblResultados.Rows[1].Cells[2].Value = tem;
                conta = "";
                conta = "Rápidos y Furiosos = " + contaRapidoCdmx + "\r\nLeague of Legends = " + contaLeagueCdmx
                    + "\r\nHalo = " + contaHaloCdmx + "\r\nJurassic World = " + contaJurassicCdmx + "\r\nStar Wars = " + contaStarCdmx
                    + "\r\nCartel de Santa = " + contaCartelCdmx;
                tblResultados.Rows[1].Cells[3].Value = conta;
                if (contaRapidoCdmx > contaJurassicCdmx && contaRapidoCdmx > contaLeagueCdmx && contaRapidoCdmx > contaHaloCdmx
                    && contaRapidoCdmx > contaStarCdmx && contaRapidoCdmx > contaCartelCdmx)
                {
                    tblResultados.Rows[1].Cells[4].Value = "Al combo de Ciudad de México se\nle asignara la temática de Rápidos y Furiosos";
                }
                else if (contaLeagueCdmx > contaJurassicCdmx && contaLeagueCdmx > contaRapidoCdmx && contaLeagueCdmx > contaHaloCdmx
                    && contaLeagueCdmx > contaStarCdmx && contaLeagueCdmx > contaCartelCdmx)
                {
                    tblResultados.Rows[1].Cells[4].Value = "Al combo de Ciudad de México se\nle asignara la temática de League of Legends";
                }
                else if (contaHaloCdmx > contaJurassicCdmx && contaHaloCdmx > contaRapidoCdmx && contaHaloCdmx > contaLeagueCdmx
                    && contaHaloCdmx > contaStarCdmx && contaHaloCdmx > contaCartelCdmx)
                {
                    tblResultados.Rows[1].Cells[4].Value = "Al combo de Ciudad de México se\nle asignara la temática de Halo";
                }
                else if (contaJurassicCdmx > contaLeagueCdmx && contaJurassicCdmx > contaRapidoCdmx && contaJurassicCdmx > contaHaloCdmx
                   && contaJurassicCdmx > contaStarCdmx && contaJurassicCdmx > contaCartelCdmx)
                {
                    tblResultados.Rows[1].Cells[4].Value = "Al combo de Ciudad de México se\nle asignara la temática de Jurassic World";
                }
                else if (contaStarCdmx > contaJurassicCdmx && contaStarCdmx > contaRapidoCdmx && contaStarCdmx > contaHaloCdmx
                   && contaStarCdmx > contaLeagueCdmx && contaStarCdmx > contaCartelCdmx)
                {
                    tblResultados.Rows[1].Cells[4].Value = "Al combo de Ciudad de México se\nle asignara la temática de Star Wars";
                }
                else if(contaCartelCdmx > contaJurassicCdmx && contaCartelCdmx > contaRapidoCdmx && contaCartelCdmx > contaHaloCdmx
                   && contaCartelCdmx > contaLeagueCdmx && contaCartelCdmx > contaStarCdmx)
                {
                    tblResultados.Rows[1].Cells[4].Value = "Al combo de Ciudad de México se\nle asignara la temática de Cartel de Santa";
                }
                else
                {
                tblResultados.Rows[1].Cells[4].Value = "Debido a los empates entre temáticas, se\nasignara una temática seleccionada al azar entre" +
                    "\nlas temáticas que tuvieron empates";
                }

            n = tblResultados.Rows.Add();
            tem = "";
            numCons = "";
            for (int i = 0; i < 25/*consTij*/; i++)
            {
                tem += "" + RiA[i] + " " + consum[i].eleccion + "\r\n";
                numCons += "" + consum[i].numeroConsumidor + "\r\n";
            }
            tblResultados.Rows[2].Cells[0].Value = "Ciudad Juárez";
            tblResultados.Rows[2].Cells[1].Value = numCons;
            tblResultados.Rows[2].Cells[2].Value = tem;
            conta = "";
            conta = "Rápidos y Furiosos = " + contaRapidoCj + "\r\nLeague of Legends = " + contaLeagueCj
                + "\r\nHalo = " + contaHaloCj + "\r\nJurassic World = " + contaJurassicCj + "\r\nStar Wars = " + contaStarCj
                + "\r\nCartel de Santa = " + contaCartelCj;
            tblResultados.Rows[2].Cells[3].Value = conta;
            if (contaRapidoCj > contaJurassicCj && contaRapidoCj > contaLeagueCj && contaRapidoCj > contaHaloCj
                && contaRapidoCj > contaStarCj && contaRapidoCj > contaCartelCj)
            {
                tblResultados.Rows[2].Cells[4].Value = "Al combo de Ciudad Juárez se\nle asignara la temática de Rápidos y Furiosos";
            }
            else if (contaLeagueCj > contaJurassicCj && contaLeagueCj > contaRapidoCj && contaLeagueCj > contaHaloCj
                && contaLeagueCj > contaStarCj && contaLeagueCj > contaCartelCj)
            {
                tblResultados.Rows[2].Cells[4].Value = "Al combo de Ciudad de México se\nle asignara la temática de League of Legends";
            }
            else if (contaHaloCj > contaJurassicCj && contaHaloCj > contaRapidoCj && contaHaloCj > contaLeagueCj
                && contaHaloCj > contaStarCj && contaHaloCj > contaCartelCj)
            {
                tblResultados.Rows[2].Cells[4].Value = "Al combo de Ciudad de México se\nle asignara la temática de Halo";
            }
            else if (contaJurassicCj > contaLeagueCj && contaJurassicCj > contaRapidoCj && contaJurassicCj > contaHaloCj
               && contaJurassicCj > contaStarCj && contaJurassicCj > contaCartelCj)
            {
                tblResultados.Rows[2].Cells[4].Value = "Al combo de Ciudad de México se\nle asignara la temática de Jurassic World";
            }
            else if (contaStarCj > contaJurassicCj && contaStarCj > contaRapidoCj && contaStarCj > contaHaloCj
               && contaStarCj > contaLeagueCj && contaStarCj > contaCartelCj)
            {
                tblResultados.Rows[2].Cells[4].Value = "Al combo de Ciudad de México se\nle asignara la temática de Star Wars";
            }
            else if (contaCartelCj > contaJurassicCj && contaCartelCj > contaRapidoCj && contaCartelCj > contaHaloCj
               && contaCartelCj > contaLeagueCj && contaCartelCj > contaStarCj)
            {
                tblResultados.Rows[2].Cells[4].Value = "Al combo de Ciudad de México se\nle asignara la temática de Cartel de Santa";
            }
            else
            {
                tblResultados.Rows[2].Cells[4].Value = "Debido a los empates entre temáticas, se\nasignara una temática seleccionada al azar entre" +
                    "\nlas temáticas que tuvieron empates";
            }

            n = tblResultados.Rows.Add();
            tem = "";
            numCons = "";
            for (int i = 0; i < 25/*consTij*/; i++)
            {
                tem += "" + RiA[i] + " " + consum[i].eleccion + "\r\n";
                numCons += "" + consum[i].numeroConsumidor + "\r\n";
            }
            tblResultados.Rows[3].Cells[0].Value = "Guadalajara";
            tblResultados.Rows[3].Cells[1].Value = numCons;
            tblResultados.Rows[3].Cells[2].Value = tem;
            conta = "";
            conta = "Rápidos y Furiosos = " + contaRapidoGdl + "\r\nLeague of Legends = " + contaLeagueGdl
                + "\r\nHalo = " + contaHaloGdl + "\r\nJurassic World = " + contaJurassicGdl + "\r\nStar Wars = " + contaStarGdl
                + "\r\nCartel de Santa = " + contaCartelGdl;
            tblResultados.Rows[3].Cells[3].Value = conta;
            if (contaRapidoGdl > contaJurassicGdl && contaRapidoGdl > contaLeagueGdl && contaRapidoGdl > contaHaloGdl
                && contaRapidoGdl > contaStarGdl && contaRapidoGdl > contaCartelGdl)
            {
                tblResultados.Rows[3].Cells[4].Value = "Al combo de Guadalajara se\nle asignara la temática de Rápidos y Furiosos";
            }
            else if (contaLeagueGdl > contaJurassicGdl && contaLeagueGdl > contaRapidoGdl && contaLeagueGdl > contaHaloGdl
                && contaLeagueGdl > contaStarGdl && contaLeagueGdl > contaCartelGdl)
            {
                tblResultados.Rows[3].Cells[4].Value = "Al combo de Guadalajara se\nle asignara la temática de League of Legends";
            }
            else if (contaHaloGdl > contaJurassicGdl && contaHaloGdl > contaRapidoGdl && contaHaloGdl > contaLeagueGdl
                && contaHaloGdl > contaStarGdl && contaHaloGdl > contaCartelGdl)
            {
                tblResultados.Rows[3].Cells[4].Value = "Al combo de Guadalajara se\nle asignara la temática de Halo";
            }
            else if (contaJurassicGdl > contaLeagueGdl && contaJurassicGdl > contaRapidoGdl && contaJurassicGdl > contaHaloGdl
               && contaJurassicGdl > contaStarGdl && contaJurassicGdl > contaCartelGdl)
            {
                tblResultados.Rows[3].Cells[4].Value = "Al combo de Guadalajara se\nle asignara la temática de Jurassic World";
            }
            else if (contaStarGdl > contaJurassicGdl && contaStarGdl > contaRapidoGdl && contaStarGdl > contaHaloGdl
               && contaStarGdl > contaLeagueGdl && contaStarGdl > contaCartelGdl)
            {
                tblResultados.Rows[3].Cells[4].Value = "Al combo de Guadalajara se\nle asignara la temática de Star Wars";
            }
            else if (contaCartelGdl > contaJurassicGdl && contaCartelGdl > contaRapidoGdl && contaCartelGdl > contaHaloGdl
               && contaCartelGdl > contaLeagueGdl && contaCartelGdl > contaStarGdl)
            {
                tblResultados.Rows[3].Cells[4].Value = "Al combo de Guadalajara se\nle asignara la temática de Cartel de Santa";
            }
            else
            {
                tblResultados.Rows[3].Cells[4].Value = "Debido a los empates entre temáticas, se\nasignara una temática seleccionada al azar entre" +
                    "\nlas temáticas que tuvieron empates";
            }

            n = tblResultados.Rows.Add();
            tem = "";
            numCons = "";
            for (int i = 0; i < 25/*consTij*/; i++)
            {
                tem += "" + RiA[i] + " " + consum[i].eleccion + "\r\n";
                numCons += "" + consum[i].numeroConsumidor + "\r\n";
            }
            tblResultados.Rows[4].Cells[0].Value = "Monterrey";
            tblResultados.Rows[4].Cells[1].Value = numCons;
            tblResultados.Rows[4].Cells[2].Value = tem;
            conta = "";
            conta = "Rápidos y Furiosos = " + contaRapidoMnt + "\r\nLeague of Legends = " + contaLeagueMnt
                + "\r\nHalo = " + contaHaloMnt + "\r\nJurassic World = " + contaJurassicMnt + "\r\nStar Wars = " + contaStarMnt
                + "\r\nCartel de Santa = " + contaCartelMnt;
            tblResultados.Rows[4].Cells[3].Value = conta;
            if (contaRapidoMnt > contaJurassicMnt && contaRapidoMnt > contaLeagueMnt && contaRapidoMnt > contaHaloMnt
                && contaRapidoMnt > contaStarMnt && contaRapidoMnt > contaCartelMnt)
            {
                tblResultados.Rows[4].Cells[4].Value = "Al combo de Monterrey se\nle asignara la temática de Rápidos y Furiosos";
            }
            else if (contaLeagueMnt > contaJurassicMnt && contaLeagueMnt > contaRapidoMnt && contaLeagueMnt > contaHaloMnt
                && contaLeagueMnt > contaStarMnt && contaLeagueMnt > contaCartelMnt)
            {
                tblResultados.Rows[4].Cells[4].Value = "Al combo de Monterrey se\nle asignara la temática de League of Legends";
            }
            else if (contaHaloMnt > contaJurassicMnt && contaHaloMnt > contaRapidoMnt && contaHaloMnt > contaLeagueMnt
                && contaHaloMnt > contaStarMnt && contaHaloMnt > contaCartelMnt)
            {
                tblResultados.Rows[4].Cells[4].Value = "Al combo de Monterrey se\nle asignara la temática de Halo";
            }
            else if (contaJurassicMnt > contaLeagueMnt && contaJurassicMnt > contaRapidoMnt && contaJurassicMnt > contaHaloMnt
               && contaJurassicMnt > contaStarMnt && contaJurassicMnt > contaCartelMnt)
            {
                tblResultados.Rows[4].Cells[4].Value = "Al combo de Monterrey se\nle asignara la temática de Jurassic World";
            }
            else if (contaStarMnt > contaJurassicMnt && contaStarMnt > contaRapidoMnt && contaStarMnt > contaHaloMnt
               && contaStarMnt > contaLeagueMnt && contaStarMnt > contaCartelMnt)
            {
                tblResultados.Rows[4].Cells[4].Value = "Al combo de Monterrey se\nle asignara la temática de Star Wars";
            }
            else if (contaCartelMnt > contaJurassicMnt && contaCartelMnt > contaRapidoMnt && contaCartelMnt > contaHaloMnt
               && contaCartelMnt > contaLeagueMnt && contaCartelMnt > contaStarMnt)
            {
                tblResultados.Rows[4].Cells[4].Value = "Al combo de Monterrey se\nle asignara la temática de Cartel de Santa";
            }
            else
            {
                tblResultados.Rows[4].Cells[4].Value = "Debido a los empates entre temáticas, se\nasignara una temática seleccionada al azar entre" +
                    "\nlas temáticas que tuvieron empates";
            }

            n = tblResultados.Rows.Add();
            tem = "";
            numCons = "";
            for (int i = 0; i < 25/*consTij*/; i++)
            {
                tem += "" + RiA[i] + " " + consum[i].eleccion + "\r\n";
                numCons += "" + consum[i].numeroConsumidor + "\r\n";
            }
            tblResultados.Rows[5].Cells[0].Value = "Zapopan";
            tblResultados.Rows[5].Cells[1].Value = numCons;
            tblResultados.Rows[5].Cells[2].Value = tem;
            conta = "";
            conta = "Rápidos y Furiosos = " + contaRapidoZap + "\r\nLeague of Legends = " + contaLeagueZap
                + "\r\nHalo = " + contaHaloZap + "\r\nJurassic World = " + contaJurassicZap + "\r\nStar Wars = " + contaStarZap
                + "\r\nCartel de Santa = " + contaCartelZap;
            tblResultados.Rows[5].Cells[3].Value = conta;
            if (contaRapidoZap > contaJurassicZap && contaRapidoZap > contaLeagueZap && contaRapidoZap > contaHaloZap
                && contaRapidoZap > contaStarZap && contaRapidoZap > contaCartelZap)
            {
                tblResultados.Rows[5].Cells[4].Value = "Al combo de Zapopan se\nle asignara la temática de Rápidos y Furiosos";
            }
            else if (contaLeagueZap > contaJurassicZap && contaLeagueZap > contaRapidoZap && contaLeagueZap > contaHaloZap
                && contaLeagueZap > contaStarZap && contaLeagueZap > contaCartelZap)
            {
                tblResultados.Rows[5].Cells[4].Value = "Al combo de Zapopan se\nle asignara la temática de League of Legends";
            }
            else if (contaHaloZap > contaJurassicZap && contaHaloZap > contaRapidoZap && contaHaloZap > contaLeagueZap
                && contaHaloZap > contaStarZap && contaHaloZap > contaCartelZap)
            {
                tblResultados.Rows[5].Cells[4].Value = "Al combo de Zapopan se\nle asignara la temática de Halo";
            }
            else if (contaJurassicZap > contaLeagueZap && contaJurassicZap > contaRapidoZap && contaJurassicZap > contaHaloZap
               && contaJurassicZap > contaStarZap && contaJurassicZap > contaCartelZap)
            {
                tblResultados.Rows[5].Cells[4].Value = "Al combo de Zapopan se\nle asignara la temática de Jurassic World";
            }
            else if (contaStarZap > contaJurassicZap && contaStarZap > contaRapidoZap && contaStarZap > contaHaloZap
               && contaStarZap > contaLeagueZap && contaStarZap > contaCartelZap)
            {
                tblResultados.Rows[5].Cells[4].Value = "Al combo de Zapopan se\nle asignara la temática de Star Wars";
            }
            else if (contaCartelZap > contaJurassicZap && contaCartelZap > contaRapidoZap && contaCartelZap > contaHaloZap
               && contaCartelZap > contaLeagueZap && contaCartelZap > contaStarZap)
            {
                tblResultados.Rows[5].Cells[4].Value = "Al combo de Zapopan se\nle asignara la temática de Cartel de Santa";
            }
            else
            {
                tblResultados.Rows[5].Cells[4].Value = "Debido a los empates entre temáticas, se\nasignara una temática seleccionada al azar entre" +
                    "\nlas temáticas que tuvieron empates";
            }

            n = tblResultados.Rows.Add();
            tem = "";
            numCons = "";
            for (int i = 0; i < 25/*consTij*/; i++)
            {
                tem += "" + RiA[i] + " " + consum[i].eleccion + "\r\n";
                numCons += "" + consum[i].numeroConsumidor + "\r\n";
            }
            tblResultados.Rows[6].Cells[0].Value = "Hermosillo";
            tblResultados.Rows[6].Cells[1].Value = numCons;
            tblResultados.Rows[6].Cells[2].Value = tem;
            conta = "";
            conta = "Rápidos y Furiosos = " + contaRapidoHer + "\r\nLeague of Legends = " + contaLeagueHer
                + "\r\nHalo = " + contaHaloHer + "\r\nJurassic World = " + contaJurassicHer + "\r\nStar Wars = " + contaStarHer
                + "\r\nCartel de Santa = " + contaCartelHer;
            tblResultados.Rows[6].Cells[3].Value = conta;
            if (contaRapidoHer > contaJurassicHer && contaRapidoHer > contaLeagueHer && contaRapidoHer > contaHaloHer
                && contaRapidoHer > contaStarHer && contaRapidoHer > contaCartelHer)
            {
                tblResultados.Rows[6].Cells[4].Value = "Al combo de Hermosillo se\nle asignara la temática de Rápidos y Furiosos";
            }
            else if (contaLeagueHer > contaJurassicHer && contaLeagueHer > contaRapidoHer && contaLeagueHer > contaHaloHer
                && contaLeagueHer > contaStarHer && contaLeagueHer > contaCartelHer)
            {
                tblResultados.Rows[6].Cells[4].Value = "Al combo de Hermosillo se\nle asignara la temática de League of Legends";
            }
            else if (contaHaloHer > contaJurassicHer && contaHaloHer > contaRapidoHer && contaHaloHer > contaLeagueHer
                && contaHaloHer > contaStarHer && contaHaloHer > contaCartelHer)
            {
                tblResultados.Rows[6].Cells[4].Value = "Al combo de Hermosillo se\nle asignara la temática de Halo";
            }
            else if (contaJurassicHer > contaLeagueHer && contaJurassicHer > contaRapidoHer && contaJurassicHer > contaHaloHer
               && contaJurassicHer > contaStarHer && contaJurassicHer > contaCartelHer)
            {
                tblResultados.Rows[6].Cells[4].Value = "Al combo de Hermosillo se\nle asignara la temática de Jurassic World";
            }
            else if (contaStarHer > contaJurassicHer && contaStarHer > contaRapidoHer && contaStarHer > contaHaloHer
               && contaStarHer > contaLeagueHer && contaStarHer > contaCartelHer)
            {
                tblResultados.Rows[6].Cells[4].Value = "Al combo de Hermosillo se\nle asignara la temática de Star Wars";
            }
            else if (contaCartelHer > contaJurassicHer && contaCartelHer > contaRapidoHer && contaCartelHer > contaHaloHer
               && contaCartelHer > contaLeagueHer && contaCartelHer > contaStarHer)
            {
                tblResultados.Rows[6].Cells[4].Value = "Al combo de Hermosillo se\nle asignara la temática de Cartel de Santa";
            }
            else
            {
                tblResultados.Rows[6].Cells[4].Value = "Debido a los empates entre temáticas, se\nasignara una temática seleccionada al azar entre" +
                    "\nlas temáticas que tuvieron empates";
            }

            n = tblResultados.Rows.Add();
            tem = "";
            numCons = "";
            for (int i = 0; i < 25/*consTij*/; i++)
            {
                tem += "" + RiA[i] + " " + consum[i].eleccion + "\r\n";
                numCons += "" + consum[i].numeroConsumidor + "\r\n";
            }
            tblResultados.Rows[7].Cells[0].Value = "Saltillo";
            tblResultados.Rows[7].Cells[1].Value = numCons;
            tblResultados.Rows[7].Cells[2].Value = tem;
            conta = "";
            conta = "Rápidos y Furiosos = " + contaRapidoSal + "\r\nLeague of Legends = " + contaLeagueSal
                + "\r\nHalo = " + contaHaloSal + "\r\nJurassic World = " + contaJurassicSal + "\r\nStar Wars = " + contaStarSal
                + "\r\nCartel de Santa = " + contaCartelSal;
            tblResultados.Rows[7].Cells[3].Value = conta;
            if (contaRapidoSal > contaJurassicSal && contaRapidoSal > contaLeagueSal && contaRapidoSal > contaHaloSal
                && contaRapidoSal > contaStarSal && contaRapidoSal > contaCartelSal)
            {
                tblResultados.Rows[7].Cells[4].Value = "Al combo de Saltillo se\nle asignara la temática de Rápidos y Furiosos";
            }
            else if (contaLeagueSal > contaJurassicSal && contaLeagueSal > contaRapidoSal && contaLeagueSal > contaHaloSal
                && contaLeagueSal > contaStarSal && contaLeagueSal > contaCartelSal)
            {
                tblResultados.Rows[7].Cells[4].Value = "Al combo de Saltillo se\nle asignara la temática de League of Legends";
            }
            else if (contaHaloSal > contaJurassicSal && contaHaloSal > contaRapidoSal && contaHaloSal > contaLeagueSal
                && contaHaloSal > contaStarSal && contaHaloSal > contaCartelSal)
            {
                tblResultados.Rows[7].Cells[4].Value = "Al combo de Saltillo se\nle asignara la temática de Halo";
            }
            else if (contaJurassicSal > contaLeagueSal && contaJurassicSal > contaRapidoSal && contaJurassicSal > contaHaloSal
               && contaJurassicSal > contaStarSal && contaJurassicSal > contaCartelSal)
            {
                tblResultados.Rows[7].Cells[4].Value = "Al combo de Saltillo se\nle asignara la temática de Jurassic World";
            }
            else if (contaStarSal > contaJurassicSal && contaStarSal > contaRapidoSal && contaStarSal > contaHaloSal
               && contaStarSal > contaLeagueSal && contaStarSal > contaCartelSal)
            {
                tblResultados.Rows[7].Cells[4].Value = "Al combo de Saltillo se\nle asignara la temática de Star Wars";
            }
            else if (contaCartelSal > contaJurassicSal && contaCartelSal > contaRapidoSal && contaCartelSal > contaHaloSal
               && contaCartelSal > contaLeagueSal && contaCartelSal > contaStarSal)
            {
                tblResultados.Rows[7].Cells[4].Value = "Al combo de Saltillo se\nle asignara la temática de Cartel de Santa";
            }
            else
            {
                tblResultados.Rows[7].Cells[4].Value = "Debido a los empates entre temáticas, se\nasignara una temática seleccionada al azar entre" +
                    "\nlas temáticas que tuvieron empates";
            }

            n = tblResultados.Rows.Add();
            tem = "";
            numCons = "";
            for (int i = 0; i < 25/*consTij*/; i++)
            {
                tem += "" + RiA[i] + " " + consum[i].eleccion + "\r\n";
                numCons += "" + consum[i].numeroConsumidor + "\r\n";
            }
            tblResultados.Rows[8].Cells[0].Value = "Cancún";
            tblResultados.Rows[8].Cells[1].Value = numCons;
            tblResultados.Rows[8].Cells[2].Value = tem;
            conta = "";
            conta = "Rápidos y Furiosos = " + contaRapidoCan + "\r\nLeague of Legends = " + contaLeagueCan
                + "\r\nHalo = " + contaHaloCan + "\r\nJurassic World = " + contaJurassicCan + "\r\nStar Wars = " + contaStarCan
                + "\r\nCartel de Santa = " + contaCartelCan;
            tblResultados.Rows[8].Cells[3].Value = conta;
            if (contaRapidoCan > contaJurassicCan && contaRapidoCan > contaLeagueCan && contaRapidoCan > contaHaloCan
                && contaRapidoCan > contaStarCan && contaRapidoCan > contaCartelCan)
            {
                tblResultados.Rows[8].Cells[4].Value = "Al combo de Cancún se\nle asignara la temática de Rápidos y Furiosos";
            }
            else if (contaLeagueCan > contaJurassicCan && contaLeagueCan > contaRapidoCan && contaLeagueCan > contaHaloCan
                && contaLeagueCan > contaStarCan && contaLeagueCan > contaCartelCan)
            {
                tblResultados.Rows[8].Cells[4].Value = "Al combo de Cancún se\nle asignara la temática de League of Legends";
            }
            else if (contaHaloCan > contaJurassicCan && contaHaloCan > contaRapidoCan && contaHaloCan > contaLeagueCan
                && contaHaloCan > contaStarCan && contaHaloCan > contaCartelCan)
            {
                tblResultados.Rows[8].Cells[4].Value = "Al combo de Cancún se\nle asignara la temática de Halo";
            }
            else if (contaJurassicCan > contaLeagueCan && contaJurassicCan > contaRapidoCan && contaJurassicCan > contaHaloCan
               && contaJurassicCan > contaStarCan && contaJurassicCan > contaCartelCan)
            {
                tblResultados.Rows[8].Cells[4].Value = "Al combo de Cancún se\nle asignara la temática de Jurassic World";
            }
            else if (contaStarCan > contaJurassicCan && contaStarCan > contaRapidoCan && contaStarCan > contaHaloCan
               && contaStarCan > contaLeagueCan && contaStarCan > contaCartelCan)
            {
                tblResultados.Rows[8].Cells[4].Value = "Al combo de Cancún se\nle asignara la temática de Star Wars";
            }
            else if (contaCartelCan > contaJurassicCan && contaCartelCan > contaRapidoCan && contaCartelCan > contaHaloCan
               && contaCartelCan > contaLeagueCan && contaCartelCan > contaStarCan)
            {
                tblResultados.Rows[8].Cells[4].Value = "Al combo de Cancún se\nle asignara la temática de Cartel de Santa";
            }
            else
            {
                tblResultados.Rows[8].Cells[4].Value = "Debido a los empates entre temáticas, se\nasignara una temática seleccionada al azar entre" +
                    "\nlas temáticas que tuvieron empates";
            }

            n = tblResultados.Rows.Add();
            tem = "";
            numCons = "";
            for (int i = 0; i < 25/*consTij*/; i++)
            {
                tem += "" + RiA[i] + " " + consum[i].eleccion + "\r\n";
                numCons += "" + consum[i].numeroConsumidor + "\r\n";
            }
            tblResultados.Rows[9].Cells[0].Value = "Culiacán";
            tblResultados.Rows[9].Cells[1].Value = numCons;
            tblResultados.Rows[9].Cells[2].Value = tem;
            conta = "";
            conta = "Rápidos y Furiosos = " + contaRapidoCul + "\r\nLeague of Legends = " + contaLeagueCul
                + "\r\nHalo = " + contaHaloCul + "\r\nJurassic World = " + contaJurassicCul + "\r\nStar Wars = " + contaStarCul
                + "\r\nCartel de Santa = " + contaCartelCul;
            tblResultados.Rows[9].Cells[3].Value = conta;
            if (contaRapidoCul > contaJurassicCul && contaRapidoCul > contaLeagueCul && contaRapidoCul > contaHaloCul
                && contaRapidoCul > contaStarCul && contaRapidoCul > contaCartelCul)
            {
                tblResultados.Rows[9].Cells[4].Value = "Al combo de Culiacán se\nle asignara la temática de Rápidos y Furiosos";
            }
            else if (contaLeagueCul > contaJurassicCul && contaLeagueCul > contaRapidoCul && contaLeagueCul > contaHaloCul
                && contaLeagueCul > contaStarCul && contaLeagueCul > contaCartelCul)
            {
                tblResultados.Rows[9].Cells[4].Value = "Al combo de Culiacán se\nle asignara la temática de League of Legends";
            }
            else if (contaHaloCul > contaJurassicCul && contaHaloCul > contaRapidoCul && contaHaloCul > contaLeagueCul
                && contaHaloCul > contaStarCul && contaHaloCul > contaCartelCul)
            {
                tblResultados.Rows[9].Cells[4].Value = "Al combo de Culiacán se\nle asignara la temática de Halo";
            }
            else if (contaJurassicCul > contaLeagueCul && contaJurassicCul > contaRapidoCul && contaJurassicCul > contaHaloCul
               && contaJurassicCul > contaStarCul && contaJurassicCul > contaCartelCul)
            {
                tblResultados.Rows[9].Cells[4].Value = "Al combo de Culiacán se\nle asignara la temática de Jurassic World";
            }
            else if (contaStarCul > contaJurassicCul && contaStarCul > contaRapidoCul && contaStarCul > contaHaloCul
               && contaStarCul > contaLeagueCul && contaStarCul > contaCartelCul)
            {
                tblResultados.Rows[9].Cells[4].Value = "Al combo de Culiacán se\nle asignara la temática de Star Wars";
            }
            else if (contaCartelCul > contaJurassicCul && contaCartelCul > contaRapidoCul && contaCartelCul > contaHaloCul
               && contaCartelCul > contaLeagueCul && contaCartelCul > contaStarCul)
            {
                tblResultados.Rows[9].Cells[4].Value = "Al combo de Culiacán se\nle asignara la temática de Cartel de Santa";
            }
            else
            {
                tblResultados.Rows[9].Cells[4].Value = "Debido a los empates entre temáticas, se\nasignara una temática seleccionada al azar entre" +
                    "\nlas temáticas que tuvieron empates";
            }
        }

        frmHistorial historial = new frmHistorial();

        //HISTORIAL de Experimentos ----------------------------------------------------------------------
        //public void GuardarHisto()
        //{
        //    //Agrega nueva fila
        //    int n = historial.dgvHistorial.Rows.Add();

        //    //Agregar datos de numeros pseudo
        //    string datos = $"Xo = {g.X0}\r\n" +
        //                   $"a = {g.a}\r\n" +
        //                   $"c = {g.c}\r\n" +
        //                   $"m = {g.m}\r\n";
        //    historial.dgvHistorial.Rows[n].Cells[0].Value = datos;

        //    //AGREGAR datos de los ANIMALES -----------------
        //    {
        //        string probAni = "";
        //        for (int i = 0; i < tematicas.Count; i++)
        //        {
        //            probAni += $"{tematicas[i].nombre} = {tematicas[i].distribucion}\r\n";
        //        }
        //        historial.dgvHistorial.Rows[n].Cells[1].Value = probAni;
        //    }

        //    //AGREGAR datos del AGUA a la tabla------------------------
        //    {
        //        string probaCiudad = "";
        //        string resCiudad = "";
        //        for (int i = 0; i < ciudades.Count; i++)
        //        {
        //            probaCiudad += $"{ciudades[i].nombre} = {ciudades[i].distribucion}\r\n";
                    
        //        }
        //        historial.dgvHistorial.Rows[n].Cells[2].Value = probaCiudad;

        //    }
        //    historial.dgvHistorial.Rows[n].Cells[3].Value = txtConclusionGeneral.Text + "\r\n" + txtConclusionAgua.Text;
        //}

        private void lblHermo_Click(object sender, EventArgs e)
        {

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

        private void txtRapidos_TextChanged(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtRapidos.Text)
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
                error1.SetError(txtRapidos, "No se admiten letras ni espacios en blanco\nIngrese números solamente");
            }
            else
            {
                error1.SetError(txtRapidos, "");
            }
        }

        private void txtRapidos_Validated(object sender, EventArgs e)
        {
            error1.SetError(txtRapidos, "");
        }

        private void txtRapidos_Validating(object sender, CancelEventArgs e)
        {
            Val(txtRapidos, error1, e);
        }
        //OBTENCION DE DATOS INGRESADOS POR EL USUARIO -----------------------------------------------------
        float temRapi, temJura, temStar, temCartel, temLeague, temHalo;
        float cdTij, cdMexico, cdJuarez, cdGuada, cdMonte, cdZapo, cdHermo, cdSalt, cdCancun, cdCuliacan;

        private void btnDatos_Click(object sender, EventArgs e)
        {
            if(error)
            {
                MessageBox.Show("Verifique que no haya espacios en blanco");
            }
            else if (txtTij.Text == "" || txtLeague.Text == "" || txtHalo.Text == "" || txtJurassic.Text =="" || txtCartel.Text == "" ||
                txtTij.Text == "" || txtCdmx.Text == "" || txtCan.Text == "" || txtCulia.Text == "" || txtSalt.Text == "" || 
                    txtHermo.Text == "" || txtGdlj.Text == "" || txtMntry.Text == "" || txtZapo.Text == "" || txtCj.Text == "")
            {
                MessageBox.Show("Verifique que no haya espacios en blanco");
            }
            else
            {
                float suma = 0F;
                float suma2 = 0F;

                //Recuperacion de datos ingresados por el usuario
                temRapi = (float)Math.Round(float.Parse(txtRapidos.Text) * 0.01F, 2);
                temJura = (float)Math.Round(float.Parse(txtJurassic.Text) * 0.01F, 2);
                temStar = (float)Math.Round(float.Parse(txtStar.Text) * 0.01F, 2);
                temCartel = (float)Math.Round(float.Parse(txtCartel.Text) * 0.01F, 2);
                temLeague = (float)Math.Round(float.Parse(txtLeague.Text) * 0.01F, 2);
                temHalo = (float)Math.Round(float.Parse(txtHalo.Text) * 0.01F, 2);

                cdTij = (float)Math.Round(float.Parse(txtTij.Text) * 0.01F, 2);
                cdMexico = (float)Math.Round(float.Parse(txtCdmx.Text) * 0.01F, 2);
                cdJuarez = (float)Math.Round(float.Parse(txtCj.Text) * 0.01F, 2);
                cdGuada = (float)Math.Round(float.Parse(txtGdlj.Text) * 0.01F, 2);
                cdMonte = (float)Math.Round(float.Parse(txtMntry.Text) * 0.01F, 2);
                cdZapo = (float)Math.Round(float.Parse(txtZapo.Text) * 0.01F, 2);
                cdHermo = (float)Math.Round(float.Parse(txtHermo.Text) * 0.01F, 2);
                cdSalt = (float)Math.Round(float.Parse(txtSalt.Text) * 0.01F, 2);
                cdCancun = (float)Math.Round(float.Parse(txtCan.Text) * 0.01F, 2);
                cdCuliacan = (float)Math.Round(float.Parse(txtCulia.Text) * 0.01F, 2);

                suma = (temRapi + temJura + temStar +
                    temCartel + temLeague + temHalo);

                suma2 = (cdTij + cdMexico + cdJuarez +
                 cdGuada + cdMonte + cdZapo + cdHermo + cdSalt + cdCancun + cdCuliacan);
                txtSuma1.Text = "" + suma;
                txtSuma2.Text = "" + suma2;

                if (suma == 1 && suma2 == 1)
                {
                    btnInterval.Visible = true;
                    btnResolver.Visible = true;
                }
                else
                {
                    if (suma > 1)
                    {
                        MessageBox.Show("La suma de la distribucion de probabilidad de tematicas supera el 1, Favor de verificar los datos", "Error al ingresar datos");
                    }
                    else if (suma < 1)
                    {
                        MessageBox.Show("La suma de la distribucion de tematicas es menor a 1, Favor de verificar los datos", "Error al ingresar datos");
                    }
                    else if (suma2 > 1)
                    {
                        MessageBox.Show("La suma de la distribucion de probabilidad de ciudades supera el 1, Favor de verificar los datos", "Error al ingresar datos");
                    }
                    else
                    {
                        MessageBox.Show("La suma de la distribucion de ciudades es menor a 1, Favor de verificar los datos", "Error al ingresar datos");
                    }
                }
                //Limpia las filas de las tablas de animales y de agua
                frmIntervalos.tblTema.Rows.Clear();
                frmIntervalos.tblCiudad.Rows.Clear();

                //Limpiar las listas de animales y agua
                tematicas.Clear();
                ciudades.Clear();

                CargarLimitesEnListas();
            }
        }
    }
}
