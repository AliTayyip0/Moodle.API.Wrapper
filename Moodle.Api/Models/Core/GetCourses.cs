using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
    public sealed class GetCourses : RequestStringGenerator, IModel
    {

            public string id { get; set; }
            public string shortname { get; set; }
            public string categoryid { get; set; }
            public string categorysortorder { get; set; }
            public string fullname { get; set; }
            public string displayname { get; set; }
            public string idnumber { get; set; }
            public string summary { get; set; }
            public string summaryformat { get; set; }
            public string format { get; set; }
            public string showgrades { get; set; }
            public string newsitems { get; set; }
            public string startdate { get; set; }
            public string enddate { get; set; }
            public string numsections { get; set; }
            public string maxbytes { get; set; }
            public string showreports { get; set; }
            public string visible { get; set; }
            public string hiddensections { get; set; }
            public string groupmode { get; set; }
            public string groupmodeforce { get; set; }
            public string defaultgroupingid { get; set; }
            public string timecreated { get; set; }
            public string timemodified { get; set; }
            public string enablecompletion { get; set; }
            public string completionnotify { get; set; }
            public string lang { get; set; }
            public string forcetheme { get; set; }
            public List<Courseformatoption> courseformatoptions { get; set; }
            public string showactivitydates { get; set; }
            public string showcompletionconditions { get; set; }
            public List<Customfield> customfields { get; set; }
        

      







        public List<KeyValuePair<string, string>> ToKeyValuePairs(string prefix = "")
        {
            var keyValuePairs = new List<KeyValuePair<string, string>>();

            keyValuePairs.AddRange(DynamicKeyValuePairsOnlyNonList(prefix));


            if(courseformatoptions!=null)
                for (var courseformatoptionsIndex = 0; courseformatoptionsIndex < courseformatoptions.Count; courseformatoptionsIndex++)
                {
                    var courseformatoptionsItem = courseformatoptions[courseformatoptionsIndex];
                    var courseformatoptionsItems = courseformatoptionsItem.ToKeyValuePairs("courseformatoptions[" + courseformatoptionsIndex + "]");
                    keyValuePairs.AddRange(courseformatoptionsItems);
                }


            if (customfields != null)
                for (var customfieldsIndex = 0; customfieldsIndex < customfields.Count; customfieldsIndex++)
                {
                    var customfieldsItem = customfields[customfieldsIndex];
                    var customfieldsItems = customfieldsItem.ToKeyValuePairs("customfields[" + customfieldsIndex + "]");
                    keyValuePairs.AddRange(customfieldsItems);
                }


            return keyValuePairs;
        }

    }
     
}