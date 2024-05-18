using EjercicioPolimorfismo;


            // Crear una lista de animales
            Animal[] animales = new Animal[3];
            animales[0] = new Perro();
            animales[1] = new Gato();
            animales[2] = new Vaca();

            // Iterar sobre la lista de animales y mostrar sus sonidos y movimientos
            foreach (var animal in animales)
            {
                animal.HacerSonido();
                animal.Mover();
                Console.WriteLine(); // Añadir una línea en blanco para separar la salida de cada animal
            }
        
    
