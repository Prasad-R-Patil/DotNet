// src/Categories/Components/CategoriesList.jsx
import { useEffect, useState } from "react";
import { getAllCategories } from "../Services/CategoryService";
import { NavLink } from "react-router-dom";

export const CategoriesList = () => {
  const [categories, setCategories] = useState([]);

  useEffect(() => {
    (async () => {
      const data = await getAllCategories();
      setCategories(data);
    })();
  }, []);

  return (
    <div className="container mt-4">
      <h2>Categories</h2>
      <NavLink to="/categories/add" className="btn btn-success mb-3">
        Add Category
      </NavLink>
      <table className="table table-bordered table-striped">
        <thead>
          <tr>
            <th>ID</th>
            <th>Category Name</th>
            <th>Action</th> {/* Only View Button */}
          </tr>
        </thead>
        <tbody>
          {categories.map((cat) => (
            <tr key={cat.id}>
              <td>{cat.id}</td>
              <td>{cat.name}</td>
              <td>
                <NavLink
                  to={`/categories/${cat.id}`}
                  className="btn btn-info btn-sm"
                >
                  View
                </NavLink>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};
