using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;
using ZedGraph;

namespace monte_carlo_03
{
    public partial class Form1 : Form
    {
        StreamReader fajl_beolvaso_StreamReader;            //adatfajl megnyitasahoz

        double[] idopontok = new double[500];               //globalis tomb az adatfajl elso oszlopaban talalhato idoadatok szamara
        double[] nyers_adatok = new double[500];            //globalis tomb adatfajl masodik oszlopaban levo adatok szamara
        double[] aktualis_illesztes = new double[500];      //globalis tomb az illesztet adatsornak

        //grafikonokon valo abrazolashoz erdemes pontlistakat alkalmazni:
        PointPairList nyers_pontok = new PointPairList(), illesztett_pontok = new PointPairList(), energia_pontok = new PointPairList();

        double beta;            //globalis valtozo az inverz homerseklet szamara
        double A, tau, T, A_lepes, tau_lepes, T_lepes, A_aktualis, tau_aktualis, T_aktualis;        //valamint a parameterek, azok lepeskozeinek
        double energia, aktualis_energia, megszakitas;                                     //es az energiaertekek szamara

        Random parameter_veletlenszam, inverz_homerseklet_veletlenszam;     //veletlenszam generatorok
        GraphPane nyers_adat_abra, illesztett_adat_abra, energia_abra;      //gorbek abrazolasahoz
        LineItem graphLine_nyers, graphLine_illesztett, graphLine_energia;  //es ezek megjelenitesenek beallitasahoz

        int iteraciok_szama;        //iditas utan vegrehajtando iteracios ciklusok szama
        int lepesek_szama = 0;      //futas soran tenylegesen vegrehajtott iteracios ciklusok szama
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            parameter_veletlenszam = new Random();              //a program indulasakor letrehozzuk a 2 veletlenszam generatort
            inverz_homerseklet_veletlenszam = new Random();
            indit_button.Hide();            //ezekre a gombokra csak az
            iteracio_button.Hide();         //adatfajl beolvasasa utan lesz szukseg
            
        }

        /***************************************************************************************************************/
        //a beolvas gombra kattintva tudjuk megadni az adatsort tartalmazo fajlt
        //ezutan a program a megfelelo formatumu adatokat tartalmazo sorokat beolvassa, konvertalja
        //es ezekkel 2 db lebegopontos szamokat tartalmazo 500 elemu tombot tolt fel
        //grafikonon valo abrazolasukhoz pedig egy pontlistaba is belemasolja az adatokat

