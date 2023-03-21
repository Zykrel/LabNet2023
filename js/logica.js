let puntajeA = 10;
let puntajeMaximo = localStorage.getItem("Puntaje Maximo") ? parseInt(localStorage.getItem("Puntaje Maximo")) : 0;
let numeroAleatorio = Math.floor(Math.random() * 20) + 1;
document.getElementById("puntaje").innerHTML = "Puntaje: " + puntajeA + " - Puntaje máximo: " + puntajeMaximo;
const adivinarNumero = () => {
    let numero = parseInt(document.getElementById("numero").value);

    if (isNaN(numero) || numero < 1 || numero > 20) {
        document.getElementById("mensaje").innerHTML = `Por favor ingresa un numero valido entre 1 y 20`;
        return;
    }

    if (numero == numeroAleatorio) {
        document.getElementById("resultado").innerHTML = `¡Ganaste! <br/> Para continuar elija otro número <br/> <br/> <img src="../img/win.gif"/>`;
        puntajeA += puntajeMaximo;
        if (puntajeA > puntajeMaximo) {
            puntajeMaximo = puntajeA;
            localStorage.setItem("Puntaje Maximo", puntajeMaximo);
            document.getElementById("puntaje").innerHTML = " Tu puntaje es de : " + puntajeMaximo;
            confetti({
                particleCount: 500
            });
            cambiarNumeroA();
        }
    } else if (numeroAleatorio < numero) {
        document.getElementById("resultado").innerHTML = `No adivinaste, intenta de nuevo. <br/> Pista: El número es menor al ingresado `;
        puntajeA -= 1;
        if (puntajeA == 0) {
            document.getElementById("resultado").innerHTML = `Perdiste <br/> El numero era: ${numeroAleatorio} <br/> <br/> <img src="./../img/lose.gif"/>`;
            puntajeA = 10;
            cambiarNumeroA();

        }
        document.getElementById("puntaje").innerHTML = "Puntaje: " + puntajeA + " - Puntaje máximo: " + puntajeMaximo;
    } else {
        document.getElementById("resultado").innerHTML = `No adivinaste, intenta de nuevo. <br/> Pista: El número es mayor al ingresado`;
        puntajeA -= 1;
        if (puntajeA === 0) {
            document.getElementById("resultado").innerHTML = `Perdiste <br/> El numero era: ${numeroAleatorio} <br/> <br/> <img src="./../img/lose2.gif"/>`;
            puntajeA = 10;
            botonA = document.querySelector('#botonA').innerHTML = "reintentar"
            cambiarNumeroA();

        }
        document.getElementById("puntaje").innerHTML = "Puntaje: " + puntajeA + " - Puntaje máximo: " + puntajeMaximo;

    }


}

const cambiarNumeroA = () => {
    numeroAleatorio = Math.floor(Math.random() * 20) + 1;
}


const reiniciar = () => {
    puntajeA = 10;
    puntajeMaximo = localStorage.getItem("Puntaje Maximo") ? parseInt(localStorage.getItem("Puntaje Maximo")) : 0;
    numeroAleatorio = Math.floor(Math.random() * 20) + 1;
    document.getElementById("resultado").innerHTML = "";
    document.getElementById("numero").value = "";
    document.getElementById("mensaje").innerHTML = ``;
    document.getElementById("puntaje").innerHTML = "Puntaje: " + puntajeA + " - Puntaje máximo: " + puntajeMaximo;
}

const botonA = document.querySelector('#botonA')
botonA.addEventListener('click', adivinarNumero);



const botonR = document.querySelector('#reiniciarB')
botonR.addEventListener('click', reiniciar)





