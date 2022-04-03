using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brutus
{
    public partial class EventEditor : Form
    {
        public const string NullMod = "B|_ANK";

        Form1 mainForm;

        public EventEditor()
        {
            InitializeComponent();
            mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        }

        public void LoadValues(EventButton eb)
        {
            refCB.Text = eb.refCB;
            ItemHTMLTxt.Text = eb.itemHTML;
            FunctionComB.Text = eb.Func;
            loopCB.Checked = eb.loop;
            if (loopCB.Checked)
                LoopCount.Value = eb.loopCount;
            InputBox.Text = eb.Input;
            itemIndex.Value = eb.itemIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoopCount.Enabled = loopCB.Checked;
        }

        private void FunctionComB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(FunctionComB.SelectedIndex == 1)
            {
                InputBox.Enabled = true;
            } else
            {
                InputBox.Enabled = false;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            mainForm.selectedButton.refCB = refCB.Text;
            mainForm.selectedButton.itemHTML = ItemHTMLTxt.Text + "," + itemIndex.Value;
            mainForm.selectedButton.Func = FunctionComB.SelectedItem.ToString();
            mainForm.selectedButton.itemIndex = (int) itemIndex.Value;

            if (mainForm.selectedButton.Func == "Click")
                mainForm.SetClickerImage(refCB.Text, mainForm.selectedButton.btn);
            else
                mainForm.SetTypingImage(refCB.Text, mainForm.selectedButton.btn);


            mainForm.selectedButton.loop = loopCB.Checked;
            if(loopCB.Checked)
                mainForm.selectedButton.loopCount = (int)LoopCount.Value;
            if(FunctionComB.SelectedItem.ToString() == "String Input")
                mainForm.selectedButton.Input = InputBox.Text;
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            mainForm.RemoveEventButton(mainForm.selectedButton);
            Close();
        }

        private void EventEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.eventEditorOpen = false;
        }
    }
}
