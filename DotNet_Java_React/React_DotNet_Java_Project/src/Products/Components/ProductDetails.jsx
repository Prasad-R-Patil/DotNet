import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { deleteProduct, getProductById } from "../Services/ProductService";

export const ProductDetails = () => {
  const { id } = useParams();
  const [product, setProduct] = useState(null);
  const navigate = useNavigate();

  useEffect(() => {
    (async () => {
      setProduct(await getProductById(id));
    })();
  }, [id]);

  const handleDelete = async () => {
    if (window.confirm("Are you sure you want to delete?")) {
      await deleteProduct(id);
      navigate("/products");
    }
  };

  return product ? (
    <div className="container mt-4">
      <h2>Product Details</h2>
      <table className="table table-bordered">
        <tbody>
          <tr><th>ID</th><td>{product.id}</td></tr>
          <tr><th>Name</th><td>{product.name}</td></tr>
          <tr><th>Price</th><td>{product.price}</td></tr>
          <tr><th>Category</th><td>{product.category?.name}</td></tr>
        </tbody>
      </table>

      <div className="mt-3 d-flex gap-3">
        <button className="btn btn-warning" onClick={() => navigate(`/products/edit/${id}`)}>Edit</button>
        <button className="btn btn-danger" onClick={handleDelete}>Delete</button>
        <button className="btn btn-secondary" onClick={() => navigate("/products")}>Back to List</button>
      </div>
    </div>
  ) : <h3 className="text-center">Loading...</h3>;
};
