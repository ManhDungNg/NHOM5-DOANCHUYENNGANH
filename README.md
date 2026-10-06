FE

NHOM5.FE/
├── public/
├── src/
│   ├── assets/                           # Chứa file tĩnh (Logo hệ thống, icon, ảnh sân cỏ mặc định)
│   │
│   ├── api/                              # Giao tiếp với Backend ASP.NET
│   │   ├── axiosClient.js                # Cấu hình Axios, tự động gắn token vào header
│   │   ├── auth.api.js                   # Gọi API Đăng ký, đăng nhập
│   │   ├── admin.api.js                  # Gọi API của Admin
│   │   ├── staff.api.js                  # Gọi API của Chủ sân/Nhân viên
│   │   └── customer.api.js               # Gọi API của Khách hàng
│   │
│   ├── components/                       # UI Components dùng chung (Shared)
│   │   ├── common/                       # Các component cơ bản: Button, Input, Modal, Table
│   │   └── layout/                       # Layout bao bọc bên ngoài các trang
│   │       ├── AdminLayout.jsx           # Sidebar quản trị, Topbar
│   │       ├── StaffLayout.jsx           # Giao diện tối ưu cho màn hình tại quầy lễ tân
│   │       └── CustomerLayout.jsx        # Navbar, Footer, Banner cho khách truy cập
│   │
│   ├── features/                         # CHIA THEO 3 ĐỐI TƯỢNG VÀ NGHIỆP VỤ (Khớp 100% Backend)
│   │   │
│   │   ├── auth/                         # XÁC THỰC
│   │   │   └── pages/
│   │   │       ├── LoginPage.jsx         # Đăng nhập SĐT/Email/Google/Facebook
│   │   │       ├── RegisterPage.jsx      # Khách hàng & Chủ sân đăng ký
│   │   │       └── ProfilePage.jsx       # Quản lý thông tin cá nhân
│   │   │
│   │   ├── admin/                        # NGHIỆP VỤ ADMIN QUẢN TRỊ HỆ THỐNG
│   │   │   └── pages/
│   │   │       ├── UserModerationPage.jsx    # Duyệt đăng ký, kích hoạt/khóa tài khoản khách & chủ sân
│   │   │       ├── PitchApprovalPage.jsx     # Duyệt sân mới
│   │   │       ├── CategoryConfigPage.jsx    # Cấu hình danh mục chung (Loại sân 5/7/11, khu vực, dịch vụ)
│   │   │       ├── CommissionConfigPage.jsx  # Quản lý hoa hồng nền tảng
│   │   │       ├── PromotionCodePage.jsx     # Tạo, quản lý mã khuyến mãi
│   │   │       ├── DisputeSupportPage.jsx    # Xử lý khiếu nại, duyệt/kiểm duyệt đánh giá vi phạm
│   │   │       ├── SubAdminRolesPage.jsx     # Phân quyền sub-admin
│   │   │       └── SystemRevenuePage.jsx     # Thống kê, báo cáo doanh thu toàn hệ thống
│   │   │
│   │   ├── staff/                        # NGHIỆP VỤ CHỦ SÂN / LỄ TÂN
│   │   │   └── pages/
│   │   │       ├── BookingMatrixPage.jsx     # Bảng lịch trực quan (Timeline ngày/tuần) & Đặt lịch thủ công
│   │   │       ├── ShiftManagementPage.jsx   # Hủy/đổi lịch, chuyển khung giờ cho khách
│   │   │       ├── PriceConfigPage.jsx       # Cấu hình bảng giá (giờ vàng/thường/lễ) & thời gian ca 60/90p
│   │   │       ├── InventoryPage.jsx         # Quản lý tồn kho dịch vụ (nước, đồ, bib, trọng tài)
│   │   │       ├── CheckInPage.jsx           # Quét QR / nhập mã đơn & Thu tiền mặt/chuyển khoản
│   │   │       └── StaffReportPage.jsx       # Thống kê doanh thu (sân/dịch vụ) & Tỷ lệ lấp đầy
│   │   │
│   │   └── customer/                     # NGHIỆP VỤ KHÁCH HÀNG (PLAYER)
│   │       └── pages/
│   │           ├── SearchPitchPage.jsx       # Tìm sân (vị trí, loại sân, giờ) & Xem sơ đồ Timeline trống
│   │           ├── BookingPage.jsx           # Chọn ca, chọn dịch vụ đi kèm & Đặt định kỳ
│   │           ├── CheckoutPage.jsx          # Thanh toán cọc/100% (VietQR, Momo, ZaloPay, VNPAY)
│   │           ├── BookingHistoryPage.jsx    # Xem lịch sử đặt, nhận mã QR/Code check-in
│   │           ├── ReviewPage.jsx            # Đánh giá chất lượng sân, thái độ
│   │           └── MatchMakingPage.jsx       # Bắt đối / Tìm đối thủ giao hữu
│   │
│   ├── routes/                           # QUẢN LÝ ĐIỀU HƯỚNG
│   │   ├── AppRoutes.jsx                 # Tổng hợp tất cả Route
│   │   └── ProtectedRoute.jsx            # Middleware bảo vệ trang (chặn User vào trang Admin/Staff)
│   │
│   ├── context/                          # QUẢN LÝ STATE TOÀN CỤC (Nếu dùng React Context thay cho Redux)
│   │   └── AuthContext.jsx               # Lưu thông tin User đang đăng nhập và Role
│   │
│   ├── utils/                            # HÀM TIỆN ÍCH DÙNG CHUNG
│   │   ├── formatters.js                 # Định dạng tiền VNĐ, định dạng ngày tháng
│   │   └── qrCodeScanner.js              # Hàm hỗ trợ đọc camera quét QR
│   │
│   ├── App.jsx                           # Component gốc
│   ├── main.jsx                          # Điểm neo vào index.html
│   └── index.css                         # CSS Global



