using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace application
{
    public class Calculadora
    {
        private List<string> listHistory;
        private string data;

        private void historyInsert(int res){
            listHistory.Insert(0, "Result: " + res + data);
        }

        public Calculadora(string data)
        {
            listHistory = new List<string>();
            this.data = data;
        }
        public int Add(int num1, int num2)
        {
            historyInsert(num1 + num2);
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            historyInsert(num1 - num2);
            return num1 - num2;
        }
        public int Multiply(int num1, int num2)
        {
            historyInsert(num1 * num2);
            return num1 * num2;
        }
        public int Divide(int num1, int num2)
        {
            historyInsert(num1 / num2);
            return num1 / num2;
        }

        public List<string> History() 
        {
            listHistory.RemoveRange(3, listHistory.Count - 3);
            return listHistory;
        }
    }
}