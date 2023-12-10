using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Planer_2._0
{
    internal class Plan
    {
       
        [JsonPropertyName("EventName")]
        public string EventName { get; set; }
        [JsonPropertyName("Date")]
        public DateTime Date { get; set; }
        [JsonPropertyName("Priority")]
        public int Priority { get; set; }
        [JsonPropertyName("Category")]
        public ECategory Category { get; set; }
        [JsonPropertyName("IsFinished")]
        public bool IsEventFinished { get; set; }
        [JsonIgnore]
        public DateTime TodayDate = DateTime.Now;
        public Plan()
        {
            EventName = string.Empty;
            Date = DateTime.Now;
            Priority = 0;
            Category = ECategory.Gry;
            IsEventFinished = false;
        }
        public Plan(string eventName, DateTime dateTime, int priority, ECategory category)
        {
            EventName = eventName;
            Date = dateTime;
            Priority = priority;
            Category = category;
            IsEventFinished = false;
        }
        public enum ECategory
        {
            Sport = 0,
            Relaks = 1,
            Praca = 2,
            Jedzenie = 3,
            Motoryzacja = 4,
            Zdrowie = 5,
            Gry = 6,
            Nauka = 7,
        }
    }
}
