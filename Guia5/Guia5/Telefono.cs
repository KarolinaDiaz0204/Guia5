using System;

namespace Guia5
{
    public class Telefono
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public Telefono(string marca, string modelo, decimal precio, int stock)
        {
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
            Stock = stock;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Precio: ${Precio}, Stock: ${Stock}");
        }

    }
}












