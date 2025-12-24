algoritmo "Pode dirigir?"
var
   AA, AN, T: Inteiro
inicio
      EscrevaL("Departamento de Transito")
      Escreva("Ano Atual (yyyy): ")
      Leia(AA)
      Escreva("Ano de Nascimento (yyyy): ")
      Leia(AN)
      T <- AA - AN
      Se (T >= 18)Entao
         EscrevaL("Você tem",T ," Anos e pode dirigir")
      senao
         EscrevaL("Você tem",T ," Anos e não pode dirigir")
      fimse
fimalgoritmo