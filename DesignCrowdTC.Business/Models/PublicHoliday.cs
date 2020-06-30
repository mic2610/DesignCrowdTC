﻿using System;

namespace DesignCrowdTC.Business.Models
{
    public class PublicHoliday
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public PublicHolidayRule? Rule { get; set; }

        public CertainOccurence Occurence { get; set; }
    }
}