using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;

namespace SpeechText
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        List<VoiceInfo> voices = new List<VoiceInfo>();
        Thread thread;
        double Volum = 0;
        double Rate = 0;
        public Form1()
        {
            InitializeComponent();
            foreach (InstalledVoice voice in synthesizer.GetInstalledVoices())
            {
                voices.Add(voice.VoiceInfo);
                Voces.Items.Add(voice.VoiceInfo.Name);
            }
            Voces.SelectedIndex = 0;
            Volumen.Value = 30;
        }
        
        private void Reproducir_Click(object sender, EventArgs e)
        {
            int indice;

            Volum = Volumen.Value;
            Rate = Ratio.Value;
            indice = Voces.SelectedIndex;
            string Nombre = voices.ElementAt(indice).Name;
            synthesizer.SelectVoice(Nombre);
            synthesizer.Volume = (int)Volum;
            synthesizer.Rate = (int)Rate;
            string Text = Texto.Text;
            thread = new Thread(() => Hablar(Text));
            thread.Start();
        }
        void Hablar(string texto)
        {
            try
            {
                synthesizer.Speak(texto);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            thread.Interrupt();
        }
    }
}
