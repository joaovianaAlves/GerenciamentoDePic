namespace Pic2024.models
{
    public class Eixo
    {
        public string Nome { get; set; }
        public List<Turma> Turmas { get; set; }

        public Eixo(string nome)
        {
            Nome = nome;
            Turmas = new List<Turma>
            {
                new Turma("14:00"),
                new Turma("14:50"),
                new Turma("15:40")
            };
        }

        public bool InscreverAluno(Aluno aluno)
        {
            // Encontra a primeira turma que ainda tem espaço para mais alunos
            var turmaDisponivel = Turmas.FirstOrDefault(turma => turma.Alunos.Count < 15);
            if (turmaDisponivel != null)
            {
                turmaDisponivel.Alunos.Add(aluno);
                return true;
            }

            return false;
        }

        // Lista de eixos fixos
        public static List<Eixo> EixosFixos = new List<Eixo>
        {
            new Eixo("CULTURA, SOCIEDADE E POLÍTICAS PÚBLICAS"),
            new Eixo("DIREITO E CIDADANIA"),
            new Eixo("PSICOLOGIA, COMPORTAMENTO E SAÚDE MENTAL"),
            new Eixo("ECONOMIA E ADMINISTRAÇÃO"),
            new Eixo("SUSTENTABILIDADE E AMBIENTES"),
            new Eixo("BIOQUÍMICA E SAÚDE: QUÍMICA MEDICINAL DE PLANTAS"),
            new Eixo("BIOQUÍMICA E SAÚDE: BIOQUÍMICA DOS SERES VIVOS"),
            new Eixo("CIÊNCIAS EXATAS, TECNOLOGIA E ENGENHARIA"),
            new Eixo("TECNOLOGIAS DIGITAIS APLICADAS")
        };
    }
}