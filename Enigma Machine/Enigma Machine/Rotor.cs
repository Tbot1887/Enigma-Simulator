using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    class Rotor
    {
        static string[] name = { "I-K", "II-K", "III-K", "UKW-K", "ETW-K" };

        private int rotorPos;
        private bool isAtMax;
        private int rotorNum;
        private char[,] wiring;

        /*
         * Rotor Wiring Details Rotor 1-5
         * 2 Dim Array with first row being abcdefghijklmnopqrstuvwxyz
         * Rotor I-K - PEZUOHXSCVFMTBGLRINQJWAYDK
         * Rotor II-K - ZOUESYDKFWPCIQXHMVBLGNJRAT
         * Rotor III-K - EHRVXGAOBQUSIMZFLYNWKTPDJC
         * Rotor UKW-K - IMETCGFRAYSQBZXWLHKDVUPOJN
         * Rotor ETW-K - QWERTZUIOASDFGHJKPYXCVBNML
         */

        //Constructor
        public Rotor()
        {
            Random random = new Random();
            rotorNum = random.Next(0, 5);

            RotorName = name[RotorNum];

            SetOutput();

            rotorNum++;
        }



        //RotorNum Properties
        public int RotorNum
        {
            get
            {
                return rotorNum;
            }
            set
            {
                rotorNum = value;
            }
        }

        //RotorName Properties
        public string RotorName { get; set; }

        //RotorPos Properties
        public int RotorPos
        {
            get
            {
                return rotorPos;
            }

            set
            {
                rotorPos = value;
            }
        }

        //isAtMax Properties
        public bool IsAtMax
        {
            get
            {
                return isAtMax;
            }
        }

        //Increment the rotor
        public int IncrementRotor()
        {
            rotorPos++;
            if(rotorPos == 26)
            {
                isAtMax = true;
                rotorPos = 0;
            }
            else if(rotorPos == 1){
                isAtMax = false;
            }

            return rotorPos+1;
        }

        //Set Rotor Output
        private void SetOutput()
        {
            switch (rotorNum)
            {
                case 0:
                    //PEZUOHXSCVFMTBGLRINQJWAYDK
                    wiring = new char[,] {
                        { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' },
                        { 'P', 'E', 'Z', 'U', 'O', 'H', 'X', 'S', 'C', 'V', 'F', 'M', 'T', 'B', 'G', 'L', 'R', 'I', 'N', 'Q', 'J', 'W', 'A', 'Y', 'D', 'K' }
                    };
                    break;
                case 1:
                    //ZOUESYDKFWPCIQXHMVBLGNJRAT
                    wiring = new char[,] {
                        { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' },
                        { 'Z', 'O', 'U', 'E', 'S', 'Y', 'D', 'K', 'F', 'W', 'P', 'C', 'I', 'Q', 'X', 'H', 'M', 'V', 'B', 'L', 'G', 'N', 'J', 'R', 'A', 'T' }
                    };
                    break;
                case 2:
                    //EHRVXGAOBQUSIMZFLYNWKTPDJC
                    wiring = new char[,] {
                        { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' },
                        { 'E', 'H', 'R', 'V', 'X', 'G', 'A', 'O', 'B', 'Q', 'U', 'S', 'I', 'M', 'Z', 'F', 'L', 'Y', 'N', 'W', 'K', 'T', 'P', 'D', 'J', 'C' }
                    };
                    break;
                case 3:
                    //IMETCGFRAYSQBZXWLHKDVUPOJN
                    wiring = new char[,] {
                        { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' },
                        { 'I', 'M', 'E', 'T', 'C', 'G', 'F', 'R', 'A', 'Y', 'S', 'Q', 'B', 'Z', 'X', 'W', 'L', 'H', 'K', 'D', 'V', 'U', 'P', 'O', 'J', 'N' }
                    };
                    break;
                case 4:
                    //QWERTZUIOASDFGHJKPYXCVBNML
                    wiring = new char[,] {
                        { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' },
                        { 'Q', 'W', 'E', 'R', 'T', 'Z', 'U', 'I', 'O', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'P', 'Y', 'X', 'C', 'V', 'B', 'N', 'M', 'L' }
                    };
                    break;
            }
        }
    }
}
