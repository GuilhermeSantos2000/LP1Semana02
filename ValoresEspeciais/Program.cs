using System;
using System.Reflection.PortableExecutable;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            byte MaxByte = byte.MaxValue;
            byte MinByte = byte.MinValue;
            short MaxShort = short.MaxValue;
            short MinShort = short.MinValue;
            int MaxInt = int.MaxValue;
            int MinInt = int.MinValue;
            long MaxLong = long.MaxValue;
            long MinLong = long.MinValue;
            char MaxChar = char.MaxValue;
            char MinChar = char.MinValue;
            sbyte MaxSByte = sbyte.MaxValue;
            sbyte MinSByte = sbyte.MinValue;
            ushort MaxUShort = ushort.MaxValue; 
            ushort MinUShort = ushort.MinValue;
            uint MaxUInt = uint.MaxValue;
            uint MinUInt = uint.MinValue;
            ulong MaxULong = ulong.MaxValue;
            ulong MinULong = ulong.MinValue;
            float MaxFloat = float.MaxValue;
            float MinFloat = float.MinValue;
            double MaxDouble = double.MaxValue;
            double MinDouble = double.MinValue;
            decimal MaxDecimal = decimal.MaxValue;
            decimal MinDecimal = decimal.MinValue;

            float PositiveInfiniteFloat = float.PositiveInfinity;
            float NegativeInfiniteFloat = float.NegativeInfinity;
            float NotANumberFloat = float.NaN;
            double PositiveInfiniteDouble = double.PositiveInfinity;
            double NegativeInfiniteDouble = double.NegativeInfinity;
            double NotANumberDouble = double.NaN;

            Console.WriteLine(MaxByte);
            Console.WriteLine(MinByte);
            Console.WriteLine(MaxShort);
            Console.WriteLine(MinShort);
            Console.WriteLine(MaxInt);
            Console.WriteLine(MinInt);
            Console.WriteLine(MaxLong);
            Console.WriteLine(MinLong);
            Console.WriteLine(MaxChar);
            Console.WriteLine(MinChar);
            Console.WriteLine(MaxSByte);
            Console.WriteLine(MinSByte);
            Console.WriteLine(MaxUShort);
            Console.WriteLine(MinUShort);
            Console.WriteLine(MaxUInt);
            Console.WriteLine(MinUInt);
            Console.WriteLine(MaxULong);
            Console.WriteLine(MinULong);
            Console.WriteLine(MaxFloat);
            Console.WriteLine(MinFloat);
            Console.WriteLine(MaxDouble);
            Console.WriteLine(MinDouble);
            Console.WriteLine(MaxDecimal);
            Console.WriteLine(MinDecimal);

            Console.WriteLine(PositiveInfiniteFloat);
            Console.WriteLine(NegativeInfiniteFloat);
            Console.WriteLine(NotANumberFloat);
            Console.WriteLine(PositiveInfiniteDouble);
            Console.WriteLine(NegativeInfiniteDouble);
            Console.WriteLine(NotANumberDouble);

            Console.WriteLine(MaxUInt + 1);

            Console.WriteLine(MaxFloat + 1);
            Console.WriteLine(MaxFloat * 2);
        }
    }
}
