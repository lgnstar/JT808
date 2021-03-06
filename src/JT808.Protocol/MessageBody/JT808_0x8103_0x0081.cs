﻿using JT808.Protocol.Attributes;
using JT808.Protocol.Formatters.MessageBodyFormatters;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 车辆所在的省域 ID
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0x0081_Formatter))]
    public class JT808_0x8103_0x0081 : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0x0081;
        /// <summary>
        /// 数据 长度
        /// </summary>
        public override byte ParamLength { get; set; } = 2;
        /// <summary>
        /// 车辆所在的省域 ID
        /// </summary>
        public ushort ParamValue { get; set; }
    }
}
