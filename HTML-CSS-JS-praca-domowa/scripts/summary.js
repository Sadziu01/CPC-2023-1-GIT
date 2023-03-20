function onLoad() {
    document.getElementById("item").innerHTML = document.cookie.split("/")[0];
    document.getElementById("price").innerHTML = document.cookie.split("/")[1];
}