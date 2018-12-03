﻿using HotelReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReservation
{
    public class Common
    {
        public static List<Answer> GetAnswers()
        {
            List<Answer> list = new List<Answer>();
            list.Add(new Answer() { ID = 1, Name = "Excellent", css = "check w3" });
            list.Add(new Answer() { ID = 2, Name = "Good", css = "check w3ls" });
            list.Add(new Answer() { ID = 3, Name = "Neutral", css = "check wthree" });
            list.Add(new Answer() { ID = 4, Name = "Poor", css = "check w3_agileits" });
            return list;
        }
    }
}