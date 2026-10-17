using PilaresPOO.Polimorfismo.Exercicios.exercicio_tres;

internal class program
{
    private static void Main(string[] args)
    {
        Instrumento instrumento = new Instrumento();
        Violao violao = new Violao();

        instrumento.Tocar();
        violao.Tocar();
    }
}