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


const login = document.getElementById('login');
const registerBtn = document.getElementById('register');
const loginBtn = document.getElementById('login-btn');

registerBtn.addEventListener('click', () => {
    login.classList.add("active");
});

loginBtn.addEventListener('click', () => {
    login.classList.remove("active");
});

const myLoginModal = new bootstrap.Modal("#exampleModal2");
window.addEventListener('DOMContentLoaded', () => {
    setTimeout(() => {
        myLoginModal.show();
    }, 1800); 
});
