package com.laojike.keytool.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import com.laojike.keytool.entity.Project_Step;
import com.laojike.keytool.repository.ProjectStepRepository;
import com.laojike.keytool.service.ProjectStepService;
import com.laojike.keytool.vo.ProjectStepWithCount;

@RestController
public class ProjectStepController {
	@Autowired
	ProjectStepService projectStepService; 

	@GetMapping("/projectStep/findAll")
	public List<Project_Step> findAll(){
		return projectStepService.findAll();
	}
	@GetMapping("/projectStep/getProjectStepWithCount")
	public List<ProjectStepWithCount> getProjectStepWithCount(){
		return projectStepService.getProjectStepWithCount();
	}
}
