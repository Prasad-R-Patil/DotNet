import dotnetAxios from "../../InfowayAxios/dotnet-axios";

async function getAllCustomers() {
    return await (await dotnetAxios.get('/customers')).data;
}
async function getCustomerDetails(id) {
    return (await dotnetAxios.get(`/customers/${id}`)).data;
}

export {
    getAllCustomers, getCustomerDetails
}
