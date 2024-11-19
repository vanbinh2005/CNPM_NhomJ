function displayCartItems() {
    const cart = JSON.parse(localStorage.getItem('cart')) || [];
    const cartItemsDiv = document.getElementById('cart-items');
    cartItemsDiv.innerHTML = ''; // Xóa nội dung cũ

    if (cart.length === 0) {
        cartItemsDiv.innerHTML = '<p>Your shopping cart is empty!</p>';
    } else {
        cart.forEach((item, index) => {
            cartItemsDiv.innerHTML += `
                <div class="cart-item">
                 <div class="cart-item">
                    <img src="${item.image}" alt="${item.name}" class="cart-item-image">
                    <div class="cart-item-details">
                    <h3>${item.name}</h3>
                    <span><p>Price: ${item.price}$</p></span>
                    <span class="quantity">Quantity: 
            <button onclick="updateQuantity(${index}, -1)">-</button>
            ${item.quantity}
            <button onclick="updateQuantity(${index}, 1)">+</button>
        </span>
                    <button onclick="removeItem(${index})">Remove</button>
                </div>
            `;
        });
    }
}
function addToCart(name, price, image) {
    // Lấy giỏ hàng hiện tại từ localStorage (nếu có)
    const cart = JSON.parse(localStorage.getItem('cart')) || [];

    // Kiểm tra xem sản phẩm đã có trong giỏ hàng chưa
    const existingItemIndex = cart.findIndex(item => item.name === name);

    if (existingItemIndex === -1) {
        // Nếu sản phẩm chưa có trong giỏ, thêm sản phẩm mới
        cart.push({ name, price, quantity: 1, image });
    } else {
        // Nếu sản phẩm đã có, tăng số lượng sản phẩm lên 1
        cart[existingItemIndex].quantity += 1;
    }

    // Lưu giỏ hàng mới vào localStorage
    localStorage.setItem('cart', JSON.stringify(cart));

    // Hiển thị lại giỏ hàng sau khi thêm sản phẩm
    displayCartItems();
}

// Hàm hiển thị các sản phẩm trong giỏ hàng
function displayCartItems() {
    const cart = JSON.parse(localStorage.getItem('cart')) || [];
    const cartItemsDiv = document.getElementById('cart-items');
    cartItemsDiv.innerHTML = ''; // Xóa nội dung cũ

    if (cart.length === 0) {
        cartItemsDiv.innerHTML = '<p>Your shopping cart is empty!</p>';
    } else {
        cart.forEach((item, index) => {
            cartItemsDiv.innerHTML += `
                <div class="cart-item">
                    <img src="${item.image}" alt="${item.name}" class="cart-item-image">
                    <div class="cart-item-details">
                        <h3>${item.name}</h3>
                        <p>Price: ${item.price}$</p>
                        <span class="quantity">
                            Quantity: 
                            <button onclick="updateQuantity(${index}, -1)">-</button>
                            ${item.quantity}
                            <button onclick="updateQuantity(${index}, 1)">+</button>
                        </span>
                        <button onclick="removeItem(${index})">Remove</button>
                    </div>
                </div>
            `;
        });
    }
}


function updateQuantity(index, change) {
    const cart = JSON.parse(localStorage.getItem('cart'));
    cart[index].quantity += change;

    if (cart[index].quantity <= 0) {
        cart.splice(index, 1);
    }

    localStorage.setItem('cart', JSON.stringify(cart));
    displayCartItems();
}

function removeItem(index) {
    const cart = JSON.parse(localStorage.getItem('cart'));
    cart.splice(index, 1);
    localStorage.setItem('cart', JSON.stringify(cart));
    displayCartItems();
}
function goBack() {
    window.location.href = 'index-categories.html';
}

function calculateCartSummary() {
    const cart = JSON.parse(localStorage.getItem('cart')) || [];
    const shippingFee = 20;
    let totalPrice = 0;


    cart.forEach(item => {
        totalPrice += item.price * item.quantity;
    });


    document.getElementById('total-price').innerText = totalPrice.toLocaleString();
    document.getElementById('shipping-fee').innerText = shippingFee.toLocaleString();


    const grandTotal = totalPrice + shippingFee;
    document.getElementById('grand-total').innerText = grandTotal.toLocaleString();
}

