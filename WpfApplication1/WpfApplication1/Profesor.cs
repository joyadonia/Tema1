﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Profesor
    {  

        
        private string _prenume;

        public string Prenume
        {
            get { return _prenume; }
            set { _prenume = value; }
        }
        private string _nume;

        public string Nume
        {
            get { return _nume; }
            set { _nume = value; }
        }
        private int _procent;

        public int Procent
        {
            get { return _procent; }
            set { _procent = value; }
        }

        
    }
}
