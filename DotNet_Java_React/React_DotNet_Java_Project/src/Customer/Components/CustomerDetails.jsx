import { useState, useEffect } from "react";
import { useParams, useNavigate } from "react-router-dom";
import { getCustomerDetails, deleteCustomer } from "../Services/CustomersService";

export const CustomerDetails = () => {
  const [customer, setCustomer] = useState(null);
  const [error, setError] = useState("");
  const params = useParams();
  const navigate = useNavigate();

  useEffect(() => {
    (async () => {
      try {
        const data = await getCustomerDetails(params.id);
        setCustomer(data);
      } catch (err) {
        console.error("Error fetching customer:", err);
        setError("Failed to fetch customer.");
      }
    })();
  }, [params.id]);

  const handleDelete = async () => {
    if (window.confirm("Are you sure you want to delete this customer?")) {
      try {
        await deleteCustomer(customer.customerId);
        alert("Customer deleted successfully.");
        navigate("/customers");
      } catch (err) {
        alert("Failed to delete customer.");
      }
    }
  };

  const handleUpdate = () => {
    navigate(`/customers/edit/${customer.customerId}`);
  };

  if (error) {
    return <h3 className="text-danger">{error}</h3>;
  }

  if (!customer) {
    return <h3 className="text-secondary">Loading...</h3>;
  }

  return (
    <div className="container mt-4">
      <h1 className="text-primary">Details Of - {customer.contactName}</h1>
      <hr />
      <table className="table table-bordered table-striped w-75 text-nowrap">
  <tbody>
    <tr>
      <th style={{ width: "200px" }}>Customer ID</th>
      <td>{customer.customerId}</td>
    </tr>
    <tr>
      <th>Contact Name</th>
      <td>{customer.contactName}</td>
    </tr>
    <tr>
      <th>City</th>
      <td>{customer.city}</td>
    </tr>
    <tr>
      <th>Pincode</th>
      <td>{customer.pinCode}</td>
    </tr>
    <tr>
      <th>Email</th>
      <td style={{ maxWidth: "300px", overflow: "hidden", textOverflow: "ellipsis", whiteSpace: "nowrap" }}>
        {customer.email}
      </td>
    </tr>
    <tr>
      <th>Phone</th>
      <td>{customer.phone}</td>
    </tr>
  </tbody>
</table>


      <div className="d-flex gap-3">
        <button onClick={handleUpdate} className="btn btn-warning">
          Update
        </button>
        <button onClick={handleDelete} className="btn btn-danger">
          Delete
        </button>
      </div>
    </div>
  );
};
