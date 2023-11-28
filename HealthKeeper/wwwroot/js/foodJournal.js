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

function toggleInput(parentDiv) {
    const inputContainer = document.getElementById(`${parentDiv}InputContainer`);
    inputContainer.classList.toggle('show');
}

function addFood(parentDiv) {
    const foodInput = document.getElementById(`${parentDiv}Input`).value;
    if (foodInput.trim() !== '') {
        const foodList = document.getElementById(`${parentDiv}List`);
        const newFood = document.createElement('li');
        newFood.textContent = foodInput;
        foodList.appendChild(newFood);
        document.getElementById(`${parentDiv}Input`).value = '';
    } else {
        alert('Bitte geben Sie einen Wert ein.');
    }
}