package com.laojike.keytool.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import com.laojike.keytool.entity.Project;
import com.laojike.keytool.vo.ProjectInfo;

public interface ProjectRepository extends JpaRepository<Project,Integer> {
	@Query(value = "select new com.laojike.keytool.vo.ProjectInfo(p,e,ps) from Project p left join Employee e on p.fk_employee_id=e.id left join Project_Step ps on p.step_index=ps.step_index where ps.step_index in(?1) order by p.id desc")
	List<ProjectInfo> getProjectListWithStep(int step_index);
	
	@Query(value = "select new com.laojike.keytool.vo.ProjectInfo(p,e,ps) from Project p left join Employee e on p.fk_employee_id=e.id left join Project_Step ps on p.step_index=ps.step_index order by p.id desc")
	List<ProjectInfo> getAllProjectDetail();
	
	@Query(value = "select count(id) from project where step_index=?1",nativeQuery = true)
	int getPaddingProjectCount(int project_step);

	@Query(value = "select new com.laojike.keytool.vo.ProjectInfo(p,e,ps) from Project p left join Employee e on p.fk_employee_id=e.id left join Project_Step ps on p.step_index=ps.step_index where p.id = ?1")
	ProjectInfo getProjectDetailById(int projectId);
}
