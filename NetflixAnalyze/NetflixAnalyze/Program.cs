﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixAnalyze
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> data = new List<Movie>();
            readfile.readMovieFiles();
            Console.ReadKey();
        }
    }
}
