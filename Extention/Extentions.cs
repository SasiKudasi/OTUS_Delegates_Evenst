using System.Collections;


namespace OTUS_Delegates_Evenst.Extention
{
    public static class Extension
    {
        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
        {
            if (collection == null || !collection.Any())
            {
                throw new ArgumentException("Collection is null or empty.");
            }

            T maxElement = null;
            float maxValue = float.MinValue;

            foreach (var item in collection)
            {
                float value = convertToNumber(item);
                if (maxElement == null || value > maxValue)
                {
                    maxElement = item;
                    maxValue = value;
                }
            }

            return maxElement;
        }
    }
}
