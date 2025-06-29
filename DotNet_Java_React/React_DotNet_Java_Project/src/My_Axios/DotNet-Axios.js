import axios from "axios";

const DotNetAxios = axios.create({
  baseURL: "https://localhost:7277/api"
});


DotNetAxios.interceptors.request.use(config => {
  config.headers["Content-Type"] = "application/json";
  return config;
});

export default DotNetAxios;
