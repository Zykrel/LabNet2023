        let puntajeMaximo = 0;
        let puntajeActual = 10;
        let numeroAleatorio = Math.floor(Math.random() * 10) + 1;

        const adivinarNumero = () => {
            let numeroIngresado = document.getElementById("numero").value;
            if (numeroIngresado == numeroAleatorio) {
                document.getElementById("resultado").innerHTML = "¡Ganaste!";
                puntajeActual += 5;
                if (puntajeActual > puntajeMaximo) {
                    puntajeMaximo = puntajeActual;
                }
                document.getElementById("puntaje").innerHTML = "Puntaje actual: " + puntajeActual + " - Puntaje máximo: " + puntajeMaximo;
                numeroAleatorio = Math.floor(Math.random() * 10) + 1;
            } else {
                document.getElementById("resultado").innerHTML = "No adivinaste, intenta de nuevo";
                puntajeActual -= 1;
                if (puntajeActual == 0) {
                    document.getElementById("resultado").innerHTML = "Perdiste";
                    puntajeActual = 10;
                    puntajeMaximo = 0;
                }
                document.getElementById("puntaje").innerHTML = "Puntaje actual: " + puntajeActual + " - Puntaje máximo: " + puntajeMaximo;
            }
        }
 