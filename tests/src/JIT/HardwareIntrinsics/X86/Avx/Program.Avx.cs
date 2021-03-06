// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace JIT.HardwareIntrinsics.X86
{
    public static partial class Program
    {
        static Program()
        {
            TestList = new Dictionary<string, Action>() {
                ["Add.Double"] = AddDouble,
                ["Add.Single"] = AddSingle,
                ["AddSubtract.Double"] = AddSubtractDouble,
                ["AddSubtract.Single"] = AddSubtractSingle,
                ["And.Double"] = AndDouble,
                ["And.Single"] = AndSingle,
                ["AndNot.Double"] = AndNotDouble,
                ["AndNot.Single"] = AndNotSingle,
                ["BlendVariable.Double"] = BlendVariableDouble,
                ["BlendVariable.Single"] = BlendVariableSingle,
                ["Ceiling.Double"] = CeilingDouble,
                ["Ceiling.Single"] = CeilingSingle,
                ["Divide.Double"] = DivideDouble,
                ["Divide.Single"] = DivideSingle,
                ["DuplicateEvenIndexed.Double"] = DuplicateEvenIndexedDouble,
                ["DuplicateEvenIndexed.Single"] = DuplicateEvenIndexedSingle,
                ["DuplicateOddIndexed.Single"] = DuplicateOddIndexedSingle,
                ["Floor.Double"] = FloorDouble,
                ["Floor.Single"] = FloorSingle,
                ["Max.Double"] = MaxDouble,
                ["Max.Single"] = MaxSingle,
                ["Min.Double"] = MinDouble,
                ["Min.Single"] = MinSingle,
                ["Multiply.Double"] = MultiplyDouble,
                ["Multiply.Single"] = MultiplySingle,
                ["Or.Double"] = OrDouble,
                ["Or.Single"] = OrSingle,
                ["RoundCurrentDirection.Double"] = RoundCurrentDirectionDouble,
                ["RoundCurrentDirection.Single"] = RoundCurrentDirectionSingle,
                ["RoundToNearestInteger.Double"] = RoundToNearestIntegerDouble,
                ["RoundToNearestInteger.Single"] = RoundToNearestIntegerSingle,
                ["RoundToNegativeInfinity.Double"] = RoundToNegativeInfinityDouble,
                ["RoundToNegativeInfinity.Single"] = RoundToNegativeInfinitySingle,
                ["RoundToPositiveInfinity.Double"] = RoundToPositiveInfinityDouble,
                ["RoundToPositiveInfinity.Single"] = RoundToPositiveInfinitySingle,
                ["RoundToZero.Double"] = RoundToZeroDouble,
                ["RoundToZero.Single"] = RoundToZeroSingle,
                ["Subtract.Double"] = SubtractDouble,
                ["Subtract.Single"] = SubtractSingle,
                ["TestC.Byte"] = TestCByte,
                ["TestC.Int16"] = TestCInt16,
                ["TestC.Int32"] = TestCInt32,
                ["TestC.Int64"] = TestCInt64,
                ["TestC.SByte"] = TestCSByte,
                ["TestC.UInt16"] = TestCUInt16,
                ["TestC.UInt32"] = TestCUInt32,
                ["TestC.UInt64"] = TestCUInt64,
                ["TestNotZAndNotC.Byte"] = TestNotZAndNotCByte,
                ["TestNotZAndNotC.Int16"] = TestNotZAndNotCInt16,
                ["TestNotZAndNotC.Int32"] = TestNotZAndNotCInt32,
                ["TestNotZAndNotC.Int64"] = TestNotZAndNotCInt64,
                ["TestNotZAndNotC.SByte"] = TestNotZAndNotCSByte,
                ["TestNotZAndNotC.UInt16"] = TestNotZAndNotCUInt16,
                ["TestNotZAndNotC.UInt32"] = TestNotZAndNotCUInt32,
                ["TestNotZAndNotC.UInt64"] = TestNotZAndNotCUInt64,
                ["TestZ.Byte"] = TestZByte,
                ["TestZ.Int16"] = TestZInt16,
                ["TestZ.Int32"] = TestZInt32,
                ["TestZ.Int64"] = TestZInt64,
                ["TestZ.SByte"] = TestZSByte,
                ["TestZ.UInt16"] = TestZUInt16,
                ["TestZ.UInt32"] = TestZUInt32,
                ["TestZ.UInt64"] = TestZUInt64,
                ["Xor.Double"] = XorDouble,
                ["Xor.Single"] = XorSingle,
            };
        }
    }
}
