﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._1_Animal_World
{
    class Eagle : Animal
    {
        public Eagle()
        {
            name = "Eagle";
            family = "Carnivore";
            food = "Fish";
            image = new Bitmap("eagle.jpg");
        }
    }
}
