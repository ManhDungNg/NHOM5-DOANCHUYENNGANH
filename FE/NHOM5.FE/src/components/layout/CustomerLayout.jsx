import React from 'react';
import { Outlet } from 'react-router-dom';
import Header from './Header';
import Footer from './Footer';

export default function CustomerLayout() {
    return (
        <div className="flex flex-col min-h-screen bg-slate-50">
            {/* Thanh điều hướng phía trên */}
            <Header />

            {/* Phần nội dung chính (Content) */}
            <main className="flex-grow w-full max-w-7xl mx-auto px-4 sm:px-6 lg:px-8 py-8">
                {/* 
                  Outlet sẽ tự động render các trang con (như SearchPitchPage) vào đây.
                  Sau này làm dữ liệu ảnh sân, form tìm kiếm thì nó sẽ nằm gọn trong khoảng trắng này.
                */}
                <Outlet />
            </main>

            {/* Chân trang phía dưới */}
            <Footer />
        </div>
    );
}