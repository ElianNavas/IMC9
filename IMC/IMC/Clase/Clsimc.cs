using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC.Clase
{
    public class Clsimc
    {
        //declaracion de variables
        public double peso, altura, edad, IMC;
        public string sexo, nombre;
        private const double KG = 2.2046;
       
        public double CalcularIMC(double peso, double altura)//metodos
        {
            IMC = peso / altura;
            IMC = Math.Pow(altura, 2);
            
            Console.WriteLine("Su Nombre es: " + nombre + " Su Edad es: " + edad + " Su Sexo es: " + sexo + " Su Peso es: " + peso + "Su Altura es: " + altura + " Su IMC es: " + IMC);
            return IMC;
        }
        public void ClasificarPeso()
        {
            if (IMC < 18.5)
            {
                Console.WriteLine($"Necesitas mejor alimentacion, estas muy delgado");
            }
            else if ((IMC >=18.5) && (IMC <=24.9))
            {
                Console.WriteLine($"Estas Bien, Tu Peso es el Ideal");
            }
            else if ((IMC <= 25.00) && (IMC >=29.9))
            {
                Console.WriteLine($"Tu Peso es superior al normal, estas en Sobrepeso");
            }
            else
            {
                Console.WriteLine($"Deberias de comer menos, Tienes problemas de obesidad");
            }
           
        }
        
        public string getnombre()
        {
            return nombre;
        }
        public void setname(string n)
        {
            nombre = n;
        }
        public double getedad()
        {
            return edad;
        }
        public void setedad(double ed)
        {
            edad = ed;
        }
        public string getsexo()
        {
            return sexo;
        }
        public void setsexo(string sex)
        {
            sexo = sex;
        }
        public double getPeso()
        {
            return peso;
        }
        public void setPeso(double pes)
        {
            peso = pes;
        }
        public double getaltura()
        {
            return altura;
        }
        public void setaltura(double alt)
        {
            altura = alt;
        }
        public double getIMC()
        {
            IMC = peso / altura;
            return IMC; 
        }
       
        //this.edad = 21;
        //this.sexo = 'F';
        //this.altura = 146;
        //this.peso = 95;

        //double pesoKG = this.peso / KG;
        //double estaturaMts = (double)this.altura / 100;
        //double altu = (Math.Pow(estaturaMts, 2));
        //this.imc = pesoKG / altu;
        //return imc.ToString();



    }
    }

