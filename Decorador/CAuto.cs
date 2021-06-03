using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public class CAuto : IComponente
    {
        private string Modelo;
        private string Caracteristicas;
        public double CostoAuto;

        public CAuto(string modelo, string caracteristicas, double costo)
        {
            this.Modelo = modelo;
            this.Caracteristicas = caracteristicas;
            this.CostoAuto = costo;
        }
            
        public void Puertas(bool estado)
        {
            if (estado)
            {
                Console.WriteLine("Puertas cerradas");
            }
            else
            {
                Console.WriteLine("Puertas abiertas");
            }
        }

        public double Costo()
        {
            throw new NotImplementedException();
        }

        public string Funciona()
        {
            throw new NotImplementedException();
        }
    }
}
