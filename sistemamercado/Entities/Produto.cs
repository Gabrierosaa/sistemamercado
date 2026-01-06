namespace sistemamercado.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }
        public string? Descricao { get; set; }
        public int Id { get; set; }
        public int Estoque { get; set; }

        public Produto (string nome, double preco, string categoria, string? descricao, int id, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
            Descricao = descricao;
            Id = id;
            Estoque = estoque;
        }
    }
}
