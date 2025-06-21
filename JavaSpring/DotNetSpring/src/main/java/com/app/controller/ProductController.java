package com.app.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.app.model.Product;
import com.app.repository.ProductRepository;
import com.app.service.ProductService;

import jakarta.validation.Valid;

@RestController
@RequestMapping("/api/products")
@CrossOrigin(origins = "*")
public class ProductController {

	@Autowired
	private ProductService proServ;

	@GetMapping
	public List<Product> getAllProducts() {
		List<Product> list = proServ.findAll();
		System.out.println("Product count: " + list.size());
		return list;
	}

	@PutMapping("/{id}")
	public ResponseEntity<String> updateProduct(@PathVariable Long id, @RequestBody Product product) {
		product.setId(id); // Ensure the ID in the URL matches the ID in the product object
		proServ.Update1Product(product);
		return ResponseEntity.ok("Product updated successfully");
	}

	@GetMapping("/{id}")
	public ResponseEntity<Product> getOneProduct(@PathVariable Long id) {
		Product product = proServ.getOneProduct(id);
		return ResponseEntity.ok(product);
	}

	@DeleteMapping("/id")
	public void deleteById(@PathVariable Long id) {
		proServ.deleteById(id);

	}

}
