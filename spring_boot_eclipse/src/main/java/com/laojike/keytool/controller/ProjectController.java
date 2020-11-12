package com.laojike.keytool.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import com.laojike.keytool.entity.Project;
import com.laojike.keytool.entity.Project_Step;
import com.laojike.keytool.service.ProjectService;
import com.laojike.keytool.util.KeyUtil;
import com.laojike.keytool.vo.ProjectInfo;

@RestController
public class ProjectController {
	@Autowired
	ProjectService projectService;

	@GetMapping("/project/getProjectListWithStep")
	public List<ProjectInfo> getProjectListWithStep(int step_index) {
		if(step_index<0) {
			return projectService.getAllProjectDetail();	
		}
		return projectService.getProjectListWithStep(step_index);
	}

	@GetMapping("/project/getProjectDetailById")
	public ProjectInfo getProjectDetailById(int projectId) {
		return projectService.getProjectDetailById(projectId);
	}
	
	@PostMapping("/project/saveProject")
	public Boolean saveProject(@RequestBody Project project) {
		String unique_code = KeyUtil.GenerateUniqueCode();		
		project.setUnique_code(unique_code);
		
		Project saveProject = projectService.saveProject(project);
		if (saveProject.getId() > 0) {
			return true;
		}
		return false;
	}
	
	@GetMapping("/project/getPaddingProjectCount")
	public int getPaddingProjectCount() {
		return projectService.getPaddingProjectCount();
	}
}
