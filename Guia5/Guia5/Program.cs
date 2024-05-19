//Implementando Reto : Estoy cansada profe 
//Necesite un poco de ayuda ya que tenía muchos errores pero al fin me dió

using System;


namespace Guia5
{
    class Program
    {
        static List<Telefono> inventario = new List<Telefono>();

        //Método Main
        static void Main(string[] args)
        {
            bool salir = false;

            do

            {
                Console.WriteLine("=== Menú ===");
                Console.WriteLine("1. Registrar Teléfono");
                Console.WriteLine("2. Mostrar Teléfonos Registrados");
                Console.WriteLine("3. Consultar Stock de un Teléfono Específico");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out int opcion))

                {
                    switch (opcion)
                    {
                        case 1:
                            RegistrarTelefono();
                            break;
                        case 2:
                            MostrarTelefonosRegistrados();
                            break;
                        case 3:
                            ConsultarStockTelefono();
                            break;
                        case 4:
                            salir = true;
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                            break;
                    }
                }

                else

                {
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                }

                Console.WriteLine();

            } while (!salir);
        }

        //Método RegistrarTelefono
        static void RegistrarTelefono()
        {
            Console.WriteLine("Ingrese la cantidad de teléfonos a registrar: ");
            int cantidad;
            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)

            {
                Console.WriteLine("Cantidad no válida. Inténtelo de nuevo.");
                Console.WriteLine("Ingrese la cantidad de teléfonos a registrar: ");
            }

            for (int i = 0; i < cantidad; i++)

            {
                Console.WriteLine($"\n=== Registrando teléfono {i + 1}/{cantidad} ===");
                Console.WriteLine("Ingrese los detalles del teléfono:");
                Console.Write("Marca: ");
                string marca = Console.ReadLine();
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();
                Console.Write("Precio: ");
                decimal precio;
                while (!decimal.TryParse(Console.ReadLine(), out precio) || precio < 0)

                {
                    Console.WriteLine("Precio no válido. Inténtelo de nuevo.");
                    Console.Write("Precio: ");
                }

                Console.Write("Stock: ");
                int stock;
                while (!int.TryParse(Console.ReadLine(), out stock) || stock < 0)

                {
                    Console.WriteLine("Stock no válido. Inténtelo de nuevo.");
                    Console.Write("Stock: ");
                }

                Telefono telefonoBasico;

                Console.WriteLine("¿Es un teléfono inteligente? (s/n): ");
                char respuesta = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (char.ToLower(respuesta) == 's')

                {
                    Console.Write("Sistema Operativo: ");
                    string sistemaOperativo = Console.ReadLine();
                    Console.Write("Memoria RAM (GB): ");
                    int memoriaRam;
                    while (!int.TryParse(Console.ReadLine(), out memoriaRam) || memoriaRam < 0)

                    {
                        Console.WriteLine("Memoria RAM no válida. Inténtelo de nuevo.");
                        Console.Write("Memoria RAM (GB): ");
                    }

                    TelefonoInteligente telefonoInteligente = new TelefonoInteligente(marca, modelo, precio, stock, sistemaOperativo, memoriaRam);
                    inventario.Add(telefonoInteligente);
                }

                else

                {
                    Console.Write("¿Tiene Radio FM? (s/n): ");
                    bool tieneRadioFM = char.ToLower(Console.ReadKey().KeyChar) == 's';
                    Console.WriteLine();
                    Console.Write("¿Tiene Linterna? (s/n): ");
                    bool tieneLinterna = char.ToLower(Console.ReadKey().KeyChar) == 's';
                    Console.WriteLine();

                    telefonoBasico = new TelefonoBasico(marca, modelo, precio, stock, tieneRadioFM, tieneLinterna);
                }

                Console.WriteLine("Teléfono registrado correctamente.");
            }
        }

        //Método MostrarTelefonosRegistrados
        static void MostrarTelefonosRegistrados()
        {
            if (inventario.Count == 0)
            {
                Console.WriteLine("No hay teléfonos registrados.");
            }
            else
            {
                Console.WriteLine("Teléfonos registrados:");
                foreach (var telefono in inventario)
                {
                    telefono.MostrarInformacion();
                }
            }
        }

        //Método ConsultarStockTelefono
        static void ConsultarStockTelefono()
        {
            Console.Write("Ingrese el modelo del teléfono a consultar: ");
            string modelo = Console.ReadLine();

            bool encontrado = false;
            foreach (var telefono in inventario)
            {
                if (telefono.Modelo == modelo)
                {
                    encontrado = true;
                    Console.WriteLine($"Stock del teléfono {modelo}: {telefono.Stock}");
                    break;
                }
            }

            if (!encontrado)

            {
                Console.WriteLine($"No se encontró ningún teléfono con el modelo {modelo}.");
            }
        }
    }
}


















