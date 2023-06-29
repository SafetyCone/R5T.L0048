using System;


namespace R5T.L0048.F000
{
    public static class Instances
    {
        public static IBaseTypeDeclarationSyntaxOperator BaseTypeDeclarationSyntaxOperator => F000.BaseTypeDeclarationSyntaxOperator.Instance;
        public static IDocumentOperator DocumentOperator => F000.DocumentOperator.Instance;
        public static IMethodDeclarationSyntaxOperator MethodDeclarationSyntaxOperator => F000.MethodDeclarationSyntaxOperator.Instance;
        public static IProjectOperator ProjectOperator => F000.ProjectOperator.Instance;
    }
}