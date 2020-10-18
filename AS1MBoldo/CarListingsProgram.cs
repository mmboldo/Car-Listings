using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AS1MBoldo
{
    [Serializable()]
    [XmlRoot]
    public class Car
    {
        [DisplayName("Make")]
        public string Make { get; set; }
        [DisplayName("Year")]
        public int Year { get; set; }
        [DisplayName("Color")]
        public string Color { get; set; }
        [DisplayName("Engine Size")]
        public decimal EngineSize { get; set; }
        [DisplayName("Price")]
        public int Price { get; set; }
        [DisplayName("Dealer")]
        public string Dealer { get; set; }

        static class CarListingsProgram
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CarListingsForm());                
            }
        }
    }
}
