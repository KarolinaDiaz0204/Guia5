using System;

namespace Guia5
{
    public class TelefonoInteligente: Telefono
    {
        public string SistemaOperativo { get; set; }
        public int MemoriaRam { get; set; }

        public TelefonoInteligente(string marca, string modelo, decimal precio, int stock, string sistemaOperativo, int memoriaRam)
        : base(marca, modelo, precio, stock)
        {
            SistemaOperativo = sistemaOperativo;
            MemoriaRam = memoriaRam;
        }

        public void MostrarInformacionInteligente()
        {
            MostrarInformacion();

            Console.WriteLine($"Sistema Operativo: {SistemaOperativo}, Memoria RAM: {MemoriaRam} GB");
        }
    }
}
