using EjercicioPolimorfismo;

namespace EjercicioPolimorfismo
{
    public class Vaca : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("La vaca hace: Muuu");
        }

        public override void Mover()
        {
            Console.WriteLine("La vaca camina.");
        }
    }

}
