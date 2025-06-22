package com.app.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.app.model.Category;
import com.app.repository.CategoryRepository;

@Service
public class CategoryService {

    @Autowired
    private CategoryRepository catRepo;

  
    public List<Category> findAll() {
        return catRepo.findAll();
    }


    public Category save(Category category) {
        return catRepo.save(category);
    }


    public Category updateCategory(Category updatedCategory) {
        Category existing = catRepo.findById(updatedCategory.getId())
                                   .orElseThrow(() -> new RuntimeException("Category not found"));

        existing.setName(updatedCategory.getName());
     

        return catRepo.save(existing);
    }


    public Category getOneCategory(Long id) {
        return catRepo.findById(id).orElseThrow(() -> new RuntimeException("Category not found"));
    }


    public void deleteById(Long id) {
        catRepo.deleteById(id);
    }
}
