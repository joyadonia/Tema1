﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
   public class Nota
    {   
        private int _activitate;

        public int Activitate
        {
            get { return _activitate; }
            set { _activitate = value; }
        }
        private List<string> _evaluare;

        public List<string> Evaluare
        {
            get { return _evaluare; }
            set { _evaluare = value; }
        }

    }
}
