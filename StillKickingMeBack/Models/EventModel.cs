using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StillKickingMeBack.Models
{
    public class EventModel
    {
        public int Patient_IDFK { get; set; }

        public string Description { get; set; }

        public int Event_Type_IDFK { get; set; }
    }
}