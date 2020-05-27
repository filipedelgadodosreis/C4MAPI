using C4M.Domain.Attributes;
using System.Collections.Generic;

namespace C4M.Domain.Entities
{
    public class EstruturaEquipamento
    {
        public List<TresCoracoesEquipamentos> Devices { get; set; } = new List<TresCoracoesEquipamentos>();
    }

    [BsonCollection("3Coracoes")]
    public class TresCoracoesEquipamentos : BaseEquipamentos
    {

    }
}
