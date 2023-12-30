const imageUrl = 'image-source.jpg';
function hidePreloader() {
    const preloader = document.querySelector('.preloader');
    const mainContent = document.getElementById('main-content');
    preloader.style.display = 'none';
    mainContent.style.display = 'block';
}

setTimeout(() => {
    hidePreloader();
}, 1200); // Hide the preloader after 1 second

const mainImage = document.createElement('img');
mainImage.src = imageUrl;
mainImage.onload = hidePreloader;


const register_btn = document.querySelector("#my-register-btn");
const login_btn = document.querySelector("#my-login-btn");
const login = document.querySelector(".login");

login_btn.addEventListener("click", () => {
    login.classList.add("sign-up-mode");
});

register_btn.addEventListener("click", () => {
    login.classList.remove("sign-up-mode");
});

const myLoginModal = new bootstrap.Modal("#exampleModal2");

window.addEventListener('DOMContentLoaded', () => {
    setTimeout(() => {
        myLoginModal.show();
    }, 1700); // Add a delay of 2000 milliseconds (2 seconds) before showing the modal
});
