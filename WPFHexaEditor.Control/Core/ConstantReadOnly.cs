﻿//////////////////////////////////////////////
// Apache 2.0  - 2016-2018
// Author : Derek Tremblay (derektremblay666@gmail.com)
//////////////////////////////////////////////

namespace WpfHexaEditor.Core
{
    public static class ConstantReadOnly
    {
        public static readonly string HexLineInfoStringFormat = "x8";
        public static readonly string HexStringFormat = "x";

        public const long Largefilelength = 52_428_800L; //50 MB
        public const int Copyblocksize = 131_072; //128 KB
        public const int Findblocksize = 1_048_576; //1 MB
    }
}