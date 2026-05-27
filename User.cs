namespace FluxoCaixa_Api
{   // entidade user
    public class User
    {
        public int Id { get; set; }
        public int CPF_CNPJ { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public int PermissionLevel { get; set; }
    }
}
