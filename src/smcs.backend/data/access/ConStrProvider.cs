namespace smcs.backend.data
{
    internal static class ConStrProvider
    {
        internal static string GetEndUserConStr()
        {
            return @"Server=.;Database=smcs;User Id=sa;Password=123;";
        }

        internal static string GetLabConStr()
        {
            return @"Server=.;Database=smcs_test;User Id=sa;Password=123;";
        }
    }
}
