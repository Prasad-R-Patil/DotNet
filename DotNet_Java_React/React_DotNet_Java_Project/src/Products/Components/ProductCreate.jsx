import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { createProduct } from "../Services/ProductService";
import { getAllCategories } from "../../Categories/Services/CategoryService";

export const ProductCreate = () => {
  const navigate = useNavigate();
  const [categories, setCategories] = useState([]);
  const [form, setForm] = useState({ name: "", price: "", category: { id: "" } });

  useEffect(() => {
    (async () => {
      setCategories(await getAllCategories());
    })();
  }, []);

  const handleSubmit = async (e) => {
    e.preventDefault();
    await createProduct(form);
    navigate("/products");
  };

  return (
    <div className="container mt-4">
      <h2>Add New Product</h2>
      <form onSubmit={handleSubmit}>
        <input className="form-control mb-2" placeholder="Name" value={form.name}
          onChange={(e) => setForm({ ...form, name: e.target.value })} required />
        <input type="number" className="form-control mb-2" placeholder="Price" value={form.price}
          onChange={(e) => setForm({ ...form, price: parseFloat(e.target.value) })} required />
        <select className="form-control mb-2"
          value={form.category.id}
          onChange={(e) => setForm({ ...form, category: { id: e.target.value } })}
          required>
          <option value="">-- Select Category --</option>
          {
            categories.map(cat => <option key={cat.id} value={cat.id}>{cat.name}</option>)
          }
        </select>
        <button className="btn btn-success">Create</button>
      </form>
    </div>
  );
};
