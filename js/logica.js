let puntajeA = 20;
let puntajeMaximo = 0;
let numeroAleatorio = Math.floor(Math.random() * 20) + 1;


const cambiarNumeroA = () => {
    numeroAleatorio = Math.floor(Math.random() * 20) + 1;
}

const adivinarNumero = () => {
    let numeroIngresado = parseInt(document.getElementById("numero").value);

    if (numeroIngresado == numeroAleatorio) {
        document.getElementById("resultado").innerHTML = "¡Ganaste!";
        puntajeA += puntajeMaximo;
        if (puntajeA > puntajeMaximo) {
            puntajeMaximo = puntajeA;
            document.getElementById("puntaje").innerHTML = " Puntaje máximo: " + puntajeMaximo;
            cambiarNumeroA();
        }
    } else if (numeroAleatorio < numeroIngresado) {
        document.getElementById("resultado").innerHTML = "No adivinaste, intenta de nuevo. Pista: El numero es menor al ingresado";
        puntajeA -= 1;
        if (puntajeA == 0) {
            document.getElementById("resultado").innerHTML = "Perdiste. El numero es: " + numeroAleatorio;
            puntajeA = 20;
            puntajeMaximo = 0;
            cambiarNumeroA();

        }
        document.getElementById("puntaje").innerHTML = "Puntaje actual: " + puntajeA + " - Puntaje máximo: " + puntajeMaximo;
    } else {
        document.getElementById("resultado").innerHTML = "No adivinaste, intenta de nuevo. Pista: El numero es mayor al ingresado";
        puntajeA -= 1;
        if (puntajeA == 0) {
            document.getElementById("resultado").innerHTML = "Perdiste, te quedaste sin intentos. El numero era: " + numeroAleatorio;
            puntajeA = 20;
            puntajeMaximo = 0;
            cambiarNumeroA();
        }
        document.getElementById("puntaje").innerHTML = "Puntaje actual: " + puntajeA + " - Puntaje máximo: " + puntajeMaximo;

    }
}
