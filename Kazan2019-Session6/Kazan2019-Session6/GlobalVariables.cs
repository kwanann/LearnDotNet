using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Xml.Linq;

namespace Kazan2019_Session6
{
    public static class GlobalVariables
    {
        public static string Language_Current
        {
            get
            {
                return Properties.Settings.Default.Language;
            }
            set
            {
                //Set current language
                Properties.Settings.Default.Language = value;

                //Save user level settings
                Properties.Settings.Default.Save();

                //Update Language pack
                Language_Pack = Helper_Language.ReadLanguagePack(value);
            }
        }

        public static List<string> Language_GetAvailable = Helper_Language.GetList();

        public static Dictionary<string, string> Language_Pack { get; set; } = Helper_Language.ReadLanguagePack(Language_Current);

        public static string GetText(string Key)
        {
            if (Language_Pack.ContainsKey(Key))
                return Language_Pack[Key];
            else
            {
                var Val = Key.Substring(Key.LastIndexOf(".")+1);

                var sb = new StringBuilder();
                foreach(var c in Val)
                {
                    if (Char.IsUpper(c))
                        sb.Append(" ");
                    
                    sb.Append(c);
                }

                return sb.ToString().Trim();
            }
        }
    }

    public static class Helper_Language
    {
        /// <summary>
        /// Gets the list of languages from the languages folder
        /// </summary>
        /// <returns>string array with the list of languages</returns>
        public static List<string> GetList()
        {
            var result = new List<string>();
            foreach(var f in Directory.EnumerateFiles(Path.Combine(Directory.GetCurrentDirectory(), "languages"), "*.xml"))
            {
                if (Path.GetFileNameWithoutExtension(f).Equals("default", StringComparison.InvariantCultureIgnoreCase))
                    result.Add("English");
                else
                    result.Add(System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Path.GetFileNameWithoutExtension(f)));
            }

            result.Sort();
            return result;
        }

        /// <summary>
        /// Extension method for Dictionary<string, string> to automatically update or add the value if the key does not exist
        /// </summary>
        /// <param name="D"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        static void AddOrUpdate(this Dictionary<string, string> D, string Key, string Value)
        {
            if (D.ContainsKey(Key))
                D[Key] = Value;
            else
                D.Add(Key, Value);
        }

        /// <summary>
        /// Read the Language pack, with the base formed from default.xml
        /// </summary>
        /// <param name="Language"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ReadLanguagePack(string Language)
        {
            var result = new Dictionary<string, string>();

            UpdateLanguageDictionary(result, $"{Path.Combine(Directory.GetCurrentDirectory(), "languages")}\\default.xml");
            UpdateLanguageDictionary(result, $"{Path.Combine(Directory.GetCurrentDirectory(), "languages")}\\{Language}.xml");

            return result;
        }

        /// <summary>
        /// Updates Dict with the actual values inside XML file
        /// </summary>
        /// <param name="Dict"></param>
        /// <param name="LanguagePackFileName"></param>
        static void UpdateLanguageDictionary(Dictionary<string, string> Dict, string LanguagePackFileName)
        {
            if (!File.Exists(LanguagePackFileName)) return;
            //Load default first
            foreach (XElement KazanNeftSoftware in XElement.Load(LanguagePackFileName).Elements("Native-Langue"))
            {
                foreach (XElement Menu in KazanNeftSoftware.Elements("Menu"))
                {
                    foreach (XElement Main in Menu.Elements("Main"))
                    {
                        foreach (XElement Entries in Main.Elements("Entries"))
                        {
                            foreach (XElement Item in Entries.Elements("Item"))
                            {                                
                                if (Item.Attribute("menuId") != null)
                                    Dict.AddOrUpdate($"Menu.Main.Entries.Item.menuId.{Item.Attribute("menuId").Value}", Item.Attribute("name").Value);
                                else if (Item.Attribute("idName") != null)
                                        Dict.AddOrUpdate($"Menu.Main.Entries.Item.idName.{Item.Attribute("idName").Value}", Item.Attribute("name").Value);
                            }
                        }
                    }

                    foreach (XElement TabBar in Menu.Elements("TabBar"))
                    {
                        foreach (XElement Item in TabBar.Elements("Item"))
                        {
                            Dict.AddOrUpdate($"Menu.TabBar.Item.{Item.Attribute("CMID").Value}", Item.Attribute("name").Value);
                        }
                    }

                }

                foreach (XElement InventoryDashboard in KazanNeftSoftware.Elements("InventoryDashboard"))
                {
                    foreach (XElement child in InventoryDashboard.Elements())
                    {
                        if (child.Attribute("value") != null)
                            Dict.AddOrUpdate($"InventoryDashboard.{child.Name}.{child.Attribute("name").Value}", child.Attribute("value").Value);
                        else
                            Dict.AddOrUpdate($"InventoryDashboard.{child.Name}", child.Attribute("name").Value);
                    }
                }

                foreach (XElement InventoryDashboard in KazanNeftSoftware.Elements("InventoryControl"))
                {
                    foreach (XElement child in InventoryDashboard.Elements())
                    {
                        if (child.Attribute("value") != null)
                            Dict.AddOrUpdate($"InventoryControl.{child.Name}.{child.Attribute("name").Value}", child.Attribute("value").Value);
                        else
                            Dict.AddOrUpdate($"InventoryControl.{child.Name}", child.Attribute("name").Value);
                    }
                }

                foreach (XElement MiscStrings in KazanNeftSoftware.Elements("MiscStrings"))
                {
                    foreach (XElement child in MiscStrings.Elements())
                    {
                        Dict.AddOrUpdate($"MiscStrings.{child.Name}", child.Attribute("value").Value);
                    }
                }
            }

        }
    }
}
