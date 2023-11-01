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
            //comboBox1.SelectedIndexChanged += (s, ea) =>
            //{
            //    restrictedTextbox3.Restrict = (RestrictedTextbox.RestrictedTextbox.RestrictType)comboBox1.SelectedItem;
            //    label3.Text = restrictedTextbox3.CapableRegexPattern;
            //};
            comboBox1_SelectedIndexChanged(comboBox1, EventArgs.Empty);
            //textBox2_TextChanged(textBox2, null);
        }

        private void restrictedTextbox6_TextChanged(object sender, EventArgs e)
        {
            restrictedTextboxText.CapableRegexPattern = restrictedTextbox6.Text;
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
            try
            {
                var regex = new Regex(textBox1.Text);
            }
            catch
            {
                return;
            }
            restrictedTextbox1.CapableRegexPattern = textBox1.Text;
        }
    }
}
