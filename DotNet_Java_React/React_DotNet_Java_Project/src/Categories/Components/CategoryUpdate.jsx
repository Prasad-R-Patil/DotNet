// src/Categories/Components/CategoryUpdate.jsx
import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { getCategoryById, updateCategory } from "../Services/CategoryService";

export const CategoryUpdate = () => {
  const { id } = useParams();
  const navigate = useNavigate();
  const [name, setName] = useState("");

  useEffect(() => {
    (async () => {
      const data = await getCategoryById(id);
      setName(data.name);
    })();
  }, [id]);

  const handleSubmit = async (e) => {
    e.preventDefault();
    await updateCategory(id, { name });
    alert("Category updated");
    navigate("/categories");
  };

  return (
    <div className="container mt-4">
      <h2>Edit Category</h2>
      <form onSubmit={handleSubmit}>
        <input type="text" value={name} onChange={(e) => setName(e.target.value)} className="form-control mb-3" required />
        <button type="submit" className="btn btn-primary">Update</button>
      </form>
    </div>
  );
};
