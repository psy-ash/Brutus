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
    public partial class ConditionalEventEditor : Form
    {
        public const string NullMod = "B|_ANK";

        Form1 mainForm;

        public ConditionalEventEditor()
        {
            InitializeComponent();
            mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        }

        public void LoadValues(ConditionalEvent ce)
        {
            ConditionComboBox.Text = ce.type;
            pauseTimelineCheck.Checked = ce.pauseOnReached;
            firstValueBox.Text = ce.value1;
            secondValueBox.Text = ce.value2;
            CustomCommandCheck.Checked = ce.toExec;
            ExecuteInputBox.Text = ce.execute;
        }

        private void CustomCommandCheck_CheckedChanged(object sender, EventArgs e)
        {
            ExecuteInputBox.Enabled = !ExecuteInputBox.Enabled;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            ConditionalEvent ce = mainForm.selectedCondEvent;
            ce.type = ConditionComboBox.Text;
            ce.pauseOnReached = pauseTimelineCheck.Checked;
            ce.value1 = firstValueBox.Text;
            ce.value2 = secondValueBox.Text;
            ce.toExec = CustomCommandCheck.Checked;
            ce.execute  = ExecuteInputBox.Text;

            // change the button icon


            Close();
        }
    }
}
