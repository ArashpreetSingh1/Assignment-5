﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__5
{
    class Program
    {
        static void Main(string[] args)
        {
            { new GenerateList().Run(57); }
        }

        class GenerateList
        {
            const int LEN = 100;
            ArrayList ListQ;
            public void Run(int AddUpToNumber)
            {
                Random r = new Random();

                ListQ = new ArrayList();
                for (int i = 0; i < LEN; i++) { ListQ.Add(r.Next(100)); }
                this.findTwoNumbersThatAddUpTo(AddUpToNumber);
            }
        }

            public void findTwoNumbersThatAddUpTo(int addUptoNumber)
            {

            }

        }
    }
}
    