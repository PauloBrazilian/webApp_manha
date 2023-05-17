using webApp_manha.Entidade;

namespace webApp_manha.Models
{
    public class NovoProdutoModelView : Produtos
    {

        public NovoProdutoModelView() 
        {
            ListaCategorias = new List<CategoriaEntidade>();
        }   

        public List<CategoriaEntidade> ListaCategorias { get; set; }
    
    }
}
