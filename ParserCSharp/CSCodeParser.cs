using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.IO;

namespace ParserCSharp
{
    public interface IParserNavigation
    {
        void Navigate(SyntaxNode node, int line, string method, string fullPath);
    }

    public class NavMessage
    {
        public SyntaxNode node;
        public int line;
        public string method;
        public string fullPath;
    }

    public class ConsoleNavigator : IParserNavigation
    {
        public void Navigate(SyntaxNode node, int line, string method, string fullPath)
        {
            Console.WriteLine("Line: " + line + " MethodName" + method + "FullPath: " + fullPath + " NODE: " + node);
            node = node.Parent;
            Console.WriteLine("Parent NODE: " + node);
            node = node.Parent;
            Console.WriteLine("Parent NODE: " + node);
            node = node.Parent;
            Console.WriteLine("Parent NODE: " + node);

        }
    }



    public class CSCodeParser
    {
        
        public static string[] CSFilePaths(string root)
        {

            string[] filePaths = Directory.GetFiles(root, "*.cs");
            foreach (var subDirs in Directory.GetDirectories(root))
            {
                filePaths = filePaths.Concat(CSFilePaths(subDirs)).ToArray();
            }

            return filePaths;

        }

        public static string ReadFromCS(string file)
        {
            string text = string.Empty;
            using (StreamReader streamReader = new StreamReader(file, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }
            return text;
        }
        public CSCodeParser(string rootPath = null)
        {
            Path = rootPath ?? Directory.GetCurrentDirectory();
            
        }

        public string Path { get; set; }

        static SyntaxNode func(SyntaxNode local)
        {
            while (local != null)
            {
                if (local is MethodDeclarationSyntax)
                    return local;
                local = local.Parent;
            }
            return null;
        }

        public IEnumerable<NavMessage> Run()
        {
            string[] filesToParse = CSFilePaths(Path);
            foreach (var csFile in filesToParse)
            {
                SyntaxTree tree = CSharpSyntaxTree.ParseText(ReadFromCS(csFile));
                var root = (CompilationUnitSyntax)tree.GetRoot();
                var literals = root.DescendantNodes().OfType<LiteralExpressionSyntax>();//LiteralExpressionSyntax
                foreach (var R in literals)
                {
                    if (R.Kind() == SyntaxKind.StringLiteralExpression || R.Kind() == SyntaxKind.CharacterLiteralExpression)
                    {
                        
                        var loc = tree.GetLineSpan(R.Span);
                        var fname = (MethodDeclarationSyntax)func(R);
                        NavMessage msg = new NavMessage() { node = R, line = loc.StartLinePosition.Line + 1, method = fname?.Identifier.ToString(), fullPath = csFile };
                        // nav.Navigate(R, loc.StartLinePosition.Line, fname?.Identifier.ToString(), csFile);
                        yield return msg;
                    }

                }
            }


        }

    }

}
