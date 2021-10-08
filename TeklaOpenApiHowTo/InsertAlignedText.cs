using Tekla.Structures.Drawing;
using Tekla.Structures.Geometry3d;

namespace TeklaOpenApiHowTo
{
    public class InsertAlignedText
    {
        public static Text InsertLeftAlignedText(ViewBase view, Point insertionPoint, string text, Text.TextAttributes textAttributes)
        {
            Text textObj = new Text(view, insertionPoint, text, new PointPlacing(), textAttributes);
            textObj.Insert();

            RectangleBoundingBox bbox = textObj.GetObjectAlignedBoundingBox();
            textObj.MoveObjectRelative(new Vector(bbox.Width / 2, 0, 0));
            textObj.Modify();

            return textObj;
        }

        public static Text InsertRightAlignedText(ViewBase view, Point insertionPoint, string text, Text.TextAttributes textAttributes)
        {
            Text textObj = new Text(view, insertionPoint, text, new PointPlacing(), textAttributes);
            textObj.Insert();

            RectangleBoundingBox bbox = textObj.GetObjectAlignedBoundingBox();
            textObj.MoveObjectRelative(new Vector(-(bbox.Width / 2), 0, 0));
            textObj.Modify();

            return textObj;
        }
    }
}
