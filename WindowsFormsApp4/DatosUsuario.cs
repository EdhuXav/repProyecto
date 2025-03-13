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
        


        public static string PerderPeso { get; set; }
        public static string MantenerPeso { get; set; }
        public static string AumentarPeso { get; set; }
        public static string ManejoEstres { get; set; }
        public static string AlimentacionSana { get; set; }


        public static string logro1 { get; set; }
        public static string logro2 { get; set; }
        public static string logro3 { get; set; } 
    }
}
