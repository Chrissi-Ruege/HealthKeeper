const toggleBtn = document.querySelector(".navbar__toggleBtn");
const menu = document.querySelector(".navbar__menu");
const icons = document.querySelector(".navbar__icons");

toggleBtn.addEventListener("click", () => {
  // class attribute에 '.activ'를 추가 or 제거 (있을경우 제거 없을경우 추가)
  menu.classList.toggle("active");
  icons.classList.toggle("active");
});
