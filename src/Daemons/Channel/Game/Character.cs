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
    public class Character
    {
        public int id               { get; set; }
        public int account          { get; set; }
        public byte slot            { get; set; }
        public string name          { get; set; }
        public uint level           { get; set; }
        public byte _class          { get; set; }
        public byte face            { get; set; }
        public byte hair            { get; set; }
        public byte colour          { get; set; }
        public bool gender          { get; set; }
        public byte map             { get; set; }
        public byte x               { get; set; }
        public byte y               { get; set; }
        public DateTime created     { get; set; }
        public Equipment equipment  { get; set; }
        public Stats stats          { get; set; }
        public Inventory[] inv      { get; set; }
        public Skills[] skills      { get; set; }
        public QuickSlots[] qslots  { get; set; }
    }
}
