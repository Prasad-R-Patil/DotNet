import axios from "axios";


const JavaAxios = axios.create({

    baseURL:'http://localhost:8080/api'
});

JavaAxios.interceptors.request.use(config=>{
    config.headers={
        "Content-Type":"application/json"
    };
    return config;
});

export default JavaAxios;
