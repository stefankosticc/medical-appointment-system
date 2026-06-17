using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Communication
{
    public enum Operation
    {
        PrijaviZaposleni,
        VratiListuSviZaposleni,
        VratiListuSviKategorijaPacijenta,
        KreirajPacijent,
        PromeniPacijent,
        KreirajZakazivanje,
        PromeniZakazivanje,
        VratiListuSviPacijent,
        VratiListuSviUsluga,
        PretraziZakazivanje,
        VratiListuZakazivanje,
        PretraziPacijent,
        VratiListuPacijent,
        ObrisiPacijent,
        UbaciUsluga,
        PromeniUsluga
    }
}
