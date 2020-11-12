package com.laojike.keytool.service;

import java.util.List;

import javax.persistence.criteria.Join;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.laojike.keytool.entity.Employee;
import com.laojike.keytool.entity.Project;
import com.laojike.keytool.repository.ProjectRepository;
import com.laojike.keytool.util.KeyUtil;
import com.laojike.keytool.vo.ProjectInfo;

@Service
public class ProjectService {
	@Autowired
	ProjectRepository projectRepository;

	public List<Project> findAll() {
		return projectRepository.findAll();
	}

	public List<ProjectInfo> getAllProjectDetail() {
		return projectRepository.getAllProjectDetail();
	}

	public List<ProjectInfo> getProjectListWithStep(int step_index) {
		return projectRepository.getProjectListWithStep(step_index);
	}

	public Project saveProject(Project project) {
		return projectRepository.save(project);
	}

	public int getPaddingProjectCount() {
		return projectRepository.getPaddingProjectCount(1);
	}

	public ProjectInfo getProjectDetailById(int projectId) {
		return projectRepository.getProjectDetailById(projectId);
	}
}
