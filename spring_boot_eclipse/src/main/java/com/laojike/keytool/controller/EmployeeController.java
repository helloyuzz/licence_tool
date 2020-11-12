package com.laojike.keytool.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import com.laojike.keytool.entity.Employee;
import com.laojike.keytool.service.EmployeeService;

import java.util.List;

@RestController
public class EmployeeController {

    @Autowired
    private EmployeeService service;

    @PostMapping("/addEmployee")
    public Employee addEmployee(@RequestBody Employee product) {
        return service.saveEmployee(product);
    }

    @PostMapping("/addProducts")
    public List<Employee> addProducts(@RequestBody List<Employee> products) {
        return service.saveEmployees(products);
    }

    @GetMapping("/employees/findAll")
    public List<Employee> findAll() {
        return service.findAll();
    }

    @GetMapping("/employeeById/{id}")
    public Employee findProductById(@PathVariable int id) {
        return service.getEmployeeById(id);
    }

    @GetMapping("/employee/{name}")
    public Employee findProductByName(@PathVariable String name) {
        return service.getEmployeeByName(name);
    }

    @PutMapping("/updateEmployee")
    public Employee updateProduct(@RequestBody Employee product) {
        return service.updateEmployee(product);
    }

    @DeleteMapping("/deleteEmployee/{id}")
    public String deleteProduct(@PathVariable int id) {
        return service.deleteEmployee(id);
    }
}
