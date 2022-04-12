var state = false;
var toggleEye = () => {
    if (state) {
        document.getElementById("pwd").setAttribute("type", "password");
        document.getElementById("togglePassword").style.color = '#7a797e';
        state = false;
    }
    else {
        document.getElementById("pwd").setAttribute("type", "text");
        document.getElementById("togglePassword").style.color = '#5887ef';
        state = true;
    }
}
