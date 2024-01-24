namespace Pic2024.models
{
    public class Turma
    {
        public string Horario { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Turma(string horario)
        {
            Horario = horario;
            Alunos = new List<Aluno>();
        }
    }
}
