﻿using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace Turnierverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            controller.run();
        }
    }
}