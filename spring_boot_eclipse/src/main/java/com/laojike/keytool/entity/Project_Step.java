package com.laojike.keytool.entity;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.Table;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "Project_Step")
public class Project_Step {
	@Id
	@GeneratedValue
	private int id;
	private int step_index;
	private String step_content;
	private String step_thumb;

	public String getStep_thumb() {
		return step_thumb;
	}

	public void setStep_thumb(String step_thumb) {
		this.step_thumb = step_thumb;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getStep_index() {
		return step_index;
	}

	public void setStep_index(int step_index) {
		this.step_index = step_index;
	}

	public String getStep_content() {
		return step_content;
	}

	public void setStep_content(String step_content) {
		this.step_content = step_content;
	}
}
