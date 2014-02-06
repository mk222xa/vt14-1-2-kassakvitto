function send() {
    var doc = document;
    var textBox = doc.getElementById("UserInputTextBox");
    textBox.focus();
    textBox.select();
}

window.onload = send();