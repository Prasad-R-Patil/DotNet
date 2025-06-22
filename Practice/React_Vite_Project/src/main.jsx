import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import { createBrowserRouter, createRoutesFromElements, Route, RouterProvider } from 'react-router-dom'
import LayOut from './LayOut.jsx'
import Home from './Components/Home/Home.jsx'
import About from './Components/About/About.jsx';       
import Contact from './Components/Contact/Contact.jsx'; 
import User from './Components/User/User.jsx'
import GitHub, { GitHubInfoLoader } from './Components/GitHubFollow/GitHub.jsx'

// const router = createBrowserRouter([
// {
//   path:'/',
//   element:<LayOut/>,
//   children:[
//     {
//       path:"",
//       element:<Home/>
//     },
//     {
//       path:"about",
//       element:<About/>
//     },
//     {
//       path:"contact",
//       element:<Contact/>
//     }
  
//   ]}

// ])


const router = createBrowserRouter(
  createRoutesFromElements(
    <Route path="/" element={<LayOut />}>
      <Route index element={<Home />} />
      <Route path="about" element={<About />} />
      <Route path="contact" element={<Contact />} />
      <Route path='user/:id' element={<User/>}/>
      <Route loader={GitHubInfoLoader}  path='github' element={<GitHub/>}/>
      <Route path="*" element={<div className="text-red-600 text-center mt-10 text-xl">404 Not Found</div>} />
    </Route>
  )
);

createRoot(document.getElementById('root')).render(
  <StrictMode>
    {/* <App /> */}

  <RouterProvider router={router}/>

  </StrictMode>,
)
