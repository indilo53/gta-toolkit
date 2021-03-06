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

using RageLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RageLib.GTA5.PSO
{
    public class PsoCHKSSection
    {
        public int Ident { get; private set; } = 0x43484B53;
        public int Length { get; set; }
        public uint FileSize { get; set; }
        public uint Checksum { get; set; }
        public uint Unk0 { get; set; } = 0x79707070;  // "yppp"

        public void Read(DataReader reader)
        {
            Ident = reader.ReadInt32();
            Length = reader.ReadInt32();

            if (Length != 20)
            { return; }

            FileSize = reader.ReadUInt32();
            Checksum = reader.ReadUInt32();
            Unk0 = reader.ReadUInt32();
        }

        public void Write(DataWriter writer)
        {

            writer.Write(Ident);
            writer.Write(Length);


        }

        public override string ToString()
        {
            return Ident.ToString() + ": " + Length.ToString();
        }
    }
}
