function handleSubmit(event){
    event.preventDefault();

    var name = document.getElementById("name").value;
    var email = document.getElementById("email").value;
    var message = document.getElementById("message").value;

    alert(name.split(" ")[0] + " odebraliśmy twoje zgłoszenie, zajrzyj na swój e-mail: " + email + " po więcej informacji.");

    document.getElementById("myForm").reset();
}