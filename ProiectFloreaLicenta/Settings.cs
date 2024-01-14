using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectFloreaLicenta
{
    public static class Settings
    {
        public static int[] FetchArray { get; } = { 4, 8, 16 };
        public static int[] InstructionBufferArray { get; } = { 4, 8, 16, 32 };
        public static int[] IssueRateArray { get; } = { 2, 4, 8, 16 };
        public static int[] NPenArray { get; } = { 10, 15, 20 };
        public static int[] NrSetRegistriiArray { get; } = { 2 };
        public static int[] BlockSizeArray { get; } = { 4, 8, 16 };
        public static int[] SizeBlockArray { get; } = { 64, 128, 256, 512, 1024, 2048, 4096, 8192 };

        public static int uniport { get; set; }
        public static int biport { get; set; }
        public static int DCSize { get; set; }
        public static int DBlocSize { get; set; }
        public static int ICSize { get; set; }
        public static int IBlocSize { get; set; }
        public static int FetchRate { get; set; }
        public static int IssueRateMax { get; set; }
        public static int Latency { get; set; }
        public static int MainMemoryLatency { get; set; }
    }
}
