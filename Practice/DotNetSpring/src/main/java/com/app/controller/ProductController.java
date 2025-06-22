package com.app.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import com.app.model.Product;
import com.app.service.ProductService;

@RestController
@RequestMapping("/products")
@CrossOrigin(origins = "*")
public class ProductController {

    @Autowired
    private ProductService productService;

   
    @GetMapping
    public List<Product> getAllProducts() {
        return productService.findAll();
    }

   
    @PostMapping
    public Product createProduct(@RequestBody Product product) {
        return productService.save(product);
    }

   
    @PutMapping("/{id}")
    public Product updateProduct(@PathVariable Long id, @RequestBody Product product) {
        product.setId(id); 
        return productService.updateProduct(product);
    }

   
    @GetMapping("/{id}")
    public Product getProductById(@PathVariable Long id) {
        return productService.getOneProduct(id);
    }

    
    @DeleteMapping("/{id}")
    public void deleteProduct(@PathVariable Long id) {
        productService.deleteById(id);
    }
}
