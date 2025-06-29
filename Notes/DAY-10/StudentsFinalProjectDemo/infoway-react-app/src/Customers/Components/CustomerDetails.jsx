import { useState, useEffect } from 'react';
import { useParams } from "react-router-dom";

import { getCustomerDetails } from "../Services/CustomersService";

export const CustomerDetails = () => {

    const [customer, setCustomer] = useState(null);
    const params = useParams();
    useEffect(() => {
        (async () => {
            setCustomer(await getCustomerDetails(params.id));
        })();
    }, [params.id])


    let title = "Details Of - ";
    if (customer!=null) {
    return (
        <>
            <h1>{title + customer.contactName}</h1>
        </>
    )    
    }else{
        <h3>Loading...</h3>
    }
    
}
