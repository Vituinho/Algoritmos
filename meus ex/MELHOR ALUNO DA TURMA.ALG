algoritmo "Melhor aluno da turma"
var
   NumeroAlunos, cont: Inteiro
   NomeAluno, MelhorAluno: Caractere
   NotaAluno, MelhorNota: Real
inicio
   cont <- 0
   MelhorNota <- 0
   Escreva("Quantos alunos a turma tem? ")
   Leia(NumeroAlunos)
   Se cont < NumeroAlunos entao
      Enquanto cont < NumeroAlunos faca
         cont <- cont + 1
         Escreval("Aluno", cont)
         Escreva("Nome do aluno: ")
         Leia(NomeAluno)
         Escreva("Nota de ", NomeAluno, ": ")
         Leia(NotaAluno)
         Se MelhorNota < NotaAluno entao
            MelhorNota <- NotaAluno
            MelhorAluno <- NomeAluno
      fimse
   fimse
   Fimenquanto

   EscrevaL("O melhor aproveitamento foi de ",MelhorAluno , " com a nota ", MelhorNota)

fimalgoritmo
