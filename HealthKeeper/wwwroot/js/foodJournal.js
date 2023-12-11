{
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
        hideAllInputContainer()
        // Hier Logik hinzufügen, um die Datenbankinhalte für den nächsten Tag zu laden
    }
}

window.onload = () => {
    updateDateDisplay();
}

function toggleInput(mealType) {
    hideOtherInputContainers(mealType);
    const inputContainer = document.getElementById(`${mealType}InputContainer`);
    const arrow = document.getElementById(`${mealType}Arrow`);
    inputContainer.classList.toggle('show');
    arrow.classList.toggle('rotate');
}

function hideOtherInputContainers(mealType) {
    const inputContainers = document.querySelectorAll('.input-container');
    const arrows = document.querySelectorAll('.arrow');
    inputContainers.forEach(container => {
        if(container != document.getElementById(`${mealType}InputContainer`)){
            container.classList.remove('show');
        }
    });
    arrows.forEach(arrow => {
        if(arrow != document.getElementById(`${mealType}Arrow`)){
            arrow.classList.remove('rotate');
        }
    });
}

function hideAllInputContainer() {
    const inputContainers = document.querySelectorAll('.input-container');
    inputContainers.forEach(container => {
        container.classList.remove('show');
    });
    const arrows = document.querySelectorAll('.arrow');
    arrows.forEach(arrow => {
        arrow.classList.remove('rotate');
    });
}

function addFood(parentDiv) {
    const foodName = document.getElementById(`${parentDiv}Name`).value;
    if (foodName.trim() !== '') {
        const foodList = document.getElementById(`${parentDiv}List`);
        const newFood = document.createElement('li');
        newFood.textContent = foodName;
        foodList.appendChild(newFood);
        document.getElementById(`${parentDiv}Name`).value = '';
    } else {
        alert('Bitte geben Sie einen Wert ein.');
    }
}

function addFood(mealType) {
    const name = document.getElementById(`${mealType}Name`).value;
    const portionSize = parseFloat(document.getElementById(`${mealType}PortionSize`).value);
    const kcal = parseFloat(document.getElementById(`${mealType}Kcal`).value);
    const fat = parseFloat(document.getElementById(`${mealType}Fat`).value);
    const carbs = parseFloat(document.getElementById(`${mealType}Carbs`).value);
    const protein = parseFloat(document.getElementById(`${mealType}Protein`).value);

    if (name.trim() !== '' && portionSize.toString() !== 'NaN' && kcal.toString() !== 'NaN' && fat.toString() !== 'NaN' && carbs.toString() !== 'NaN' && protein.toString() !== 'NaN') {
        const calculatedPortion = portionSize * 100;
        const calculatedKcal = portionSize * kcal;
        const calculatedFat = portionSize * fat;
        const calculatedCarbs = portionSize * carbs;
        const calculatedProtein = portionSize * protein;

        createListItem(mealType, name, calculatedPortion, calculatedKcal, calculatedFat, calculatedCarbs, calculatedProtein);
        clearInputContainer(mealType);
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

    const list = document.getElementById(`${mealType}List`);
    list.appendChild(listItem);
}

function clearInputContainer(mealType) {
    document.getElementById(`${mealType}Name`).value = '';
    document.getElementById(`${mealType}PortionSize`).value = '';
    document.getElementById(`${mealType}Kcal`).value = '';
    document.getElementById(`${mealType}Fat`).value = '';
    document.getElementById(`${mealType}Carbs`).value = '';
    document.getElementById(`${mealType}Protein`).value = '';
}

function editListItem (mealType, listItem) {
    const upperPart = listItem.querySelector('.upper-part').textContent.trim();
    const lowerPart = listItem.querySelector('.lower-part').textContent.trim();
    const values = lowerPart.split(', ');

    const name = upperPart;
    const portionSize = parseFloat(values[0].split(' ')[0]) / 100; 
    const kcal = parseFloat(values[1].split(' ')[0]) / portionSize;
    const fat = parseFloat(values[2].split(' ')[0]) / portionSize;
    const carbs = parseFloat(values[3].split(' ')[0]) / portionSize;
    const protein = parseFloat(values[4].split(' ')[0]) / portionSize;

    document.getElementById(`${mealType}Name`).value = name;
    document.getElementById(`${mealType}PortionSize`).value = portionSize;
    document.getElementById(`${mealType}Kcal`).value = kcal;
    document.getElementById(`${mealType}Fat`).value = fat;
    document.getElementById(`${mealType}Carbs`).value = carbs;
    document.getElementById(`${mealType}Protein`).value = protein;

    deleteListItem(listItem)
}

function deleteListItem (listItem) {
    listItem.remove(); 
}