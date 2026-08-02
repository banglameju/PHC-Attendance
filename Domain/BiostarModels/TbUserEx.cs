using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbUserEx
{
    public int NUserIdn { get; set; }

    public string SSurName { get; set; } = null!;

    public string SFirstName { get; set; } = null!;

    public string SMiddleName { get; set; } = null!;

    public int NImageSize { get; set; }

    public string SImageFilePath { get; set; } = null!;

    public int NDuration { get; set; }

    public int NCountPerDay { get; set; }

    public short NUsePrivateImage { get; set; }

    public string SGreetingMsg { get; set; } = null!;

    public int NEncryption { get; set; }
}
