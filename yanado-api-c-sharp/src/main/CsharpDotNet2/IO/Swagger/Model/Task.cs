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
  public class Task {
    /// <summary>
    /// Assignee id
    /// </summary>
    /// <value>Assignee id</value>
    [DataMember(Name="assigneeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assigneeId")]
    public string AssigneeId { get; set; }

    /// <summary>
    /// Assignee name
    /// </summary>
    /// <value>Assignee name</value>
    [DataMember(Name="assigneeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assigneeName")]
    public string AssigneeName { get; set; }

    /// <summary>
    /// Created
    /// </summary>
    /// <value>Created</value>
    [DataMember(Name="createTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createTime")]
    public DateTime? CreateTime { get; set; }

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
    /// Hight priority
    /// </summary>
    /// <value>Hight priority</value>
    [DataMember(Name="highPriority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highPriority")]
    public bool? HighPriority { get; set; }

    /// <summary>
    /// List id
    /// </summary>
    /// <value>List id</value>
    [DataMember(Name="listId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "listId")]
    public string ListId { get; set; }

    /// <summary>
    /// List name
    /// </summary>
    /// <value>List name</value>
    [DataMember(Name="listName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "listName")]
    public string ListName { get; set; }

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
    /// Status name
    /// </summary>
    /// <value>Status name</value>
    [DataMember(Name="statusName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusName")]
    public string StatusName { get; set; }

    /// <summary>
    /// Id
    /// </summary>
    /// <value>Id</value>
    [DataMember(Name="taskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taskId")]
    public string TaskId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Task {\n");
      sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
      sb.Append("  AssigneeName: ").Append(AssigneeName).Append("\n");
      sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DueDate: ").Append(DueDate).Append("\n");
      sb.Append("  HighPriority: ").Append(HighPriority).Append("\n");
      sb.Append("  ListId: ").Append(ListId).Append("\n");
      sb.Append("  ListName: ").Append(ListName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  StatusId: ").Append(StatusId).Append("\n");
      sb.Append("  StatusName: ").Append(StatusName).Append("\n");
      sb.Append("  TaskId: ").Append(TaskId).Append("\n");
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
