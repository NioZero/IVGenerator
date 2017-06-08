using IVGenerator.Encryption;
using System;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace IVGenerator.App
{
    public partial class FormMain : Form
    {
        #region properties
        #endregion

        #region initialization

        public FormMain()
        {
            InitializeComponent();
        }

        #endregion

        #region methods
        #endregion

        #region events

        private void button1_Click(object sender, EventArgs e)
        {
            var vector = RijndaelEncryptorHelper.GenerateVector();

            var vectorString = vector.ToList().Select(n => string.Format("0x{0:x2}", n));

            textBox1.Text = string.Join(", ", vectorString);
        }

        #endregion
    }
}
