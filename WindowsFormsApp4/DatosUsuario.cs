using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public static class DatosUsuario
    {
        public static string Nombre { get; set; }  
        public static string Edad { get; set; }
        public static string Altura { get; set; }
        public static string Peso { get; set; }
        public static string Genero { get; set; }

        public static string Nombre2 { get; set; }  
        public static string Edad2 { get; set; }
        public static string Altura2 { get; set; }
        public static string Peso2 { get; set; }
        public static string Genero2 { get; set; }



        public static string usuario { get; set; }
        public static string contraseña { get; set; }



        public static bool x { get; set; } = false;
        public static bool y { get; set; } = false;
        public static bool a { get; set; } = false;
        public static bool b { get; set; } = false;
        public static bool c { get; set; } = false;
        public static bool conf { get; set; } = false;
        public static bool siguiente { get; set; } = false;

        public static bool Boton2Oculto { get ; set; } = false;
        public static bool Boton3Oculto { get; set; } = false;
        public static bool Boton4Oculto { get; set; } = false;


        public static string opc1 { get; set; } = "Perder peso";
        public static string opc2 { get; set; } = "Aumentar peso";
        public static string opc3 { get; set; } = "Perder Peso y Alimentación Sana";
        public static string opc4 { get; set; } = "Aumentar Peso y Alimentación Sana";
        public static string opc5 { get; set; } = "Mantener Peso";
        public static string opc6 { get; set; } = "No muy activo";
        public static string opc7 { get; set; } = "Ligeramente activo";
        public static string opc8 { get; set; } = "Activo";
        public static string opc9 { get; set; } = "Muy activo";




        public static string PerderPeso { get; set; }
        public static string MantenerPeso { get; set; }
        public static string AumentarPeso { get; set; }
        public static string ManejoEstres { get; set; }
        public static string AlimentacionSana { get; set; }


        public static string logro1 { get; set; }
        public static string logro2 { get; set; }
        public static string logro3 { get; set; }

        public static int PosicionButton2 = 0;
        public static int PosicionButton3 = 0;
        public static int PosicionButton4 = 0;

        public static bool aa { get; set; } = false;
        public static bool bb { get; set; } = false;
        public static bool cc { get; set; } = false;
        public static bool dd { get; set; } = false;

        public static bool ObjetivosCompletos { get; set; } = false;
    }
}
