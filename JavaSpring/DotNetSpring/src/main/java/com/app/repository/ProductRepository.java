package com.app.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.jpa.repository.query.Procedure;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import com.app.model.Product;

import jakarta.transaction.Transactional;

@Repository
public interface ProductRepository extends JpaRepository<Product, Long> {
	
	@Modifying
    @Transactional
    @Query("UPDATE Product p SET p.name = :name, p.price = :price WHERE p.id = :id")
    void updateProduct(@Param("id") Long id, @Param("name") String name, @Param("price") double price);
}
	


