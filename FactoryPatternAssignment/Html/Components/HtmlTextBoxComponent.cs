﻿using LayoutBuilderLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternAssignment
{
    public class HtmlTextBoxComponent : Component
    {
        public override string MakeSource()
        {
            return $"<input type=\"text\" style=\"{HtmlHelper.StyleForComponent(this)}\" value=\"{Content}\" />";
        }
    }
}
