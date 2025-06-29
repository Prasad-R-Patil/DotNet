import axios from "axios";

const dotnetAxios=axios.create({
    baseURL:'https://localhost:7227/api'
});

dotnetAxios.interceptors.request.use(config=>{
    config.headers={
        "Content-Type":"application/json"
    };
    return config;
});

export default dotnetAxios;