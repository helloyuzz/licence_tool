package com.laojike.keytool.vo;

import java.io.Serializable;

import com.laojike.keytool.entity.Employee;
import com.laojike.keytool.entity.Project;
import com.laojike.keytool.entity.Project_Step;

import lombok.Data;

@Data
public class ProjectInfo {
	private Employee employee;
	private Project project;
	private Project_Step project_Step;
	

	public Employee getEmployee() {
		return employee;
	}

	public void setEmployee(Employee employee) {
		this.employee = employee;
	}

	public Project getProject() {
		return project;
	}

	public void setProject(Project project) {
		this.project = project;
	}


	public Project_Step getProjectStep() {
		return project_Step;
	}

	public void setProjectStep(Project_Step projectStep) {
		this.project_Step = projectStep;
	}

	public ProjectInfo() {

	}

	public ProjectInfo(Employee employee) {
		this.employee = employee;
		this.project = new Project();
		this.project_Step = new Project_Step();
	}

	public ProjectInfo(Project project) {
		this.project = project;
		this.employee = new Employee();
		this.project_Step = new Project_Step();
	}


	public ProjectInfo(Project_Step projectStep) {
		this.project = new Project();
		this.employee = new Employee();
		this.project_Step = projectStep;

	}

	public ProjectInfo(Project project, Employee employee,  Project_Step projectStep) {
		this.employee = employee;
		this.project = project;
		this.project_Step = projectStep;
	}
}
