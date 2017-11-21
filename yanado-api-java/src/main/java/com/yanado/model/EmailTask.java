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
 * EmailTask
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-11-21T10:08:54.066Z")
public class EmailTask {
  @SerializedName("assigneeId")
  private String assigneeId = null;

  @SerializedName("assigneeName")
  private String assigneeName = null;

  @SerializedName("id")
  private Integer id = null;

  @SerializedName("listId")
  private String listId = null;

  @SerializedName("listName")
  private String listName = null;

  @SerializedName("participantEmail")
  private String participantEmail = null;

  @SerializedName("participantName")
  private String participantName = null;

  @SerializedName("statusId")
  private String statusId = null;

  @SerializedName("statusName")
  private String statusName = null;

  @SerializedName("subject")
  private String subject = null;

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

  @SerializedName("threadId")
  private String threadId = null;

  public EmailTask assigneeId(String assigneeId) {
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

  public EmailTask assigneeName(String assigneeName) {
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

  public EmailTask id(Integer id) {
    this.id = id;
    return this;
  }

   /**
   * Id
   * @return id
  **/
  @ApiModelProperty(value = "Id")
  public Integer getId() {
    return id;
  }

  public void setId(Integer id) {
    this.id = id;
  }

  public EmailTask listId(String listId) {
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

  public EmailTask listName(String listName) {
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

  public EmailTask participantEmail(String participantEmail) {
    this.participantEmail = participantEmail;
    return this;
  }

   /**
   * Participant email
   * @return participantEmail
  **/
  @ApiModelProperty(value = "Participant email")
  public String getParticipantEmail() {
    return participantEmail;
  }

  public void setParticipantEmail(String participantEmail) {
    this.participantEmail = participantEmail;
  }

  public EmailTask participantName(String participantName) {
    this.participantName = participantName;
    return this;
  }

   /**
   * Participant name
   * @return participantName
  **/
  @ApiModelProperty(value = "Participant name")
  public String getParticipantName() {
    return participantName;
  }

  public void setParticipantName(String participantName) {
    this.participantName = participantName;
  }

  public EmailTask statusId(String statusId) {
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

  public EmailTask statusName(String statusName) {
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

  public EmailTask subject(String subject) {
    this.subject = subject;
    return this;
  }

   /**
   * Subject
   * @return subject
  **/
  @ApiModelProperty(value = "Subject")
  public String getSubject() {
    return subject;
  }

  public void setSubject(String subject) {
    this.subject = subject;
  }

  public EmailTask taskCreated(OffsetDateTime taskCreated) {
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

  public EmailTask taskDescription(String taskDescription) {
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

  public EmailTask taskDueDate(OffsetDateTime taskDueDate) {
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

  public EmailTask taskHighPriority(Boolean taskHighPriority) {
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

  public EmailTask taskId(String taskId) {
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

  public EmailTask taskName(String taskName) {
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

  public EmailTask threadId(String threadId) {
    this.threadId = threadId;
    return this;
  }

   /**
   * Thread id
   * @return threadId
  **/
  @ApiModelProperty(value = "Thread id")
  public String getThreadId() {
    return threadId;
  }

  public void setThreadId(String threadId) {
    this.threadId = threadId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EmailTask emailTask = (EmailTask) o;
    return Objects.equals(this.assigneeId, emailTask.assigneeId) &&
        Objects.equals(this.assigneeName, emailTask.assigneeName) &&
        Objects.equals(this.id, emailTask.id) &&
        Objects.equals(this.listId, emailTask.listId) &&
        Objects.equals(this.listName, emailTask.listName) &&
        Objects.equals(this.participantEmail, emailTask.participantEmail) &&
        Objects.equals(this.participantName, emailTask.participantName) &&
        Objects.equals(this.statusId, emailTask.statusId) &&
        Objects.equals(this.statusName, emailTask.statusName) &&
        Objects.equals(this.subject, emailTask.subject) &&
        Objects.equals(this.taskCreated, emailTask.taskCreated) &&
        Objects.equals(this.taskDescription, emailTask.taskDescription) &&
        Objects.equals(this.taskDueDate, emailTask.taskDueDate) &&
        Objects.equals(this.taskHighPriority, emailTask.taskHighPriority) &&
        Objects.equals(this.taskId, emailTask.taskId) &&
        Objects.equals(this.taskName, emailTask.taskName) &&
        Objects.equals(this.threadId, emailTask.threadId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(assigneeId, assigneeName, id, listId, listName, participantEmail, participantName, statusId, statusName, subject, taskCreated, taskDescription, taskDueDate, taskHighPriority, taskId, taskName, threadId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EmailTask {\n");
    
    sb.append("    assigneeId: ").append(toIndentedString(assigneeId)).append("\n");
    sb.append("    assigneeName: ").append(toIndentedString(assigneeName)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    listId: ").append(toIndentedString(listId)).append("\n");
    sb.append("    listName: ").append(toIndentedString(listName)).append("\n");
    sb.append("    participantEmail: ").append(toIndentedString(participantEmail)).append("\n");
    sb.append("    participantName: ").append(toIndentedString(participantName)).append("\n");
    sb.append("    statusId: ").append(toIndentedString(statusId)).append("\n");
    sb.append("    statusName: ").append(toIndentedString(statusName)).append("\n");
    sb.append("    subject: ").append(toIndentedString(subject)).append("\n");
    sb.append("    taskCreated: ").append(toIndentedString(taskCreated)).append("\n");
    sb.append("    taskDescription: ").append(toIndentedString(taskDescription)).append("\n");
    sb.append("    taskDueDate: ").append(toIndentedString(taskDueDate)).append("\n");
    sb.append("    taskHighPriority: ").append(toIndentedString(taskHighPriority)).append("\n");
    sb.append("    taskId: ").append(toIndentedString(taskId)).append("\n");
    sb.append("    taskName: ").append(toIndentedString(taskName)).append("\n");
    sb.append("    threadId: ").append(toIndentedString(threadId)).append("\n");
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

