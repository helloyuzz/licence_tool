package com.laojike.keytool.service;

import java.util.ArrayList;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.autoconfigure.data.web.SpringDataWebProperties.Pageable;
import org.springframework.data.domain.Sort;
import org.springframework.data.domain.Sort.Direction;
import org.springframework.data.domain.Sort.Order;
import org.springframework.stereotype.Service;

import com.laojike.keytool.entity.Project_Step;
import com.laojike.keytool.repository.ProjectStepRepository;
import com.laojike.keytool.vo.ProjectStepWithCount;

@Service
public class ProjectStepService {
	@Autowired
	ProjectStepRepository projectStepRepository;

	public List<Project_Step> findAll() {
		List<Sort.Order> order = new ArrayList<Sort.Order>();
		order.add(new Order(Direction.ASC, "id"));
		Sort sort = Sort.by(order);
		return projectStepRepository.findAll(sort);
	}

	public List<ProjectStepWithCount> getProjectStepWithCount() {
		return projectStepRepository.getProjectStepWithCount();
	}
}
