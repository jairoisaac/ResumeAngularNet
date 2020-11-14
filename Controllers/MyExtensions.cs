using System;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static string[] RemoveBadCharacters(this String str)
        {
            
            return str.Split(new char[] { ' ', '.', ':' },
                             StringSplitOptions.RemoveEmptyEntries);
            //return FirstRemove;
        }
    }
}