using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CoursesModel : RequestStringGenerator, IModel 
	{

		public int categoryid {get;set;}
		public int categorysortorder {get;set;}
		public int completionnotify {get;set;}
		public List<Courseformatoption> courseformatoptions {get;set;}
		public int defaultgroupingid {get;set;}
		public string displayname {get;set;}
		public int enablecompletion {get;set;}
		public int enddate {get;set;}
		public string forcetheme {get;set;}
		public string format {get;set;}
		public string fullname {get;set;}
		public int groupmode {get;set;}
		public int groupmodeforce {get;set;}
		public int hiddensections {get;set;}
		public int id {get;set;}
		public string idnumber {get;set;}
		public string lang {get;set;}
		public int maxbytes {get;set;}
		public int newsitems {get;set;}
		public int numsections {get;set;}
		public string shortname {get;set;}
		public int showgrades {get;set;}
		public int showreports {get;set;}
		public int startdate {get;set;}
		public string summary {get;set;}
		public int summaryformat {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public int visible {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			keyValuePairs.AddRange(DynamicKeyValuePairsOnlyNonList(prefix));



			for (var courseformatoptionsIndex = 0; courseformatoptionsIndex<courseformatoptions.Count;courseformatoptionsIndex++) 
			{
				var courseformatoptionsItem = courseformatoptions[courseformatoptionsIndex];
				var courseformatoptionsItems = courseformatoptionsItem.ToKeyValuePairs("courseformatoptions[" + courseformatoptionsIndex + "]");
				keyValuePairs.AddRange(courseformatoptionsItems);
			}
			 
			return keyValuePairs;
		}

	}
}