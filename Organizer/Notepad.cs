using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Organizer
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
            Directory.CreateDirectory(@"C:\Users\TThielker\Desktop\Notepad\");
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            // laden der Datei
            if (System.IO.File.Exists(@"C:\Users\TThielker\Desktop\Notepad\notes.txt"))  // überprüfen ob die Datei vorhanden ist und ob sie dann ausgelesen werden kann
            {
                System.IO.StreamReader streamreader = new System.IO.StreamReader(@"C:\Users\TThielker\Desktop\Notepad\notes.txt");
                textBox1.Text = streamreader.ReadToEnd();   // komplette txt-Datei wird ausgelesen und dem Inhalt der TextBox übergeben
                streamreader.Close(); // damit wieder auf die Datei zugegriffen werden kann, da sie ansonsten hier weiterhin verwendet wird
            }
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            // speichern der Datei
            System.IO.StreamWriter streamwriter = new System.IO.StreamWriter(@"C:\Users\TThielker\Desktop\Notepad\notes.txt"); // anlegen eines Objektes und dem Konstruktor den Pfad mitgeben
                                                                                                                               // an dem das File gespeichert werden soll
            streamwriter.WriteLine(textBox1.Text); // zum Inhalt schreiben mit writeline als String wird die TextBox verwendet und hier der Text
            streamwriter.Flush(); // damit der grschriebene Inhalt in der Datei gespeichert ist
            streamwriter.Close(); // um die Datei freizugeben
        }

        private void öffnenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = File.ReadAllText(filename);
            textBox1.Text = readfile;
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newFile = @"C:\Users\TThielker\Desktop\Notepad\newFile.txt";
            File.Create(@"C:\Users\TThielker\Desktop\Notepad");
            

            //using (File.Create(@"C:\Users\TThielker\Desktop\Notepad"));
            //System.IO.FileStream (@"C:\Users\TThielker\Desktop\Notepad\");
            //File.Create(@"C:\Users\TThielker\Desktop\Notepad");
            //string fileName = System.IO.Path.GetRandomFileName();
        }
    }
}
