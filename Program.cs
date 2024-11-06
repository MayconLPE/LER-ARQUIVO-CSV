using CsvHelper;
using CsvHelper.Configuration;
using Ler_Gravar_DadosCSV;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true
        };

        using (var reader = new StreamReader("../../../Data.csv"))
        using (var csv = new CsvReader(reader, config))
        {
            csv.Context.RegisterClassMap<VendaMap>();

            var vendas = csv.GetRecord<Venda>();

            foreach (var venda in vendas)
            {
                Console.WriteLine($"Cliente: {venda.NomeCliente}. Pacote: {venda.NomePacote}");
            }
        }

        Console.Read();
    }
}