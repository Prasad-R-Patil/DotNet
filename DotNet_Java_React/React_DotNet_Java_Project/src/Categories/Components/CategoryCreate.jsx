// src/Categories/Components/CategoryCreate.jsx
import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { createCategory } from "../Services/CategoryService";

export const CategoryCreate = () => {
  const [name, setName] = useState("");
  const navigate = useNavigate();

  const handleSubmit = async (e) => {
    e.preventDefault();
    await createCategory({ name });
    alert("Category created");
    navigate("/categories");
  };

  return (
    <div className="container mt-4">
      <h2>Add New Category</h2>
      <form onSubmit={handleSubmit}>
        <input type="text" value={name} onChange={(e) => setName(e.target.value)} className="form-control mb-3" required />
        <button type="submit" className="btn btn-success">Create</button>
      </form>
    </div>
  );
};
