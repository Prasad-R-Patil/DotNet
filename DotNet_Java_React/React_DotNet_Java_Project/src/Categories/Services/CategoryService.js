// src/Categories/Services/CategoryService.js
import JavaAxios from "../../My_Axios/Java-Axios";

export async function getAllCategories() {
  return (await JavaAxios.get("/categories")).data;
}

export async function createCategory(category) {
  return (await JavaAxios.post("/categories", category)).data;
}

export async function getCategoryById(id) {
  return (await JavaAxios.get(`/categories/${id}`)).data;
}

export async function updateCategory(id, category) {
  return (await JavaAxios.put(`/categories/${id}`, category)).data;
}

export async function deleteCategory(id) {
  return (await JavaAxios.delete(`/categories/${id}`)).data;
}
