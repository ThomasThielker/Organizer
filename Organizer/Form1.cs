using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class Form1 : Form   // aufgeteilt in mehrere Code Fragmente --> partial
    {
        public Form1()      // Konstruktor von Form1
        {
            InitializeComponent();
        }

        Calculator calc = new Calculator(); // Datentyp: Calculator Name: calc = mit "new" Schlüsselwort neues Objekt erzeugen 

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            calc.ShowDialog();
        }

        Notepad notice = new Notepad(); //durch hinzufügen eines Formulars

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            notice.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
