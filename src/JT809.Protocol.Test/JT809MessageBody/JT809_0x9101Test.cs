﻿using JT809.Protocol;
using JT809.Protocol.JT809Extensions;
using JT809.Protocol.JT809MessageBody;
using JT809.Protocol.JT809Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JT809.Protocol.Test.JT809MessageBody
{
    public class JT809_0x9101Test
    {
        [Fact]
        public void Test1()
        {
            JT809_0x9101 jT809_0X9101 = new JT809_0x9101();
            jT809_0X9101.DynamicInfoTotal = 10000;
            jT809_0X9101.StartTime = 1537513862;
            jT809_0X9101.EndTime = 1537531862;
            var hex = JT809Serializer.Serialize(jT809_0X9101).ToHexString();
        }

        [Fact]
        public void Test2()
        {
            var bytes = "00 00 27 10 00 00 00 00 5B A4 99 86 00 00 00 00 5B A4 DF D6".ToHexBytes();
            JT809_0x9101 jT809_0X9101 = JT809Serializer.Deserialize<JT809_0x9101>(bytes);
            Assert.Equal((uint)10000, jT809_0X9101.DynamicInfoTotal);
            Assert.Equal((ulong)1537513862, jT809_0X9101.StartTime);
            Assert.Equal((ulong)1537531862, jT809_0X9101.EndTime);
        }
    }
}