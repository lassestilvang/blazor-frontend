
using System;

namespace EventManager.Client.Models
{
    public class EventItem
    {
        public string Title { get; set; } = "New Event";
        public DateTime Date { get; set; } = DateTime.Today;
        public string Location { get; set; } = "TBD";
        public string Description { get; set; } = "Event description goes here.";
    }
}
