using System;
namespace AULA07ENCAPSULAMENTO
{
    public class Cartao
    {
        public string titular { get; set; }

        public string bandeira { get; set; }

        public string numero { get; set; }


        private string token = "wafjiaegjeahijsehakldslakjdalksjdlkajsdlkajdskl";

        protected string cvv { get; set; }


        public void AprovarCompra (){
            Console.WriteLine("Compra aprovada!");
        }

        private bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }
    }
}