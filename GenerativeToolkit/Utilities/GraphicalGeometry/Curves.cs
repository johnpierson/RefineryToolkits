﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using DSCurve = Autodesk.DesignScript.Geometry.Curve;
using DSPoint = Autodesk.DesignScript.Geometry.Point;
using Autodesk.DesignScript.Geometry;
using Autodesk.DesignScript.Runtime;
using GenerativeToolkit.Graphs.Geometry;
using GenerativeToolkit.Graphs.Extensions;
using GenerativeToolkit.Graphs;
using Analyse;

namespace Autodesk.GenerativeToolkit.Utilities.GraphicalGeometry
{

    /// <summary>
    /// Static class extending Point functionality
    /// </summary>
    [IsVisibleInDynamoLibrary(false)]
    public static class Curves
    {
        #region Internal Methods
        [IsVisibleInDynamoLibrary(false)]
        internal static GeometryEdge ToEdge(this Autodesk.DesignScript.Geometry.Line line)
        {
            return GeometryEdge.ByStartVertexEndVertex(line.StartPoint.ToVertex(), line.EndPoint.ToVertex());
        }
        #endregion
    }
}
