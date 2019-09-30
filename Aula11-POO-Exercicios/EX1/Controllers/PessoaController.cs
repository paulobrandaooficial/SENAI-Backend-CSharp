using System;

namespace EX1.Controllers
{
    public class PessoaController
    {
        
        public void Cadastrar(){

        }

        public void Exibir(){

        }

        public string CalcularIMC(double peso, double altura){
            string retorno = "";

            double calculo = peso / Math.Pow(altura, 2);

            if(calculo < 18.5){
                retorno = "Abaixo do peso";
            }else if(calculo >= 18.5 && calculo < 25){
                retorno = "Peso Normal";
            }else if(calculo >= 25 && calculo < 30){
                retorno = "Sobrepeso";
            }else if(calculo >= 30 && calculo < 35){
                retorno = "Obesidade Grau I";
            }else if(calculo >= 35 && calculo < 40){
                retorno = "Obesidade Grau II";
            }else{
                retorno = "Obesidade Grau III";
            }

            return retorno;
        }

    }
}