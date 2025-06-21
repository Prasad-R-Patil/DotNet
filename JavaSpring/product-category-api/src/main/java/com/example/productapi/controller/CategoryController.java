package com.example.productapi.controller;

import com.example.productapi.model.Category;
import com.example.productapi.repository.CategoryRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import jakarta.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/categories")
@CrossOrigin(origins = "*")
public class CategoryController {

    @Autowired
    private CategoryRepository categoryRepo;

    @GetMapping
    public List<Category> getAllCategories() {
        return categoryRepo.findAll();
    }

    @PostMapping
    public Category createCategory(@Valid @RequestBody Category category) {
        return categoryRepo.save(category);
    }
}
