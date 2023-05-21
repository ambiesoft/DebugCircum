using Ambiesoft;
using System;
using System.Diagnostics;

namespace DebugCircum
{
    public partial class FormMain : Form
    {
        static readonly string SECTION_OPTION = "Option";
        static readonly string KEY_COPYCOUNT = "CopyCount";

        static Random random = new Random();
        enum RANDAM_LETTER
        {
            ASCII, NUMERIC,
        }

        public FormMain()
        {
            InitializeComponent();

            this.Text = Application.ProductName;

            int intval;
            HashIni ini = Profile.ReadAll(IniFile);
            Profile.GetInt(SECTION_OPTION, KEY_COPYCOUNT, 1, out intval, ini);
            udCopyCount.Value = intval;
        }

        static string IniFile
        {
            get
            {
                return Path.Combine(
                    Path.GetDirectoryName(Application.ExecutablePath) ?? string.Empty,
                    Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".ini");
            }
        }
        static char getRandomLetter(RANDAM_LETTER rl)
        {
            switch (rl)
            {
                case RANDAM_LETTER.ASCII:
                    {
                        int asciiValue = random.Next(26) + 97; // 97から122の範囲で乱数生成
                        return (char)asciiValue;
                    }
            }
            Debug.Assert(false);
            return 'A';
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            uint len = Decimal.ToUInt32(udCopyCount.Value);
            char[] chars = new char[len];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = getRandomLetter(RANDAM_LETTER.ASCII);
            }

            try
            {
                Clipboard.SetText(new string(chars));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            HashIni ini = Profile.ReadAll(IniFile);
            Profile.WriteInt(SECTION_OPTION, KEY_COPYCOUNT, Decimal.ToInt32(udCopyCount.Value), ini);

            if (!Profile.WriteAll(ini, IniFile))
            {
                MessageBox.Show("Failed to save ini",
                    Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}