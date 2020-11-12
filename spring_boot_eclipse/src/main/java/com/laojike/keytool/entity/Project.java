package com.laojike.keytool.entity;

import java.util.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonFormat;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "project")
public class Project {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id", unique = true, nullable = false)
	private int id;

	private String project_name;
	private Integer fk_employee_id;
	@JsonFormat(pattern = "yyyy-MM-dd",timezone = "GMT+8")
	private Date sign_date;
	@JsonFormat(pattern = "yyyy-MM-dd",timezone = "GMT+8")
	private Date finish_date;
	private int step_index;
	private String unique_code;
	private String project_desc;
	@JsonFormat(pattern = "yyyy-MM-dd",timezone = "GMT+8")
	private Date reg_date;
	@JsonFormat(pattern = "yyyy-MM-dd",timezone = "GMT+8")
	private Date licence_date;
	private Integer licence_day;
	private String hardware_info;
	private String licence_code;
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getProject_name() {
		return project_name;
	}
	public void setProject_name(String project_name) {
		this.project_name = project_name;
	}
	public Integer getFk_employee_id() {
		return fk_employee_id;
	}
	public void setFk_employee_id(Integer fk_employee_id) {
		this.fk_employee_id = fk_employee_id;
	}
	public Date getSign_date() {
		return sign_date;
	}
	public void setSign_date(Date sign_date) {
		this.sign_date = sign_date;
	}
	public Date getFinish_date() {
		return finish_date;
	}
	public void setFinish_date(Date finish_date) {
		this.finish_date = finish_date;
	}
	public int getStep_index() {
		return step_index;
	}
	public void setStep_index(int step_index) {
		this.step_index = step_index;
	}
	public String getUnique_code() {
		return unique_code;
	}
	public void setUnique_code(String unique_code) {
		this.unique_code = unique_code;
	}
	public String getProject_desc() {
		return project_desc;
	}
	public void setProject_desc(String project_desc) {
		this.project_desc = project_desc;
	}
	public Date getReg_date() {
		return reg_date;
	}
	public void setReg_date(Date reg_date) {
		this.reg_date = reg_date;
	}
	public Date getLicence_date() {
		return licence_date;
	}
	public void setLicence_date(Date licence_date) {
		this.licence_date = licence_date;
	}
	public Integer getLicence_day() {
		return licence_day;
	}
	public void setLicence_day(Integer licence_day) {
		this.licence_day = licence_day;
	}
	public String getHardware_info() {
		return hardware_info;
	}
	public void setHardware_info(String hardware_info) {
		this.hardware_info = hardware_info;
	}
	public String getLicence_code() {
		return licence_code;
	}
	public void setLicence_code(String licence_code) {
		this.licence_code = licence_code;
	}
}
