using System;
using System.Numerics;

namespace Int32VsBigInteger.Models
{
    public static class BigIntegerModels
    {
        public static readonly BigInteger BigInteger1 = new(123);
        public static readonly BigInteger BigInteger2 = BigInteger.Parse(Int32.MaxValue.ToString()) + new BigInteger(123);

        public static readonly object BigInteger1Object = BigInteger1;
        public static readonly object BigInteger2Object = BigInteger2;
    }
}