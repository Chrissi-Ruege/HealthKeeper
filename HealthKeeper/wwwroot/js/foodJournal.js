let currentDate = new Date();

function updateDateDisplay() {

    const dateElement = document.getElementById('currentDate');
    const today = new Date().toDateString();
    const currentDateStr = currentDate.toDateString();

    if (currentDateStr === today) {
        dateElement.textContent = 'Heute';
    } else {
        const yesterday = new Date(Date.now() - 86400000).toDateString();
        const tomorrow = new Date(Date.now() + 86400000).toDateString();

        if (currentDateStr === yesterday) {
            dateElement.textContent = 'Gestern';
        } else if (currentDateStr === tomorrow) {
            dateElement.textContent = 'Morgen';
        } else {
            const options = { weekday: 'long', day: 'numeric', month: 'long' };
            const formattedDate = currentDate.toLocaleDateString('de-DE', options);
            dateElement.textContent = formattedDate;
        }
    }
}

function showPreviousDay() {
    currentDate.setDate(currentDate.getDate() - 1);
    updateDateDisplay();
    hideInputContainer()
    // Hier Logik hinzufügen, um die Datenbankinhalte für den vorherigen Tag zu laden
}

function showNextDay() {
    currentDate.setDate(currentDate.getDate() + 1);
    updateDateDisplay();
    hideInputContainer()
    // Hier Logik hinzufügen, um die Datenbankinhalte für den nächsten Tag zu laden
}

function toggleInput(mealType) {
    const inputContainer = document.getElementById(`foodInputContainer`);
    const arrow = document.getElementById(`addFoodButtonArrow`);
    if (mealType !== undefined) {
        document.getElementById(`mealType`).value = mealType;
        inputContainer.classList.add('show');
        arrow.classList.add('rotate');
    } else if (mealType === undefined) {
        inputContainer.classList.toggle('show');
        arrow.classList.toggle('rotate');
    }
}

function hideInputContainer() {
    const inputContainer = document.getElementById(`foodInputContainer`);
    inputContainer.classList.remove('show');
    const arrow = document.getElementById(`addFoodButtonArrow`);
    arrow.classList.remove('rotate');
}

function addFood() {
    const name = document.getElementById(`foodName`).value;
    const mealType = document.getElementById(`mealType`).value;
    const portionSize = parseFloat(document.getElementById(`foodPortionSize`).value);
    const kcal = parseFloat(document.getElementById(`foodKcal`).value);
    const fat = parseFloat(document.getElementById(`foodFat`).value);
    const carbs = parseFloat(document.getElementById(`foodCarbs`).value);
    const protein = parseFloat(document.getElementById(`foodProtein`).value);

    if (name.trim() !== '' && portionSize.toString() !== 'NaN' && kcal.toString() !== 'NaN' && fat.toString() !== 'NaN' && carbs.toString() !== 'NaN' && protein.toString() !== 'NaN') {
        const calculatedPortion = portionSize * 100;
        const calculatedKcal = portionSize * kcal;
        const calculatedFat = portionSize * fat;
        const calculatedCarbs = portionSize * carbs;
        const calculatedProtein = portionSize * protein;

        const Kcal = (calculatedFat * 9 + calculatedCarbs * 4 + calculatedProtein * 4);
        if (Kcal >= calculatedKcal * 0.95 && Kcal <= calculatedKcal * 1.05) {
            createListItem(mealType, name, calculatedPortion, calculatedKcal, calculatedFat, calculatedCarbs, calculatedProtein);
            clearInputContainer();
        } else {
            alert('Die Summe der Kalorien aus Fetten, Kohlenhydraten und Proteinen stimme nicht mit den angegebenen Kalorien pro 100g/100ml überein.');
        }
    } else {
        alert('Bitte geben Sie nur gültige Werte ein.');
    }
}

function createListItem(mealType, name, calculatedPortion, calculatedKcal, calculatedFat, calculatedCarbs, calculatedProtein) {
    const listItem = document.createElement('li');
    listItem.className = 'list-item';

    const itemContent = document.createElement('div');
    itemContent.className = 'item-content';

    const upperPart = document.createElement('div');
    upperPart.className = 'upper-part';
    upperPart.textContent = name;

    const lowerPart = document.createElement('div');
    lowerPart.className = 'lower-part';
    const small = document.createElement('small');
    small.textContent = `${calculatedPortion.toFixed(2)} Gramm, ${calculatedKcal.toFixed(2)} Kcal, ${calculatedFat.toFixed(2)}g Fett, ${calculatedCarbs.toFixed(2)}g Kohlenhydrate, ${calculatedProtein.toFixed(2)}g Protein`;
    lowerPart.appendChild(small);

    const icons = document.createElement('div');
    icons.className = 'icons';

    const editIcon = document.createElement('span');
    editIcon.className = 'edit-icon';
    editIcon.innerHTML = '&#9998;';
    editIcon.addEventListener('click', function() {
        editListItem(mealType, listItem);
    });

    const deleteIcon = document.createElement('span');
    deleteIcon.className = 'delete-icon';
    deleteIcon.innerHTML = '&#128465;';
    deleteIcon.addEventListener('click', function() {
        deleteListItem(listItem)
    });

    icons.appendChild(editIcon);
    icons.appendChild(deleteIcon);
    itemContent.appendChild(upperPart);
    itemContent.appendChild(lowerPart);
    listItem.appendChild(itemContent);
    listItem.appendChild(icons);

    const list = document.getElementById(`${mealType}Liste`);
    list.appendChild(listItem);
}

function clearInputContainer() {
    document.getElementById(`foodName`).value = '';
    document.getElementById(`foodPortionSize`).value = '';
    document.getElementById(`foodKcal`).value = '';
    document.getElementById(`foodFat`).value = '';
    document.getElementById(`foodCarbs`).value = '';
    document.getElementById(`foodProtein`).value = '';
}

function editListItem (mealType, listItem) {
    toggleInput('');
    const upperPart = listItem.querySelector('.upper-part').textContent.trim();
    const lowerPart = listItem.querySelector('.lower-part').textContent.trim();
    const values = lowerPart.split(', ');

    const name = upperPart;
    const portionSize = parseFloat(values[0].split(' ')[0]) / 100; 
    const kcal = parseFloat(values[1].split(' ')[0]) / portionSize;
    const fat = parseFloat(values[2].split(' ')[0]) / portionSize;
    const carbs = parseFloat(values[3].split(' ')[0]) / portionSize;
    const protein = parseFloat(values[4].split(' ')[0]) / portionSize;

    document.getElementById(`foodName`).value = name;
    document.getElementById(`mealType`).value = mealType;
    document.getElementById(`foodPortionSize`).value = portionSize;
    document.getElementById(`foodKcal`).value = kcal;
    document.getElementById(`foodFat`).value = fat;
    document.getElementById(`foodCarbs`).value = carbs;
    document.getElementById(`foodProtein`).value = protein;

    deleteListItem(listItem)
}

function deleteListItem (listItem) {
    listItem.remove(); 
}

window.onload = () => {
    updateDateDisplay();
}