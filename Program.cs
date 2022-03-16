using Examen1.Models;
namespace Examen1
{
    class Program
    {
        private List<Dados> _dado;
        private List<Dinero> _mony;
        private int monto = 300;
        private int ganado = 0;
        private int perdido = 0;
        private int tiradas = 0;
        private int extremos = 0;
        private int medios = 0;
        private int pares = 0;
        private int impares = 0;
        private int bandera_j = 0;
        private int bandera = 0;

        public Program()
        {
            _dado = new List<Dados>();
            _mony = new List<Dinero>();
        }
        public void juegoDados()
        {
            do
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("Bienvenido al juego de la perdicion");
                    Console.WriteLine("1.- Tirar dados");
                    Console.WriteLine("2.- Historial de tiradas");
                    Console.WriteLine("3.- Estadisticas");
                    Console.WriteLine("4.- Salir");
                } while (!validacion(4, ref bandera));

                switch (bandera)
                {
                    case 1:
                        MenuDeJuego();
                        break;
                    case 2:
                        HistorialJuego();
                        break;
                    case 3:
                        Estadisticas();
                        break;
                    case 4:
                        foreach (Dinero item in _mony)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        Console.Write("Pulsa enter para contunuar...");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            } while (bandera != 4);

        }

        private void Estadisticas()
        {
            Dinero dinero = new Dinero(monto, ganado, perdido);
            _mony.Add(dinero);
            Console.Write("Balance: ");
            Console.WriteLine(dinero.ToString());
            Console.WriteLine("Cantidad de tiradas realizadas: " + tiradas);
            Console.WriteLine("Cantidad de resultados extremos: " + extremos);
            Console.WriteLine("Cantidad de resultados medios: " + medios);
            Console.WriteLine("Cantidad de resultados pares: " + pares);
            Console.WriteLine("Cantidad de resultados impares: " + impares);
            Console.Write("Pulsa enter para contunuar...");
            Console.ReadLine();
        }

        private void HistorialJuego()
        {
            int i = 1;
            foreach (Dados item in _dado)
            {
                Console.WriteLine("Tirada: " + i);
                Console.WriteLine(item.ToString());
                i = i + 1;
            }
            Console.Write("Pulsa enter para contunuar...");
            Console.ReadLine();
        }

        private void MenuDeJuego()
        {
            do
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("Modos de juego");
                    Console.WriteLine("1.- Demente (Apostar a un numero especifico (2-12), que multiplicara su apuesta por 10)");
                    Console.WriteLine("2.- Heroico (Apostar a que el numero es un extremo (2, 3, 4, 10, 11 ó 12), que multiplicara su apuesta por 8)");
                    Console.WriteLine("3.- Valiente (Apostar a que el número es un medio (5, 6, 7, 8 ó 9), que multiplicará su apuesta por 4.)");
                    Console.WriteLine("4.- A la segura (Apostar si el número será par o impar, que multiplicará su apuesta por 2)");
                    Console.WriteLine("5.- Salir");
                } while (!validacion(5, ref bandera_j));

