namespace Aula10Polimorfismo
{
    public class Sonic : Player
    {
        public override void Correr(){
        System.Console.WriteLine("Sonic Corrreu");
            
    }

    public override void Atacar(){

    

        System.Console.WriteLine("Sonic   atacou  ");
    }
    public override void Enrolar(){
    
        
        System.Console.WriteLine("Sonic enrolou-se e acabou todos ");
    }
  }
}