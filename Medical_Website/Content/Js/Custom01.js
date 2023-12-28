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



$(document).ready(function () {
    $('.service-slider').slick({
        slidesToShow: 3, // Number of visible slides at once
        slidesToScroll: 1,
        autoplay: false,
        autoplaySpeed: 2000, // Set to 2000 for a 2-second delay between auto-slides
        infinite: true,
        dots: true, // Show navigation dots
        centerMode: true,
        focusOnSelect: true,
        variableWidth: true, // Allows variable width for the slides
        responsive: [
            {
                breakpoint: 768, // Adjust the settings for smaller screens if needed
                settings: {
                    slidesToShow: 1
                }
            }
        ]
    });
});
