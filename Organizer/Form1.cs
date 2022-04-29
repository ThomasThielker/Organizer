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
    public partial class Organizer : Form   // aufgeteilt in mehrere Code Fragmente --> partial
    {
        public Organizer()      // Konstruktor von Form1
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

        private void Organizer_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHourMinute.Text = DateTime.Now.ToString("t");
            lblDate.Text = DateTime.Now.ToString("dddd, dd MM yyyy");
        }

    
    }
}
