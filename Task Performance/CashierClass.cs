﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Performance
{
    class CashierClass
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;
    
        public CashierClass(){
            x = 10000;
            CashierQueue = new Queue<string>();
        }
        public string CashierGenerateNumber(string CashierNumber){
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
    }
}
