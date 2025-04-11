using System;

namespace x {

    class Persona {
        public string nombre;
        private int edad;
        public int dni;

        public Persona () {
            nombre = "x";
            edad = 5;
            dni = 14346758;
        }
        public Persona(string Nombre) {
            nombre = Nombre;
            edad = 10;
            dni = 87655462;
        }
        public Persona(string Nombre, int Edad, int DNI) {
            nombre = Nombre;
            edad = Edad;
            dni = DNI;
        }
        public int getedad() {
            return edad;
        } 
        public void setedad(int edad2) {
            edad = edad2;
        } 
 
        public void mostrarDatos() {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("DNI: " + dni);
        }

    }
    
    class calculadora {
        public int suma1 (int a,int b) {
            return a + b;
        }
        public double suma2 (double a, double b, double c) {
            return a + b + c;
        }
        public int suma3 (string mensaje, int a, int b) {
            Console.WriteLine(mensaje);
            return a + b;
        }
        public bool par (int a) {
            return a  % 2 ==0;
        }

    }
    
    class Program {
        static void Main(string[] args) {   
            Persona persona1 = new Persona("pedro",87, 988676);
            Persona persona2 = new Persona("juan", 54, 245644);
            Persona persona3 = new Persona("jose", 12, 6574981);

            persona1.mostrarDatos();

            persona2.mostrarDatos();

            persona3.mostrarDatos();

            calculadora op = new calculadora();
            int s1 = op.suma1 (5,9);
            Console.WriteLine($"Suma; {s1}");
            double s2 = op.suma2 (4.6, 7.9, 2.7);
            Console.WriteLine($"Suma: {s2}");
            int s3 = op.suma3("hola", 7, 9);
            Console.WriteLine($"Suma: {s3}");
            bool p = op.par (4);
            Console.WriteLine($"4 es par? {p}");
            bool impar = op.par(9);
            Console.WriteLine($"9 es par? {impar}");

        }
    }

}
