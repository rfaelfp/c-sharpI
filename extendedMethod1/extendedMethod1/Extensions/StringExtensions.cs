namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string strObj, int amount)
        {
            if(strObj.Length <= amount)
            {
                return strObj;
            } else
            {
                return strObj.Substring(0, amount) + "...";
            }
        }
    }
}
