namespace ProjetoAula01.Entities
{
    public class Cliente
    {
        private Guid? _id;
        private string? _nome;
        private string? _cpf;
        private string? _email;
        public Guid? Id
        {
            set { _id = value; } //entrada
            get { return _id; } //saída
        }
        public string? Nome
        {
            set { _nome = value; } //entrada
            get { return _nome; } //saída
        }
        public string? Cpf
        {
            set { _cpf = value; }
            get { return _cpf; }
        }
        public string? Email
        {
            set { _email = value; }
            get { return _email; }
        }
    }
}
