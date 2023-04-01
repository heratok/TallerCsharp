using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Puntos;

namespace menu
{
    public class Menu
    {
        static void Main(string[] args)
        {
            PuntosC puntosC = new PuntosC();
            int op;
            do
            {
                Console.WriteLine("---------MENU DESTACADOS---------");
                Console.WriteLine("1. Punto");
                Console.WriteLine("2. Punto");
                Console.WriteLine("3. Punto");
                Console.WriteLine("4. Punto");
                Console.WriteLine("5. Punto");
                Console.WriteLine("6. Punto");
                Console.WriteLine("7. Punto");
                Console.WriteLine("8. Punto");
                Console.WriteLine("9. Punto");
                Console.WriteLine("10. Punto");
                Console.WriteLine("11. Punto");
                Console.WriteLine("12. Punto");
                Console.WriteLine("13. Punto");
                Console.WriteLine("14. Punto");
                Console.WriteLine("15. Salir");
                Console.WriteLine("ESCOJA UNA OBCION DEL MENU: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        puntosC.punto1();
                        break;
                    case 2:
                        puntosC.punto2();
                        break;
                    case 3:
                        puntosC.punto3();
                        break;
                    case 4:
                        puntosC.punto4();
                        break;
                    case 5:
                        puntosC.punto5();
                        break;
                    case 6:
                        puntosC.puntos6();
                        break;
                    case 7:
                        puntosC.puntos7();
                        break;
                    case 8:
                        puntosC.punto8();
                        break;
                    case 9:
                        puntosC.punto9();
                        break;
                    case 10:
                        puntosC.punto10();
                        break;
                    case 11:
                        puntosC.punto11();
                        break;
                    case 12:
                        puntosC.punto12();
                        break;
                    case 13:
                        puntosC.punto13();
                        break;
                    case 14:
                        puntosC.punto14();
                        break;
                    case 15:
                        break;
                }
            } while (op != 15);

        }
    }
}
