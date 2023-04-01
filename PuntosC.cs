using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puntos
{
    public class PuntosC
    {
        public void punto1()
        {
            const double PRECIO = 650.0;
            const double DESCUENTO = 0.3;
            int cantidad;
            double total;

            Console.WriteLine("Ingrese la cantidad de jeans que comprará:");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad > 2)
            {
                total = cantidad * PRECIO * (1 - DESCUENTO);
            }
            else
            {
                total = cantidad * PRECIO;
            }
            Console.WriteLine("El total a pagar es: $" + total);
            Console.ReadKey();
        }
        public void punto2()
        {
            Console.Write("Ingrese la edad : ");
            int edad = int.Parse(Console.ReadLine());

            if (0 < edad && edad < 2)
            {
                Console.WriteLine("es un bebe");

            }
            else if (2 <= edad && edad < 12)
            {
                Console.WriteLine("es un niño");
            }
            else if (12 <= edad && edad < 18)
            {
                Console.WriteLine("es un joven");
            }
            else if (18 <= edad && edad < 30)
            {
                Console.WriteLine("es un adulto joven");
            }
            else if (30 <= edad && edad < 65)
            {
                Console.WriteLine("es un adulto");
            }
            else if (edad >= 65)
            {
                Console.WriteLine("es de tercera edad");
            }
            Console.ReadKey();
        }
        public void punto3()
        {
            double num1, num2, resultado;
            int operacion;

            Console.WriteLine("Ingrese el primer número:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - División");
            operacion = int.Parse(Console.ReadLine());

            switch (operacion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("La suma es: " + resultado);
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("La resta es: " + resultado);
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("La multiplicación es: " + resultado);
                    break;
                case 4:
                    resultado = num1 / num2;
                    Console.WriteLine("La división es: " + resultado);
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }
            Console.ReadKey();
        }
        double Function4(double x)
        {
            if (x <= 0)
            {
                return 0;
            }
            else
            {
                return Math.Pow(x, 2);
            }
        }
        public void punto4()
        {
            Console.WriteLine("ingrese el valor: ");
            double x = double.Parse(Console.ReadLine());
            double result = Function4(x);
            Console.WriteLine("El valor de la función en x={0} es {1}", x, result);
            Console.ReadKey();
        }
        public void punto5()
        {
            int[] numeros = new int[100];
            int num1 = 0, num5 = 0, num10 = 0, otros = 0;

            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                numeros[i] = rnd.Next(1, 11);
                if (numeros[i] == 1)
                {
                    num1++;
                }
                else if (numeros[i] == 5)
                {
                    num5++;
                }
                else if (numeros[i] == 10)
                {
                    num10++;
                }
                else
                {
                    otros++;
                }
            }

            Console.WriteLine("Se generaron " + num1 + " números iguales a 1.");
            Console.WriteLine("Se generaron " + num5 + " números iguales a 5.");
            Console.WriteLine("Se generaron " + num10 + " números iguales a 10.");
            Console.WriteLine("Se generaron " + otros + " números diferentes de 1, 5 y 10.");
            Console.ReadKey();
        }
        public void puntos6()
        {
            string[] diasTrabajo = new string[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            string[] diasFinSemana = new string[] { "Sábado", "Domingo" };
            int contDiasTrabajo = 0, contDiasFinSemana = 0;

            Console.WriteLine("Ingrese los días de trabajo del empleado (separados por coma):");
            string[] diasEmpleado = Console.ReadLine().Split(',');

            foreach (string dia in diasEmpleado)
            {
                if (Array.Exists(diasTrabajo, element => element == dia.Trim()))
                {
                    contDiasTrabajo++;
                }
                else if (Array.Exists(diasFinSemana, element => element == dia.Trim()))
                {
                    contDiasFinSemana++;
                }
            }

            Console.WriteLine("El empleado trabaja " + contDiasTrabajo + " días laborables.");
            Console.WriteLine("El empleado trabaja " + contDiasFinSemana + " días de fin de semana.");
            Console.ReadKey();
        }
        public void puntos7()
        {
            int notasMayoresIgualesA7 = 0;
            int notasMenoresA7 = 0;

            Console.WriteLine("Ingrese las notas de los alumnos (separadas por coma):");
            string[] notasString = Console.ReadLine().Split(',');

            foreach (string nota in notasString)
            {
                double notaDouble = Convert.ToDouble(nota.Trim());

                if (notaDouble >= 7.0)
                {
                    notasMayoresIgualesA7++;
                }
                else
                {
                    notasMenoresA7++;
                }
            }

            Console.WriteLine("Cantidad de alumnos con notas mayores o iguales a 7: " + notasMayoresIgualesA7);
            Console.WriteLine("Cantidad de alumnos con notas menores a 7: " + notasMenoresA7);
            Console.ReadKey();
        }
        public void punto8()
        {
            int notasMayoresIgualesA7 = 0;
            int notasMenoresA7 = 0;

            Console.WriteLine("Ingrese las notas de los alumnos (separadas por coma):");
            string[] notasString = Console.ReadLine().Split(',');

            foreach (string nota in notasString)
            {
                double notaDouble = Convert.ToDouble(nota.Trim());

                if (notaDouble >= 7.0)
                {
                    notasMayoresIgualesA7++;
                }
                else
                {
                    notasMenoresA7++;
                }
            }

            Console.WriteLine("Cantidad de alumnos con notas mayores o iguales a 7: " + notasMayoresIgualesA7);
            Console.WriteLine("Cantidad de alumnos con notas menores a 7: " + notasMenoresA7);
            Console.ReadKey();
        }
        public void punto9()
        {
            Console.WriteLine("Ingrese las coordenadas de los puntos (x,y). Presione Enter después de cada coordenada.");

            int numPuntos = 0;
            double sumaX = 0;
            double sumaY = 0;

            while (true)
            {
                Console.Write("Coordenada " + (numPuntos + 1) + ": ");

                string[] coordenadas = Console.ReadLine().Split(',');

                if (coordenadas.Length != 2)
                {
                    Console.WriteLine("Coordenada inválida. Debe ingresar dos valores separados por una coma.");
                }
                else
                {
                    double x;
                    double y;

                    if (Double.TryParse(coordenadas[0].Trim(), out x) && Double.TryParse(coordenadas[1].Trim(), out y))
                    {
                        sumaX += x;
                        sumaY += y;
                        numPuntos++;
                    }
                    else
                    {
                        Console.WriteLine("Coordenada inválida. Debe ingresar valores numéricos.");
                    }
                }

                if (numPuntos == 3)
                {
                    break;
                }
            }

            double promedioX = sumaX / numPuntos;
            double promedioY = sumaY / numPuntos;

            Console.WriteLine("El promedio de las coordenadas X es: " + promedioX.ToString("0.##"));
            Console.WriteLine("El promedio de las coordenadas Y es: " + promedioY.ToString("0.##"));
            Console.ReadKey();
        }
        public void punto10()
        {
            Console.Write("Ingrese la cantidad de puntos a procesar: ");
            int cantidadPuntos = int.Parse(Console.ReadLine());

            int cuadrante1 = 0;
            int cuadrante2 = 0;
            int cuadrante3 = 0;
            int cuadrante4 = 0;

            for (int i = 1; i <= cantidadPuntos; i++)
            {
                Console.WriteLine("Ingrese las coordenadas (x,y) del punto " + i + ":");
                Console.Write("x: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("y: ");
                double y = double.Parse(Console.ReadLine());

                if (x > 0 && y > 0)
                {
                    cuadrante1++;
                }
                else if (x < 0 && y > 0)
                {
                    cuadrante2++;
                }
                else if (x < 0 && y < 0)
                {
                    cuadrante3++;
                }
                else if (x > 0 && y < 0)
                {
                    cuadrante4++;
                }
            }

            Console.WriteLine("Cantidad de puntos en el primer cuadrante: " + cuadrante1);
            Console.WriteLine("Cantidad de puntos en el segundo cuadrante: " + cuadrante2);
            Console.WriteLine("Cantidad de puntos en el tercer cuadrante: " + cuadrante3);
            Console.WriteLine("Cantidad de puntos en el cuarto cuadrante: " + cuadrante4);
            Console.ReadKey();
        }
        public void punto11()
        {
            Console.Write("Ingrese la cantidad de números a procesar: ");
            int cantidadNumeros = int.Parse(Console.ReadLine());

            int pares = 0;
            int impares = 0;

            int i = 1;
            while (i <= cantidadNumeros)
            {
                Console.Write("Ingrese el número " + i + ": ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                i++;
            }

            Console.WriteLine("Cantidad de números pares: " + pares);
            Console.WriteLine("Cantidad de números impares: " + impares);
            Console.ReadKey();
        }
        public void punto12()
        {
            int numCuenta, saldo;
            int totalAcreedores = 0;

            do
            {
                Console.Write("Ingrese el número de cuenta (ingrese un número negativo para terminar): ");
                numCuenta = int.Parse(Console.ReadLine());

                if (numCuenta >= 0)
                {
                    Console.Write("Ingrese el saldo actual de la cuenta: ");
                    saldo = int.Parse(Console.ReadLine());

                    Console.Write("Cuenta " + numCuenta + ": ");

                    if (saldo > 0)
                    {
                        Console.WriteLine("Acreedor");
                        totalAcreedores += saldo;
                    }
                    else if (saldo < 0)
                    {
                        Console.WriteLine("Deudor");
                    }
                    else
                    {
                        Console.WriteLine("Nulo");
                    }
                }
            } while (numCuenta >= 0);

            Console.WriteLine("La suma total de los saldos acreedores es: " + totalAcreedores);
            Console.ReadKey();
        }
        public void punto13()
        {
            string nombre;
            double sueldo;

            Console.Write("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el sueldo del empleado: ");
            sueldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Nombre del empleado: {0}", nombre);
            Console.WriteLine("Sueldo del empleado: {0}", sueldo);

            if (sueldo > 3000)
            {
                Console.WriteLine("{0} debe pagar impuestos.", nombre);
            }
            else
            {
                Console.WriteLine("{0} no debe pagar impuestos.", nombre);
            }




        }
        public void punto14()
        {
            Console.Write("Ingrese la cantidad de elementos del vector: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese el elemento " + (i + 1) + ": ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            int menor = vector[0];
            bool repetido = false;

            for (int i = 1; i < n; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (vector[i] == menor && i != 0)
                {
                    repetido = true;
                    break;
                }
            }

            Console.WriteLine("El menor elemento del vector es " + menor);

            if (repetido)
            {
                Console.WriteLine("El menor elemento se repite dentro del vector.");
            }
            else
            {
                Console.WriteLine("El menor elemento no se repite dentro del vector.");
            }
            Console.ReadKey();
        }
    }
}
