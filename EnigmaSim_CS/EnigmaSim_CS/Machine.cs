using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSim_CS
{
    public partial class Machine : Form
    {
        Enigma enigma;

        bool isKeyDown = false;
        char keyPressed;

        public Machine()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            enigma = new Enigma();
            enigma.RandomRotors();
            enigma.RandomPositions();
            GetRotorNames();
            GetRotorPos();
        }

        private void GetRotorNames()
        {
            string name1 = "", name2 = "", name3 = "";
            enigma.GetRotorNames(ref name1, ref name2, ref name3);
            RotorOne_Name.Text = name1;
            RotorTwo_Name.Text = name2;
            RotorThree_Name.Text = name3;
        }

        private void GetRotorPos()
        {
            int one = 0, two = 0, three = 0;

            enigma.GetRotorPos(ref one, ref two, ref three);

            RotorOne_Center.Text = one.ToString();
            RotorTwo_Center.Text = two.ToString();
            RotorThree_Center.Text = three.ToString();
            UpdateRotorPos();
        }

        //Key Change Function - Called When user chooses a key to press
        private void KeyChange(char Key, string Code)
        {
            if(Code == "Down")
            {
                //Turn On Light
                switch (Key)
                {
                    case 'A':
                        A_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'B':
                        B_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'C':
                        C_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'D':
                        D_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'E':
                        E_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'F':
                        F_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'G':
                        G_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'H':
                        H_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'I':
                        I_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'J':
                        J_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'K':
                        K_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'L':
                        L_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'M':
                        M_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'N':
                        N_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'O':
                        O_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'P':
                        P_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'Q':
                        Q_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'R':
                        R_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'S':
                        S_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'T':
                        T_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'U':
                        U_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'V':
                        V_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'W':
                        W_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'X':
                        X_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'Y':
                        Y_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    case 'Z':
                        Z_Key.Image = EnigmaSim_CS.Properties.Resources.Key_Lit;
                        break;
                    default:
                        break;
                }
            }
            else{
                //Turn Off Light
                switch (Key)
                {
                    case 'A':
                        A_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'B':
                        B_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'C':
                        C_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'D':
                        D_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'E':
                        E_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'F':
                        F_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'G':
                        G_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'H':
                        H_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'I':
                        I_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'J':
                        J_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'K':
                        K_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'L':
                        L_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'M':
                        M_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'N':
                        N_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'O':
                        O_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'P':
                        P_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'Q':
                        Q_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'R':
                        R_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'S':
                        S_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'T':
                        T_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'U':
                        U_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'V':
                        V_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'W':
                        W_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'X':
                        X_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'Y':
                        Y_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    case 'Z':
                        Z_Key.Image = EnigmaSim_CS.Properties.Resources.Key;
                        break;
                    default:
                        break;
                }
            }
        }

        private void UpdateRotorPos()
        {
            int one = 0, two = 0, three = 0;

            enigma.GetRotorPos(ref one, ref two, ref three);

            RotorOne_Upper.Text = (one + 1).ToString();
            RotorOne_Center.Text = one.ToString();
            RotorOne_Lower.Text = (one - 1).ToString();

            RotorTwo_Upper.Text = (two + 1).ToString();
            RotorTwo_Center.Text = two.ToString();
            RotorTwo_Lower.Text = (two - 1).ToString();

            RotorThree_Upper.Text = (three + 1).ToString();
            RotorThree_Center.Text = three.ToString();
            RotorThree_Lower.Text = (three - 1).ToString();

            if(RotorOne_Center.Text == "26")
            {
                RotorOne_Upper.Text = "1";
            }
            else if(RotorOne_Center.Text == "1")
            {
                RotorOne_Lower.Text = "26";
            }

            if (RotorTwo_Center.Text == "26")
            {
                RotorTwo_Upper.Text = "1";
            }
            else if (RotorTwo_Center.Text == "1")
            {
                RotorTwo_Lower.Text = "26";
            }
            if (RotorThree_Center.Text == "26")
            {
                RotorThree_Upper.Text = "1";
            }
            else if (RotorThree_Center.Text == "1")
            {
                RotorThree_Lower.Text = "26";
            }
        }

        //Check if valid Alphabetic Char
        private bool ValidateChar(int AsciiCode) 
        {
            bool isValid = false;
            if (AsciiCode <= 26 && AsciiCode >= 0)
            {
                isValid = true;
            }
            else
            {
                //No
            }

            return isValid;
        }

        //Key Events
        private void Machine_KeyDown(object sender, KeyEventArgs e)
        {
            //Turn on Light if not pressed already
            if(isKeyDown != true)
            {
                isKeyDown = true;

                //Get Key ASCII Value
                int input = (e.KeyValue - 65);

                if(ValidateChar(input) == true)
                {
                    //Valid Alpabet Key
                    char output = enigma.RunMachine(input);
                    UpdateRotorPos();
                    keyPressed = output;
                    KeyChange(output, "Down");
                }
            }
            else
            {
            }
        }

        private void Machine_KeyUp(object sender, KeyEventArgs e)
        {
            //Turn off Light
            isKeyDown = false;
            KeyChange(keyPressed, "UP");
        }

        //Show Plugs when user clicks botom of window
        private void Panel_Bottom_Click(object sender, EventArgs e)
        {

        }

        private void RotorOne_Center_Click(object sender, EventArgs e)
        {
            enigma.rotor1.RotorPos++;
            UpdateRotorPos();
        }

        private void RotorTwo_Center_Click(object sender, EventArgs e)
        {
            enigma.rotor2.RotorPos++;
            UpdateRotorPos();
        }

        private void RotorThree_Center_Click(object sender, EventArgs e)
        {
            enigma.rotor3.RotorPos++;
            UpdateRotorPos();
        }

        private void RotorOne_Name_Click(object sender, EventArgs e)
        {
            enigma.rotor1.NextRotor();
            GetRotorNames();
        }

        private void RotorTwo_Name_Click(object sender, EventArgs e)
        {
            enigma.rotor2.NextRotor();
            GetRotorNames();
        }

        private void RotorThree_Name_Click(object sender, EventArgs e)
        {
            enigma.rotor3.NextRotor();
            GetRotorNames();
        }
    }
}
