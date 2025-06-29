import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { getProductById, updateProduct } from "../Services/ProductService";
import { getAllCategories } from "../../Categories/Services/CategoryService";

export const ProductUpdate = () => {
  const { id } = useParams();
  const navigate = useNavigate();
  const [product, setProduct] = useState(null);
  const [categories, setCategories] = useState([]);

  useEffect(() => {
    (async () => {
      const data = await getProductById(id);
      setProduct(data);
      setCategories(await getAllCategories());
    })();
  }, [id]);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setProduct({ ...product, [name]: name === "price" ? parseFloat(value) : value });
  };

  const handleCategoryChange = (e) => {
    setProduct({ ...product, category: { id: e.target.value } });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    await updateProduct(product);
    navigate("/products");
  };

  return product ? (
    <div className="container mt-4">
      <h2>Edit Product</h2>
      <form onSubmit={handleSubmit}>
        <input name="name" className="form-control mb-2" value={product.name} onChange={handleChange} required />
        <input type="number" name="price" className="form-control mb-2" value={product.price} onChange={handleChange} required />
        <select className="form-control mb-2" value={product.category?.id || ""} onChange={handleCategoryChange} required>
          <option value="">-- Select Category --</option>
          {
            categories.map(cat => <option key={cat.id} value={cat.id}>{cat.name}</option>)
          }
        </select>
        <button className="btn btn-success">Update</button>
      </form>
    </div>
  ) : <h3>Loading...</h3>;
};
