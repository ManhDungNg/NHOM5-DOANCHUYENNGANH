import axiosClient from './axiosClient';

const authApi = {
    register: (data) => {
        return axiosClient.post('/Auth/register', data);
    },
    login: (data) => {
        return axiosClient.post('/Auth/login', data);
    }
};

export default authApi;