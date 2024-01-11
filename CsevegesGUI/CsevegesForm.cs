
using System.Security.Policy;

namespace CsevegesGUI
{
    public partial class CsevegesForm : Form
    {
        private List<Beszelgetes> beszelgetesek = new();

        public CsevegesForm()
        {
            InitializeComponent();
            InitNonStatic();

            this.Load += BeszelgetesekRtbFill;
            cbxKezdemenyezok.SelectedIndexChanged += BeszelgetesekRtbFill;
            cbxFogadok.SelectedIndexChanged += BeszelgetesekRtbFill;

        }

        private void BeszelgetesekRtbFill(object sender, EventArgs e)
        {
            rtbCsevegesek.Text = string.Empty;

            if (cbxKezdemenyezok.SelectedItem.ToString() == cbxFogadok.SelectedItem.ToString())
            {
                rtbCsevegesek.Text = "Nem történt beszélgetés!";
            }
            else
            {
                var szurtLista = beszelgetesek.Where(
                    b => b.Kezdemenyezo == cbxKezdemenyezok.SelectedItem.ToString()
                    && b.Fogado == cbxFogadok.SelectedItem.ToString()).ToList();

                if (szurtLista.Count == 0)
                {
                    rtbCsevegesek.Text = "Nem történt beszélgetés!";
                }
                else
                {
                    int id = 1;
                    foreach (var b in szurtLista)
                    {
                        rtbCsevegesek.Text += $"{id}. " +
                            $"{b.Kezdet:yy.MM.dd-HH:mm:ss} --> " +
                            $"{b.Veg:yy.MM.dd-HH:mm:ss}\n";
                        id++;
                    }
                }
            }
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
                beszelgetesek.Add(beszelgetes);
            }

            cbxKezdemenyezok.Items.AddRange(kezd.OrderBy(x => x).ToArray());
            cbxFogadok.Items.AddRange(fogad.OrderBy(x => x).ToArray());
            cbxKezdemenyezok.SelectedIndex = 0;
            cbxFogadok.SelectedIndex = cbxFogadok.Items.Count - 1;
        }
    }
}
