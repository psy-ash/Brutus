using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Brutus
{
    internal class TimelineProcessor
    {

        // ---- add saving and loading conditional events ---- ////

        public List<string> result = new List<string>();
        Form1 form1;

        public void ReadFile(string fileName)
        {
            form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            form1.ClearTimeline();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line != null)
                        result.Add(line);
                }
                reader.Close();
            }

            int eventCount = int.Parse(result[0]);
            int linecount = 0;
            for (int i = 0; i < eventCount; i++)
            {
                Point pos = new Point(int.Parse(result[linecount + 1]), int.Parse(result[linecount + 2]));
                EventButton eb = new EventButton();
                Button button = new Button();
                button.Text = "";
                button.Name = "Event" + eventCount + 1;
                button.Size = new Size(48, 49);
                button.Location = pos;
                button.Click += form1.OpenEditor;
                button.MouseMove += form1.DraggingControls;
                button.MouseDown += form1.EventButtonMouseDown;
                button.MouseUp += form1.EventButtonMouseUp;
                eb.btn = button;
                eb.refCB = result[linecount + 3];
                eb.Func = result[linecount + 4];
                eb.itemHTML = result[linecount + 5];
                if (result[linecount + 6] == "true")
                    eb.loop = true;
                else
                    eb.loop = false;
                eb.loopCount = int.Parse(result[linecount + 7]);
                eb.Input = result[linecount + 8];
                form1.Timeline.Controls.Add(button);
                form1.eButtons.Add(button);
                form1.eBtnData.Add(eb);
                form1.Timeline.Update();
                form1.selectedButton = eb;
                form1.SelectedControl = button;
                form1.UpdateImage(eb);
                linecount += 8;

            }
        }

        public void WriteFile(string fileName, List<EventButton> ebData)
        {
            using (StreamWriter w = new StreamWriter(fileName + ".csv"))
            {
                w.WriteLine(ebData.Count + "");

                for (int i = 0; i < ebData.Count; i++)
                {
                    w.WriteLine(ebData[i].btn.Location.X + "");
                    w.WriteLine(ebData[i].btn.Location.Y + "");
                    w.WriteLine(ebData[i].refCB);
                    w.WriteLine(ebData[i].Func);
                    w.WriteLine(ebData[i].itemHTML);
                    w.WriteLine(ebData[i].loop.ToString());
                    w.WriteLine(ebData[i].loopCount + "");
                    w.WriteLine(ebData[i].Input);
                    w.Flush();
                }
            }
        }
    }
}