                switch (bandera_j)
                {
                    case 1:
                        int apuesta = 0;
                        int num_s;
                        Random rnd = new Random();
                        int num_d1 = rnd.Next(1, 7);
                        int num_d2 = rnd.Next(1, 7);
                        int valor_r = num_d1 + num_d2;
                        if (valor_r == 2 || valor_r == 3 || valor_r == 4 || valor_r == 10 || valor_r == 11 || valor_r == 12)
                        {
                            extremos = extremos + 1;
                        }
                        if (valor_r == 5 || valor_r == 6 || valor_r == 7 || valor_r == 8 || valor_r == 9)
                        {
                            medios = medios + 1;
                        }
                        if (valor_r % 2 == 0)
                        {
                            pares = pares + 1;
                        }
                        if (valor_r % 2 != 0)
                        {
                            impares = impares + 1;
                        }
                        Console.Write("Elige un numero del 2 al 12: ");
                        int.TryParse(Console.ReadLine(), out num_s);
                        Console.Write("Realiza tu apuesta: ");
                        int.TryParse(Console.ReadLine(), out apuesta);
                        Dados dado1 = new Dados(num_d1, 1);
                        Dados dado2 = new Dados(num_d2, 2);
                        _dado.Add(dado1);
                        _dado.Add(dado2);
                        Console.WriteLine(dado1.ToString());
                        Console.WriteLine(dado2.ToString());
                        if (num_s == valor_r)
                        {
                            Console.WriteLine("Felicidades!");
                            apuesta = apuesta * 10;
                            monto = monto + apuesta;
                            ganado = ganado + apuesta;
                        }
                        else
                        {
                            Console.WriteLine("Mala suerte");
                            apuesta = apuesta * 10;
                            monto = monto - apuesta;
                            perdido = perdido + apuesta;
                            Console.WriteLine("Numero correcto: " + valor_r);
                        }
                        Console.Write("Pulsa enter para contunuar...");
                        Console.ReadLine();
                        tiradas = tiradas + 1;
                        break;
                    case 2:
                        int apuesta2 = 0;
                        Random rnd2 = new Random();
                        int num_d12 = rnd2.Next(1, 7);
                        int num_d22 = rnd2.Next(1, 7);
                        int valor_r2 = num_d12 + num_d22;
                        if (valor_r2 == 2 || valor_r2 == 3 || valor_r2 == 4 || valor_r2 == 10 || valor_r2 == 11 || valor_r2 == 12)
                        {
                            extremos = extremos + 1;
                        }
                        if (valor_r2 == 5 || valor_r2 == 6 || valor_r2 == 7 || valor_r2 == 8 || valor_r2 == 9)
                        {
                            medios = medios + 1;
                        }
                        if (valor_r2 % 2 == 0)
                        {
                            pares = pares + 1;
                        }
                        if (valor_r2 % 2 != 0)
                        {
                            impares = impares + 1;
                        }
                        Console.Write("Realiza tu apuesta: ");
                        int.TryParse(Console.ReadLine(), out apuesta2);
                        Dados dado12 = new Dados(num_d12, 1);
                        Dados dado22 = new Dados(num_d22, 2);
                        _dado.Add(dado12);
                        _dado.Add(dado22);
                        Console.WriteLine(dado12.ToString());
                        Console.WriteLine(dado22.ToString());
                        if (valor_r2 == 2 || valor_r2 == 3 || valor_r2 == 4 || valor_r2 == 10 || valor_r2 == 11 || valor_r2 == 12)
                        {
                            Console.WriteLine("Felicidades!");
                            apuesta2 = apuesta2 * 8;
                            monto = monto + apuesta2;
                            ganado = ganado + apuesta2;
                        }
                        else
                        {
                            Console.WriteLine("Mala suerte");
                            apuesta2 = apuesta2 * 8;
                            monto = monto - apuesta2;
                            perdido = perdido + apuesta2;
                            Console.WriteLine("Numero generado: " + valor_r2);
                        }
                        Console.Write("Pulsa enter para contunuar...");
                        Console.ReadLine();
                        tiradas = tiradas + 1;
                        break;
                    case 3:
                        int apuesta3 = 0;
                        Random rnd3 = new Random();
                        int num_d13 = rnd3.Next(1, 7);
                        int num_d23 = rnd3.Next(1, 7);
                        int valor_r3 = num_d13 + num_d23;
                        if (valor_r3 == 2 || valor_r3 == 3 || valor_r3 == 4 || valor_r3 == 10 || valor_r3 == 11 || valor_r3 == 12)
                        {
                            extremos = extremos + 1;
                        }
                        if (valor_r3 == 5 || valor_r3 == 6 || valor_r3 == 7 || valor_r3 == 8 || valor_r3 == 9)
                        {
                            medios = medios + 1;
                        }
                        if (valor_r3 % 2 == 0)
                        {
                            pares = pares + 1;
                        }
                        if (valor_r3 % 2 != 0)
                        {
                            impares = impares + 1;
                        }
                        Console.Write("Realiza tu apuesta: ");
                        int.TryParse(Console.ReadLine(), out apuesta3);
                        Dados dado13 = new Dados(num_d13, 1);
                        Dados dado23 = new Dados(num_d23, 2);
                        _dado.Add(dado13);
                        _dado.Add(dado23);
                        Console.WriteLine(dado13.ToString());
                        Console.WriteLine(dado23.ToString());
                        if (valor_r3 == 5 || valor_r3 == 6 || valor_r3 == 7 || valor_r3 == 8 || valor_r3 == 9)
                        {
                            Console.WriteLine("Felicidades!");
                            apuesta3 = apuesta3 * 4;
                            monto = monto + apuesta3;
                            ganado = ganado + apuesta3;
                        }
                        else
                        {
                            Console.WriteLine("Mala suerte");
                            apuesta3 = apuesta3 * 4;
                            monto = monto - apuesta3;
                            perdido = perdido + apuesta3;
                            Console.WriteLine("Numero generado: " + valor_r3);
                        }
                        Console.Write("Pulsa enter para contunuar...");
                        Console.ReadLine();
                        tiradas = tiradas + 1;
                        break;
                    case 4:
                        int apuesta4 = 0;
                        int num_s4;
                        Random rnd4 = new Random();
                        int num_d14 = rnd4.Next(1, 7);
                        int num_d24 = rnd4.Next(1, 7);
                        int valor_r4 = num_d14 + num_d24;
                        if (valor_r4 == 2 || valor_r4 == 3 || valor_r4 == 4 || valor_r4 == 10 || valor_r4 == 11 || valor_r4 == 12)
                        {
                            extremos = extremos + 1;
                        }
                        if (valor_r4 == 5 || valor_r4 == 6 || valor_r4 == 7 || valor_r4 == 8 || valor_r4 == 9)
                        {
                            medios = medios + 1;
                        }
                        if (valor_r4 % 2 == 0)
                        {
                            pares = pares + 1;
                        }
                        if (valor_r4 % 2 != 0)
                        {
                            impares = impares + 1;
                        }
                        Console.Write("Elige 1 para par - Elige 2 para impar: ");
                        int.TryParse(Console.ReadLine(), out num_s4);
                        Console.Write("Realiza tu apuesta: ");
                        int.TryParse(Console.ReadLine(), out apuesta4);
                        Dados dado14 = new Dados(num_d14, 1);
                        Dados dado24 = new Dados(num_d24, 2);
                        _dado.Add(dado14);
                        _dado.Add(dado24);
                        Console.WriteLine(dado14.ToString());
                        Console.WriteLine(dado24.ToString());
                        if (num_s4 == 1)
                        {
                            if (valor_r4 == 2 || valor_r4 == 4 || valor_r4 == 6 || valor_r4 == 8 || valor_r4 == 10 || valor_r4 == 12)
                            {
                                Console.WriteLine("Felicidades!");
                                apuesta4 = apuesta4 * 2;
                                monto = monto + apuesta4;
                                ganado = ganado + apuesta4;
                            }
                            else 
                            {
                                Console.WriteLine("Mala suerte");
                                apuesta = apuesta4 * 2;
                                monto = monto - apuesta4;
                                perdido = perdido + apuesta4;
                                Console.WriteLine("Numero correcto: " + valor_r4);
                            }
                        }
                        else
                        {
                            if (valor_r4 == 3 || valor_r4 == 5 || valor_r4 == 7 || valor_r4 == 9 || valor_r4 == 11)
                            {
                                Console.WriteLine("Felicidades!");
                                apuesta4 = apuesta4 * 2;
                                monto = monto + apuesta4;
                                ganado = ganado + apuesta4;
                            }
                            else 
                            {
                                Console.WriteLine("Mala suerte");
                                apuesta = apuesta4 * 2;
                                monto = monto - apuesta4;
                                perdido = perdido + apuesta4;
                                Console.WriteLine("Numero correcto: " + valor_r4);
                            }
                        }
                        Console.Write("Pulsa enter para contunuar...");
                        Console.ReadLine();
                        tiradas = tiradas + 1;
                        break;
                    case 5:
                        juegoDados();
                        break;
                    default:
                        break;
                }
            } while (bandera_j != 5);
        }

        private bool validacion(int opcion, ref int bandera)
        {
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
            {
                if (x <= opcion)
                {
                    bandera = x;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Mala eleccion");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Mala eleccion");
                return false;
            }
        }
        public static void Main(string[] args)
        {
            Program control = new Program();
            control.juegoDados();
        }
    }
}