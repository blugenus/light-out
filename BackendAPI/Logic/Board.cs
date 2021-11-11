using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Logic
{
    public class Board
    {
        private Random GenerateRandom = new Random();
        private bool RandomResult = false;
        private int NoOfTrue = 0;
        private List<List<Boolean>> BoardData = new List<List<Boolean>>();

        public Board(int Width, int Height) 
        {
            for (int coun1 = 0; coun1 < Height; coun1++)
            {
                List<Boolean> WidthList = new List<Boolean>();
                for (int coun2 = 0; coun2 < Width; coun2++)
                {
                    WidthList.Add(GenerateRandomOutCome());
                }
                BoardData.Add(WidthList);
            }
            // ensuring that there is at least 1 on box.
            if (NoOfTrue < 1) BoardData[0][0] = true;
        }


        private Boolean GenerateRandomOutCome()
        {
            // 30% change for a sector to be on
            RandomResult = GenerateRandom.Next(100) <= 30;
            if (RandomResult) NoOfTrue++;
            return RandomResult;
        }

        public List<List<Boolean>> Get()
        {
            return BoardData;
        }

    }
}
