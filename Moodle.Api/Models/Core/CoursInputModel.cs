using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Moodle.Api.Models.Core
{
	public sealed class CoursInputModel : RequestStringGenerator, IModel
	{
		public string fullname { get; set; } 
		public string shortname { get; set; }
		public int categoryid { get; set; }
		public string idnumber { get; set; }
		public string summary { get; set; }
		public int summaryformat { get; set; } = 1;
		public string format { get; set; } = "weeks"; //  topics
		public int showgrades { get; set; } = 1;
		public int newsitems { get; set; } = 5;
		public int startdate { get; set; }
		public int enddate { get; set; }
		public int numsections { get; set; }
		public int maxbytes { get; set; } = 0;
		public int showreports { get; set; } = 0;
		public int visible { get; set; } = 1;
		public int hiddensections { get; set; }
		public int groupmode { get; set; } = 0;
		public int groupmodeforce { get; set; } = 0;
		public int defaultgroupingid { get; set; } = 0;
		public int enablecompletion { get; set; }
		public int completionnotify { get; set; }
		public string lang { get; set; }
		public string forcetheme { get; set; }
		public List<CourseformatoptionInputModel> courseformatoptions { get; set; }
		public List<Customfield> customfields { get; set; }










		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{

			var keyValuePairs = new List<KeyValuePair<string, string>>();



			keyValuePairs.AddRange(DynamicKeyValuePairsOnlyNonList(prefix));




			if (courseformatoptions!=null)
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




/*
 
 
 General structure

  //courses to create
list of ( 
object {
fullname string   //full name
shortname string   //course short name
categoryid int   //category id
idnumber string  Optional //id number
summary string  Optional //summary
summaryformat int  Default to "1" //summary format (1 = HTML, 0 = MOODLE, 2 = PLAIN or 4 = MARKDOWN)
format string  Default to "topics" //course format: weeks, topics, social, site,..
showgrades int  Default to "1" //1 if grades are shown, otherwise 0
newsitems int  Default to "5" //number of recent items appearing on the course page
startdate int  Optional //timestamp when the course start
enddate int  Optional //timestamp when the course end
numsections int  Optional //(deprecated, use courseformatoptions) number of weeks/topics
maxbytes int  Default to "0" //largest size of file that can be uploaded into the course
showreports int  Default to "0" //are activity report shown (yes = 1, no =0)
visible int  Optional //1: available to student, 0:not available
hiddensections int  Optional //(deprecated, use courseformatoptions) How the hidden sections in the course are displayed to students
groupmode int  Default to "0" //no group, separate, visible
groupmodeforce int  Default to "0" //1: yes, 0: no
defaultgroupingid int  Default to "0" //default grouping id
enablecompletion int  Optional //Enabled, control via completion and activity settings. Disabled,
                                        not shown in activity settings.
completionnotify int  Optional //1: yes 0: no
lang string  Optional //forced course language
forcetheme string  Optional //name of the force theme
courseformatoptions  Optional //additional options for particular course format
list of ( 
object {
name string   //course format option name
value string   //course format option value
} 
)customfields  Optional //custom fields for the course
list of ( 
object {
shortname string   //The shortname of the custom field
value string   //The value of the custom field
} 
)} 
)
 
 
 */