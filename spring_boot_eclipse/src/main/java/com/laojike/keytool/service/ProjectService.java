package com.laojike.keytool.service;

import java.util.List;
import java.util.Optional;

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

	public int getPaddingProjectCount(int step_index) {
		return projectRepository.getPaddingProjectCount(step_index);
	}

	public ProjectInfo getProjectDetailById(int projectId) {
		return projectRepository.getProjectDetailById(projectId);
	}

	public Boolean changeProjectStepById(int projectId, int step_index) {
		Optional<Project> project = projectRepository.findById(projectId);
		project.get().setStep_index(step_index);

		Project saveProject = projectRepository.save(project.get());
		if (saveProject != null) {
			return true;
		} else {
			return false;
		}
	}
}
