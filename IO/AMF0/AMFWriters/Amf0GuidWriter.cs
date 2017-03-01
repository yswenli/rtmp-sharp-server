﻿using System;
using System.Threading.Tasks;

namespace RtmpSharp.IO.AMF0.AMFWriters
{
    class Amf0GuidWriter : IAmfItemWriter
    {
        public void WriteData(AmfWriter writer, object obj)
        {
            writer.WriteMarker(Amf0TypeMarkers.String);
            writer.WriteUtfPrefixed(((Guid)obj).ToString());
        }

        public void WriteDataAsync(AmfWriter writer, object obj)
        {
            writer.WriteMarkerAsync(Amf0TypeMarkers.String);
            writer.WriteUtfPrefixedAsync(((Guid)obj).ToString());
        }
    }
}
