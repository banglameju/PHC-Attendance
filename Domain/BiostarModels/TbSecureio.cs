using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbSecureio
{
    public int NSecureIoidn { get; set; }

    public int NReaderIdn { get; set; }

    public int NIndex { get; set; }

    public short NInput0 { get; set; }

    public short NInput1 { get; set; }

    public short NInput2 { get; set; }

    public short NInput3 { get; set; }

    public short NOutput0 { get; set; }

    public short NOutput1 { get; set; }
}
