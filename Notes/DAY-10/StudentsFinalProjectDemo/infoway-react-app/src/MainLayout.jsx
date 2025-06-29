import { Routes, Route } from "react-router-dom";

import { Navbar } from "./Navigation/Components/Navbar";
import { Footer } from "./Navigation/Components/Footer";

import { Home } from "./Home/Home";
import { CustomersList } from "./Customers/Components/CustomersList";
import { CustomerDetails } from "./Customers/Components/CustomerDetails";

export const MainLayout = () => {
    return (
        <>
            <Navbar />
            <Routes>
                <Route path="/" element={<Home />} />
                <Route path="/home" element={<Home />} />
                <Route path="/customers" element={<CustomersList />} />
                <Route path="/customers/:id" element={<CustomerDetails />} />
            </Routes>
            <Footer />
        </>
    )
}
