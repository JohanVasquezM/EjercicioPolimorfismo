using EjercicioPolimorfismo;

namespace EjercicioPolimorfismo
{
    public class Gato : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El gato hace: Miau Miau");
        }

        public override void Mover()
        {
            Console.WriteLine("El gato salta.");
        }
    }

}
