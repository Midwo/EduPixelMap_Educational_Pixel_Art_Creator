using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaEdukacyjna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bActiveColor.BackColor = button2.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bActiveColor.BackColor = button3.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bActiveColor.BackColor = button4.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bActiveColor.BackColor = button5.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bActiveColor.BackColor = button6.BackColor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bActiveColor.BackColor = button7.BackColor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bActiveColor.BackColor = button8.BackColor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bActiveColor.BackColor = button9.BackColor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bActiveColor.BackColor = button10.BackColor;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bActiveColor.BackColor = button11.BackColor;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bActiveColor.BackColor = button12.BackColor;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bActiveColor.BackColor = button13.BackColor;
        }
     

        private void ChangeButton(object sender, EventArgs e)
        {
            var x = sender as Button;
            var y = x.Name;

            if (x.BackColor == bActiveColor.BackColor)
            {
                
                switch (bActiveColor.BackColor.Name)
                {
                    case "Red":
                        var Red = listViewRed.FindItemWithText(""+y+"");
                        if (Red != null)
                        {
                            listViewRed.Items.Remove(Red);
                        }
                        break;
                    case "Aqua":
                       var Aqua = listViewAqua.FindItemWithText("" + y + "");
                        if (Aqua != null)
                        {
                            listViewAqua.Items.Remove(Aqua);
                        }
                        break;
                    case "Navy":
                        var Navy = listViewNavy.FindItemWithText("" + y + "");
                        if (Navy != null)
                        {
                            listViewNavy.Items.Remove(Navy);
                        }
                        break;
                    case "Black":
                        var Black = listViewBlack.FindItemWithText("" + y + "");
                        if (Black != null)
                        {
                            listViewBlack.Items.Remove(Black);
                        }
                        break;
                    case "Blue":
                        var Blue = listViewBlue.FindItemWithText("" + y + "");
                        if (Blue != null)
                        {
                            listViewBlue.Items.Remove(Blue);
                        }
                        break;
                    case "Fuchsia":
                        var Fuchsia = listViewFuchsia.FindItemWithText("" + y + "");
                        if (Fuchsia != null)
                        {
                            listViewFuchsia.Items.Remove(Fuchsia);
                        }
                        break;
                    case "Green":
                        var Green = listViewGreen.FindItemWithText("" + y + "");
                        if (Green != null)
                        {
                            listViewGreen.Items.Remove(Green);
                        }
                        break;
                    case "Silver":
                        var Silver = listViewSilver.FindItemWithText("" + y + "");
                        if (Silver != null)
                        {
                            listViewSilver.Items.Remove(Silver);
                        }
                        break;
                    case "DarkOrange":
                        var DarkOrange = listViewDarkOrange.FindItemWithText("" + y + "");
                        if (DarkOrange != null)
                        {
                            listViewDarkOrange.Items.Remove(DarkOrange);
                        }
                        break;
                    case "Lime":
                        var Lime = listViewLime.FindItemWithText("" + y + "");
                        if (Lime != null)
                        {
                            listViewLime.Items.Remove(Lime);
                        }
                        break;
                    case "Maroon":
                        var Maroon = listViewMaroon.FindItemWithText("" + y + "");
                        if (Maroon != null)
                        {
                            listViewMaroon.Items.Remove(Maroon);
                        }
                        break;
                    case "Yellow":
                        var Yellow = listViewYellow.FindItemWithText("" + y + "");
                        if (Yellow != null)
                        {
                            listViewYellow.Items.Remove(Yellow);
                        }
                        break;


                }
                x.BackColor = Color.White;
            }
            else
            {
                switch (x.BackColor.Name)
                {
                    case "Red":
                        var Red = listViewRed.FindItemWithText("" + y + "");
                        if (Red != null)
                        {
                            listViewRed.Items.Remove(Red);
                        }
                        break;
                    case "Aqua":
                        var Aqua = listViewAqua.FindItemWithText("" + y + "");
                        if (Aqua != null)
                        {
                            listViewAqua.Items.Remove(Aqua);
                        }
                        break;
                    case "Navy":
                        var Navy = listViewNavy.FindItemWithText("" + y + "");
                        if (Navy != null)
                        {
                            listViewNavy.Items.Remove(Navy);
                        }
                        break;
                    case "Black":
                        var Black = listViewBlack.FindItemWithText("" + y + "");
                        if (Black != null)
                        {
                            listViewBlack.Items.Remove(Black);
                        }
                        break;
                    case "Blue":
                        var Blue = listViewBlue.FindItemWithText("" + y + "");
                        if (Blue != null)
                        {
                            listViewBlue.Items.Remove(Blue);
                        }
                        break;
                    case "Fuchsia":
                        var Fuchsia = listViewFuchsia.FindItemWithText("" + y + "");
                        if (Fuchsia != null)
                        {
                            listViewFuchsia.Items.Remove(Fuchsia);
                        }
                        break;
                    case "Green":
                        var Green = listViewGreen.FindItemWithText("" + y + "");
                        if (Green != null)
                        {
                            listViewGreen.Items.Remove(Green);
                        }
                        break;
                    case "Silver":
                        var Silver = listViewSilver.FindItemWithText("" + y + "");
                        if (Silver != null)
                        {
                            listViewSilver.Items.Remove(Silver);
                        }
                        break;
                    case "DarkOrange":
                        var DarkOrange = listViewDarkOrange.FindItemWithText("" + y + "");
                        if (DarkOrange != null)
                        {
                            listViewDarkOrange.Items.Remove(DarkOrange);
                        }
                        break;
                    case "Lime":
                        var Lime = listViewLime.FindItemWithText("" + y + "");
                        if (Lime != null)
                        {
                            listViewLime.Items.Remove(Lime);
                        }
                        break;
                    case "Maroon":
                        var Maroon = listViewMaroon.FindItemWithText("" + y + "");
                        if (Maroon != null)
                        {
                            listViewMaroon.Items.Remove(Maroon);
                        }
                        break;
                    case "Yellow":
                        var Yellow = listViewYellow.FindItemWithText("" + y + "");
                        if (Yellow != null)
                        {
                            listViewYellow.Items.Remove(Yellow);
                        }
                        break;


                }


                switch (bActiveColor.BackColor.Name)
                {
                    case "Red":
                        listViewRed.Items.Add(""+y+"");
                        break;

                    case "Aqua":
                        listViewAqua.Items.Add("" + y + "");
                        break;

                    case "Navy":
                        listViewNavy.Items.Add("" + y + "");
                        break;

                    case "Black":
                        listViewBlack.Items.Add("" + y + "");
                        break;

                    case "Blue":
                        listViewBlue.Items.Add("" + y + "");
                        break;

                    case "Fuchsia":
                        listViewFuchsia.Items.Add("" + y + "");
                        break;

                    case "Green":
                        listViewGreen.Items.Add("" + y + "");
                        break;

                    case "Silver":
                        listViewSilver.Items.Add("" + y + "");
                        break;

                    case "DarkOrange":
                        listViewDarkOrange.Items.Add("" + y + "");
                        break;

                    case "Lime":
                        listViewLime.Items.Add("" + y + "");
                        break;

                    case "Maroon":
                        listViewMaroon.Items.Add("" + y + "");
                        break;

                    case "Yellow":
                        listViewYellow.Items.Add("" + y + "");
                        break;
                }
                x.BackColor = bActiveColor.BackColor;
            }
        }

        private void wyczyśćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewAqua.Clear();
            listViewBlack.Clear();
            listViewBlue.Clear();
            listViewDarkOrange.Clear();
            listViewFuchsia.Clear();
            listViewGreen.Clear();
            listViewLime.Clear();
            listViewMaroon.Clear();
            listViewNavy.Clear();
            listViewRed.Clear();
            listViewSilver.Clear();
            listViewYellow.Clear();

            A1.BackColor = BackColor = Color.White;
            A2.BackColor = BackColor = Color.White;
            A3.BackColor = BackColor = Color.White;
            A4.BackColor = BackColor = Color.White;
            A5.BackColor = BackColor = Color.White;
            A6.BackColor = BackColor = Color.White;
            A7.BackColor = BackColor = Color.White;
            A8.BackColor = BackColor = Color.White;
            A9.BackColor = BackColor = Color.White;
            A10.BackColor = BackColor = Color.White;
            A11.BackColor = BackColor = Color.White;
            A12.BackColor = BackColor = Color.White;
            A13.BackColor = BackColor = Color.White;
            A14.BackColor = BackColor = Color.White;
            A15.BackColor = BackColor = Color.White;
            A16.BackColor = BackColor = Color.White;
            A17.BackColor = BackColor = Color.White;
            A18.BackColor = BackColor = Color.White;
            A19.BackColor = BackColor = Color.White;
            A20.BackColor = BackColor = Color.White;


            B1.BackColor = BackColor = Color.White;
            B2.BackColor = BackColor = Color.White;
            B3.BackColor = BackColor = Color.White;
            B4.BackColor = BackColor = Color.White;
            B5.BackColor = BackColor = Color.White;
            B6.BackColor = BackColor = Color.White;
            B7.BackColor = BackColor = Color.White;
            B8.BackColor = BackColor = Color.White;
            B9.BackColor = BackColor = Color.White;
            B10.BackColor = BackColor = Color.White;
            B11.BackColor = BackColor = Color.White;
            B12.BackColor = BackColor = Color.White;
            B13.BackColor = BackColor = Color.White;
            B14.BackColor = BackColor = Color.White;
            B15.BackColor = BackColor = Color.White;
            B16.BackColor = BackColor = Color.White;
            B17.BackColor = BackColor = Color.White;
            B18.BackColor = BackColor = Color.White;
            B19.BackColor = BackColor = Color.White;
            B20.BackColor = BackColor = Color.White;

            C1.BackColor = BackColor = Color.White;
            C2.BackColor = BackColor = Color.White;
            C3.BackColor = BackColor = Color.White;
            C4.BackColor = BackColor = Color.White;
            C5.BackColor = BackColor = Color.White;
            C6.BackColor = BackColor = Color.White;
            C7.BackColor = BackColor = Color.White;
            C8.BackColor = BackColor = Color.White;
            C9.BackColor = BackColor = Color.White;
            C10.BackColor = BackColor = Color.White;
            C11.BackColor = BackColor = Color.White;
            C12.BackColor = BackColor = Color.White;
            C13.BackColor = BackColor = Color.White;
            C14.BackColor = BackColor = Color.White;
            C15.BackColor = BackColor = Color.White;
            C16.BackColor = BackColor = Color.White;
            C17.BackColor = BackColor = Color.White;
            C18.BackColor = BackColor = Color.White;
            C19.BackColor = BackColor = Color.White;
            C20.BackColor = BackColor = Color.White;

            D1.BackColor = BackColor = Color.White;
            D2.BackColor = BackColor = Color.White;
            D3.BackColor = BackColor = Color.White;
            D4.BackColor = BackColor = Color.White;
            D5.BackColor = BackColor = Color.White;
            D6.BackColor = BackColor = Color.White;
            D7.BackColor = BackColor = Color.White;
            D8.BackColor = BackColor = Color.White;
            D9.BackColor = BackColor = Color.White;
            D10.BackColor = BackColor = Color.White;
            D11.BackColor = BackColor = Color.White;
            D12.BackColor = BackColor = Color.White;
            D13.BackColor = BackColor = Color.White;
            D14.BackColor = BackColor = Color.White;
            D15.BackColor = BackColor = Color.White;
            D16.BackColor = BackColor = Color.White;
            D17.BackColor = BackColor = Color.White;
            D18.BackColor = BackColor = Color.White;
            D19.BackColor = BackColor = Color.White;
            D20.BackColor = BackColor = Color.White;

            E1.BackColor = BackColor = Color.White;
            E2.BackColor = BackColor = Color.White;
            E3.BackColor = BackColor = Color.White;
            E4.BackColor = BackColor = Color.White;
            E5.BackColor = BackColor = Color.White;
            E6.BackColor = BackColor = Color.White;
            E7.BackColor = BackColor = Color.White;
            E8.BackColor = BackColor = Color.White;
            E9.BackColor = BackColor = Color.White;
            E10.BackColor = BackColor = Color.White;
            E11.BackColor = BackColor = Color.White;
            E12.BackColor = BackColor = Color.White;
            E13.BackColor = BackColor = Color.White;
            E14.BackColor = BackColor = Color.White;
            E15.BackColor = BackColor = Color.White;
            E16.BackColor = BackColor = Color.White;
            E17.BackColor = BackColor = Color.White;
            E18.BackColor = BackColor = Color.White;
            E19.BackColor = BackColor = Color.White;
            E20.BackColor = BackColor = Color.White;

            F1.BackColor = BackColor = Color.White;
            F2.BackColor = BackColor = Color.White;
            F3.BackColor = BackColor = Color.White;
            F4.BackColor = BackColor = Color.White;
            F5.BackColor = BackColor = Color.White;
            F6.BackColor = BackColor = Color.White;
            F7.BackColor = BackColor = Color.White;
            F8.BackColor = BackColor = Color.White;
            F9.BackColor = BackColor = Color.White;
            F10.BackColor = BackColor = Color.White;
            F11.BackColor = BackColor = Color.White;
            F12.BackColor = BackColor = Color.White;
            F13.BackColor = BackColor = Color.White;
            F14.BackColor = BackColor = Color.White;
            F15.BackColor = BackColor = Color.White;
            F16.BackColor = BackColor = Color.White;
            F17.BackColor = BackColor = Color.White;
            F18.BackColor = BackColor = Color.White;
            F19.BackColor = BackColor = Color.White;
            F20.BackColor = BackColor = Color.White;

            G1.BackColor = BackColor = Color.White;
            G2.BackColor = BackColor = Color.White;
            G3.BackColor = BackColor = Color.White;
            G4.BackColor = BackColor = Color.White;
            G5.BackColor = BackColor = Color.White;
            G6.BackColor = BackColor = Color.White;
            G7.BackColor = BackColor = Color.White;
            G8.BackColor = BackColor = Color.White;
            G9.BackColor = BackColor = Color.White;
            G10.BackColor = BackColor = Color.White;
            G11.BackColor = BackColor = Color.White;
            G12.BackColor = BackColor = Color.White;
            G13.BackColor = BackColor = Color.White;
            G14.BackColor = BackColor = Color.White;
            G15.BackColor = BackColor = Color.White;
            G16.BackColor = BackColor = Color.White;
            G17.BackColor = BackColor = Color.White;
            G18.BackColor = BackColor = Color.White;
            G19.BackColor = BackColor = Color.White;
            G20.BackColor = BackColor = Color.White;

            H1.BackColor = BackColor = Color.White;
            H2.BackColor = BackColor = Color.White;
            H3.BackColor = BackColor = Color.White;
            H4.BackColor = BackColor = Color.White;
            H5.BackColor = BackColor = Color.White;
            H6.BackColor = BackColor = Color.White;
            H7.BackColor = BackColor = Color.White;
            H8.BackColor = BackColor = Color.White;
            H9.BackColor = BackColor = Color.White;
            H10.BackColor = BackColor = Color.White;
            H11.BackColor = BackColor = Color.White;
            H12.BackColor = BackColor = Color.White;
            H13.BackColor = BackColor = Color.White;
            H14.BackColor = BackColor = Color.White;
            H15.BackColor = BackColor = Color.White;
            H16.BackColor = BackColor = Color.White;
            H17.BackColor = BackColor = Color.White;
            H18.BackColor = BackColor = Color.White;
            H19.BackColor = BackColor = Color.White;
            H20.BackColor = BackColor = Color.White;

            I1.BackColor = BackColor = Color.White;
            I2.BackColor = BackColor = Color.White;
            I3.BackColor = BackColor = Color.White;
            I4.BackColor = BackColor = Color.White;
            I5.BackColor = BackColor = Color.White;
            I6.BackColor = BackColor = Color.White;
            I7.BackColor = BackColor = Color.White;
            I8.BackColor = BackColor = Color.White;
            I9.BackColor = BackColor = Color.White;
            I10.BackColor = BackColor = Color.White;
            I11.BackColor = BackColor = Color.White;
            I12.BackColor = BackColor = Color.White;
            I13.BackColor = BackColor = Color.White;
            I14.BackColor = BackColor = Color.White;
            I15.BackColor = BackColor = Color.White;
            I16.BackColor = BackColor = Color.White;
            I17.BackColor = BackColor = Color.White;
            I18.BackColor = BackColor = Color.White;
            I19.BackColor = BackColor = Color.White;
            I20.BackColor = BackColor = Color.White;

            J1.BackColor = BackColor = Color.White;
            J2.BackColor = BackColor = Color.White;
            J3.BackColor = BackColor = Color.White;
            J4.BackColor = BackColor = Color.White;
            J5.BackColor = BackColor = Color.White;
            J6.BackColor = BackColor = Color.White;
            J7.BackColor = BackColor = Color.White;
            J8.BackColor = BackColor = Color.White;
            J9.BackColor = BackColor = Color.White;
            J10.BackColor = BackColor = Color.White;
            J11.BackColor = BackColor = Color.White;
            J12.BackColor = BackColor = Color.White;
            J13.BackColor = BackColor = Color.White;
            J14.BackColor = BackColor = Color.White;
            J15.BackColor = BackColor = Color.White;
            J16.BackColor = BackColor = Color.White;
            J17.BackColor = BackColor = Color.White;
            J18.BackColor = BackColor = Color.White;
            J19.BackColor = BackColor = Color.White;
            J20.BackColor = BackColor = Color.White;

            K1.BackColor = BackColor = Color.White;
            K2.BackColor = BackColor = Color.White;
            K3.BackColor = BackColor = Color.White;
            K4.BackColor = BackColor = Color.White;
            K5.BackColor = BackColor = Color.White;
            K6.BackColor = BackColor = Color.White;
            K7.BackColor = BackColor = Color.White;
            K8.BackColor = BackColor = Color.White;
            K9.BackColor = BackColor = Color.White;
            K10.BackColor = BackColor = Color.White;
            K11.BackColor = BackColor = Color.White;
            K12.BackColor = BackColor = Color.White;
            K13.BackColor = BackColor = Color.White;
            K14.BackColor = BackColor = Color.White;
            K15.BackColor = BackColor = Color.White;
            K16.BackColor = BackColor = Color.White;
            K17.BackColor = BackColor = Color.White;
            K18.BackColor = BackColor = Color.White;
            K19.BackColor = BackColor = Color.White;
            K20.BackColor = BackColor = Color.White;

            L1.BackColor = BackColor = Color.White;
            L2.BackColor = BackColor = Color.White;
            L3.BackColor = BackColor = Color.White;
            L4.BackColor = BackColor = Color.White;
            L5.BackColor = BackColor = Color.White;
            L6.BackColor = BackColor = Color.White;
            L7.BackColor = BackColor = Color.White;
            L8.BackColor = BackColor = Color.White;
            L9.BackColor = BackColor = Color.White;
            L10.BackColor = BackColor = Color.White;
            L11.BackColor = BackColor = Color.White;
            L12.BackColor = BackColor = Color.White;
            L13.BackColor = BackColor = Color.White;
            L14.BackColor = BackColor = Color.White;
            L15.BackColor = BackColor = Color.White;
            L16.BackColor = BackColor = Color.White;
            L17.BackColor = BackColor = Color.White;
            L18.BackColor = BackColor = Color.White;
            L19.BackColor = BackColor = Color.White;
            L20.BackColor = BackColor = Color.White;

            M1.BackColor = BackColor = Color.White;
            M2.BackColor = BackColor = Color.White;
            M3.BackColor = BackColor = Color.White;
            M4.BackColor = BackColor = Color.White;
            M5.BackColor = BackColor = Color.White;
            M6.BackColor = BackColor = Color.White;
            M7.BackColor = BackColor = Color.White;
            M8.BackColor = BackColor = Color.White;
            M9.BackColor = BackColor = Color.White;
            M10.BackColor = BackColor = Color.White;
            M11.BackColor = BackColor = Color.White;
            M12.BackColor = BackColor = Color.White;
            M13.BackColor = BackColor = Color.White;
            M14.BackColor = BackColor = Color.White;
            M15.BackColor = BackColor = Color.White;
            M16.BackColor = BackColor = Color.White;
            M17.BackColor = BackColor = Color.White;
            M18.BackColor = BackColor = Color.White;
            M19.BackColor = BackColor = Color.White;
            M20.BackColor = BackColor = Color.White;

            N1.BackColor = BackColor = Color.White;
            N2.BackColor = BackColor = Color.White;
            N3.BackColor = BackColor = Color.White;
            N4.BackColor = BackColor = Color.White;
            N5.BackColor = BackColor = Color.White;
            N6.BackColor = BackColor = Color.White;
            N7.BackColor = BackColor = Color.White;
            N8.BackColor = BackColor = Color.White;
            N9.BackColor = BackColor = Color.White;
            N10.BackColor = BackColor = Color.White;
            N11.BackColor = BackColor = Color.White;
            N12.BackColor = BackColor = Color.White;
            N13.BackColor = BackColor = Color.White;
            N14.BackColor = BackColor = Color.White;
            N15.BackColor = BackColor = Color.White;
            N16.BackColor = BackColor = Color.White;
            N17.BackColor = BackColor = Color.White;
            N18.BackColor = BackColor = Color.White;
            N19.BackColor = BackColor = Color.White;
            N20.BackColor = BackColor = Color.White;

            O1.BackColor = BackColor = Color.White;
            O2.BackColor = BackColor = Color.White;
            O3.BackColor = BackColor = Color.White;
            O4.BackColor = BackColor = Color.White;
            O5.BackColor = BackColor = Color.White;
            O6.BackColor = BackColor = Color.White;
            O7.BackColor = BackColor = Color.White;
            O8.BackColor = BackColor = Color.White;
            O9.BackColor = BackColor = Color.White;
            O10.BackColor = BackColor = Color.White;
            O11.BackColor = BackColor = Color.White;
            O12.BackColor = BackColor = Color.White;
            O13.BackColor = BackColor = Color.White;
            O14.BackColor = BackColor = Color.White;
            O15.BackColor = BackColor = Color.White;
            O16.BackColor = BackColor = Color.White;
            O17.BackColor = BackColor = Color.White;
            O18.BackColor = BackColor = Color.White;
            O19.BackColor = BackColor = Color.White;
            O20.BackColor = BackColor = Color.White;

            P1.BackColor = BackColor = Color.White;
            P2.BackColor = BackColor = Color.White;
            P3.BackColor = BackColor = Color.White;
            P4.BackColor = BackColor = Color.White;
            P5.BackColor = BackColor = Color.White;
            P6.BackColor = BackColor = Color.White;
            P7.BackColor = BackColor = Color.White;
            P8.BackColor = BackColor = Color.White;
            P9.BackColor = BackColor = Color.White;
            P10.BackColor = BackColor = Color.White;
            P11.BackColor = BackColor = Color.White;
            P12.BackColor = BackColor = Color.White;
            P13.BackColor = BackColor = Color.White;
            P14.BackColor = BackColor = Color.White;
            P15.BackColor = BackColor = Color.White;
            P16.BackColor = BackColor = Color.White;
            P17.BackColor = BackColor = Color.White;
            P18.BackColor = BackColor = Color.White;
            P19.BackColor = BackColor = Color.White;
            P20.BackColor = BackColor = Color.White;

            Q1.BackColor = BackColor = Color.White;
            Q2.BackColor = BackColor = Color.White;
            Q3.BackColor = BackColor = Color.White;
            Q4.BackColor = BackColor = Color.White;
            Q5.BackColor = BackColor = Color.White;
            Q6.BackColor = BackColor = Color.White;
            Q7.BackColor = BackColor = Color.White;
            Q8.BackColor = BackColor = Color.White;
            Q9.BackColor = BackColor = Color.White;
            Q10.BackColor = BackColor = Color.White;
            Q11.BackColor = BackColor = Color.White;
            Q12.BackColor = BackColor = Color.White;
            Q13.BackColor = BackColor = Color.White;
            Q14.BackColor = BackColor = Color.White;
            Q15.BackColor = BackColor = Color.White;
            Q16.BackColor = BackColor = Color.White;
            Q17.BackColor = BackColor = Color.White;
            Q18.BackColor = BackColor = Color.White;
            Q19.BackColor = BackColor = Color.White;
            Q20.BackColor = BackColor = Color.White;

            R1.BackColor = BackColor = Color.White;
            R2.BackColor = BackColor = Color.White;
            R3.BackColor = BackColor = Color.White;
            R4.BackColor = BackColor = Color.White;
            R5.BackColor = BackColor = Color.White;
            R6.BackColor = BackColor = Color.White;
            R7.BackColor = BackColor = Color.White;
            R8.BackColor = BackColor = Color.White;
            R9.BackColor = BackColor = Color.White;
            R10.BackColor = BackColor = Color.White;
            R11.BackColor = BackColor = Color.White;
            R12.BackColor = BackColor = Color.White;
            R13.BackColor = BackColor = Color.White;
            R14.BackColor = BackColor = Color.White;
            R15.BackColor = BackColor = Color.White;
            R16.BackColor = BackColor = Color.White;
            R17.BackColor = BackColor = Color.White;
            R18.BackColor = BackColor = Color.White;
            R19.BackColor = BackColor = Color.White;
            R20.BackColor = BackColor = Color.White;

            S1.BackColor = BackColor = Color.White;
            S2.BackColor = BackColor = Color.White;
            S3.BackColor = BackColor = Color.White;
            S4.BackColor = BackColor = Color.White;
            S5.BackColor = BackColor = Color.White;
            S6.BackColor = BackColor = Color.White;
            S7.BackColor = BackColor = Color.White;
            S8.BackColor = BackColor = Color.White;
            S9.BackColor = BackColor = Color.White;
            S10.BackColor = BackColor = Color.White;
            S11.BackColor = BackColor = Color.White;
            S12.BackColor = BackColor = Color.White;
            S13.BackColor = BackColor = Color.White;
            S14.BackColor = BackColor = Color.White;
            S15.BackColor = BackColor = Color.White;
            S16.BackColor = BackColor = Color.White;
            S17.BackColor = BackColor = Color.White;
            S18.BackColor = BackColor = Color.White;
            S19.BackColor = BackColor = Color.White;
            S20.BackColor = BackColor = Color.White;

            T1.BackColor = BackColor = Color.White;
            T2.BackColor = BackColor = Color.White;
            T3.BackColor = BackColor = Color.White;
            T4.BackColor = BackColor = Color.White;
            T5.BackColor = BackColor = Color.White;
            T6.BackColor = BackColor = Color.White;
            T7.BackColor = BackColor = Color.White;
            T8.BackColor = BackColor = Color.White;
            T9.BackColor = BackColor = Color.White;
            T10.BackColor = BackColor = Color.White;
            T11.BackColor = BackColor = Color.White;
            T12.BackColor = BackColor = Color.White;
            T13.BackColor = BackColor = Color.White;
            T14.BackColor = BackColor = Color.White;
            T15.BackColor = BackColor = Color.White;
            T16.BackColor = BackColor = Color.White;
            T17.BackColor = BackColor = Color.White;
            T18.BackColor = BackColor = Color.White;
            T19.BackColor = BackColor = Color.White;
            T20.BackColor = BackColor = Color.White;


        }

        private void zapiszWydrukToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void punktyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string stringViewAqua = "";
            foreach (ListViewItem item in listViewAqua.Items)
            {
                stringViewAqua += item.Text + ", ";
            }

            string stringtViewBlack = "";
            foreach (ListViewItem item in listViewBlack.Items)
            {
                stringtViewBlack += item.Text + ", ";
            }

            string stringViewBlue = "";
            foreach (ListViewItem item in listViewBlue.Items)
            {
                stringViewBlue += item.Text + ", ";
            }

            string stringViewDarkOrange = "";
            foreach (ListViewItem item in listViewDarkOrange.Items)
            {
                stringViewDarkOrange += item.Text + ", ";
            }

            string stringViewFuchsia = "";
            foreach (ListViewItem item in listViewFuchsia.Items)
            {
                stringViewFuchsia += item.Text + ", ";
            }

            string stringtViewGreen = "";
            foreach (ListViewItem item in listViewGreen.Items)
            {
                stringtViewGreen += item.Text + ", ";
            }

            string stringViewLimek = "";
            foreach (ListViewItem item in listViewLime.Items)
            {
                stringViewLimek += item.Text + ", ";
            }

            string stringViewMaroon = "";
            foreach (ListViewItem item in listViewMaroon.Items)
            {
                stringViewMaroon += item.Text + ", ";
            }

            string stringViewNavy = "";
            foreach (ListViewItem item in listViewNavy.Items)
            {
                stringViewNavy += item.Text + ", ";
            }

            string stringtViewRed = "";
            foreach (ListViewItem item in listViewRed.Items)
            {
                stringtViewRed += item.Text + ", ";
            }

            string stringViewSilver = "";
            foreach (ListViewItem item in listViewSilver.Items)
            {
                stringViewSilver += item.Text + ", ";
            }

            string stringtViewYellow = "";
            foreach (ListViewItem item in listViewYellow.Items)
            {
                stringtViewYellow += item.Text + ", ";
            }


            string filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + Guid.NewGuid() + ".html";


            string twiml = string.Format(@"
<!DOCTYPE html>
<html>
<head>
<meta charset=""utf-8"">
</head>
<header>
<title>Plansza Edukacyjna</title>
</header>
<body>

<div id=""app"" class=""container"">

<h1> Michał Dwojak - Plansza - Wytyczne </h1>
<div class=""col - 12"" style=""padding - top: 2em; "">
<table style=""width: 100 %; "" border=""1""><tbody><tr>

                                <td style=""width: 30px; height: 30px; background-color: rgb(0, 255, 255);""></td> <td style=""padding - left: 5px; "">
                                        {0}

                                 </td></tr><tr><td style = ""width: 30px; height: 30px; background-color: rgb(0, 0, 128);"" ></td><td style = ""padding-left: 5px;"">
                                       {1}

                                 </td></tr><tr><td style = ""width: 30px; height: 30px; background-color: rgb(0, 0, 0);""></td><td style = ""padding-left: 5px;"">
                                       {2}

                                 </td></tr><tr><td style = ""width: 30px; height: 30px; background-color: rgb(0, 0, 255);"" ></td><td style = ""padding-left: 5px;"">
                                          {3}          

                                 </td></tr><tr><td style = ""width: 30px; height: 30px; background-color: rgb(255, 0, 255);"" ></td><td style = ""padding-left: 5px;"">
                                           {4}                      

                                </td></tr><tr><td style = ""width: 30px; height: 30px; background-color: rgb(255, 0, 0);"" ></td><td style = ""padding-left: 5px;"">
                                         {5}

                                 </td></tr><tr><td style = ""width: 30px; height: 30px; background-color: rgb(0, 128, 0);""></td><td style = ""padding-left: 5px;"">
                                        {6}

                                 </td></tr><tr><td style = ""width: 30px; height: 30px; background-color: rgb(192, 192, 192);"" ></td><td style = ""padding-left: 5px;"">
                                        {7}

                                 </td></tr><tr><td style = ""width: 30px; height: 30px; background-color: rgb(254, 127, 0);"" ></td><td style = ""padding-left: 5px;"">
                                      {8}

                                 </td></tr><tr><td style = ""width: 30px; height: 30px; background-color: rgb(0, 255, 0);"" ></td><td style = ""padding-left: 5px;"">
                                      {9}                        

                                  </td></tr><tr><td style = ""width: 30px; height: 30px; background-color: rgb(128, 0, 0);""></td><td style = ""padding-left: 5px;"">
                                     {10}                                   

                                 </td></tr><tr><td style = ""width: 30px; height: 30px; background-color: rgb(255, 255, 0);"" ></td><td style = ""padding-left: 5px;"">
                                    {11}

                                 
                                                                 
                                                                              

                                           </td></tr></ tbody ></table></div>
                                                                                                                                                            



</div>

</body>
</html>
            ", stringViewAqua, stringtViewBlack, stringtViewGreen, stringtViewRed, stringtViewYellow, stringViewBlue, stringViewDarkOrange, stringViewFuchsia, stringViewLimek, stringViewMaroon, stringViewNavy, stringViewSilver);
            twiml.Replace("\"\"", "\"");

            File.WriteAllText(filename, twiml);



            Process.Start(filename);
        }

        private void planszaToolStripMenuItem_Click(object sender, EventArgs e)
        {
       

            string filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + Guid.NewGuid() + ".html";


            string twiml = string.Format(@"
<!DOCTYPE html>
<html>
<head>
<meta charset=""utf-8"">
</head>
<header>
<title>Plansza Edukacyjna - Karta</title>
</header>
<body>

<div id=""app"" class=""container"">
<h1> Michał Dwojak - Plansza do edukacji </h1>


    <div class=""row"">
        <div class=""col-10"">
            <table class=""no-bg"" style=""border-collapse: collapse;"" cellspacing=""0"" cellpadding=""0"">
                <tbody>
                    <tr>
                        <td></td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            A
                        </td >
                        <td style =""width: 32px; height: 25px; text-align: center;"">
                            B
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            C
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            D
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            E
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            F
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            G
                        </td >
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            H
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            I
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            J
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            K
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            L
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            M
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            N
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            O
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            P
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            Q
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            R
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            S
                        </td>
                        <td style = ""width: 32px; height: 25px; text-align: center;"">
                            T
                        </td>
                    </tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">1</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">2</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">3</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">4</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">5</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">6</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">7</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">8</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">9</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">10</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">11</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">12</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">13</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">14</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">15</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">16</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">17</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">18</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">19</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;"">20</td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>

                </tbody>
            </table>
        </div> 
    </div>



        

</div>

</body>
</html>
            ");
            twiml.Replace("\"\"", "\"");

            File.WriteAllText(filename, twiml);



            Process.Start(filename);
        }
        Bitmap bmp;
        private void planszaKolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            System.Threading.Thread.Sleep(1000);
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height-360, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X+15, this.Location.Y+60, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void planszaNaBlokKolorowyToolStripMenuItem_Click(object sender, EventArgs e)
        {


            string filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + Guid.NewGuid() + ".html";


            string twiml = string.Format(@"
<!DOCTYPE html>
<html>
<head>
<meta charset=""utf-8"">
</head>
<header>
<title>Plansza Edukacyjna - Karta</title>
</header>
<body>

<div id=""app"" class=""container"">

    <div class=""row"">
        <div class=""col-10"">
            <table class=""no-bg"" style=""border-collapse: collapse;"" cellspacing=""0"" cellpadding=""0"">
                <tbody>
                 
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>
                    <tr><td style = ""height: 32px; width: 32px; text-align: right; padding-right: 5px;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style = ""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td><td style=""cursor: pointer; width: 32px; height: 32px; border: 1px solid rgb(170, 170, 170); text-align: center;""></td></tr>

                </tbody>
            </table>
        </div> 
    </div>



        

</div>

</body>
</html>
            ");
            twiml.Replace("\"\"", "\"");

            File.WriteAllText(filename, twiml);



            Process.Start(filename);
        }
    }
}
