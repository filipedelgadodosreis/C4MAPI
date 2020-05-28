using System.Collections.Generic;

namespace C4M.Domain.Entities
{
    public class EquipamentosDadosMinimos
    {
        public List<DadosMinimos> Devices { get; set; } = new List<DadosMinimos>();
    }

    public class DadosMinimos : BaseDadosMinimos
    {

    }
}
