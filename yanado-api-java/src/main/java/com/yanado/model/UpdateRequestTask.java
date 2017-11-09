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
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * UpdateRequestTask
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-11-09T11:43:43.254Z")
public class UpdateRequestTask {
  @SerializedName("archived")
  private Boolean archived = null;

  @SerializedName("assigneeId")
  private String assigneeId = null;

  @SerializedName("description")
  private String description = null;

  @SerializedName("dueDate")
  private OffsetDateTime dueDate = null;

  @SerializedName("form")
  private Map<String, String> form = null;

  @SerializedName("listId")
  private String listId = null;

  @SerializedName("name")
  private String name = null;

  @SerializedName("statusId")
  private String statusId = null;

  public UpdateRequestTask archived(Boolean archived) {
    this.archived = archived;
    return this;
  }

   /**
   * Archived
   * @return archived
  **/
  @ApiModelProperty(example = "false", value = "Archived")
  public Boolean getArchived() {
    return archived;
  }

  public void setArchived(Boolean archived) {
    this.archived = archived;
  }

  public UpdateRequestTask assigneeId(String assigneeId) {
    this.assigneeId = assigneeId;
    return this;
  }

   /**
   * Assignee id
   * @return assigneeId
  **/
  @ApiModelProperty(value = "Assignee id")
  public String getAssigneeId() {
    return assigneeId;
  }

  public void setAssigneeId(String assigneeId) {
    this.assigneeId = assigneeId;
  }

  public UpdateRequestTask description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Description
   * @return description
  **/
  @ApiModelProperty(value = "Description")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public UpdateRequestTask dueDate(OffsetDateTime dueDate) {
    this.dueDate = dueDate;
    return this;
  }

   /**
   * Due date
   * @return dueDate
  **/
  @ApiModelProperty(value = "Due date")
  public OffsetDateTime getDueDate() {
    return dueDate;
  }

  public void setDueDate(OffsetDateTime dueDate) {
    this.dueDate = dueDate;
  }

  public UpdateRequestTask form(Map<String, String> form) {
    this.form = form;
    return this;
  }

  public UpdateRequestTask putFormItem(String key, String formItem) {
    if (this.form == null) {
      this.form = new HashMap<String, String>();
    }
    this.form.put(key, formItem);
    return this;
  }

   /**
   * Get form
   * @return form
  **/
  @ApiModelProperty(value = "")
  public Map<String, String> getForm() {
    return form;
  }

  public void setForm(Map<String, String> form) {
    this.form = form;
  }

  public UpdateRequestTask listId(String listId) {
    this.listId = listId;
    return this;
  }

   /**
   * List id
   * @return listId
  **/
  @ApiModelProperty(value = "List id")
  public String getListId() {
    return listId;
  }

  public void setListId(String listId) {
    this.listId = listId;
  }

  public UpdateRequestTask name(String name) {
    this.name = name;
    return this;
  }

   /**
   * Name
   * @return name
  **/
  @ApiModelProperty(value = "Name")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public UpdateRequestTask statusId(String statusId) {
    this.statusId = statusId;
    return this;
  }

   /**
   * Status Id
   * @return statusId
  **/
  @ApiModelProperty(value = "Status Id")
  public String getStatusId() {
    return statusId;
  }

  public void setStatusId(String statusId) {
    this.statusId = statusId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UpdateRequestTask updateRequestTask = (UpdateRequestTask) o;
    return Objects.equals(this.archived, updateRequestTask.archived) &&
        Objects.equals(this.assigneeId, updateRequestTask.assigneeId) &&
        Objects.equals(this.description, updateRequestTask.description) &&
        Objects.equals(this.dueDate, updateRequestTask.dueDate) &&
        Objects.equals(this.form, updateRequestTask.form) &&
        Objects.equals(this.listId, updateRequestTask.listId) &&
        Objects.equals(this.name, updateRequestTask.name) &&
        Objects.equals(this.statusId, updateRequestTask.statusId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(archived, assigneeId, description, dueDate, form, listId, name, statusId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UpdateRequestTask {\n");
    
    sb.append("    archived: ").append(toIndentedString(archived)).append("\n");
    sb.append("    assigneeId: ").append(toIndentedString(assigneeId)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    dueDate: ").append(toIndentedString(dueDate)).append("\n");
    sb.append("    form: ").append(toIndentedString(form)).append("\n");
    sb.append("    listId: ").append(toIndentedString(listId)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    statusId: ").append(toIndentedString(statusId)).append("\n");
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
