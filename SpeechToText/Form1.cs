using System;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
using Vosk;
using Newtonsoft.Json.Linq;

namespace SpeechToText
{
    public partial class Form1 : Form
    {
        private WaveInEvent wave;
        private VoskRecognizer recognizer;
        private Model model;
        private bool kayıt = false;

        public Form1()
        {
            InitializeComponent();
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            string modelPath = Path.Combine(Application.StartupPath, "model/vosk-model-small-tr-0.3");
            if (!Directory.Exists(modelPath))
            {
                
                MessageBox.Show("Model klasörü bulunamadı!\n" + modelPath);
                return;
            }

            Vosk.Vosk.SetLogLevel(-1);
            model = new Model(modelPath);
            recognizer = new VoskRecognizer(model, 16000.0f);

            wave = new WaveInEvent
            {
                WaveFormat = new WaveFormat(16000, 1)
            };
            wave.DataAvailable += WaveIn_DataAvailable;

            wave.StartRecording();
            kayıt = true;

            txtTranscript.AppendText(" Dinleniyor... /r/n");

            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (recognizer.AcceptWaveform(e.Buffer, e.BytesRecorded))
            {
                var result = JObject.Parse(recognizer.Result());
                var text = result["text"]?.ToString();

                if (!string.IsNullOrEmpty(text))
                {
                    this.Invoke(new Action(() =>
                    {
                        txtTranscript.AppendText(text + " ");
                    }));
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (kayıt)
            {
                kayıt = false;
                wave.StopRecording();

                var finalResult = JObject.Parse(recognizer.FinalResult());
                var finalText = finalResult["text"]?.ToString();
                if (!string.IsNullOrEmpty(finalText))
                {
                    txtTranscript.AppendText(finalText + "\r\n");
                }

                wave.Dispose();
                recognizer.Dispose();
                model.Dispose();
                wave = null;
                recognizer = null;
                model = null;

              
                txtTranscript.AppendText("Kayıt durduruldu.");
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }
    }
}