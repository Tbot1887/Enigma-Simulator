using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_Machine
{
    public partial class Form1 : Form
    {
        bool keyIsDown = false;
        int one, two, three;
        Enigma enigma = new Enigma();

        public Form1()
        {
            InitializeComponent();

            one = Int32.Parse(RotorOne_Center.Text);
            two = Int32.Parse(RotorTwo_Center.Text);
            three = Int32.Parse(RotorThree_Center.Text);

            SetRotors();

            string RNameOne = "";
            string RNameTwo = "";
            string RNameThree = "";

            enigma.GetRotorNames(ref RNameOne, ref RNameTwo, ref RNameThree);

            RotorOne_Name.Text = RNameOne;
            RotorTwo_Name.Text = RNameTwo;
            RotorThree_Name.Text = RNameThree;
        }

        private void SetRotors()
        {
            enigma.RandomizeRotors(ref one, ref two, ref three);
            UpdateRotorPos();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            keyIsDown = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(keyIsDown == false)
            {
                keyIsDown = true;
                enigma.MoveRotors(ref one, ref two, ref three);
                UpdateRotorPos();
                //Get Input
                char input = Convert.ToChar(e.KeyCode);

            }
            else
            {
            }
        }

        private void UpdateRotorPos()
        {
            //Set Text
            RotorOne_Upper.Text = (one + 1).ToString();
            RotorOne_Center.Text = one.ToString();
            RotorOne_Lower.Text = (one - 1).ToString();

            RotorTwo_Upper.Text = (two + 1).ToString();
            RotorTwo_Center.Text = two.ToString();
            RotorTwo_Lower.Text = (two - 1).ToString();

            RotorThree_Upper.Text = (three + 1).ToString();
            RotorThree_Center.Text = three.ToString();
            RotorThree_Lower.Text = (three - 1).ToString();

            //Set Min/Max Values Accordingly
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
    }
}
