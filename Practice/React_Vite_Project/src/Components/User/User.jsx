import React from 'react'
import { useParams } from 'react-router-dom'

function User() {
    const {id} = useParams()
    return (
        <div className='bg-orange-600 text-white text-3xl'>
            User Id :{id}
        </div>
    )
}

export default User
