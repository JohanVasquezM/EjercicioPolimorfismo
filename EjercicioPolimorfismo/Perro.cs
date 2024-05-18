using EjercicioPolimorfismo;

namespace EjercicioPolimorfismo
{
    public class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro hace: Guau Guau");
        }

        public override void Mover()
        {
            Console.WriteLine("El perro corre.");
        }
    }

}
