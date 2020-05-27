using C4M.Domain.Attributes;
using System.Collections.Generic;

namespace C4M.Domain.Entities
{
    public class TresCoracoesEquipamentosDadosMinimos
    {
        public List<TresCoracoesDadosMinimos> Devices { get; set; } = new List<TresCoracoesDadosMinimos>();
    }

    [BsonCollection("TresCoracoesDM")]
    public class TresCoracoesDadosMinimos : BaseDadosMinimos
    {

    }
}
