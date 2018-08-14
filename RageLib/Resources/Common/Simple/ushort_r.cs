﻿/*
    Copyright(c) 2016 Neodymium

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.
*/

namespace RageLib.Resources.Common
{
    /// <summary>
    /// Represents a ushort that can be referenced in a resource structure.
    /// </summary>
    public class ushort_r : ResourceSystemBlock
    {
        /// <summary>
        /// Gets the length of the ushort.
        /// </summary>
        public override long Length
        {
            get { return 2; }
        }

        /// <summary>
        /// Gets or sets the ushort value.
        /// </summary>
        public ushort Value { get; set; }

        public override void Read(ResourceDataReader reader, params object[] parameters)
        {
            Value = reader.ReadUInt16();
        }

        public override void Write(ResourceDataWriter writer, params object[] parameters)
        {
            writer.Write(Value);
        }

        public static explicit operator ushort (ushort_r value)
        {
            return value.Value;
        }

        public static explicit operator ushort_r(ushort value)
        {
            var x = new ushort_r();
            x.Value = value;
            return x;
        }
    }
}