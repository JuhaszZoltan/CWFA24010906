
using System.Security.Policy;

namespace CsevegesGUI
{
    public partial class CsevegesForm : Form
    {
        private List<Beszelgetes> _beszelgetesek = new();

        public CsevegesForm()
        {
            InitializeComponent();
            InitNonStatic();
        }

        private void InitNonStatic()
        {
            HashSet<string> kezd = new();
            HashSet<string> fogad = new();

            using StreamReader sr = new(@"..\..\..\src\csevegesek.txt");
            _ = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Beszelgetes beszelgetes = new(sr.ReadLine());
                kezd.Add(beszelgetes.Kezdemenyezo);
                fogad.Add(beszelgetes.Fogado);
                _beszelgetesek.Add(beszelgetes);
            }

            cbxKezdemenyezok.Items.AddRange(kezd.OrderBy(x => x).ToArray());
            cbxFogadok.Items.AddRange(fogad.OrderBy(x => x).ToArray());
            cbxKezdemenyezok.SelectedIndex = 0;
            cbxFogadok.SelectedIndex = cbxFogadok.Items.Count - 1;
        }
    }
}
