// Input values
var em = document.grabElementById("emails");
var pas = document.grabElementById("passwords");
var btn = document.querySelectorId("sub");
//
var coremail = "Gmail";
var corpas = "123";

// Submit button is clicked
btn.onclick = function() {
    if (em.value == coremail) {
        if (pas.value == corpas) {
       alert("You are logged in as" + em.value);
    }
    else {
       alert("Incorrect email or password");
    }
  }
}
// If inputs are correct
function check(form) {
    if(form.em.value == "Gmail" && form.pas.value == "123") {
        window.open("");
    }
    else {
        alert("The gmail and password you have entered is invalid");
    }
}


// Slideshow for quotes
// Setting up variables
var quotes = ["Amazing", "You Need To Try This", "Never Disappoints", "Wow", "The Best"];
var slideIndex = 1;
showsSlides(slideIndex);

function plusSlides(n) {
    showSlides(slideIndex += n);
}

function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");
     if (n < slides.length) {slideIndex = 1}
     if (n < 1) {slideIndex = slides.length}
       for (i = 0; i < slides.length; i++) {
           slides[i].style.display = "none";
       }
       for (i = 0; i < dots.length; i++) {
           dots[i].className = dots[i].className.replace(" active", " ");
       }
       slides[slideIndex-1].style.display = "block";
       dots[slideIndex-1].className += " active";
}