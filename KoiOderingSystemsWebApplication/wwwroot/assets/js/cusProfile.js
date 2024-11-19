document.addEventListener('DOMContentLoaded', function () {
    // Lấy thông tin người dùng đang đăng nhập từ localStorage
    const loggedInUser = JSON.parse(localStorage.getItem('loggedInUser')) || {};

    console.log("Logged in user:", loggedInUser);

    // Kiểm tra vai trò của người dùng
    if (loggedInUser.role === "employee-sale") {
        // Nếu là Sales Staff, hiển thị danh sách khách hàng
        const users = JSON.parse(localStorage.getItem('users')) || [];

        // Lọc danh sách khách hàng
        const customers = users.filter(user => user.role === "guest");

        const customerTableBody = document.getElementById("customer-list");
        if (customers.length === 0) {
            document.getElementById("no-customers-msg").style.display = "block";
        } else {
            customers.forEach(customer => {
                const row = document.createElement("tr");
                row.innerHTML = `
                    <td>${customer.username || 'N/A'}</td>
                    <td>${customer.email || 'N/A'}</td>
                    <td>${customer.phone || 'N/A'}</td>
                `;
                customerTableBody.appendChild(row);
            });
        }
    } else if (loggedInUser.role === "guest") {
        // Nếu là khách hàng, hiển thị thông tin cá nhân
        document.getElementById('customer-name').textContent = loggedInUser.username || 'N/A';
        document.getElementById('customer-email').textContent = loggedInUser.email || 'N/A';
        document.getElementById('customer-phone').textContent = loggedInUser.phone || 'N/A';
    } else {
        // Vai trò khác không được phép truy cập trang này
        alert("Access restricted to this page.");
        window.location.href = "index-home.html";
    }
});
