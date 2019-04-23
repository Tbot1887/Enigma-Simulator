using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    class Enigma
    {
        Rotor rotorOne;
        Rotor rotorTwo;
        Rotor rotorThree;

        public Enigma()
        {
            rotorOne = new Rotor();
            rotorTwo = new Rotor();
            rotorThree = new Rotor();
        }

        public void RandomizeRotors(ref int randomOne, ref int randomTwo, ref int randomThree)
        {
            Random random = new Random();

            randomOne = random.Next(1, 27);

            randomTwo = random.Next(1, 27);
            while(randomTwo == randomOne)
            {
                randomTwo = random.Next(1, 27);
            }

            randomThree = random.Next(1, 27);

            while (randomOne == randomThree || randomTwo == randomThree)
            {
                randomThree = random.Next(1, 27);
            }

            rotorOne.RotorPos = randomOne - 1;
            rotorTwo.RotorPos = randomTwo - 1;
            rotorThree.RotorPos = randomThree -1;
        }

        public void MoveRotors(ref int one, ref int two, ref int three)
        {
            one = rotorOne.IncrementRotor();
            if(rotorOne.IsAtMax == true){
                two = rotorTwo.IncrementRotor();
                if(rotorTwo.IsAtMax == true)
                {
                    three = rotorThree.IncrementRotor();
                }
            }
        }

        public void GetRotorNames(ref string one, ref string two, ref string three)
        {
            one = rotorOne.RotorName;
            two = rotorTwo.RotorName;
            three = rotorThree.RotorName;
        }
    }
}
