import JavaAxios from "../../My_Axios/Java-Axios";

export async function getAllProducts() {
  return (await JavaAxios.get('/products')).data;
}

export async function getProductById(id) {
  return (await JavaAxios.get(`/products/${id}`)).data;
}

export async function createProduct(product) {
  return (await JavaAxios.post('/products', product)).data;
}

export async function updateProduct(product) {
  return (await JavaAxios.put(`/products/${product.id}`, product)).data;
}

export async function deleteProduct(id) {
  return (await JavaAxios.delete(`/products/${id}`)).data;
}
