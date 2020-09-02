namespace ApiRest.Domain.Entitys
{
    public class Cliente:Base
    {
       
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string dt_cadastro { get; set; }
        public bool isAtivo { get; set; }
            
    }
}
