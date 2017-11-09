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
  public class Notification {
    /// <summary>
    /// Task assignee id
    /// </summary>
    /// <value>Task assignee id</value>
    [DataMember(Name="assigneeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assigneeId")]
    public string AssigneeId { get; set; }

    /// <summary>
    /// Task assignee name
    /// </summary>
    /// <value>Task assignee name</value>
    [DataMember(Name="assigneeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assigneeName")]
    public string AssigneeName { get; set; }

    /// <summary>
    /// Created
    /// </summary>
    /// <value>Created</value>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Id
    /// </summary>
    /// <value>Id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Task list id
    /// </summary>
    /// <value>Task list id</value>
    [DataMember(Name="listId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "listId")]
    public string ListId { get; set; }

    /// <summary>
    /// Task list name
    /// </summary>
    /// <value>Task list name</value>
    [DataMember(Name="listName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "listName")]
    public string ListName { get; set; }

    /// <summary>
    /// Task status id
    /// </summary>
    /// <value>Task status id</value>
    [DataMember(Name="statusId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusId")]
    public string StatusId { get; set; }

    /// <summary>
    /// Task status name
    /// </summary>
    /// <value>Task status name</value>
    [DataMember(Name="statusName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusName")]
    public string StatusName { get; set; }

    /// <summary>
    /// Task created
    /// </summary>
    /// <value>Task created</value>
    [DataMember(Name="taskCreated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taskCreated")]
    public DateTime? TaskCreated { get; set; }

    /// <summary>
    /// Task description
    /// </summary>
    /// <value>Task description</value>
    [DataMember(Name="taskDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taskDescription")]
    public string TaskDescription { get; set; }

    /// <summary>
    /// Task due date
    /// </summary>
    /// <value>Task due date</value>
    [DataMember(Name="taskDueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taskDueDate")]
    public DateTime? TaskDueDate { get; set; }

    /// <summary>
    /// Task high priority
    /// </summary>
    /// <value>Task high priority</value>
    [DataMember(Name="taskHighPriority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taskHighPriority")]
    public bool? TaskHighPriority { get; set; }

    /// <summary>
    /// Task id
    /// </summary>
    /// <value>Task id</value>
    [DataMember(Name="taskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taskId")]
    public string TaskId { get; set; }

    /// <summary>
    /// Task Name
    /// </summary>
    /// <value>Task Name</value>
    [DataMember(Name="taskName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taskName")]
    public string TaskName { get; set; }

    /// <summary>
    /// User id
    /// </summary>
    /// <value>User id</value>
    [DataMember(Name="userId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userId")]
    public string UserId { get; set; }

    /// <summary>
    /// User name
    /// </summary>
    /// <value>User name</value>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Notification {\n");
      sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
      sb.Append("  AssigneeName: ").Append(AssigneeName).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ListId: ").Append(ListId).Append("\n");
      sb.Append("  ListName: ").Append(ListName).Append("\n");
      sb.Append("  StatusId: ").Append(StatusId).Append("\n");
      sb.Append("  StatusName: ").Append(StatusName).Append("\n");
      sb.Append("  TaskCreated: ").Append(TaskCreated).Append("\n");
      sb.Append("  TaskDescription: ").Append(TaskDescription).Append("\n");
      sb.Append("  TaskDueDate: ").Append(TaskDueDate).Append("\n");
      sb.Append("  TaskHighPriority: ").Append(TaskHighPriority).Append("\n");
      sb.Append("  TaskId: ").Append(TaskId).Append("\n");
      sb.Append("  TaskName: ").Append(TaskName).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
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
