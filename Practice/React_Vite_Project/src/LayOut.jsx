import React from 'react'
import Header from './Components/Header/header'
import Footer from './Components/Footer/footer'
import { Outlet } from 'react-router-dom'

function LayOut() {
    return (
        <>
            
                 <Header/>
                 <Outlet/>
                 <Footer/>
        </>
    )
}

export default LayOut
