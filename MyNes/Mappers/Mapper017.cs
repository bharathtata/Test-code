// This file is part of My Nes
//
// A Nintendo Entertainment System / Family Computer (Nes/Famicom)
// Emulator written in C#.
// 
// Copyright © Alaa Ibrahim Hadid 2009 - 2021
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program.If not, see<http://www.gnu.org/licenses/>.
// 
// Author email: mailto:alaahadidfreeware@gmail.com
//
namespace MyNes.Core
{
    [BoardInfo("FFE F8xxx", 17)]
    class Mapper017 : FFE
    {
        internal override void HardReset()
        {
            base.HardReset();
            Switch16KPRG(PRG_ROM_16KB_Mask, PRGArea.AreaC000);
        }
        internal override void WriteEX(ref ushort address, ref byte data)
        {
            switch (address)
            {
                case 0x4504: base.Switch08KPRG(data, PRGArea.Area8000); break;
                case 0x4505: base.Switch08KPRG(data, PRGArea.AreaA000); break;
                case 0x4506: base.Switch08KPRG(data, PRGArea.AreaC000); break;
                case 0x4507: base.Switch08KPRG(data, PRGArea.AreaE000); break;
                case 0x4510: base.Switch01KCHR(data, CHRArea.Area0000); break;
                case 0x4511: base.Switch01KCHR(data, CHRArea.Area0400); break;
                case 0x4512: base.Switch01KCHR(data, CHRArea.Area0800); break;
                case 0x4513: base.Switch01KCHR(data, CHRArea.Area0C00); break;
                case 0x4514: base.Switch01KCHR(data, CHRArea.Area1000); break;
                case 0x4515: base.Switch01KCHR(data, CHRArea.Area1400); break;
                case 0x4516: base.Switch01KCHR(data, CHRArea.Area1800); break;
                case 0x4517: base.Switch01KCHR(data, CHRArea.Area1C00); break;
            }
        }
    }
}
