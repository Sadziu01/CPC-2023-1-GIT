const form = document.getElementById("quiz-form");

form.addEventListener('submit', (event) => {
    event.preventDefault();
    const answers = ['b', 'c'];

    for (let i = 1; i <= 2; i++) {
        const question = 'question'+i;
        const answer = form[question].value;
        let answerNr = "answer"+i;
        if (answer === answers[i-1]) {
            document.cookie = answerNr + "=correct";
        } else {
            document.cookie = answerNr + "=incorrect";
        }
        console.log(document.cookie);
    }
    window.location.href = "statistics.html";
});