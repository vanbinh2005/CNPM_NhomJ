// Lấy thông tin người dùng đã đăng nhập từ localStorage
document.addEventListener("DOMContentLoaded", () => {
    const loggedInUser = JSON.parse(localStorage.getItem("loggedInUser"));
  
    // Kiểm tra nếu người dùng không tồn tại hoặc không phải là manager
    if (!loggedInUser || loggedInUser.role !== "manager") {
      alert("Access denied. Only managers can access this page.");
      window.location.href = "index-login.html"; // Chuyển hướng về trang login
      return;
    }
  
    // Hiển thị thông tin trong bảng
    const managementTable = document.getElementById("managementTable");
  
    // Tạo dòng thông tin người dùng
    const row = document.createElement("tr");
  
    const nameCell = document.createElement("td");
    nameCell.textContent = loggedInUser.username; // Lấy tên đăng nhập
    row.appendChild(nameCell);
  
    const emailCell = document.createElement("td");
    emailCell.textContent = loggedInUser.email; // Lấy email
    row.appendChild(emailCell);
  
    const phoneCell = document.createElement("td");
    phoneCell.textContent = loggedInUser.phone; // Lấy số điện thoại
    row.appendChild(phoneCell);
  
    const positionCell = document.createElement("td");
    positionCell.textContent = loggedInUser.role; // Lấy chức vụ
    row.appendChild(positionCell);
  
    managementTable.appendChild(row);
  });
  