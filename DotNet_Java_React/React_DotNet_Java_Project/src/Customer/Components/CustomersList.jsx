import { useState, useEffect } from "react";
import { NavLink } from "react-router-dom";
import { getAllCustomers } from "../Services/CustomersService";

export const CustomersList = () => {
  const [customers, setCustomers] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState("");

  useEffect(() => {
    (async () => {
      try {
        const data = await getAllCustomers();
        setCustomers(data);
      } catch (err) {
        console.error("Error loading customers:", err);
        setError("Failed to load customers.");
      } finally {
        setLoading(false);
      }
    })();
  }, []);

  const title = "Welcome To Spare_Part_Wala Customers List!";
  const subTitle = "All customers from India!";

  if (loading) {
    return <h3 className="text-center text-secondary">Loading...</h3>;
  }

  if (error) {
    return <h3 className="text-center text-danger">{error}</h3>;
  }

  return (
    <div className="container mt-4">
      <h1 className="text-primary">{title}</h1>
      <hr />
      <h6 className="text-muted">{subTitle}</h6>

      {/* ✅ Add Customer Button */}
      <div className="mb-3">
        <NavLink className="btn btn-success" to="/customers/add">
          Add Customer
        </NavLink>
      </div>

      {customers.length === 0 ? (
        <p className="text-warning">No customers found.</p>
      ) : (
        <table className="table table-hover table-striped">
          <thead className="table-dark">
            <tr>
              <th>Contact Name</th>
              <th>City</th>
              <th>Pincode</th>
              <th>Email</th>
              <th>Contact #</th>
              <th>Show Details</th>
            </tr>
          </thead>
          <tbody>
            {customers.map((customer) => (
              <tr key={customer.customerId}>
                <td>{customer.contactName}</td>
                <td>{customer.city}</td>
                <td>{customer.pincode}</td>
                <td>{customer.email}</td>
                <td>{customer.phone}</td>
                <td>
                  <NavLink className="btn btn-info btn-sm" to={`/customers/${customer.customerId}`}>
                    Show Details
                  </NavLink>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
};
