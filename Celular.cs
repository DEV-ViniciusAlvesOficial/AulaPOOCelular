namespace Aula4_POOCelular
{
    public class Celular
    {
        //Declarando variavel
        public string marca;
        public string tamanho;
        public string cor;

        //Variavel bool = Verifica se é verdadeiro ou falso :)
        public bool ligado;
        public string acao;

    //corcunda de camelo aA
        public string verAcao(){
            return acao;
        } 
        
        public string verMarca(){
            return marca;
        } 
        public string verTamanho(){
            return tamanho;
        } 
        public string verCor(){
            return cor;
        } 
           public bool verLigado(){
            return ligado;
        } 
    }
}