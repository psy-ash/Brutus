using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Web.Helpers;
using System.Diagnostics;
using Newtonsoft.Json;

namespace Brutus
{
    public partial class Form1 : Form
    {
        public const string NullMod = "B|_ANK";

        public EventButton selectedButton;
        public ConditionalEvent selectedCondEvent;
        public List<string> words = new List<string>();
        public List<string> GenCombos = new List<string>();
        public JsonClips jClips = new JsonClips();
        public List<EventButton> eBtnData = new List<EventButton>();
        public List<Button> eButtons = new List<Button>();
        public List<ConditionalEvent> cond_eBtnData = new List<ConditionalEvent>();
        public List<Button> cond_eButtons = new List<Button>();
        public int loopCount = 0;
        public bool settingsOpen = false, eventEditorOpen = false;
        public Control SelectedControl;

        private JsonObject jsonObject;
        private int eventCount = 0;
        private bool playing, looping;
        private readonly Stopwatch timelineStopwatch = new Stopwatch();
        private TimelineProcessor timelineProcessor = new TimelineProcessor();
        private Point mouseDownLocation, startLocation, _mousePos;
        private Rectangle pseudoBounds = new Rectangle(0, 0, 866, 175);
        private string windowObjectFromContext;

        public Form1()
        {
            InitializeComponent();
            jClips.Load();
            Init();
        }

        private void Init()
        {

        }

        private void ZoomValue_ValueChanged(object sender, EventArgs e)
        {
            Window.ZoomFactor = (double)ZoomValue.Value / 100;
        }

        internal void UpdateImage(EventButton eb)
        {
            if (eb.Func == "Click")
                SetClickerImage(eBtnData.Last().refCB, eBtnData.Last().btn);
            else
                SetTypingImage(eBtnData.Last().refCB,eBtnData.Last().btn);
        }

        internal void RemoveEventButton(EventButton selectedButton)
        {
            Timeline.Controls.Remove(SelectedControl);
            eButtons.Remove(selectedButton.btn);
            eBtnData.Remove(selectedButton);
        }

