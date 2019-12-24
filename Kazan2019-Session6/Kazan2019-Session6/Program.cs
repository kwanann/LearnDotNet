using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kazan2019_Session6
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInventoryDashboard());
            /*
            var d = new Dictionary<string, object>();
            d.Add("Language_Current", GlobalVariables.Language_Current);
            d.Add("Language_GetAvailable", GlobalVariables.Language_GetAvailable);
            d.Add("Language_Pack", GlobalVariables.Language_Pack);
            System.IO.File.WriteAllText(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Languages\\output.json"), Newtonsoft.Json.JsonConvert.SerializeObject(d, Newtonsoft.Json.Formatting.Indented));
            */
        }
    }
}
