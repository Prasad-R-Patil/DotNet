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
	
	public List<Product> findAll()
	{
		return prorepo.findAll();
	}
	
	public Product save(Product product)
	{
		return prorepo.save(product);
	}
	
	
	public void Update1Product(Product product) {
		prorepo.updateProduct(product.getId(), product.getName(), product.getPrice());
	}
	
	
	

	public Product getOneProduct(Long id) {
		return prorepo.findById(id).orElseThrow();
	}
	
	public void deleteById(Long id)
	{
		prorepo.deleteById(id);
	}
}
