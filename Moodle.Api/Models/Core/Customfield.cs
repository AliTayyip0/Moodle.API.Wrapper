using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Customfield : RequestStringGenerator, IModel 
	{

		public string name {get;set;}
		public string shortname {get;set;}
		public string type {get;set;}
		public string value {get;set;}
		public string valueraw { get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.AddRange(DynamicKeyValuePairsOnlyNonList(prefix));

			return keyValuePairs;
		}

	}
}