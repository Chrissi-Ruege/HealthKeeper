let currentDate = new Date();

window.onload = () => {
    updateDateDisplay();
};

function updateDateDisplay() {
    const dateElement = document.getElementById('currentDate');
    dateElement.textContent = currentDate.toDateString();
}

function showPreviousDay() {
    currentDate.setDate(currentDate.getDate() - 1);
    updateDateDisplay();
    // Hier Logik hinzufügen, um die Inhalte für den vorherigen Tag zu laden
}

function showNextDay() {
    currentDate.setDate(currentDate.getDate() + 1);
    updateDateDisplay();
    // Hier Logik hinzufügen, um die Inhalte für den nächsten Tag zu laden
}

function toggleInput() {
    const inputContainer = document.getElementById('inputContainer');
    inputContainer.classList.toggle('show');
}

function addBreakfast() {
    const breakfastInput = document.getElementById('breakfastInput').value;
    if (breakfastInput.trim() !== '') {
        const breakfastList = document.getElementById('breakfastList');
        const newBreakfast = document.createElement('li');
        newBreakfast.textContent = breakfastInput;
        breakfastList.appendChild(newBreakfast);
        document.getElementById('breakfastInput').value = '';
    } else {
        alert('Bitte geben Sie einen Wert ein.');
    }
}