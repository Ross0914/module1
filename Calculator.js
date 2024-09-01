let number1 = 0;
let number2 = 0;
let result = 0;

function convertNum() {
    number1 = Number(document.getElementById("number1").value);
    number2 = Number(document.getElementById("number2").value);
}

function addNum() {
    convertNum();
    result = number1 + number2;
    document.getElementById("output").innerText = String(result) ;
}

function subNum() {
    convertNum();
    result =number1 + number2;
    document.getElementById("output").innerText = String(result) ;
}

function multiNum() {
    convertNum();
    result = number1 * number2;
    document.getElementById("output").innerText = String(result) ;
}

function diviNum() {
    convertNum() ;
    result = number1 / number2;
    document.getElementById("output").innerText = String(result) ;
}

document.getElementById("add").addEventListener("click", addNum) ;
document.getElementById("sub").addEventListener("click", subNum) ;
document.getElementById("multi").addEventListener("click", multiNum) ;
document.getElementById("divi").addEventListener("click", diviNum) ;