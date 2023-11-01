using RestrictedTextbox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestrictedTextboxSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(RestrictedTextbox.RestrictedTextbox.RestrictType));
            comboBox1_SelectedIndexChanged(comboBox1, EventArgs.Empty);
            restrictedTextbox_TextChanged(restrictedTextboxPt, null);
        }

        private void restrictedTextbox_TextChanged(object sender, EventArgs e)
        {
            restrictedTextboxText.CapableRegexPattern = restrictedTextboxPt.Text;

            if (string.IsNullOrEmpty(restrictedTextboxText.ErrorMessage)== false)
                restrictedTextboxPt.BackColor = Color.Red;
            else
                restrictedTextboxPt.BackColor = Color.White;
            toolTip1.SetToolTip(restrictedTextboxPt, restrictedTextboxText.ErrorMessage);
            toolTip1.Show(restrictedTextboxText.ErrorMessage, restrictedTextboxPt, 0, 20, 2000);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            restrictedTextbox1.Restrict = (RestrictedTextbox.RestrictedTextbox.RestrictType)comboBox1.SelectedItem;
            textBox1.Text = restrictedTextbox1.CapableRegexPattern;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (restrictedTextbox1.CapableRegexPattern == textBox1.Text)
                return;
            restrictedTextbox1.CapableRegexPattern = textBox1.Text;


            if (string.IsNullOrEmpty(restrictedTextbox1.ErrorMessage) == false)
                textBox1.BackColor = Color.Red;
            else
                textBox1.BackColor = Color.White;
            toolTip1.SetToolTip(textBox1, restrictedTextbox1.ErrorMessage);
            toolTip1.Show(restrictedTextbox1.ErrorMessage, textBox1, 0, 20, 2000);

        }
    }
}
