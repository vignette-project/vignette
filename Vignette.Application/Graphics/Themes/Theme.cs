﻿// Copyright 2020 - 2021 Vignette Project
// Licensed under NPOSLv3. See LICENSE for details.

using System;
using System.Collections.Generic;
using Humanizer;
using osu.Framework.Graphics;

namespace Vignette.Application.Graphics.Themes
{
    public class Theme
    {
        private readonly Dictionary<ThemeColour, Colour4> colours = new Dictionary<ThemeColour, Colour4>();

        public Theme(IDictionary<string, string> mapping)
        {
            foreach ((string key, string value) in mapping)
                colours.Add(Enum.Parse<ThemeColour>(key.Pascalize()), Colour4.FromHex(value));
        }

        public Colour4 Get(ThemeColour name) => colours.GetValueOrDefault(name);
    }
}