BE
NHOM5.API/
│
├── Controllers/
│   ├── AuthController.cs              # Đăng ký, đăng nhập (SĐT/Email, Google/Facebook), Quản lý thông tin cá nhân[cite: 1]
│   ├── AdminController.cs             # Khóa/mở tài khoản, Phân quyền sub-admin, Duyệt chủ sân/sân mới[cite: 1]
│   ├── AdminConfigsController.cs      # Cấu hình danh mục (5/7/11, quận/huyện), Hoa hồng nền tảng, Mã khuyến mãi[cite: 1]
│   ├── AdminSupportsController.cs     # Xử lý khiếu nại tranh chấp, Duyệt/kiểm duyệt đánh giá[cite: 1]
│   ├── AdminReportsController.cs      # Báo cáo doanh thu toàn hệ thống[cite: 1]
│   ├── PitchesController.cs           # Tìm kiếm sân, Sơ đồ trực quan (Calendar/Timeline), Loại sân[cite: 1]
│   ├── StaffConfigsController.cs      # Cấu hình bảng giá (giờ vàng/thường, lễ), Thời gian tối thiểu 60/90p[cite: 1]
│   ├── StaffOperationsController.cs   # Booking Matrix, Đặt thủ công lễ tân, Check-in QR/nhập mã, Thu tiền tại chỗ[cite: 1]
│   ├── ServicesController.cs          # Quản lý dịch vụ tại chỗ, tồn kho, Chọn thêm áo bib/nước/trọng tài[cite: 1]
│   ├── BookingsController.cs          # Lịch sử đặt sân, Đặt cố định/định kỳ, Hủy/đổi khung giờ, Nhận mã check-in[cite: 1]
│   ├── PaymentsController.cs          # Thanh toán VietQR, Momo, ZaloPay, VNPAY[cite: 1]
│   ├── ReviewsController.cs           # Khách đánh giá mặt sân, dịch vụ, thái độ[cite: 1]
│   ├── MatchMakingController.cs       # Bắt đối / Tìm đối thủ[cite: 1]
│   └── StaffReportsController.cs      # Thống kê doanh thu sân, Tỷ lệ lấp đầy (Occupancy rate)[cite: 1]
│
├── Models/
│   ├── Common/
│   │   └── BaseEntity.cs
│   ├── User.cs                        # Tài khoản khách, chủ sân, Admin, Sub-admin[cite: 1]
│   ├── SystemCategory.cs              # Danh mục chung (Loại sân 5/7/11, Quận/Huyện)[cite: 1]
│   ├── Pitch.cs                       # Sân bóng[cite: 1]
│   ├── PriceConfig.cs                 # Bảng giá khung giờ, Thời gian 1 ca (60/90p)[cite: 1]
│   ├── PromotionCode.cs               # Mã khuyến mãi hệ thống[cite: 1]
│   ├── Booking.cs                     # Lịch đặt sân (Cố định/Định kỳ), Mã đặt sân QR/Code[cite: 1]
│   ├── ServiceItem.cs                 # Dịch vụ tại chỗ (Nước, Bib, Trọng tài) & Tồn kho[cite: 1]
│   ├── BookingService.cs              # Dịch vụ đính kèm trong đơn đặt sân[cite: 1]
│   ├── PaymentTransaction.cs          # Giao dịch Cọc, 100%, hoặc Trực tiếp tại quầy[cite: 1]
│   ├── PlatformCommission.cs          # Chính sách hoa hồng nền tảng[cite: 1]
│   ├── Review.cs                      # Đánh giá của khách hàng[cite: 1]
│   ├── Dispute.cs                     # Khiếu nại, tranh chấp[cite: 1]
│   └── MatchPost.cs                   # Bài đăng bắt đối/tìm đối thủ[cite: 1]
│
├── DTOs/
│   ├── Auth/
│   │   ├── LoginDto.cs                # Login SĐT/Email/Google/Facebook[cite: 1]
│   │   └── UserProfileDto.cs          # Quản lý thông tin cá nhân[cite: 1]
│   │
│   ├── Admin/
│   │   ├── UserModerationDto.cs       # Kích hoạt, khóa/mở tài khoản[cite: 1]
│   │   ├── PitchApprovalDto.cs        # Duyệt thông tin sân mới[cite: 1]
│   │   ├── CategoryConfigDto.cs       # Cấu hình loại sân, khu vực, dịch vụ đi kèm[cite: 1]
│   │   ├── CommissionPolicyDto.cs     # Quản lý chính sách hoa hồng[cite: 1]
│   │   ├── PromotionCodeDto.cs        # Tạo quản lý mã khuyến mãi[cite: 1]
│   │   ├── SubAdminRoleDto.cs         # Phân quyền sub-admin[cite: 1]
│   │   ├── DisputeResolutionDto.cs    # Xử lý khiếu nại tranh chấp[cite: 1]
│   │   ├── ReviewModerationDto.cs     # Duyệt/kiểm duyệt đánh giá[cite: 1]
│   │   └── SystemRevenueReportDto.cs  # Thống kê doanh thu toàn hệ thống[cite: 1]
│   │
│   ├── Staff/
│   │   ├── BookingMatrixDto.cs        # Bảng lịch trực quan Timeline[cite: 1]
│   │   ├── ManualBookingDto.cs        # Đặt lịch thủ công tại lễ tân[cite: 1]
│   │   ├── ChangeCancelShiftDto.cs    # Hủy/đổi lịch, chuyển khung giờ[cite: 1]
│   │   ├── PriceMatrixConfigDto.cs    # Cấu hình bảng giá giờ vàng/thường/lễ[cite: 1]
│   │   ├── ShiftDurationConfigDto.cs  # Cấu hình thời gian tối thiểu 60/90p[cite: 1]
│   │   ├── InventoryManagementDto.cs  # Quản lý tồn kho dịch vụ tại chỗ[cite: 1]
│   │   ├── CheckInDto.cs              # Quét mã QR / nhập mã đơn[cite: 1]
│   │   ├── CashCollectionDto.cs       # Thu tiền mặt/chuyển khoản phần còn lại[cite: 1]
│   │   ├── StaffRevenueReportDto.cs   # Thống kê doanh thu tách tiền sân/dịch vụ[cite: 1]
│   │   └── OccupancyRateReportDto.cs  # Thống kê tỷ lệ lấp đầy sân[cite: 1]
│   │
│   ├── Customer/
│   │   ├── PitchSearchDto.cs          # Tìm kiếm vị trí, loại sân, khung giờ[cite: 1]
│   │   ├── CalendarTimelineViewDto.cs # Xem sơ đồ trực quan sân trống[cite: 1]
│   │   ├── CreateBookingDto.cs        # Đặt sân cố định/định kỳ, chọn dịch vụ[cite: 1]
│   │   ├── BookingHistoryDto.cs       # Lịch sử đặt sân[cite: 1]
│   │   ├── PaymentGatewayDto.cs       # Thanh toán cọc/100% qua VietQR/Ví điện tử/VNPAY[cite: 1]
│   │   ├── AddReviewDto.cs            # Đánh giá chất lượng, thái độ[cite: 1]
│   │   └── FindOpponentDto.cs         # Đăng tin tìm đội giao hữu[cite: 1]
│
├── Services/
│   ├── Interfaces/                    # Các Interface định nghĩa logic cho từng Controller
│   │   ├── IAuthService.cs
│   │   ├── IAdminManagementService.cs
│   │   ├── IAdminReportService.cs
│   │   ├── IPitchSearchService.cs
│   │   ├── IBookingService.cs
│   │   ├── IStaffOperationService.cs
│   │   ├── IStaffReportService.cs
│   │   ├── IPaymentGatewayService.cs
│   │   └── IMatchMakingService.cs
│   └── Implementations/               # Các Class code logic thực tế implement từ Interface
│       ├── AuthService.cs
│       ├── AdminManagementService.cs
│       ├── BookingService.cs
│       └── ... (Tương ứng với các Interface phía trên)
│
├── Data/
│   └── ApplicationDbContext.cs        # File ánh xạ các Models thành bảng trong SQL Server
├── Middlewares/
├── Helpers/
├── appsettings.json
└── Program.cs


