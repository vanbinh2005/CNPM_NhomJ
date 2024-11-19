document.addEventListener('DOMContentLoaded', function () {
    // Lấy dữ liệu khách hàng từ localStorage
    const customer = JSON.parse(localStorage.getItem('customer')) || {};
    
    // Lấy dữ liệu lịch sử đơn hàng từ localStorage
    const orders = JSON.parse(localStorage.getItem('orderHistory')) || [];

    // Điền thông tin khách hàng vào trang
    if (customer) {
        document.getElementById('customer-name').textContent = customer.fullName || 'N/A';
        document.getElementById('customer-email').textContent = customer.email || 'N/A';
        document.getElementById('customer-phone').textContent = customer.phone || 'N/A';
    }

    // Điền lịch sử đơn hàng vào trang
    const orderHistoryList = document.getElementById('order-history-list');
    const noOrdersMsg = document.getElementById('no-orders-msg');
    orderHistoryList.innerHTML = ''; // Xóa các đơn hàng cũ

    if (orders.length === 0) {
        noOrdersMsg.style.display = 'block';
    } else {
        noOrdersMsg.style.display = 'none';
        orders.forEach(order => {
            const orderRow = document.createElement('tr');
            orderRow.innerHTML = `
                <td>${order.orderId}</td>
                <td>${order.date}</td>
                <td>${order.productName}</td>
                <td>${order.quantity}</td>
                <td>${order.totalPrice} ¥</td>
                <td class="status ${order.status.toLowerCase()}">${order.status}</td>
            `;
            orderHistoryList.appendChild(orderRow);
        });
    }
});
