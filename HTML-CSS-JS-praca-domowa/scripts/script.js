setInterval(updateClock, 1000);

function updateClock() {
    let clock = document.getElementById("clock");
    let now = new Date();
    let timeString = now.toLocaleTimeString();

    clock.textContent = timeString;
  }

  