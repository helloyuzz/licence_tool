package com.laojike.keytool.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import com.laojike.keytool.entity.Project_Step;
import com.laojike.keytool.vo.ProjectStepWithCount;

public interface ProjectStepRepository extends JpaRepository<Project_Step,Integer> {
	@Query(value = "SELECT ps.step_index,ps.step_content,ps.step_thumb,p1.project_count FROM project_step ps LEFT JOIN ( SELECT p.step_index AS 'step_index1', count( p.step_index ) AS 'project_count' FROM project p GROUP BY p.step_index ) p1 ON ps.step_index = p1.step_index1 order by ps.step_index",nativeQuery = true)
	List<ProjectStepWithCount> getProjectStepWithCount();
}
