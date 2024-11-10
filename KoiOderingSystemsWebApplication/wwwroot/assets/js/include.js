function includeHTML() {
  const elements = document.querySelectorAll("[data-include]");
  let loadCount = elements.length; // Đếm số phần tử cần tải

  elements.forEach((el) => {
    const file = el.getAttribute("data-include");
    if (file) {
      fetch(file)
        .then(response => {
          if (!response.ok) throw new Error(`HTTP error! Status: ${response.status}`);
          return response.text();
        })
        .then(data => {
          el.innerHTML = data;
          el.removeAttribute("data-include");

          // Thực thi lại các script nếu có
          const scripts = el.querySelectorAll("script");
          scripts.forEach((script) => {
            const newScript = document.createElement("script");
            if (script.src) {
              newScript.src = script.src;
            } else {
              newScript.textContent = script.textContent;
            }
            document.head.appendChild(newScript).parentNode.removeChild(newScript);
          });

          loadCount--; // Giảm số phần tử cần tải sau khi tải xong

          // Khi tất cả các phần tử đã tải xong, gọi hàm updateAuthButton
          if (loadCount === 0) {
            updateAuthButton();
          }
        })
        .catch(error => console.error("Error loading file:", error));
    }
  });
}

// Gọi hàm để chèn HTML khi trang tải xong
window.onload = includeHTML;
