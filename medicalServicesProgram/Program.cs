namespace medicalServicesProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testado a classe Receita
            Receita r1 = new Receita("Cafézinho", 23);

            Console.WriteLine(r1.Relatorio());
        }
    }
}
