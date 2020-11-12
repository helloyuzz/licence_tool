package com.laojike.keytool.vo;

import com.laojike.keytool.entity.Project_Step;

import lombok.Data;

// 采用接口可以避免自定义查询报错的问题
// 使用class会产生查询错误
@Data
public interface ProjectStepWithCount {
//	private Project_Step project_Step;
//	private Integer step_index;
//	private String step_content;
//	private String step_thumb;
//	private Integer project_count;
	Integer getStep_index();

	String getStep_content();

	String getStep_thumb();

	Integer getProject_count();
	
//	public ProjectStepWithCount() {
//		
//	}

//	public ProjectStepWithCount(Project_Step project_Step, int step_index1, int project_count) {
//		this.project_Step = project_Step;
//		this.step_index1 = step_index1;
//		this.project_count = this.project_count;
//	}

}
