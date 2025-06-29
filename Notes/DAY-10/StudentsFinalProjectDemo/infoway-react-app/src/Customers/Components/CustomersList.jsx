import { useState, useEffect } from 'react'
import { NavLink } from "react-router-dom";

import { getAllCustomers } from "../Services/CustomersService";

export const CustomersList = () => {
    let title = "Welcome To Infoway's Customers List!";
    let subTitle = "All customers from India!";
    const [customers, setCustomers] = useState([]);
    useEffect(() => {
        //IIFE
        (async () => {
            setCustomers(await getAllCustomers());
        })();
    }, []);
    if (customers.length > 0) {
        return (
            <>
                <h1>{title}</h1>
                <hr />
                <h6>{subTitle}</h6>
                <table className="table table-hover table-striped">
                    <thead>
                        <tr>
                            <th>Contact Name</th>
                            <th>City</th>
                            <th>Pincode</th>
                            <th>Email</th>
                            <th>Contact #</th>
                            <th>Show Details</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            customers.map(customer => <tr key={customer.customerId}>
                                <td><span>{customer.contactName}</span></td>
                                <td><span>{customer.city}</span></td>
                                <td><span>{customer.pincode}</span></td>
                                <td><span>{customer.email}</span></td>
                                <td><span>{customer.phone}</span></td>
                                <td>
                                    <NavLink className={"btn btn-info"} 
                                    to={"/customers/"+customer.customerId}>Show Details</NavLink>
                                </td>
                            </tr>)
                        }
                    </tbody>
                </table>
            </>
        )
    } else {
        return <>
            <h1>Loading...</h1>
        </>
    }
}
