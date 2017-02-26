using StillKickingMeBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace StillKickingMeBack.Controllers
{
    [RoutePrefix("api/patient")]
    public class EventController : ApiController
    {
        // GET: api/patient/example@example.com/event
        [HttpGet]
        [Route("{patientId:int}/event")]
        public IEnumerable<Event> getEvent(int patientId)
        {
            var db = new StillKickingDBDataContext();
            var events = db.Event.Where(p => p.Patient_IDFK == patientId);
            return events;
        }

        // POST: api/patient/example@example.com/event
        [HttpPost]
        [Route("{patientId:int}/event")]
        public Event Create(int patientId, EventModel events)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            var db = new StillKickingDBDataContext();
            var a = new Event();
            a.Description = events.Description;
            a.Event_Type_IDFK = events.Event_Type_IDFK;
            a.Patient_IDFK = patientId;
            db.Event.InsertOnSubmit(a);
            db.SubmitChanges();
            return a;
        }
    }
}