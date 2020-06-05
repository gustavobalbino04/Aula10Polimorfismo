namespace Aula10Polimorfismo
{
    public class Dreggman : Player
    {
        //override-necessário para fazer a alteração
        public override void Atacar(){
       
        // Acrescento novas ações
        System.Console.WriteLine("Dr.Eggman atacou com robos ");
    }
     public override void Correr(){
         
        //base.Correr();( Mantém as ações do método pai)
        System.Console.WriteLine("Dr.Eggman correu atraz  ");
    }
    }
}