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
    public partial class Calculator : Form
    {
        Double value = 0;
        String operation_Event = "";    // für die einzelnen Operationen
        bool operation_status = false;  // dafür ob eine Operation (+, -, *, /) gedrückt wurde
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
                

        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((resultCalc.Text == "0") || (operation_status))     // sobald eine Zifferntaste angeklickt wurde verschwindet die "0".
            {
                resultCalc.Clear();
            }
            Button btn = (Button)sender;    // Parameter der Methode in einen Button umwandeln

            resultCalc.Text = resultCalc.Text + btn.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;    // Parameter der Methode in einen Button umwandeln
            operation_Event = btn.Text;
            value = Double.Parse(resultCalc.Text);    // string in einen double parsen
            operation_status = true;        // true, wenn eine Operation gewählt wurde; nachdem eine Operation gewählt wurde wird die Anzeige zur
                                            // Darstellung der neuen Ziffer angezeigt
        }

        private void btnEqual_Click(object sender, EventArgs e) // was auch immer in Value steht 
        {
            switch (operation_Event)
            {
                case "+":
                    resultCalc.Text = (value + Double.Parse(resultCalc.Text)).ToString();    // Double.Parse(resultCalc.Text); --> ist das was als Wert in der Anzeige steht
                                                                                            // ToString --> in einem Textfeld werden Zeichen gespeichert
                    break;
                case "-":
                    resultCalc.Text = (value - Double.Parse(resultCalc.Text)).ToString(); 
                    break;
                case "*":
                    resultCalc.Text = (value * Double.Parse(resultCalc.Text)).ToString();
                    break;
                case "/":
                    resultCalc.Text = (value / Double.Parse(resultCalc.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_status = false;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            resultCalc.Text = "0";  // löscht den letzten Eintrag
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resultCalc.Clear(); // löscht alle Eingaben und
            value = 0;        // setzt den Wert auf "0"
        }
    }
}
