using C4M.Domain.Attributes;
using System.Collections.Generic;

namespace C4M.Domain.Entities
{
    public class EstruturaEquipamento
    {
        public List<TresCoracoesEquipamentos> Devices { get; set; } = new List<TresCoracoesEquipamentos>();
    }

    [BsonCollection("TresCoracoesDC")]
    public class TresCoracoesEquipamentos : BaseEquipamentos
    {

    }
}
