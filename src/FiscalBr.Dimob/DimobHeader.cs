﻿using FiscalBr.Common.Dimob;

namespace FiscalBr.Dimob
{
    /// <summary>
    /// Header da Declaração
    /// </summary>
    public class DimobHeader
    {
        public DimobHeader()
        {
            Sistema = "DIMOB";
            Reservado = string.Empty.PadRight(369);
        }

        [DimobCampos(1, "Sistema", 1, 5, 5, "X")]
        public string Sistema { get; private set; }

        [DimobCampos(2, "Reservado", 6, 374, 369, "Branco(s)")]
        public string Reservado { get; private set; }

        public override string ToString()
        {
            return string.Concat(Sistema, Reservado);
        }
    }
}