        private void Window_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            Window.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            Window.ZoomFactor = (double)ZoomValue.Value / 100;
        }

        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Uri uri = new Uri("https://www." + SearchBar.Text);
                Window.Source = uri;
            }
        }

        private void PlaceEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouseClick = new Point(e.X, e.Y);
                bool canPlace = true;


                CreateEventButton(canPlace, mouseClick);
            } else if(e.Button == MouseButtons.Right)
            {
                _mousePos = e.Location;
                TimeLineCM.Show(Timeline, e.Location);
            }
        }

        private void CreateEventButton(bool canPlace, Point mouseClick)
        {
            Size EBtnBox = new Size(49, 49);

            if (eButtons.Count > 0)
            {
                for (int i = 0; i < eButtons.Count; i++)
                {
                    if (eButtons[i].Bounds.IntersectsWith(new Rectangle(mouseClick, EBtnBox)) /*|| eButtons[i].Location.X > mouseClick.X*/)
                    {
                        canPlace = false;
                    }
                }
            }
            if (canPlace)
            {
                EventButton eb = new EventButton();
                Button eventBtn = new Button();
                eventBtn.Text = "";
                eventBtn.Name = "Event" + eventCount++;
                eventBtn.Size = new Size(48, 49);
                eventBtn.Location = mouseClick;
                eventBtn.Click += OpenEditor;
                eventBtn.MouseMove += DraggingControls;
                eventBtn.MouseDown += EventButtonMouseDown;
                eventBtn.MouseUp += EventButtonMouseUp;
                eventBtn.Image = Properties.Resources.ClassClicker;
                eb.refCB = "Class";
                eb.Func = "Click";
                eb.itemHTML = "class name";
                eb.loop = false;
                eb.loopCount = 1;
                eb.Input = NullMod;
                eb.btn = eventBtn;
                Timeline.Controls.Add(eventBtn);
                eButtons.Add(eventBtn);
                eBtnData.Add(eb);
                Timeline.Update();
                selectedButton = eb;
                SelectedControl = eventBtn;
            }
        }

        private void makeTimelineEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventButton eb = new EventButton();
            Button button = new Button();
            button.Text = "";
            button.Name = "Event" + eventCount++;
            button.Size = new Size(48, 48);
            if (eButtons.Count > 0)
            {
                Button ebTemp = eButtons.Last();
                button.Location = new Point(ebTemp.Right + 12, ebTemp.Top);
            }
            else
            {
                button.Location = new Point(2, 32);
            }
            button.Click += OpenEditor;
            button.MouseMove += DraggingControls;
            button.MouseDown += EventButtonMouseDown;
            button.MouseUp += EventButtonMouseUp;
            button.Image = Properties.Resources.ClassClicker;
            eb.refCB = "Class";
            eb.Func = "Click";
            eb.itemHTML = jsonObject.objClass.Substring(1, jsonObject.objClass.Length - 2) + "," + eb.itemIndex;
            eb.started = false;
            eb.loop = false;
            eb.loopCount = 1;
            eb.Input = NullMod;
            eb.btn = button;
            Timeline.Controls.Add(button);
            eButtons.Add(button);
            eBtnData.Add(eb);
            Timeline.Update();
            selectedButton = eb;
            SelectedControl = button;
        }

        public void CreateConditionalEventButton(bool canPlace, Point mouseClick)
        {
            Size EBtnBox = new Size(33, 49);

            if (eButtons.Count > 0)
            {
                for (int i = 0; i < eButtons.Count; i++)
                {
                    if (eButtons[i].Bounds.IntersectsWith(new Rectangle(mouseClick, EBtnBox)))
                    {
                        canPlace = false;
                    }
                }
            }
            if (canPlace)
            {
                ConditionalEvent eb = new ConditionalEvent();
                Button eventBtn = new Button();
                eventBtn.Text = "";
                eventBtn.Name = "Event" + eventCount++;
                eventBtn.Size = new Size(32, 48);
                eventBtn.Location = mouseClick;
                eventBtn.Click += OpenConditionalEditor;
                eventBtn.MouseMove += DraggingControls;
                eventBtn.MouseDown += EventButtonMouseDown;
                eventBtn.MouseUp += EventButtonMouseUp;
                eventBtn.Image = Properties.Resources.ConditionalB;
                eb.type = "If";
                eb.value1 = NullMod;
                eb.value2 = NullMod;
                eb.pauseOnReached = true;
                eb.execute = NullMod;
                eb.btn = eventBtn;
                Timeline.Controls.Add(eventBtn);
                cond_eButtons.Add(eventBtn);
                cond_eBtnData.Add(eb);
                Timeline.Update();
                selectedCondEvent = eb;
            }
        }

        private void OpenConditionalEditor(object sender, EventArgs e)
        {
            selectedCondEvent = cond_eBtnData[cond_eButtons.IndexOf(sender as Button)];
            ConditionalEventEditor cee = new ConditionalEventEditor();
            cee.Show();
            cee.LoadValues(selectedCondEvent);
        }

        internal void EventButtonMouseUp(object sender, MouseEventArgs e)
        {
            Button dragRefBtn = sender as Button;
            if (e.Button == MouseButtons.Right && !pseudoBounds.Contains(dragRefBtn.Location))
            {
                dragRefBtn.Location = startLocation;
            }
        }

        internal void EventButtonMouseDown(object sender, MouseEventArgs e)
        {
            selectedButton = sender as EventButton;
            Button dragRefBtn = sender as Button;
            startLocation = dragRefBtn.Location;
            if (e.Button == MouseButtons.Right && pseudoBounds.Contains(dragRefBtn.Location))
            {
                mouseDownLocation = e.Location;
            }
        }

        internal void DraggingControls(object sender, MouseEventArgs e)
        {
            Button dragRefBtn = sender as Button;

            if (e.Button == MouseButtons.Right && pseudoBounds.Contains(dragRefBtn.Location))
            {
                dragRefBtn.Left = e.X + dragRefBtn.Left - mouseDownLocation.X;
                dragRefBtn.Top = e.Y + dragRefBtn.Top - mouseDownLocation.Y;
            }
        }

        public void SetTypingImage(string s, Button b)
        {
            if (s == "Class")
            {
                b.Image = Properties.Resources.ClassTypeIcon;
            }
            else if (s == "Id")
            {
                b.Image = Properties.Resources.IdTypeIcon;
            }
            else if (s == "Name")
            {
                b.Image = Properties.Resources.NameTypeIcon;
            }
            else if (s == "Tag")
            {
                b.Image = Properties.Resources.TagTypeIcon;
            }
        }

        public void SetClickerImage(string s, Button b)
        {
            if(s == "Class")
            {
                b.Image = Properties.Resources.ClassClicker;
            }
            else if (s == "Id")
            {
                b.Image = Properties.Resources.IdClicker;
            }
            else if (s == "Name")
            {
                b.Image = Properties.Resources.NameClicker;
            }
            else if (s == "Tag")
            {
                b.Image = Properties.Resources.TagClicker;
            }
        }

        internal void OpenEditor(object sender, EventArgs e)
        {
            if (!eventEditorOpen)
            {
                selectedButton = eBtnData[eButtons.IndexOf(sender as Button)];
                EventEditor ee = new EventEditor();
                ee.Show();
                ee.LoadValues(selectedButton);
                eventEditorOpen = true;
            }
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                playing = true;
                playBtn.Text = "Pause";
                animTimer.Start();
                tlTicker.BackColor = Color.Firebrick;
                timelineStopwatch.Start();
            }
            else
            {
                tlTicker.BackColor = Color.DimGray;
                playBtn.Text = "Play";
                playing = false;
                TimelineStop();
            }
        }

        private void animTimer_Tick(object sender, EventArgs e)
        {

            // add pause on condition in here <------------

            int len = timelineIMG.Width + 125;

            // incrementally move
            if(playing)
                tlTicker.Left += 1;
            // huh? //
            if (tlTicker.Left > len) tlTicker.Left = len;

            // End Conditions
            if (tlTicker.Left == len || timelineStopwatch.Elapsed.TotalMinutes >= (float)loopMinutesNB.Value)
            {
                if (looping)
                {
                    tlTicker.Location = new Point(0, tlTicker.Location.Y);
                    timelineStopwatch.Restart();
                }
                else
                {
                    playing = false;
                    animTimer.Stop();
                    timelineStopwatch.Stop();
                }
            }
            for(int i = 0; i < eButtons.Count; i++) 
            {
                if (!eBtnData[i].started && tlTicker.Right >= eButtons[i].Left)
                {
                    ExecuteCodeOnTimeline(eBtnData[i]);
                    eBtnData[i].started = true;
                }
            }
            for (int i = 0; i < cond_eButtons.Count; i++)
            {
                if (!cond_eBtnData[i].started && tlTicker.Right >= cond_eButtons[i].Left)
                {
                    CheckCondition(cond_eBtnData[i]);
                    cond_eBtnData[i].started = true;
                }
            }
        }

        private void CheckCondition(ConditionalEvent ce)
        {
            //await Window.CoreWebView2.ExecuteScriptAsync(EventExecutes.ExecuteEvent(ce));
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timelineStopwatch.Reset();
            playBtn.Text = "Play";
            playing = false;
            tlTicker.BackColor = Color.DimGray;
            tlTicker.Location = new Point(0, tlTicker.Location.Y);
            TimelineStop();
        }

        public void TimelineStop()
        {
            if (playing)
            {
                tlTicker.BackColor = Color.DimGray;
                playBtn.Text = "Play";
                animTimer.Stop();
                timelineStopwatch.Stop();
                playing = false;

            }
        }

        public async void ExecuteCodeOnTimeline(EventButton eb)
        {
            await Window.CoreWebView2.ExecuteScriptAsync(EventExecutes.ExecuteEvent(eb));
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if(Window.CanGoBack)
                Window.GoBack();
        }

        private void fwrdBtn_Click(object sender, EventArgs e)
        {
            if (Window.CanGoForward)
                Window.GoForward();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Window.Refresh();
        }

        private void saveStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Window.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateEventButton(true, _mousePos);
            _mousePos = new Point(0, 0);
            
        }

        private void addConditionalEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateConditionalEventButton(true, _mousePos);
            _mousePos = new Point(0, 0);
        }

        private void inspectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.CoreWebView2.OpenDevToolsWindow();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Clipboard.SetText();
        }

        private void LoopingButton_Click(object sender, EventArgs e)
        {
            looping = LoopChecked.Checked;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.GoBack();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTimeline();
        }

        public void ClearTimeline()
        {
            Timeline.Controls.OfType<Button>().ToList().ForEach(btn => btn.Dispose());
            eButtons.Clear();
            eBtnData.Clear();
        }

        private void loopMinutesNB_ValueChanged(object sender, EventArgs e)
        {
            loopMinutesNB.Validate();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            timelineProcessor.WriteFile(saveFileDialog1.FileName, eBtnData);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string s = Path.GetFullPath(openFileDialog1.FileName);
            if(s != null)
                timelineProcessor.ReadFile(s);
        }

        private void settingsManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!settingsOpen)
            {
                SettingsManager sm = new SettingsManager();
                sm.Show();
                settingsOpen = true;
            }
        }

        private async void WebView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            Window.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            string script = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, @"contextDisableInject.js"));
            await Window.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(script);
        }

        private void WebView21_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            jsonObject = JsonConvert.DeserializeObject<JsonObject>(e.WebMessageAsJson);
            switch (jsonObject.Key)
            {
                case "contextmenu":
                    WindowContextMenu.Show(Point.Truncate(jsonObject.Value));
                    mouseDownLocation = Cursor.Position;
                    break;
                case "mousedown":
                    WindowContextMenu.Hide();
                    break;
                case "mousemove":
                    GetObjectFromWindow(jsonObject.objClass);
                    break;

            }
        }

        private void GetObjectFromWindow(string s)
        {
            windowObjectFromContext = s;
            testBox.Text = windowObjectFromContext;
        }

        private void Timeline_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = Timeline.CreateGraphics())
            {
                int largeStep = 30, smallStep = 15;

                SolidBrush brush = new SolidBrush(Color.DimGray);
                Pen pen = new Pen(Color.Black, 2);
                g.FillRectangle(brush, new Rectangle(0, 0, Timeline.Width, 21));
                for(int i = 0; i < Timeline.Width; i+= largeStep)
                    g.DrawLine(pen, 0 + i, 0, 0 + i, 20);
                pen.Width = 1.4f;
                for (int i = 0; i < Timeline.Width; i += smallStep)
                    g.DrawLine(pen, 0 + i, 0, 0 + i, 12);
                brush.Color = Color.White;
                brush.Dispose();
                pen.Dispose();


                SolidBrush brush2 = new SolidBrush(Color.Moccasin);
                Pen pen2 = new Pen(Color.LightGray, 2);
                g.FillRectangle(brush2, new Rectangle(0, 21, Timeline.Width, Timeline.Height));
                for (int i = 0; i < Timeline.Width; i += largeStep)
                    g.DrawLine(pen2, 0 + i, 21, 0 + i, Timeline.Height);
                pen2.Width = 1.4f;
                for (int i = 0; i < Timeline.Width; i += smallStep)
                    g.DrawLine(pen2, 0 + i, 21, 0 + i, Timeline.Height);
                brush2.Color = Color.White;
                brush2.Dispose();
                pen2.Dispose();
            }
        }

    }
}


public class EventButton
{
    public bool started = false;
    public Button btn;
    public string refCB;
    public string Func, itemHTML;
    public bool loop;
    public int loopCount;
    public string Input;
    public Point _pos;
    public int itemIndex = 0;
}
public class ConditionalEvent
{
    public bool started = false;
    public string type;
    public string value1, value2;
    public bool pauseOnReached = true, paused = false;
    public string execute;
    public Point _pos;
    public Button btn;
    internal bool toExec = false;
}
struct JsonObject
{
    public string Key;
    public PointF Value;
    public string objClass;
}