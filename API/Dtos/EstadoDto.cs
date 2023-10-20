using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class EstadoDto
    {
        public int Id { get; set; }
        public string DescripcionEstado { get; set; }
        public int IdTipoEstado { get; set; }
    }
}