using IVGenerator.Encryption;
using System;
using System.Linq;
using System.Windows.Forms;

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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var keys = RijndaelEncryptorHelper.GenerateKeys();

            var keyString = keys.Key.ToList().Select(n => string.Format("0x{0:x2}", n));
            var ivString = keys.IV.ToList().Select(n => string.Format("0x{0:x2}", n));

            txtPrivateKey.Text = string.Join(", ", keyString);
            txtIV.Text = string.Join(", ", ivString);
        }

        #endregion
    }
}
