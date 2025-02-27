﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */
    public class Car : Vehicle
    {
        
        public bool HasTrunk { get; set; }


        public override void DriveAbstract()
        {
            Console.WriteLine("Cars driving by...");
        }

        public virtual void DriveVirtual()
        {
            throw new NotImplementedException();
        }

    }
}
