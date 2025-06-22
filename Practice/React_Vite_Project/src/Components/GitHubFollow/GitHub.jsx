import React, { useEffect, useState } from 'react';
import { useLoaderData } from 'react-router-dom';

function GitHub() {

    const data = useLoaderData()

//   const [data, setData] = useState({});

//   useEffect(() => {
//     fetch('https://api.github.com/users/Prasad-R-Patil') 
//       .then(response => response.json())
//       .then(data => {
//         console.log(data);
//         setData(data);
//       });
//   }, []);

  return (
    <div className="text-center m-4 bg-orange-700 text-white p-4 rounded shadow">
      <h2 className="text-xl font-bold mb-2">GitHub Follower Count</h2>
      <p className="text-lg">
        👥 Followers: <span className="font-mono">{data.followers}</span>
      </p>
      <img  src={data.avatar_url} alt="Git Picture" width={200}/>
    </div>
  );
}

export default GitHub;
export const GitHubInfoLoader = async() => {
    const response = await fetch('https://api.github.com/users/Prasad-R-Patil') 
    return response.json()
}