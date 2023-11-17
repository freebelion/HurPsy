namespace HurPsyStrings
{
    public static class LibStrings
    {
        public static string GetString(string strName)
        {
            string? str = LibStringResources.ResourceManager.GetString(strName);
            
            if(str != null) { return str; }
            else
            {
                throw new ApplicationException("String resource not found");
            }
        }
    }
}