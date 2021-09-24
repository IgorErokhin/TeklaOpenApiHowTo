using System.Collections.Generic;
using Tekla.Structures.ModelInternal;

namespace TeklaOpenApiHowTo
{
    public class ExportIfc4_
    {
        public static bool ExportIfc4(bool isExportSelected, string modelName, string fullFileName, List<string> propertySets, string exportLayerAs, string objectColoring)
        {
            Operation.IFCExportFlags flags = new Operation.IFCExportFlags
            {
                IsFlatBeamsAsPlates = false,
                IsLocationFromOrganizer = false,
                IsPoursEnabled = false
            };

            if (isExportSelected)
            {
                return Operation.ExportIFCFromSelected(modelName, fullFileName, Operation.IFCExportViewTypeEnum.UNDEFINED, propertySets, Operation.ExportBasePoint.BASE_POINT,
                    exportLayerAs, objectColoring, flags);
            }
            else
            {
                return Operation.ExportIFCFromAll(modelName, fullFileName, Operation.IFCExportViewTypeEnum.UNDEFINED, propertySets, Operation.ExportBasePoint.BASE_POINT,
                    exportLayerAs, objectColoring, flags);
            }
        }
    }
}
