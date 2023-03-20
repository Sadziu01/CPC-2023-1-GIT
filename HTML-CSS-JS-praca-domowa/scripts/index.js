let textArray = ["Zapraszamy również do sklepów stacjonarnych :)", "Najlepsze ceny!", "Najlepsi w tym co robią!", "Sprzęt i wyposażenie z najwyższej półki :D", "Zamów jeszcze dziś, a towar u ciebie będzie już jutro 0.0"];
let i = 0;

setInterval(function() {
  document.getElementById("dynamic-text").innerHTML = textArray[i];
  i++;
  if (i === textArray.length) {
    i = 0;
  }
}, 5000);

