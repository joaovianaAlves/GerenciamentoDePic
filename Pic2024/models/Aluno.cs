using Pic2024.models;
using System.Linq;

namespace Pic2024.models
{
    public class Aluno
    {
        public string NomeCompleto { get; set; }
        public string Turma { get; set; }
        public Eixo PicInscrito { get; private set; }
        public bool IsHighSchool { get; set; }
        public bool IsConventional { get; set; }

        public bool InscreverPic(Eixo pic)
        {
            // Verificar se o aluno já está inscrito em um PIC
            if (PicInscrito != null)
            {
                return false;
            }

            // Verificar se o PIC já atingiu o limite de alunos inscritos
            int limiteAlunos = IsHighSchool ? 30 : 45;
            if (pic.Turmas.Sum(turma => turma.Alunos.Count) >= limiteAlunos)
            {
                return false;
            }

            // Tentar inscrever o aluno no PIC
            if (pic.InscreverAluno(this))
            {
                PicInscrito = pic;
                return true;
            }

            return false;
        }
    }
}