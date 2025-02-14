namespace AlmoxarifadoBackAPI.Models
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Descricao { get; set; }
        public int UnidadeMedida { get; set; }
        public int EstoqueAtual { get; set; }
        public int Epermanente { get; set; }
        public int CodigoCategoria { get; set; }
    }
}
