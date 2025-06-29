import { NavLink } from "react-router-dom";

export const Navbar = () => {
  return (
    <nav className="navbar navbar-expand-lg navbar-dark bg-dark px-3">
      <div className="container-fluid">
        <NavLink className="navbar-brand fw-bold text-primary" to="/">
          🚗 Spare_Part_Wala
        </NavLink>
        <button
          className="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarNav"
          aria-controls="navbarNav"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span className="navbar-toggler-icon"></span>
        </button>
        <div className="collapse navbar-collapse" id="navbarNav">
          <ul className="navbar-nav ms-auto">

            <li className="nav-item">
              <NavLink
                to="/home"
                className="nav-link"
                activeclassname="active"
              >
                Home
              </NavLink>
            </li>

            <li className="nav-item">
              <NavLink
                to="/customers"
                className="nav-link"
                activeclassname="active"
              >
                Customers
              </NavLink>
            </li>

            <li className="nav-item">
              <NavLink to="/categories" className="nav-link">
                   Categories
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link" to="/products">
                    Products
              </NavLink>
            </li>
            
            {/* Add more links if needed */}
          </ul>
        </div>
      </div>
    </nav>
  );
};
