import { useEffect, useState } from "react";
import { getAllProducts } from "../Services/ProductService";
import { Link } from "react-router-dom";

export const ProductsList = () => {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    (async () => {
      setProducts(await getAllProducts());
    })();
  }, []);

  return (
    <div className="container mt-4">
      <h2>Products List</h2>
      <Link to="/products/add" className="btn btn-primary mb-3">Add Product</Link>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Name</th>
            <th>Price</th>
            <th>Category Name</th>
            <th>Action</th>
          </tr>
        </thead>
        <tbody>
          {
            products.map(product => (
              <tr key={product.id}>
                <td>{product.name}</td>
                <td>{product.price}</td>
                <td>{product.category?.name}</td>
                <td>
                  <Link to={`/products/${product.id}`} className="btn btn-info btn-sm">
                    View
                  </Link>
                </td>
              </tr>
            ))
          }
        </tbody>
      </table>
    </div>
  );
};
