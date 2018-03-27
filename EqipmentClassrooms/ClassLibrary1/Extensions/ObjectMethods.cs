using Common.Characteristics.Interfaces;

namespace Common.Characteristics.Extensions
{
    public static class ObjectMethods
    {

        public static string ToFullInfoString(this object obj)
        {
            string info = obj.ToString();// + "\n"
            var hierarchicalObj = obj as IHierarchical;
            if (hierarchicalObj != null)
            {
                info += "\tоб'єкт вищого рівня ієрархії: "
                    + hierarchicalObj.ParentName + "\n";
            }
            var descriptiveObj = obj as IDescriptive;
            if (descriptiveObj != null)
            {
                info += descriptiveObj.DescriptiveInfo;
            }
            return info;
        }
    }
}
