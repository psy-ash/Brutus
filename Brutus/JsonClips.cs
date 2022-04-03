using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brutus
{
    public class JsonClips
    {

        public List<string> examples = new List<string>();

        public string action;

        public void Load()
        {
            // eventually csv/txt of scripts

            string a = "document.getElementsByClassName(\"hoverable-cell disableable utility\")[0].click();";
            string b = "document.getElementsByClassName(\"hoverable-cell action\")[1].click();";
            string c = "document.getElementsByClassName(\"hoverable-cell disableable utility\")[1].click();";
            string comp = "walletIcon large-48";

            examples.Add(a);
            examples.Add(b);
            examples.Add(c);
        }

        public Task InputLoop(string v)
        {
            action = "document.getElementsByClassName(\"field_value\")[0].value = \"" + v + "\";";
            return Task.CompletedTask;
        }

        public string ConvertStringToJSONItemByClass(string item)
        {
            string itemHtml = item.Substring(0, item.IndexOf(','));
            string index = item.Substring(item.IndexOf(',') + 1);
            return "document.getElementsByClassName(\"" + itemHtml + "\")[" + index + "]";
        }
        public string ConvertStringToJSONItemById(string item)
        {
            string itemHtml = item.Substring(0, item.IndexOf(','));
            string index = item.Substring(item.IndexOf(',') + 1);
            return "document.getElementsById(\"" + itemHtml + "\")[" + index + "]";
        }
        public string ConvertStringToJSONItemByName(string item)
        {
            string itemHtml = item.Substring(0, item.IndexOf(','));
            string index = item.Substring(item.IndexOf(',') + 1);
            return "document.getElementsByName(\"" + itemHtml + "\")[" + index + "]";
        }
        public string ConvertStringToJSONItemByTag(string item)
        {
            string itemHtml = item.Substring(0, item.IndexOf(','));
            string index = item.Substring(item.IndexOf(',') + 1);
            return "document.getElementsByName(\"" + itemHtml + "\")[" + index + "]";
        }

        internal string Class_ClickItem(string itemHTMLClass)
        {
            return ConvertStringToJSONItemByClass(itemHTMLClass) + ".click()";
        }

        internal string Class_InputString(string itemHTMLClass, string input)
        {
            return ConvertStringToJSONItemByClass(itemHTMLClass) + ".value = \"" + input + "\";";
        }

        internal string Id_ClickItem(string itemHTMLId)
        {
            return ConvertStringToJSONItemById(itemHTMLId) + ".click()";
        }

        internal string Id_InputString(string itemHTMLId, string input)
        {
            return ConvertStringToJSONItemById(itemHTMLId) + ".value = \"" + input + "\";";
        }

        internal string Name_ClickItem(string itemHTMLName)
        {
            return ConvertStringToJSONItemByName(itemHTMLName) + ".click()";
        }

        internal string Name_InputString(string itemHTMLName, string input)
        {
            return ConvertStringToJSONItemByName(itemHTMLName) + ".value = \"" + input + "\";";

        }

        internal string Tag_ClickItem(string itemHTMLTag)
        {
            return ConvertStringToJSONItemByTag(itemHTMLTag) + ".click()";
        }

        internal string Tag_InputString(string itemHTMLTag, string input)
        {
            return ConvertStringToJSONItemByTag(itemHTMLTag) + ".value = \"" + input + "\";";

        }
    }
}
