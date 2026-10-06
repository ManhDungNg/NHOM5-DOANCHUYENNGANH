import React from 'react';
import { Routes, Route } from 'react-router-dom';
import LoginPage from '../features/auth/pages/LoginPage';
import RegisterPage from '../features/auth/pages/RegisterPage';
import CustomerLayout from '../components/layout/CustomerLayout';

// Tạo tạm một component giả cho trang tìm sân để test ruột của Layout
const SearchPitchPage = () => (
    <div className="text-center mt-20">
        <h2 className="text-3xl font-bold text-slate-700">Giao diện Tìm Sân Bóng</h2>
        <p className="text-slate-500 mt-4">Dữ liệu và hình ảnh các sân sẽ được đổ vào đây...</p>
    </div>
);

export default function AppRoutes() {
    return (
        <Routes>
            <Route path="/login" element={<LoginPage />} />
            <Route path="/register" element={<RegisterPage />} />
            <Route path="/" element={<CustomerLayout />}>
                <Route index element={<SearchPitchPage />} />
            </Route>
            
            <Route path="/staff" element={<div className="flex h-screen items-center justify-center text-2xl font-bold text-blue-600">Đây là trang chủ Chủ Sân (BookingMatrixPage)</div>} />
            <Route path="/admin" element={<div className="flex h-screen items-center justify-center text-2xl font-bold text-red-600">Đây là trang Quản trị Admin</div>} />
        </Routes>
    );
}