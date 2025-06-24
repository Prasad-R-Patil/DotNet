package com.app.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.app.model.Product;
import com.app.repository.ProductRepository;

@Service
public class ProductService {
    
    @Autowired
    private ProductRepository prorepo;

    public List<Product> findAll() {
        return prorepo.findAll();
    }

    public Product save(Product product) {
        return prorepo.save(product);  // insert or update
    }

    public Product updateProduct(Product updatedProduct) {
        Product existing = prorepo.findById(updatedProduct.getId())
            .orElseThrow(() -> new RuntimeException("Product ID " + updatedProduct.getId() + " not found for update"));

        existing.setName(updatedProduct.getName());
        existing.setPrice(updatedProduct.getPrice());
        return prorepo.save(existing);
    }

    public Product getOneProduct(Long id) {
        return prorepo.findById(id)
            .orElseThrow(() -> new RuntimeException("Product ID " + id + " not found"));
    }

    public void deleteById(Long id) {
        if (!prorepo.existsById(id)) {
            throw new RuntimeException("Product ID " + id + " not found for delete");
        }
        prorepo.deleteById(id);
    }
}