document.addEventListener('DOMContentLoaded', () => {
    displayCartItems();
    calculateCartSummary();
});
function goToCheckout() {
    window.location.href = 'index-thanhtoan.html';
}
// Thanh toan
function confirmOrder() {
    alert("Thank you for your order! Your details will be processed.");
    window.location.href = 'confirmation.html';
}

function goToCart() {
    window.location.href = 'index-cart.html';
}

function goToShopping() {
    window.location.href = 'index-categories.html';
}
function validateForm() {
    const fullName = document.querySelector('input[placeholder="(kaji)"]').value;
    const email = document.querySelector('input[placeholder=""]').value;

    if (fullName === '' || email === '') {
        alert('Please fill out all required fields!');
        return false;
    }

    alert('Form submitted successfully!');
    return true;
}

// LỊCH SỬ MUA HÀNG 
function saveOrder() {
    const order = {
        orderId: '#12345',  // Mã đơn hàng
        date: new Date().toLocaleDateString(),  // Ngày đặt hàng
        productName: 'Japanies Koi Fish - Kohaku',  // Tên sản phẩm
        quantity: 1,  // Số lượng
        totalPrice: 100,  // Tổng giá tiền
        status: 'Đã Giao'  // Trạng thái đơn hàng
    };

    // Lấy lịch sử đơn hàng hiện tại từ localStorage
    const orders = JSON.parse(localStorage.getItem('orderHistory')) || [];

    // Thêm đơn hàng mới vào danh sách
    orders.push(order);

    // Lưu lại danh sách đơn hàng vào localStorage
    localStorage.setItem('orderHistory', JSON.stringify(orders));
}

// LỊCH SỬ ĐƠN HÀNG 
// Lưu thông tin đơn hàng vào localStorage khi thanh toán
function confirmOrder() {
    const cart = JSON.parse(localStorage.getItem('cart')) || [];
    const totalPrice = calculateTotalPrice(cart);
    const shippingFee = 20; // Phí vận chuyển
    const grandTotal = totalPrice + shippingFee;

    // Tạo thông tin đơn hàng
    const order = {
        orderId: '#12345',  // Mã đơn hàng, có thể sử dụng UUID hoặc một hệ thống tạo ID khác
        date: new Date().toLocaleDateString(),  // Ngày đặt hàng
        products: cart,  // Danh sách sản phẩm trong giỏ hàng
        totalPrice: totalPrice,
        shippingFee: shippingFee,
        grandTotal: grandTotal,
        status: 'Đang xử lý'  // Trạng thái đơn hàng
    };

    // Lưu đơn hàng vào lịch sử đơn hàng
    saveOrderHistory(order);

    // Thông báo đơn hàng thành công
    alert("Thank you for your order! Your details will be processed.");

    // Chuyển hướng đến trang xác nhận đơn hàng
    window.location.href = 'confirmation.html';
}

// Tính tổng tiền trong giỏ hàng
function calculateTotalPrice(cart) {
    let totalPrice = 0;
    cart.forEach(item => {
        totalPrice += item.price * item.quantity;
    });
    return totalPrice;
}

// Lưu lịch sử đơn hàng vào localStorage
function saveOrderHistory(order) {
    // Lấy lịch sử đơn hàng hiện tại từ localStorage
    const orderHistory = JSON.parse(localStorage.getItem('orderHistory')) || [];

    // Thêm đơn hàng mới vào danh sách
    orderHistory.push(order);

    // Lưu lại danh sách đơn hàng vào localStorage
    localStorage.setItem('orderHistory', JSON.stringify(orderHistory));
}



function generateOrderId() {
    const timestamp = Date.now(); // Lấy thời gian hiện tại (tính bằng millisecond)
    const randomPart = Math.floor(Math.random() * 10000); // Tạo một số ngẫu nhiên từ 0 đến 9999
    return `ORD-${timestamp}-${randomPart}`; // Kết hợp timestamp và số ngẫu nhiên để tạo orderId
}

const orderId = generateOrderId();
console.log(orderId); // Ví dụ output: ORD-1673832998496-9472


function displayOrderHistory() {
    const orders = JSON.parse(localStorage.getItem('orderHistory')) || [];
    const orderHistoryList = document.getElementById('order-history-list');
    const noOrdersMsg = document.getElementById('no-orders-msg');
    orderHistoryList.innerHTML = ''; // Clear any existing orders

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
}

document.addEventListener('DOMContentLoaded', displayOrderHistory);
