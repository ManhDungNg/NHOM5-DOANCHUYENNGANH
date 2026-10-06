import React from 'react';
import { Link } from 'react-router-dom';

export default function Footer() {
    return (
        <footer className="bg-slate-900 text-slate-300 py-10 mt-auto border-t border-slate-800">
            <div className="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8 grid grid-cols-1 md:grid-cols-3 gap-8">
                <div className="space-y-4">
                    <h3 className="text-2xl font-extrabold text-emerald-500 tracking-tight">HỆ THỐNG ĐẶT SÂN</h3>
                    <p className="text-sm text-slate-400 leading-relaxed">
                        Nền tảng đặt sân bóng trực tuyến thông minh, giúp bạn dễ dàng tìm sân, bắt đối và thanh toán nhanh chóng chỉ trong vài thao tác.
                    </p>
                </div>

                <div className="space-y-4">
                    <h4 className="text-lg font-semibold text-white">Khám Phá</h4>
                    <ul className="space-y-2 text-sm">
                        <li><Link to="/" className="hover:text-emerald-400 transition-colors duration-300">Tìm sân quanh đây</Link></li>
                        <li><Link to="/match-making" className="hover:text-emerald-400 transition-colors duration-300">Đăng tin tìm đối thủ</Link></li>
                        <li><Link to="/register" className="hover:text-emerald-400 transition-colors duration-300">Trở thành đối tác (Chủ sân)</Link></li>
                    </ul>
                </div>

                <div className="space-y-4">
                    <h4 className="text-lg font-semibold text-white">Hỗ Trợ Khách Hàng</h4>
                    <ul className="space-y-2 text-sm">
                        <li>Hotline: <span className="text-emerald-400 font-medium">1900 6868</span></li>
                        <li>Trường Đại học Công nghiệp Hà Nội</li>
                    </ul>
                </div>
            </div>

            <div className="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8 mt-10 pt-6 border-t border-slate-800 text-center text-sm text-slate-500">
                <p>&copy; 2026 Đồ Án Chuyên Ngành NHÓM 5. Nguyễn Mạnh Dũng (Leader) - Sinh viên CNTT Khóa 2023. Mã SV: 2023602555.</p>
            </div>
        </footer>
    );
}