using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Forms_App
{
    public partial class MainForm : Form
    {
        private static string _username => ConfigurationManager.AppSettings.Get("Username");

        public MainForm()
        {
            InitializeComponent();
            MainLabel.Text = MainResources.WelcomeMessagePlaceholder + _username;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(MainResources.FarewellMesssagePlaceholder + _username);
        }
    }
}
