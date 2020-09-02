namespace ApiRest.Domain.Entitys
{
    public class Produto : Base
    {

        public string nome { get; set; }
        public decimal valor { get; set; }
        public bool isAtivo { get; set; }

    }
}
