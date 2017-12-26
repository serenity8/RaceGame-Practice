﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceGame
{
    public class SportCar : Car
    {
        public event CarOperationsHandler HasFinished;

        public SportCar(double maxDistance)
        {
            MaxSpeed = 350;
            DistanceCovered = 0;
            MaxDistance = maxDistance;
        }
        public override void Go()
        {
            CurrentSpeed = MaxSpeed * rnd.NextDouble();
            DistanceCovered += CurrentSpeed * 1000 / 3600;
            if (HasFinished != null && DistanceCovered >= MaxDistance)
            {
                IsFinished = true;
                HasFinished(this, new CarArgs(DistanceCovered));
            }
        }
    }
}
