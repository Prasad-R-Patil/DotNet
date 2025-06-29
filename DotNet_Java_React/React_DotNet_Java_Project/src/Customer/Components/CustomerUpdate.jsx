import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { getCustomerDetails, updateCustomer } from "../Services/CustomersService";

export const CustomerEdit = () => {
  const { id } = useParams();
  const navigate = useNavigate();

  const [customer, setCustomer] = useState({
    customerId: "",
    contactName: "",
    city: "",
    pinCode: "",
    email: "",
    phone: ""
  });

  useEffect(() => {
    (async () => {
      const data = await getCustomerDetails(id);
      setCustomer(data);
    })();
  }, [id]);

  const handleChange = (e) => {
    setCustomer({ ...customer, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    await updateCustomer(customer);
    alert("Customer updated successfully.");
    navigate("/customers");
  };

  return (
    <div className="container mt-4">
      <h2 className="text-warning mb-4">Update Customer - {customer.contactName}</h2>
      <form onSubmit={handleSubmit}>
        <table className="table table-bordered w-100 text-nowrap align-middle">
          <tbody>
            <tr>
              <th style={{ width: "200px" }}>Customer ID</th>
              <td>{customer.customerId}</td>
            </tr>
            <tr>
              <th>Contact Name</th>
              <td>
                <input
                  type="text"
                  name="contactName"
                  value={customer.contactName}
                  onChange={handleChange}
                  className="form-control"
                  placeholder="Enter contact name"
                  required
                />
              </td>
            </tr>
            <tr>
              <th>City</th>
              <td>
                <input
                  type="text"
                  name="city"
                  value={customer.city}
                  onChange={handleChange}
                  className="form-control"
                  placeholder="Enter city"
                  required
                />
              </td>
            </tr>
            <tr>
              <th>Pincode</th>
              <td>
                <input
                  type="text"
                  name="pinCode"
                  value={customer.pinCode}
                  onChange={handleChange}
                  className="form-control"
                  placeholder="Enter pincode"
                  required
                />
              </td>
            </tr>
            <tr>
              <th>Email</th>
              <td>
                <input
                  type="email"
                  name="email"
                  value={customer.email}
                  onChange={handleChange}
                  className="form-control"
                  placeholder="Enter email"
                  required
                />
              </td>
            </tr>
            <tr>
              <th>Phone</th>
              <td>
                <input
                  type="text"
                  name="phone"
                  value={customer.phone}
                  onChange={handleChange}
                  className="form-control"
                  placeholder="Enter phone number"
                  required
                />
              </td>
            </tr>
          </tbody>
        </table>
        <div className="mt-3 d-flex gap-3">
          <button type="submit" className="btn btn-success">Update</button>
          <button type="button" className="btn btn-secondary" onClick={() => navigate("/customers")}>
            Cancel
          </button>
        </div>
      </form>
    </div>
  );
};
