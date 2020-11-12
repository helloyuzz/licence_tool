package com.laojike.keytool.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.laojike.keytool.entity.Employee;

public interface EmployeeRepository extends JpaRepository<Employee,Integer> {
    Employee findByName(String name);
}

