using System;
using AutoRest.CSharp.Model;
using AutoRest.Core.Model;

namespace SimpleSwaggerGenerator
{
	public class ApiModel
	{
		public CodeModelCs CodeModel { get; set; }
		public SecurityDefinition Definition { get; set; }
		public string ApiSubclass
		{
			get
			{
				if (Definition == null)
					return "";
				return "";
			}
		}
	}
}
