using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UpdateRequestTask {
    /// <summary>
    /// Archived
    /// </summary>
    /// <value>Archived</value>
    [DataMember(Name="archived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archived")]
    public bool? Archived { get; set; }

    /// <summary>
    /// Assignee id
    /// </summary>
    /// <value>Assignee id</value>
    [DataMember(Name="assigneeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assigneeId")]
    public string AssigneeId { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    /// <value>Description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Due date
    /// </summary>
    /// <value>Due date</value>
    [DataMember(Name="dueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Gets or Sets Form
    /// </summary>
    [DataMember(Name="form", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "form")]
    public Dictionary<string, string> Form { get; set; }

    /// <summary>
    /// List id
    /// </summary>
    /// <value>List id</value>
    [DataMember(Name="listId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "listId")]
    public string ListId { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    /// <value>Name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Status Id
    /// </summary>
    /// <value>Status Id</value>
    [DataMember(Name="statusId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusId")]
    public string StatusId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateRequestTask {\n");
      sb.Append("  Archived: ").Append(Archived).Append("\n");
      sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DueDate: ").Append(DueDate).Append("\n");
      sb.Append("  Form: ").Append(Form).Append("\n");
      sb.Append("  ListId: ").Append(ListId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  StatusId: ").Append(StatusId).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
