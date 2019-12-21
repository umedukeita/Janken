using System.Collections;
using System.Collections.Generic;

namespace PlayerScript
{
    public class Te
    {
        private int Level = 0;
        private int Evo = 0;

        public void Levelup()
        {
            Level++;
        }

        public void LevelDown()
        {
            Level--;
        }
    }
}
