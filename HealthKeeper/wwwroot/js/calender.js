const modal = document.getElementById('modal');
const modalDate = document.getElementById('modalDate');
const eventInput = document.getElementById('eventInput');
const saveBtn = document.getElementById('saveBtn');
const closeBtn = document.querySelector('.close');
const calendarDays = document.getElementById('calendarDays');
const prevMonthBtn = document.getElementById('prevMonth');
const nextMonthBtn = document.getElementById('nextMonth');
const monthYear = document.getElementById('monthYear');
const weekdays = ['Mo', 'Di', 'Mi', 'Do', 'Fr', 'Sa', 'So'];

let currentDate = new Date();
let currentMonth = currentDate.getMonth();
let currentYear = currentDate.getFullYear();

function openModal(date) {
    modal.style.display = 'block';
    modalDate.textContent = date.toDateString();
}

function closeModal() {
    modal.style.display = 'none';
}

function generateCalendar() {

    calendarDays.innerHTML = '';

    const daysInMonth = new Date(currentYear, currentMonth + 1, 0).getDate();
    const firstDayOfMonth = new Date(currentYear, currentMonth, 1).getDay(); // Erste Tag des Monats

    monthYear.textContent = new Date(currentYear, currentMonth).toLocaleString('default', { month: 'long' }) + ' ' + currentYear;

    // Erzeuge leere Zellen für Tage vor dem ersten Tag des Monats
    for (let i = 0; i < firstDayOfMonth; i++) {
        const emptyDay = document.createElement('div');
        emptyDay.classList.add('empty');
        calendarDays.appendChild(emptyDay);
    }

    for (let i = 1; i <= daysInMonth; i++) {
        const date = new Date(currentYear, currentMonth, i);
        const dayElement = document.createElement('div');
        dayElement.textContent = i;
        dayElement.classList.add('day');
        dayElement.addEventListener('click', () => openModal(date));
        calendarDays.appendChild(dayElement);
    }


}

prevMonthBtn.addEventListener('click', () => {
    if (currentMonth === 0) {
        currentMonth = 11;
        currentYear--;
    } else {
        currentMonth--;
    }
    generateCalendar();
});

nextMonthBtn.addEventListener('click', () => {
    if (currentMonth === 11) {
        currentMonth = 0;
        currentYear++;
    } else {
        currentMonth++;
    }
    generateCalendar();
});

saveBtn.addEventListener('click', () => {
    const event = eventInput.value.trim();
    if (event !== '') {
        alert(`Event "${event}" saved for ${modalDate.textContent}`);
        eventInput.value = '';
        closeModal();
    } else {
        alert('Please enter an event.');
    }
});

closeBtn.addEventListener('click', () => {
    closeModal();
});

generateCalendar();
