import { Routes, Route } from "react-router-dom";

import { Navbar } from "./Navigation/Components/Navbar";
import { Footer } from "./Navigation/Components/Footer";

import { Home } from "./Home/Home";

// ✅ Customer Components
import { CustomersList } from "./Customer/Components/CustomersList";
import { CustomerCreate } from "./Customer/Components/CustomerCreate";
import { CustomerDetails } from "./Customer/Components/CustomerDetails";
import { CustomerEdit } from "./Customer/Components/CustomerUpdate";

// ✅ Category Components
import { CategoriesList } from "./Categories/Components/CategoriesList";
import { CategoryCreate } from "./Categories/Components/CategoryCreate";
import { CategoryDetails } from "./Categories/Components/CategoryDetails";
import { CategoryUpdate } from "./Categories/Components/CategoryUpdate";

// ✅ Product Components
import { ProductsList } from "./Products/Components/ProductsList";
import { ProductCreate } from "./Products/Components/ProductCreate";
import { ProductUpdate } from "./Products/Components/ProductUpdate";
import { ProductDetails } from "./Products/Components/ProductDetails";

export const MainLayout = () => {
  return (
    <>
      <Navbar />
      <div style={{ minHeight: "calc(100vh - 120px)" }}> {/* prevent footer overlap */}
        <Routes>
          {/* Home */}
          <Route path="/" element={<Home />} />
          <Route path="/home" element={<Home />} />

          {/* Customer Routes */}
          <Route path="/customers" element={<CustomersList />} />
          <Route path="/customers/add" element={<CustomerCreate />} />
          <Route path="/customers/:id" element={<CustomerDetails />} />
          <Route path="/customers/edit/:id" element={<CustomerEdit />} />


          {/* Category Routes */}
          <Route path="/categories" element={<CategoriesList />} />
          <Route path="/categories/add" element={<CategoryCreate />} />
          <Route path="/categories/:id" element={<CategoryDetails />} />
          <Route path="/categories/edit/:id" element={<CategoryUpdate />} />

          {/* Product Routes */}
          <Route path="/products" element={<ProductsList />} />
          <Route path="/products/add" element={<ProductCreate />} />
          <Route path="/products/edit/:id" element={<ProductUpdate />} />
          <Route path="/products/:id" element={<ProductDetails />} />
        </Routes>
      </div>
      <Footer />
    </>
  );
};
