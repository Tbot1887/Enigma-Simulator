using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSim_CS
{
    class Enigma
    {
        public Rotor rotor1;
        public Rotor rotor2;
        public Rotor rotor3;
        EndRotor end = new EndRotor();

        public void RandomRotors()
        {
            Random random = new Random();

            int randomInt1 = random.Next(5);
            int randomInt2 = random.Next(5);
            while(randomInt2 == randomInt1)
            {
                randomInt2 = random.Next(5);
            }
            int randomInt3 = random.Next(5);
            while(randomInt3 == randomInt2 || randomInt3 == randomInt1)
            {
                randomInt3 = random.Next(5);
            }
            SetRotors(randomInt1, randomInt2, randomInt3);
        }

        private void SetRotors(int first, int second, int third)
        {
            if (first != second && first != third && second != third)
            {
                rotor1 = new Rotor(first, 1);
                rotor2 = new Rotor(second, 2);
                rotor3 = new Rotor(third, 3);
            }
        }

        public void RandomPositions()
        {
            Random random = new Random();

            SetRotorPositions(random.Next(26), random.Next(26), random.Next(26));
        }

        private void SetRotorPositions(int first, int second, int third)
        {
            rotor1.RotorPos = first;
            rotor2.RotorPos = second;
            rotor3.RotorPos = third;
        }

        public char RunMachine(int input)
        {
            char output;
            if (rotor1.RotorNum == rotor2.RotorNum || rotor3.RotorNum == rotor2.RotorNum || rotor1.RotorNum == rotor3.RotorNum)
            {
                output = '1';
                MessageBox.Show("Error! Rotors cannot have the same number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                input = rotor1.RunThrough(input, true);
                input = rotor2.RunThrough(input, true);
                input = rotor3.RunThrough(input, true);
                input = end.RunThrough(input, true);
                input = rotor3.RunThrough(input, false);
                input = rotor2.RunThrough(input, false);
                input = rotor1.RunThrough(input, false);

                output = GetChar(input);
            }

            IncrementRotors();

            return output;
        }

        private char GetChar(int input)
        {
            return Convert.ToChar(input + 65);
        }

        private void IncrementRotors()
        {
            rotor1.RotorPos += 1;
            if (rotor1.RotorPos == 26)
            {
                rotor1.RotorPos = 0;
                rotor2.RotorPos += 1;
                if (rotor2.RotorPos == 26)
                {
                    rotor2.RotorPos = 0;
                    rotor3.RotorPos += 1;
                    if (rotor3.RotorPos == 26)
                    {
                        rotor3.RotorPos = 0;
                    }
                }
            }
        }

        public void GetRotorNames(ref string one, ref string two, ref string three)
        {
            one = rotor1.RotorName;
            two = rotor2.RotorName;
            three = rotor3.RotorName;
        }

        public void GetRotorPos(ref int one, ref int two, ref int three)
        {
            one = rotor1.RotorPos+1;
            two = rotor2.RotorPos+1;
            three = rotor3.RotorPos+1;
        }
    }
}
