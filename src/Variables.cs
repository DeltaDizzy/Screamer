﻿using System;

namespace Screamer
{
    /// <summary>
    /// A class containing variable definitions for screams
    /// </summary>
    public static class Variables
    {
        [ScreamVariable("GameTitle")]
        public static String GameTitle()
        {
            return HighLogic.CurrentGame?.Title;
        }

        [ScreamVariable("br")]
        public static String NewLine()
        {
            return "\n";
        }

        // Just this one example for now
    }
}
