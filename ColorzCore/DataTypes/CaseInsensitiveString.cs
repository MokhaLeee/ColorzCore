﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorzCore.DataTypes
{
    class CaseInsensitiveString
    {
        private string data;
        public string String {
            get { return data; }
            set
            {
                data = value.ToUpper();
            }
        }
        public CaseInsensitiveString(string input)
        {
            String = input;
        }
        public override int GetHashCode()
        {
            return String.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return String == obj.ToString();
        }
        public override string ToString()
        {
            return String;
        }
    }
}