Database_Tables/
├── Users                      # Quản lý tài khoản và phân quyền (Admin, Chủ sân, Khách hàng)
├── SportComplexes             # Quản lý thông tin các cụm sân bóng lớn
├── SportComplexImages         # Lưu album ảnh chi tiết cho từng cụm sân (mặt cỏ, khán đài, chỗ để xe...)
├── Pitches                    # Quản lý danh sách sân con (sân 5, 7, 11) thuộc từng cụm
├── PriceRules                 # Cấu hình bảng giá thay đổi theo khung giờ, ngày lễ, cuối tuần
├── Bookings                   # Lưu thông tin đơn đặt sân tổng của khách hàng
├── BookingDetails             # Lưu chi tiết ngày giờ từng ca đá (hỗ trợ đặt lịch cố định)
├── PaymentTransactions        # Ghi nhận lịch sử giao dịch (thanh toán tiền cọc, hoàn tiền)
├── ExtraServices              # Quản lý kho dịch vụ bán kèm (nước uống, áo bib, trọng tài)
├── ServiceOrders              # Ghi lại số lượng dịch vụ khách đã mua/thuê trong mỗi ca đá
├── Reviews                    # Đánh giá và chấm điểm chất lượng sân từ khách hàng
└── MatchPosts                 # Các tin đăng tìm đội đá giao hữu (tính năng bắt đối)
