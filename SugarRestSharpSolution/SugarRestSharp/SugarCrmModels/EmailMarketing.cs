// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

namespace SugarRestSharp.Models
{
	using System;
	using Newtonsoft.Json;
	

    /// <summary>
    /// A class which represents the email_marketing table.
    /// </summary>
	[ModuleProperty(ModuleName = "EmailMarketing", TableName="email_marketing")]
	public partial class EmailMarketing : EntityBase
	{
		[JsonProperty(PropertyName = "id")]
		public virtual string Id { get; set; }

		[JsonProperty(PropertyName = "deleted")]
		public virtual sbyte? Deleted { get; set; }

		[JsonProperty(PropertyName = "date_entered")]
		public virtual DateTime? DateEntered { get; set; }

		[JsonProperty(PropertyName = "date_modified")]
		public virtual DateTime? DateModified { get; set; }

		[JsonProperty(PropertyName = "modified_user_id")]
		public virtual string ModifiedUserId { get; set; }

		[JsonProperty(PropertyName = "created_by")]
		public virtual string CreatedBy { get; set; }

		[JsonProperty(PropertyName = "name")]
		public virtual string Name { get; set; }

		[JsonProperty(PropertyName = "from_name")]
		public virtual string FromName { get; set; }

		[JsonProperty(PropertyName = "from_addr")]
		public virtual string FromAddr { get; set; }

		[JsonProperty(PropertyName = "reply_to_name")]
		public virtual string ReplyToName { get; set; }

		[JsonProperty(PropertyName = "reply_to_addr")]
		public virtual string ReplyToAddr { get; set; }

		[JsonProperty(PropertyName = "inbound_email_id")]
		public virtual string InboundEmailId { get; set; }

		[JsonProperty(PropertyName = "date_start")]
		public virtual DateTime? DateStart { get; set; }

		[JsonProperty(PropertyName = "template_id")]
		public virtual string TemplateId { get; set; }

		[JsonProperty(PropertyName = "status")]
		public virtual string Status { get; set; }

		[JsonProperty(PropertyName = "campaign_id")]
		public virtual string CampaignId { get; set; }

		[JsonProperty(PropertyName = "all_prospect_lists")]
		public virtual sbyte? AllProspectLists { get; set; }

	}
}