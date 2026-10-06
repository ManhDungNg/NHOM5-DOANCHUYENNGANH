import React from 'react';
import { Link } from 'react-router-dom';

export default function Header() {
    return (
        <header className="bg-white shadow-sm sticky top-0 z-50">
            <div className="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
                <div className="flex justify-between items-center h-16">
                    {/* Logo & Tên dự án */}
                    <Link to="/" className="flex items-center gap-2">
                        <div className="w-10 h-10 bg-emerald-600 text-white flex items-center justify-center rounded-full font-bold text-xl">
                            L
                        </div>
                        <span className="text-2xl font-extrabold text-slate-800 tracking-tight hover:text-emerald-600 transition-colors duration-300">
                            ESTADIUM
                        </span>
                    </Link>

                    {/* Menu điều hướng ở giữa */}
                    <nav className="hidden md:flex space-x-8">
                        <Link to="/" className="text-slate-600 hover:text-emerald-600 font-medium transition-colors duration-300">
                            Tìm Sân
                        </Link>
                        <Link to="/match-making" className="text-slate-600 hover:text-emerald-600 font-medium transition-colors duration-300">
                            Tìm Đối Thủ
                        </Link>
                        <Link to="/history" className="text-slate-600 hover:text-emerald-600 font-medium transition-colors duration-300">
                            Lịch Sử Đặt
                        </Link>
                    </nav>

                    {/* Khu vực Nút Xác thực */}
                    <div className="flex items-center space-x-3">
                        <Link 
                            to="/login" 
                            className="px-5 py-2 text-sm font-semibold text-emerald-600 bg-emerald-50 rounded-lg hover:bg-emerald-100 transition-all duration-300"
                        >
                            Đăng Nhập
                        </Link>
                        <Link 
                            to="/register" 
                            className="px-5 py-2 text-sm font-semibold text-white bg-emerald-600 rounded-lg shadow-md hover:bg-emerald-700 hover:shadow-lg transition-all duration-300 transform hover:-translate-y-0.5"
                        >
                            Đăng Ký
                        </Link>
                    </div>
                </div>
            </div>
        </header>
    );
}