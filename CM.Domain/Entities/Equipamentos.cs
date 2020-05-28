using System.Collections.Generic;

namespace C4M.Domain.Entities
{
    public class EstruturaEquipamento
    {
        public List<Equipamentos> Devices { get; set; } = new List<Equipamentos>();
    }

    public class Equipamentos : BaseEquipamentos
    {

    }
}
