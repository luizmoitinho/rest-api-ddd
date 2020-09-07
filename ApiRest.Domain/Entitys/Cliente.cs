namespace ApiRest.Domain.Entitys
{
    public class Cliente : Base
    {

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string dt_cadastro { get; set; }
        public bool isAtivo { get; set; }

    }
}
