using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Solid;

namespace TeklaOpenApiHowTo
{
    public class FindOutSolidsIntersect
    {
        public static bool AreSolidsIntersect(Solid solid1, Solid solid2)
        {
            EdgeEnumerator edges1 = solid1.GetEdgeEnumerator();
            while (edges1.MoveNext())
            {
                Edge current1 = (Edge)edges1.Current;
                if (solid2.Intersect(new LineSegment(current1.StartPoint, current1.EndPoint)).Count != 0)
                {
                    return true;
                }

            };

            EdgeEnumerator edges2 = solid2.GetEdgeEnumerator();
            while (edges2.MoveNext())
            {
                Edge current2 = (Edge)edges2.Current;
                if (solid1.Intersect(new LineSegment(current2.StartPoint, current2.EndPoint)).Count != 0)
                {
                    return true;
                }
            };

            return false;
        }
    }
}
