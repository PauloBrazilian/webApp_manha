namespace webApp_manha.Entidade
{
    public class Produtos
    {
        public int ID { get; set; }
        public string DESCRICAO { get; set; }
        public decimal VALOR { get; set;}
        public bool ATIVO { get; set;}

        public int CategoriaId { get; set; }

        public Categorias Categoria { get; set; }

    }
}
