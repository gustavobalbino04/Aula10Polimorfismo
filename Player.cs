namespace Aula10Polimorfismo
{
    public class Player
    {
        //virtual-permite outras classe fazer alterações 
        public virtual void Correr(){
            System.Console.WriteLine("Correndo rapido de mais ");
        }

        public virtual void Enrolar(){
            System.Console.WriteLine("Encolar para ativar a super velocidae");
        }

        public virtual void Atacar(){
            System.Console.WriteLine("Atacou ");
        }

        public virtual void Desviar(){
            System.Console.WriteLine("Desviar");
        }
    }
}       