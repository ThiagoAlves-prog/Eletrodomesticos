namespace Eletrodomesticos.Models
{
    public class Geladeira : Eletrodomestico
    {
        public int CapacidadeLitros {  get; set; }
        public bool TemFreezer {  get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo:{Modelo}, Capacidade: {CapacidadeLitros}, KWH:{ConsumoEnergetico}, Freezer: {(TemFreezer ? "Sim" : "Não")} ";
        }
    }
}
