window.onload = () => {
    let button = document.querySelector("#BmiCalculator > input.bmibutton.bw");
 
    // Function for calculating BMI
    button.addEventListener("click", calculateBMI);
};

function calculateBMI(){
    let height=parseFloat(document.querySelector("#height").value);
    let weight=parseFloat(document.querySelector("#weight").value);
    let result=document.querySelector("#result");

    if(height==""|| isNaN(height)){
        result.innerHTML("Keine gültige Größe");
    }else if(weight==""|| isNaN(weight)){
        result.innerHTML("Kein gültiges Gewicht");
    }else {
        let bmi=(weight /((height * height)/ 10000)).toFixed(2);
    }
    if (bmi < 18.6) result.innerHTML =
            `Untergewicht : <span>${bmi}</span>`;
 
        else if (bmi >= 18.6 && bmi < 24.9) 
            result.innerHTML = 
                `Normal : <span>${bmi}</span>`;
 
        else result.innerHTML =
            `Übergewicht : <span>${bmi}</span>`;
    }
