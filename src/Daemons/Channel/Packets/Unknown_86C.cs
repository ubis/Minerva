﻿/*
    Copyright © 2010 The Divinity Project; 2013-2016 Dignity Team.
    All rights reserved.
    https://bitbucket.org/dignityteam/minerva
    http://www.ragezone.com


    This file is part of Minerva.

    Minerva is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    any later version.

    Minerva is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Minerva.  If not, see <http://www.gnu.org/licenses/>.
*/

#region Includes

using System;

#endregion

namespace Minerva
{
    partial class PacketProtocol
    {
        public static void Unknown_86C(PacketReader packet, PacketBuilder builder, ClientHandler client, EventHandler events)
        {
            var pck = new byte[] {
                0xE2, 0xB7, 0x07, 0x01, 0x6C, 0x08, 0x00, 0x90, 0x89, 0x62, 0xA4, 0x50, 0x89, 0x62, 0xA4, 0xD8,
                0x16, 0xEA, 0x0A, 0x40, 0x31, 0x57, 0x5A, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02,
                0x00, 0x00, 0x00, 0x50, 0x89, 0x62, 0xA4, 0xF0, 0xDC, 0xCF, 0xB5, 0xA8, 0xDC, 0xCF, 0xB5, 0xFB,
                0x60, 0x63, 0x08, 0x94, 0xDC, 0xCF, 0xB5, 0xD4, 0x16, 0xEA, 0x0A, 0x00, 0x00, 0x00, 0x00, 0x50,
                0x89, 0x62, 0xA4, 0xF0, 0xDC, 0xCF, 0xB5, 0x90, 0x89, 0x62, 0xA4, 0x30, 0xEE, 0x6E, 0xA4, 0xE3,
                0x2A, 0xEA, 0x0A, 0x04, 0x34, 0xB4, 0x5B, 0x2C, 0x34, 0xB4, 0x5B, 0xE3, 0x2A, 0xEA, 0x0A, 0x7A,
                0x28, 0x62, 0x08, 0xEC, 0x36, 0xEA, 0x0A, 0xD4, 0x16, 0xEA, 0x0A, 0xF0, 0xDC, 0xCF, 0xB5, 0xD1,
                0x26, 0x62, 0x08, 0x17, 0xDD, 0xCF, 0xB5, 0x38, 0xCE, 0xEF, 0xA4, 0xEC, 0x26, 0xEA, 0x0A, 0x21,
                0x04, 0x00, 0x00, 0x48, 0x48, 0x1B, 0x04, 0xF2, 0x26, 0xEA, 0x0A, 0x19, 0x00, 0x00, 0x00, 0xD4,
                0x16, 0xEA, 0x0A, 0x90, 0x89, 0x62, 0xA4, 0x01, 0xCE, 0xEF, 0xA4, 0x58, 0xDD, 0xCF, 0xB5, 0xAF,
                0x51, 0x55, 0x08, 0x02, 0x25, 0x02, 0x25, 0x15, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x0B, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xAA, 0x1E, 0x01, 0x09, 0xC8,
                0x00, 0x55, 0x5D, 0xDA, 0x4C, 0x93, 0xF6, 0x50, 0x10, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x24,
                0x84, 0xC6, 0x5A, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x31, 0x30, 0x34, 0x2E, 0x32, 0x33, 0x38, 0x00,
                0x00, 0x00, 0x00, 0x48, 0xB0, 0x70, 0xB6, 0x44, 0x08, 0x70, 0xB6, 0x58, 0xDD, 0xCF, 0xB5, 0xC5,
                0xA1, 0x2F, 0x08, 0x34, 0x13, 0xEA, 0x0A, 0x12, 0x30, 0xB4, 0x5B, 0x7F, 0x0B, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0xD8, 0xCC, 0x70, 0xB6
            };

            client.Send(ref pck, "Unknown_86C");
        }
    }
}