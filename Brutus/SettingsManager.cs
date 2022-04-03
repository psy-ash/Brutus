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
    public partial class SettingsManager : Form
    {
        Form1 mainForm;

        public SettingsManager()
        {
            mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            InitializeComponent();
        }

        private void SettingsManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.settingsOpen = false;
        }
    }
}
