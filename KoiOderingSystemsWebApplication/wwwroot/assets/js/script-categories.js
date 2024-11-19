function addToCart(name, price) {
    // Lấy giỏ hàng từ localStorage (nếu chưa có, tạo mảng rỗng)
    let cart = JSON.parse(localStorage.getItem('cart')) || [];

    // Kiểm tra xem sản phẩm đã tồn tại trong giỏ hàng hay chưa
    const existingItemIndex = cart.findIndex(item => item.name === name);

    if (existingItemIndex !== -1) {
        // Nếu sản phẩm đã tồn tại, tăng số lượng
        cart[existingItemIndex].quantity += 1;
    } else {
        // Nếu chưa có sản phẩm, thêm mới
        cart.push({ name: name, price: price, quantity: 1 });
    }

    // Lưu giỏ hàng vào localStorage
    localStorage.setItem('cart', JSON.stringify(cart));

    // Chuyển hướng đến trang giỏ hàng
    window.location.href = 'cart.html';
}
