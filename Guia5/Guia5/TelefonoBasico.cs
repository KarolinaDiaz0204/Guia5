using System;

namespace Guia5
{
    public class TelefonoBasico : Telefono
    {
        public bool TieneRadioFM { get; set; }
        public bool TieneLinterna { get; set; }

        public TelefonoBasico(string marca, string modelo, decimal precio, int stock, bool tieneRadioFM, bool tieneLinterna)
            : base(marca, modelo, precio, stock)
        {
            TieneRadioFM = tieneRadioFM;
            TieneLinterna = tieneLinterna;
        }

        public void MostrarInformacionBasico()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Precio: ${Precio}, Stock: ${Stock}, Tiene Radio FM: {TieneRadioFM}, Tiene Linterna: {TieneLinterna}");
        }
    }
}