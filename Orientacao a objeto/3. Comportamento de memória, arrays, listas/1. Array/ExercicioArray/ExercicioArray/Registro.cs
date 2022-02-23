namespace ExercicioArray
{
    class Registro
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Registro(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
