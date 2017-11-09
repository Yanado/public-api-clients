/*
 * Yanado REST API
 * REST API for Yanado
 *
 * OpenAPI spec version: 1.0
 * Contact: prle@yanado.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.yanado.model;

import java.util.Objects;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.time.OffsetDateTime;

/**
 * Notification
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-11-09T11:43:43.254Z")
public class Notification {
  @SerializedName("assigneeId")
  private String assigneeId = null;

  @SerializedName("assigneeName")
  private String assigneeName = null;

  @SerializedName("created")
  private OffsetDateTime created = null;

  @SerializedName("id")
  private Long id = null;

  @SerializedName("listId")
  private String listId = null;

  @SerializedName("listName")
  private String listName = null;

  @SerializedName("statusId")
  private String statusId = null;

  @SerializedName("statusName")
  private String statusName = null;

  @SerializedName("taskCreated")
  private OffsetDateTime taskCreated = null;

  @SerializedName("taskDescription")
  private String taskDescription = null;

  @SerializedName("taskDueDate")
  private OffsetDateTime taskDueDate = null;

  @SerializedName("taskHighPriority")
  private Boolean taskHighPriority = null;

  @SerializedName("taskId")
  private String taskId = null;

  @SerializedName("taskName")
  private String taskName = null;

  @SerializedName("userId")
  private String userId = null;

  @SerializedName("userName")
  private String userName = null;

  public Notification assigneeId(String assigneeId) {
    this.assigneeId = assigneeId;
    return this;
  }

   /**
   * Task assignee id
   * @return assigneeId
  **/
  @ApiModelProperty(value = "Task assignee id")
  public String getAssigneeId() {
    return assigneeId;
  }

  public void setAssigneeId(String assigneeId) {
    this.assigneeId = assigneeId;
  }

  public Notification assigneeName(String assigneeName) {
    this.assigneeName = assigneeName;
    return this;
  }

   /**
   * Task assignee name
   * @return assigneeName
  **/
  @ApiModelProperty(value = "Task assignee name")
  public String getAssigneeName() {
    return assigneeName;
  }

  public void setAssigneeName(String assigneeName) {
    this.assigneeName = assigneeName;
  }

  public Notification created(OffsetDateTime created) {
    this.created = created;
    return this;
  }

   /**
   * Created
   * @return created
  **/
  @ApiModelProperty(value = "Created")
  public OffsetDateTime getCreated() {
    return created;
  }

  public void setCreated(OffsetDateTime created) {
    this.created = created;
  }

  public Notification id(Long id) {
    this.id = id;
    return this;
  }

   /**
   * Id
   * @return id
  **/
  @ApiModelProperty(value = "Id")
  public Long getId() {
    return id;
  }

  public void setId(Long id) {
    this.id = id;
  }

  public Notification listId(String listId) {
    this.listId = listId;
    return this;
  }

   /**
   * Task list id
   * @return listId
  **/
  @ApiModelProperty(value = "Task list id")
  public String getListId() {
    return listId;
  }

  public void setListId(String listId) {
    this.listId = listId;
  }

  public Notification listName(String listName) {
    this.listName = listName;
    return this;
  }

   /**
   * Task list name
   * @return listName
  **/
  @ApiModelProperty(value = "Task list name")
  public String getListName() {
    return listName;
  }

  public void setListName(String listName) {
    this.listName = listName;
  }

  public Notification statusId(String statusId) {
    this.statusId = statusId;
    return this;
  }

   /**
   * Task status id
   * @return statusId
  **/
  @ApiModelProperty(value = "Task status id")
  public String getStatusId() {
    return statusId;
  }

  public void setStatusId(String statusId) {
    this.statusId = statusId;
  }

  public Notification statusName(String statusName) {
    this.statusName = statusName;
    return this;
  }

   /**
   * Task status name
   * @return statusName
  **/
  @ApiModelProperty(value = "Task status name")
  public String getStatusName() {
    return statusName;
  }

  public void setStatusName(String statusName) {
    this.statusName = statusName;
  }

  public Notification taskCreated(OffsetDateTime taskCreated) {
    this.taskCreated = taskCreated;
    return this;
  }

   /**
   * Task created
   * @return taskCreated
  **/
  @ApiModelProperty(value = "Task created")
  public OffsetDateTime getTaskCreated() {
    return taskCreated;
  }

  public void setTaskCreated(OffsetDateTime taskCreated) {
    this.taskCreated = taskCreated;
  }

  public Notification taskDescription(String taskDescription) {
    this.taskDescription = taskDescription;
    return this;
  }

   /**
   * Task description
   * @return taskDescription
  **/
  @ApiModelProperty(value = "Task description")
  public String getTaskDescription() {
    return taskDescription;
  }

  public void setTaskDescription(String taskDescription) {
    this.taskDescription = taskDescription;
  }

  public Notification taskDueDate(OffsetDateTime taskDueDate) {
    this.taskDueDate = taskDueDate;
    return this;
  }

   /**
   * Task due date
   * @return taskDueDate
  **/
  @ApiModelProperty(value = "Task due date")
  public OffsetDateTime getTaskDueDate() {
    return taskDueDate;
  }

  public void setTaskDueDate(OffsetDateTime taskDueDate) {
    this.taskDueDate = taskDueDate;
  }

  public Notification taskHighPriority(Boolean taskHighPriority) {
    this.taskHighPriority = taskHighPriority;
    return this;
  }

   /**
   * Task high priority
   * @return taskHighPriority
  **/
  @ApiModelProperty(example = "false", value = "Task high priority")
  public Boolean getTaskHighPriority() {
    return taskHighPriority;
  }

  public void setTaskHighPriority(Boolean taskHighPriority) {
    this.taskHighPriority = taskHighPriority;
  }

  public Notification taskId(String taskId) {
    this.taskId = taskId;
    return this;
  }

   /**
   * Task id
   * @return taskId
  **/
  @ApiModelProperty(value = "Task id")
  public String getTaskId() {
    return taskId;
  }

  public void setTaskId(String taskId) {
    this.taskId = taskId;
  }

  public Notification taskName(String taskName) {
    this.taskName = taskName;
    return this;
  }

   /**
   * Task Name
   * @return taskName
  **/
  @ApiModelProperty(value = "Task Name")
  public String getTaskName() {
    return taskName;
  }

  public void setTaskName(String taskName) {
    this.taskName = taskName;
  }

  public Notification userId(String userId) {
    this.userId = userId;
    return this;
  }

   /**
   * User id
   * @return userId
  **/
  @ApiModelProperty(value = "User id")
  public String getUserId() {
    return userId;
  }

  public void setUserId(String userId) {
    this.userId = userId;
  }

  public Notification userName(String userName) {
    this.userName = userName;
    return this;
  }

   /**
   * User name
   * @return userName
  **/
  @ApiModelProperty(value = "User name")
  public String getUserName() {
    return userName;
  }

  public void setUserName(String userName) {
    this.userName = userName;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Notification notification = (Notification) o;
    return Objects.equals(this.assigneeId, notification.assigneeId) &&
        Objects.equals(this.assigneeName, notification.assigneeName) &&
        Objects.equals(this.created, notification.created) &&
        Objects.equals(this.id, notification.id) &&
        Objects.equals(this.listId, notification.listId) &&
        Objects.equals(this.listName, notification.listName) &&
        Objects.equals(this.statusId, notification.statusId) &&
        Objects.equals(this.statusName, notification.statusName) &&
        Objects.equals(this.taskCreated, notification.taskCreated) &&
        Objects.equals(this.taskDescription, notification.taskDescription) &&
        Objects.equals(this.taskDueDate, notification.taskDueDate) &&
        Objects.equals(this.taskHighPriority, notification.taskHighPriority) &&
        Objects.equals(this.taskId, notification.taskId) &&
        Objects.equals(this.taskName, notification.taskName) &&
        Objects.equals(this.userId, notification.userId) &&
        Objects.equals(this.userName, notification.userName);
  }

  @Override
  public int hashCode() {
    return Objects.hash(assigneeId, assigneeName, created, id, listId, listName, statusId, statusName, taskCreated, taskDescription, taskDueDate, taskHighPriority, taskId, taskName, userId, userName);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Notification {\n");
    
    sb.append("    assigneeId: ").append(toIndentedString(assigneeId)).append("\n");
    sb.append("    assigneeName: ").append(toIndentedString(assigneeName)).append("\n");
    sb.append("    created: ").append(toIndentedString(created)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    listId: ").append(toIndentedString(listId)).append("\n");
    sb.append("    listName: ").append(toIndentedString(listName)).append("\n");
    sb.append("    statusId: ").append(toIndentedString(statusId)).append("\n");
    sb.append("    statusName: ").append(toIndentedString(statusName)).append("\n");
    sb.append("    taskCreated: ").append(toIndentedString(taskCreated)).append("\n");
    sb.append("    taskDescription: ").append(toIndentedString(taskDescription)).append("\n");
    sb.append("    taskDueDate: ").append(toIndentedString(taskDueDate)).append("\n");
    sb.append("    taskHighPriority: ").append(toIndentedString(taskHighPriority)).append("\n");
    sb.append("    taskId: ").append(toIndentedString(taskId)).append("\n");
    sb.append("    taskName: ").append(toIndentedString(taskName)).append("\n");
    sb.append("    userId: ").append(toIndentedString(userId)).append("\n");
    sb.append("    userName: ").append(toIndentedString(userName)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
  
}

