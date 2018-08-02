﻿//
// Copyright (c) Jesse Freeman. All rights reserved.  
//
// Licensed under the Microsoft Public License (MS-PL) License. 
// See LICENSE file in the project root for full license information. 
//
// Contributors
// --------------------------------------------------------
// This is the official list of Pixel Vision 8 contributors:
//
// Jesse Freeman - @JesseFreeman
// Christer Kaitila - @McFunkypants
// Pedro Medeiros - @saint11
// Shawn Rakowski - @shwany

using PixelVisionSDK;

namespace PixelVisionRunner
{
    public interface IDisplayTarget
    {
        void ResetResolution(int width, int height, int overScanX = 0, int overScanY = 0);
        void Render();
        void CacheColors();
        void ConvertMousePosition(Vector pos);
    }
}
