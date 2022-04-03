using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brutus
{
    internal static class EventExecutes
    {
        public const string NullMod = "B|_ANK";

        static Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        static JsonClips jClips = new JsonClips();

        public static string ExecuteEvent(EventButton eb)
        {
            for (int i = 0; i <= eb.loopCount; i++)
            {
                if (eb.refCB == "Class")
                {
                    if (eb.Func == "Click")
                    {
                        return jClips.Class_ClickItem(eb.itemHTML);
                    }
                    else if (eb.Func == "String Input")
                    {
                        return jClips.Class_InputString(eb.itemHTML, eb.Input);
                    }
                }
                else if (eb.refCB == "Id")
                {
                    if (eb.Func == "Click")
                    {
                        return jClips.Id_ClickItem(eb.itemHTML);
                    }
                    else if (eb.Func == "String Input")
                    {
                        return jClips.Id_InputString(eb.itemHTML, eb.Input);
                    }
                }
                else if (eb.refCB == "Name")
                {
                    if (eb.Func == "Click")
                    {
                        return jClips.Name_ClickItem(eb.itemHTML);
                    }
                    else if (eb.Func == "String Input")
                    {
                        return jClips.Name_InputString(eb.itemHTML, eb.Input);
                    }
                }
                else if (eb.refCB == "Tag")
                {
                    if (eb.Func == "Click")
                    {
                        return jClips.Tag_ClickItem(eb.itemHTML);
                    }
                    else if (eb.Func == "String Input")
                    {
                        return jClips.Tag_InputString(eb.itemHTML, eb.Input);
                    }
                }
            }
            return null;
        }
    }
}
