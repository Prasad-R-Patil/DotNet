// src/Customer/Components/CustomerCreate.jsx
import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { addCustomer } from "../Services/CustomersService";

export const CustomerCreate = () => {
  const [customer, setCustomer] = useState({
    contactName: "",
    city: "",
    phone: "",
    email: "",
    pinCode: ""
  });

  const navigate = useNavigate();

  const handleChange = (e) => {
    setCustomer({ ...customer, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      await addCustomer({ ...customer, pinCode: parseInt(customer.pinCode) });
      alert("✅ Customer added successfully!");
      navigate("/customers");
    } catch (err) {
      console.error(err);
      alert("❌ Failed to add customer. Please check your input.");
    }
  };

  return (
    <div className="container mt-5">
      <div className="bg-light border rounded p-4 shadow-lg">
        <h2 className="text-center text-primary mb-4">🚀 Add New Customer</h2>

        <form onSubmit={handleSubmit}>
          <table className="table table-bordered table-hover table-striped align-middle shadow-sm rounded overflow-hidden">
            <tbody>
              <tr className="table-info">
                <th>Contact Name</th>
                <td>
                  <input
                    type="text"
                    name="contactName"
                    value={customer.contactName}
                    onChange={handleChange}
                    className="form-control"
                    required
                    placeholder="Enter full name"
                  />
                </td>
              </tr>
              <tr className="table-light">
                <th>City</th>
                <td>
                  <input
                    type="text"
                    name="city"
                    value={customer.city}
                    onChange={handleChange}
                    className="form-control"
                    required
                    placeholder="Enter city"
                  />
                </td>
              </tr>
              <tr className="table-info">
                <th>Phone</th>
                <td>
                  <input
                    type="text"
                    name="phone"
                    value={customer.phone}
                    onChange={handleChange}
                    className="form-control"
                    required
                    placeholder="Enter phone number"
                  />
                </td>
              </tr>
              <tr className="table-light">
                <th>Email</th>
                <td>
                  <input
                    type="email"
                    name="email"
                    value={customer.email}
                    onChange={handleChange}
                    className="form-control"
                    required
                    placeholder="Enter email address"
                  />
                </td>
              </tr>
              <tr className="table-info">
                <th>Pin Code</th>
                <td>
                  <input
                    type="number"
                    name="pinCode"
                    value={customer.pinCode}
                    onChange={handleChange}
                    className="form-control"
                    required
                    placeholder="Enter pin code"
                  />
                </td>
              </tr>
            </tbody>
          </table>

          <div className="text-center mt-4">
            <button type="submit" className="btn btn-success btn-lg px-5">
              💾 Save Customer
            </button>
          </div>
        </form>
      </div>
    </div>
  );
};
