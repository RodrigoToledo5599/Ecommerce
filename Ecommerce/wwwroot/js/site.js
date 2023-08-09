const nightButton = document.getElementById('NightOrDay');
const body = document.body
var noite = false;


nightButton.addEventListener('click', toggleNight);

function toggleNight() {
    if (noite === false) {
        body.style.backgroundColor = "rgb(40,40,40)";
        noite = true;
    }
    else {
        body.style.backgroundColor = "rgb(255,255,255)";
        noite = false;
    }
}

