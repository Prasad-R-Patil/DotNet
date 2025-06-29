// src/Categories/Components/CategoryDetails.jsx
import { useEffect, useState } from "react";
import { useNavigate, useParams, Link } from "react-router-dom";
import { getCategoryById, deleteCategory } from "../Services/CategoryService";

export const CategoryDetails = () => {
  const { id } = useParams();
  const navigate = useNavigate();
  const [category, setCategory] = useState(null);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    (async () => {
      try {
        const data = await getCategoryById(id);
        setCategory(data);
      } finally {
        setLoading(false);
      }
    })();
  }, [id]);

  const handleDelete = async () => {
    if (window.confirm("Are you sure? This will delete this category and all its products!")) {
      await deleteCategory(id);
      navigate("/categories");
    }
  };

  if (loading) return <h4 className="text-center mt-4">Loading…</h4>;

  return (
    <div className="container mt-4">
      <h2 className="mb-3">Category Details</h2>

      <table className="table table-bordered w-50">
        <tbody>
          <tr><th>ID</th><td>{category.id}</td></tr>
          <tr><th>Name</th><td>{category.name}</td></tr>
          <tr><th>Total Products</th><td>{category.products?.length || 0}</td></tr>
        </tbody>
      </table>

      <h4 className="mt-4">Products in this Category</h4>

      {category.products?.length ? (
        <table className="table table-striped w-75">
          <thead className="table-light">
            <tr><th>ID</th><th>Name</th><th>Price</th></tr>
          </thead>
          <tbody>
            {category.products.map(p => (
              <tr key={p.id}>
                <td>{p.id}</td>
                <td>{p.name}</td>
                <td>{p.price}</td>
              </tr>
            ))}
          </tbody>
        </table>
      ) : (
        <p className="text-muted">No products found in this category.</p>
      )}

      <div className="mt-4 d-flex gap-3">
        <button className="btn btn-warning"
                onClick={() => navigate(`/categories/edit/${category.id}`)}>
          Edit
        </button>

        <button className="btn btn-danger" onClick={handleDelete}>
          Delete Category
        </button>

        <Link to="/categories" className="btn btn-secondary">
          Back to List
        </Link>
      </div>
    </div>
  );
};
