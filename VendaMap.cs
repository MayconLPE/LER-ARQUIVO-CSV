using CsvHelper.Configuration;

namespace Ler_Gravar_DadosCSV;

    public class VendaMap : ClassMap<Venda>
    {
        public VendaMap()
        {
            Map(v => v.Id).Name("id");
            Map(v => v.NomeCliente).Name("nome_cliente");
            Map(v => v.NomePacote).Name("nome_pacote");
            Map(v => v.DataNascimento).Name("data_nascimento");
            Map(v => v.DataAtendimento).Name("data_atendimento");
            Map(v => v.CidadeEstado).Name("cidade_estado");
        }
        
    }
