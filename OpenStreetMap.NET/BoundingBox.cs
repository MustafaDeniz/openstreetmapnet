﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenStreetMap.NET
{
  public class BoundingBox
  {
    public Point LeftBottom { get; set; }
    public Point RightTop { get; set; }
  }
}