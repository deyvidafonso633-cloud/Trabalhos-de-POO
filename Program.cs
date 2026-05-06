namespace Exercicio6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo v1 = new Veiculo("LD-123-AA", "Toyota", "Corolla", 2020, 15000);
            Veiculo v2 = new Veiculo("LD-456-BB", "Hyundai", "i10", 2019, 22000);
            Veiculo v3 = new Veiculo("LD-789-CC", "Kia", "Sportage", 2021, 10000);

            v1.ActualizarQuilometragem(500);
            v2.ActualizarQuilometragem(300);
            v3.ActualizarQuilometragem(700);

            v1.ApresentarDados();
            v2.ApresentarDados();
            v3.ApresentarDados();
        }
    }
}
