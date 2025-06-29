import DotNetAxios from "../../My_Axios/DotNet-Axios";

// ✅ GET: All customers
export async function getAllCustomers() {
    try {
        const response = await DotNetAxios.get("/Customers");
        return response.data;
    } catch (error) {
        console.error("Error fetching all customers:", error);
        throw error;
    }
}

// ✅ GET: Single customer by ID
export async function getCustomerDetails(id) {
    try {
        const response = await DotNetAxios.get(`/Customers/${id}`);
        return response.data;
    } catch (error) {
        console.error(`Error fetching customer ${id}:`, error);
        throw error;
    }
}

// ✅ POST: Add new customer
export async function addCustomer(customerData) {
    try {
        const response = await DotNetAxios.post("/Customers", customerData);
        return response.data;
    } catch (error) {
        console.error("Error adding customer:", error);
        throw error;
    }
}

// ✅ PUT: Update customer
export async function updateCustomer(customerData) {
    try {
        const response = await DotNetAxios.put("/Customers", customerData);
        return response.data;
    } catch (error) {
        console.error("Error updating customer:", error);
        throw error;
    }
}

// ✅ DELETE: Delete customer by ID
export async function deleteCustomer(id) {
    try {
        const response = await DotNetAxios.delete(`/Customers/${id}`);
        return response.data;
    } catch (error) {
        console.error(`Error deleting customer ${id}:`, error);
        throw error;
    }
}
