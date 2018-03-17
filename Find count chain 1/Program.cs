using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Find_count_chain_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var _pathInput = @"INPUT.TXT";
            var _pathOutput = @"OUTPUT.TXT";

            var _sr = new StreamReader(_pathInput);
            var _sw = new StreamWriter(_pathOutput, false, System.Text.Encoding.Default);

            var _count = 0;
            var _symbolOne = '1';

            var _row = _sr.ReadToEnd();
            _sr.Close();

            if (_row.Length < 100)
            {
                var temp = 0;
                foreach (var symbol in _row)
                {
                    if (symbol == _symbolOne)
                    {
                        temp++;
                        if (_count < temp) _count = temp;
                    }
                    else temp = 0;
                }
                _sw.WriteLine("Max count chain of 1 = " + _count.ToString());
            }
            else _sw.WriteLine("Count of sybols in line > 100");
            _sw.Close();

        }
    }
}
