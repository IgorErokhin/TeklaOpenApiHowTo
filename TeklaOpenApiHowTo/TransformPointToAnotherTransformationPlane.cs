using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace TeklaOpenApiHowTo
{
    public class TransformPointToAnotherTransformationPlane_
    {
        public static Point TransformPointToAnotherTransformationPlane(Point point, TransformationPlane startPlane, TransformationPlane goalPlane)
        {
            return new Point(goalPlane.TransformationMatrixToLocal.Transform(startPlane.TransformationMatrixToGlobal.Transform(point)));
        }
    }
}