        private void beolvas_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                fajl_beolvaso_StreamReader = new StreamReader(openFileDialog1.FileName);
            }

            string sor;         //egy sor beolvasasa szamara
            int i = 0;          //tombok indexelesehez

            while (!fajl_beolvaso_StreamReader.EndOfStream)     //fajl vegeig dolgozik
            {
                sor = fajl_beolvaso_StreamReader.ReadLine();    //beolvas egy sort

                int hossz = sor.Length;             
                int tab = sor.IndexOf('\t');
                int kezd = tab + 1;                             //tabulator valasztja el a 2 lebegopontos szamot

                string x_beolvas = sor.Substring(0, tab);                   //elso
                string y_beolvas = sor.Substring(kezd, hossz - kezd);       //es masodik szam

                idopontok[i] = Convert.ToDouble(x_beolvas);                 //
                nyers_adatok[i] = Convert.ToDouble(y_beolvas);              //belemasolva a tombokbe    

                i++;
            }
            fajl_beolvaso_StreamReader.Close();         //zarjuk a beolvasast

            for (i = 0; i < 500; i++)               //a tombok elemeivel feltoltjuk a pontlistat
            {
                nyers_pontok.Add(idopontok[i], nyers_adatok[i]);
            }
            
            nyers_adat_abra = illesztett_grafikon_zedGraphControl.GraphPane;
            nyers_adat_abra.Title.Text = "mérési adatsor és illesztés";
            nyers_adat_abra.XAxis.Title.Text = "idõ";
            nyers_adat_abra.YAxis.Title.Text = "amplitúdó";

            if(graphLine_nyers == null) graphLine_nyers = nyers_adat_abra.AddCurve("nyers", nyers_pontok, Color.Blue, SymbolType.None);
            graphLine_nyers.Line.IsVisible = true;

            illesztett_grafikon_zedGraphControl.AxisChange();  
            illesztett_grafikon_zedGraphControl.Refresh();              //es megfelelo formatumban abrazoljuk az adatfajl tartalmat
  
            beolvas_button.Hide();      //tovabbiakban nem lesz szukseg a beolvasasra
            indit_button.Show();        //az inditas gombra viszont igen
        }

        /***************************************************************************************************************/
        //az indit gomb rogziti a kezdeti parametereket es a fentebb abrazolt adatokkal megegyezo grafikonon letrehoz egy
        //ezeknek megfelelo kezdeti gorbet
        //a program futasa soran ezzel a gombbal lehet ujrainditani is az illesztest

        private void indit_button_Click(object sender, EventArgs e)
        {
            energia_pontok.Clear();             //ujrainditaskor ha mar nem ures a ponlista
            illesztett_pontok.Clear();          //ujrainditaskor ha mar nem ures a ponlista

            A_aktualis_textBox.Text = A_kezdo_textBox.Text;         //
            tau_aktualis_textBox.Text = tau_kezdo_textBox.Text;     //
            T_aktualis_textBox.Text = T_kezdo_textBox.Text;         //rogzitjuk a kezdeti parametereket

            A_aktualis = Convert.ToDouble(A_aktualis_textBox.Text);         //
            tau_aktualis = Convert.ToDouble(tau_aktualis_textBox.Text);     //
            T_aktualis = Convert.ToDouble(T_aktualis_textBox.Text);         //a program az altala hasznalt ertekeket mindig a texboxokbol olvassa be
            
            aktualis_energia = 0;       //energiaertek szummazasahoz 

            for (int i = 0; i < 500; i++)       //illesztett adatok letrehozasa egy 500 elemu tombben
            {
                aktualis_illesztes[i] = A_aktualis * Math.Exp(-idopontok[i] / tau_aktualis) * Math.Sin(2 * Math.PI * idopontok[i] / T_aktualis);
            }

            for (int i = 0; i < 500; i++)       //illesztett adatok abrazolasahoz pontlista feltoltese
            {
                illesztett_pontok.Add(idopontok[i], aktualis_illesztes[i]);
            }

            for (int i = 0; i < 500; i++)       //energiaertek meghatarozasa a kezdeti illesztett es eredeti nyers adatok felhasznalasaval
            {
                aktualis_energia += Math.Abs(aktualis_illesztes[i] - nyers_adatok[i]);
            }

            energia_textBox.Text = Convert.ToString(aktualis_energia);      //kiiratjuk a kezdeti energiaerteket

            illesztett_adat_abra = illesztett_grafikon_zedGraphControl.GraphPane;
            if(graphLine_illesztett == null) graphLine_illesztett = illesztett_adat_abra.AddCurve("illesztett", illesztett_pontok, Color.Red, SymbolType.None);
            graphLine_illesztett.Line.IsVisible = true;

            illesztett_grafikon_zedGraphControl.AxisChange();  
            illesztett_grafikon_zedGraphControl.Refresh();                  //es abrazoljuk a kezdeti illeszett adatokat

            energia_abra = energia_grafikon_zedGraphControl.GraphPane;
            energia_abra.Title.Text = "illesztés \"jósága\" ";
            energia_abra.YAxis.Title.Text = "energia";
            energia_abra.XAxis.Title.Text = "megtett lépések száma";
            
            if(graphLine_energia == null) graphLine_energia = energia_abra.AddCurve("energia", energia_pontok, Color.Black, SymbolType.None);
            graphLine_energia.Line.IsVisible = true;

            energia_grafikon_zedGraphControl.AxisChange();  
            energia_grafikon_zedGraphControl.Refresh();             //valamint ha meg nem letezik letrehozunk egy gorbet amivel majd a lepesenkent valtozo energiat abrazoljuk

            lepesek_szama = 0;              //ujrainditaskor 0-zuk a lepesek szamat
            megtett_lepesek_textBox.Text = Convert.ToString(lepesek_szama);
            indit_button.Text = "újraindít";        //az elso alkalom utan mar ujrainditjuk az illesztest
            iteracio_button.Show();                 //es szukseg lesz az iteraciokat indíto gombra is
        }

        /***************************************************************************************************************/
        //az iteracio gomb az aktualis parametereket tartalmazo texboxbol vett ertekeket felhasznalva
        // (ezaltal minden iteracios ciklus elott valtoztathato modon)
        //az iteraciok szama textboxbol (szinten valtoztathato inditas elott) vett
        //egesz szamszor kiserel meg jobb illesztest letrehozni
        //a ciklus veget er ha a megadott szamu iteracio lefutott, vagy ha az illesztes josaga eler
        //egy a felhasznalo altal elore megadott energiaertekkel jellemzett merteket,
        //illetve  (a tesztelesek soran utolag kiegeszitve): ha az egy parameter egyuttesbol
        //kiindult sikertelen probalkozasok szama eleri a 10000-es erteket
        //(ez a 10000-es ertek a futtatasok soran megfelelonek bizonyult arra, hogy eleg jo illesztest
        //lehessen elerni, amellett, hogy a program ne fusson a vegtelensegig)

        private void iteracio_button_Click(object sender, EventArgs e)
        {
            iteraciok_szama = Convert.ToInt32(iteraciok_szama_textBox.Text);        //hanyszor fusson le a ciklus
            beta = Convert.ToDouble(beta_textBox.Text);                             //inverz homersekleti tenyezo
            megszakitas = Convert.ToDouble(megszakitas_textBox.Text);               //energiaertek ami alatt nem javitja tovabb az illesztest

            A_lepes = Convert.ToDouble(A_lepes_textBox.Text);               //
            tau_lepes = Convert.ToDouble(tau_lepes_textBox.Text);           //
            T_lepes = Convert.ToDouble(T_lepes_textBox.Text);               //szinten inditas elott modosithatok az alkalmazott lepeskozok

            A_aktualis = Convert.ToDouble(A_aktualis_textBox.Text);         //
            tau_aktualis = Convert.ToDouble(tau_aktualis_textBox.Text);     //
            T_aktualis = Convert.ToDouble(T_aktualis_textBox.Text);         //es az aktualis parameterek is

            A = A_aktualis;
            tau = tau_aktualis;
            T = T_aktualis;
            energia = aktualis_energia;         //kezdo ertekek rogzitese

            int ciklusszam = 0;     //sikertelen probalkozasok szamanak meghatarozasahoz

            for (int n = 0; n < iteraciok_szama; n++)
            {
                ciklusszam = 0;     //minden parameter egyuttes tiszta lappal indul

                while (true)            //itt zajlik a monte carlo modszerre epulo javitott parameterek keresese
                {
                    ciklusszam++;       //itt szamoljuk, hogy egy adott parameter egyuttesbol hanyszor nem sikerult annal jobbat letrehozni 

                    aktualis_energia = 0;       //a szummazashoz eloszor 0-zuk az energiaerteket
                    
                    //majd fuggetlen [-0.5, 0.5] intervallumba eso veletlenszamok segitsegevel, a lepeskozokkel aranyos mertekben veletlenszeruen modositjuk az aktualis parametereket
                    A_aktualis = A + A_lepes * (parameter_veletlenszam.NextDouble() - 0.5);         //
                    tau_aktualis = tau + tau_lepes * (parameter_veletlenszam.NextDouble() - 0.5);   //
                    T_aktualis = T + T_lepes * (parameter_veletlenszam.NextDouble() - 0.5);         //kulon-kulon megfelelo lepeskozoket felhasznalva

                    for (int i = 0; i < 500; i++)       //ha megvannak az uj parameterek a megfelelo tombben letrehozzuk az aktualis illesztett adatokat
                    {
                        aktualis_illesztes[i] = A_aktualis * Math.Exp(-idopontok[i] / tau_aktualis) * Math.Sin(2 * Math.PI * idopontok[i] / T_aktualis);
                    }

                    for (int i = 0; i < 500; i++)       //meghatarozzuk az uj illesztes josagat
                    {
                        aktualis_energia += Math.Abs(aktualis_illesztes[i] - nyers_adatok[i]);
                    }


                    //es
                    if (aktualis_energia < energia)     //ha jobb az illesztes
                    {
                        break;                          //elfogadjuk
                    }
                    else                //vagy ha nem jobb de az inverz homersekleti tenyezovel jellemzett merteket nem meghaladoan rosz
                    {
                        if (inverz_homerseklet_veletlenszam.NextDouble() < Math.Exp(-beta * (aktualis_energia - energia)))
                        {
                            break;      //szinten elfogadjuk
                        }
                    }

                    if (ciklusszam > 10000)     //ha nagyon sokaig nem talalunk jobb parametereket nem keresunk tovabb
                    {
                        break;
                    }

                    //a fenti feltetelek nem teljesulese eseten ujrakezdjuk a ciklust
                    //ujabb jobb illesztest keresve, a sikertelen modositas elotti parameterekbol kiindulva
                }

                if (ciklusszam > 10000) //ha nagyon sokaig nem talaltunk jobb parametereket a while ciklusban: nem kezdunk bele megegyszer
                {
                    break;
                }

                //viszont ha nem a sikertelen illesztesek nagyon nagy szama miatt leptunk ki a while ciklusbol
                //akkor elfogadjunk az ujabb illesztest:

                A = A_aktualis;                 //az uj ertekeket teszuk meg kezdoertekeknek
                tau = tau_aktualis;
                T = T_aktualis;
                energia = aktualis_energia;

                lepesek_szama++;                                            //sikeres iteracios lepes szamat noveljuk
                energia_pontok.Add(lepesek_szama, aktualis_energia);        //es ennek fuggvenyeben abrazoljuk az illesztes josagara jellemzo energiaerteket

                A_aktualis_textBox.Text = Convert.ToString(A_aktualis);         //
                tau_aktualis_textBox.Text = Convert.ToString(tau_aktualis);     //
                T_aktualis_textBox.Text = Convert.ToString(T_aktualis);         //
                energia_textBox.Text = Convert.ToString(aktualis_energia);      //
                megtett_lepesek_textBox.Text = Convert.ToString(lepesek_szama); //textboxokban is kozoljuk az aktualis ertekeket

                illesztett_pontok.Clear();              //es ujra rajzoljuk az illeszett gorbet
                for (int i = 0; i < 500; i++)
                {
                    illesztett_pontok.Add(idopontok[i], aktualis_illesztes[i]);
                }

                illesztett_grafikon_zedGraphControl.AxisChange();
                illesztett_grafikon_zedGraphControl.Refresh();

                energia_grafikon_zedGraphControl.AxisChange();
                energia_grafikon_zedGraphControl.Refresh();

                if (aktualis_energia < megszakitas)         //ha az illesztes josaga eler egy a megadott erteket a program nem folytatja a javitast
                {
                    break;
                }
            }
        }
    }
}