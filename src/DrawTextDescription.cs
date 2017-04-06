using System;
using System.Linq;
using System.Collections.Generic;
using FeralTic.DX11.Geometry;
using VL.Core;
using SharpDX;

namespace CraftLie
{

    [Type]
    public class DrawTextDescription : DrawDescriptionBase
    {
        public readonly string Text;
        public readonly float Size;
        public readonly string FontName;

        [Node(Hidden = true, IsDefaultValue = true)]
        public static readonly DrawTextDescription Default = new DrawTextDescription(Matrix.Identity, Color4.White);

        [Node]
        public DrawTextDescription(Matrix transformation, Color4 color, string text = "CraftLie", float size = 32, string fontName = "Arial")
        {
            Text = text;
            Size = size;
            FontName = fontName;
            Color = color;
            Transformation = transformation;
        }

        [Node]
        public void Transform(Matrix transformation)
        {
            Matrix.Multiply(ref Transformation, ref transformation, out Transformation);
        }
    }

}