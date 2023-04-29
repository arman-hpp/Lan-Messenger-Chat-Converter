using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LanMessengerChatConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowseSrc_Click(object sender, EventArgs e)
        {
            ofdSelectSrc.Filter = @"db files (*.db)|*.db";
            ofdSelectSrc.RestoreDirectory = true;
            ofdSelectSrc.Multiselect = false;
            ofdSelectSrc.FileName = string.Empty;

            if (ofdSelectSrc.ShowDialog() == DialogResult.OK)
            {
                txtSrcPath.Text = ofdSelectSrc.FileName;
            }
        }

        private void btnBrowseDes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSrcPath.Text))
            {
                MessageBox.Show(@"Source file path is empty");
                return;
            }

            if (ofdSelectDes.ShowDialog() == DialogResult.OK)
            {
                var selectedPath = ofdSelectDes.SelectedPath;
                txtDesPath.Text = Path.Combine(selectedPath,
                    Path.GetFileNameWithoutExtension(ofdSelectSrc.FileName) + ".html");
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                var reader = new StreamReader(txtSrcPath.Text, Encoding.UTF8);
                var writer = new StreamWriter(txtDesPath.Text);

                var rawline = reader.ReadLine();
                while (rawline != null)
                {
                    var line = ParseLine(rawline);

                    writer.WriteLine(line);

                    rawline = reader.ReadLine();
                }

                reader.Close();
                writer.Close();

                MessageBox.Show(@"Db file converted to html file successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Exception: " + ex.Message);
            }
        }

        public static string ParseLine(string orginal)
        {
            // remove control chars
            var result = new string(
                orginal.Where(cc => !char.IsControl(cc) && cc != '\0').ToArray());

            // remove html codes
            result = result
                .Replace("&nbsp;", " ")
                .Replace("&amp;", "&")
                .Replace("&quot;", "\"")
                .Replace("&apos;", "'")
                .Replace("&gt;", ">")
                .Replace("&lt;", "<");

            // remove ids
            const string pattern = "</html>(.*?)<html>";
            var regex = new Regex(pattern, RegexOptions.RightToLeft);
            foreach (Match match in regex.Matches(result))
            {
                result = result.Replace(match.Groups[1].Value, string.Empty);
            }

            // remove first id
            var counts = result.IndexOf("<html>", StringComparison.Ordinal);
            if (counts > 0)
            {
                result = result.Remove(0, counts);
            }

            // remove last id
            var start = result.LastIndexOf("</html>", StringComparison.Ordinal) + "</html>".Length;
            if (result.Length - start > 0)
            {
                result = result.Remove(start, result.Length - start);
            }

            return result;
        }
    }
}
