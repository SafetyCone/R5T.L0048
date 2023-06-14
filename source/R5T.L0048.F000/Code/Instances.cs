using System;


namespace R5T.L0048.F000
{
    public static class Instances
    {
        public static IDocumentOperator DocumentOperator => F000.DocumentOperator.Instance;
        public static IProjectOperator ProjectOperator => F000.ProjectOperator.Instance;
    }
}