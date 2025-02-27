﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework.Graphics
{
    public static class BlendXna
    {
        public const int GL_NEVER = 0x0200;
        public static readonly int GL_LESS = 0x0201;
        public static readonly int GL_EQUAL = 0x0202;
        public static readonly int GL_LEQUAL = 0x0203;
        public static readonly int GL_GREATER = 0x0204;
        public static readonly int GL_NOTEQUAL = 0x0205;
        public static readonly int GL_GEQUAL = 0x0206;
        public static readonly int GL_ALWAYS = 0x0207;

        public const int GL_ZERO = 0;
        public const int GL_ONE = 1;
        public const int GL_SRC_COLOR = 0x0300;
        public const int GL_ONE_MINUS_SRC_COLOR = 0x0301;
        public const int GL_SRC_ALPHA = 0x0302;
        public const int GL_ONE_MINUS_SRC_ALPHA = 0x0303;
        public const int GL_DST_ALPHA = 0x0304;
        public const int GL_ONE_MINUS_DST_ALPHA = 0x0305;

        public const int GL_DST_COLOR = 0x0306;
        public const int GL_ONE_MINUS_DST_COLOR = 0x0307;
        public const int GL_SRC_ALPHA_SATURATE = 0x0308;

        public static Blend GetXNABlend(int glBlend)
        {
            switch (glBlend)
            {
                case GL_ZERO:
                    return Blend.Zero;
                case GL_ONE:
                    return Blend.One;
                case GL_SRC_COLOR:
                    return Blend.SourceColor;
                case GL_ONE_MINUS_SRC_COLOR:
                    return Blend.InverseSourceColor;
                case GL_SRC_ALPHA:
                    return Blend.SourceAlpha;
                case GL_ONE_MINUS_SRC_ALPHA:
                    return Blend.InverseSourceAlpha;
                case GL_DST_ALPHA:
                    return Blend.DestinationAlpha;
                case GL_ONE_MINUS_DST_ALPHA:
                    return Blend.InverseDestinationAlpha;
                case GL_DST_COLOR:
                    return Blend.DestinationColor;
                case GL_ONE_MINUS_DST_COLOR:
                    return Blend.InverseDestinationColor;
                case GL_SRC_ALPHA_SATURATE:
                    return Blend.SourceAlphaSaturation;
            }

            return Blend.One;
        }
    }
}
