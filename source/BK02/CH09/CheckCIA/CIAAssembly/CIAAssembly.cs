using System;

namespace CIAAssembly
{
    internal class GroupA
    {
        private string _secretFormulaForCocaCola; // Secret X
        internal GroupA() { _secretFormulaForCocaCola = "lots of sugar"; }
        internal string SecretX
        {
            get { return _secretFormulaForCocaCola; }
        }
    }

    public class GroupB
    {
        public void DoSomethingWithSecretX()
        {
            GroupA myAccess = new GroupA();

            // Do something with Secret X, now that we can see it:
            Console.WriteLine($"I know Secret X, which is" +
                $" {myAccess.SecretX.Length}" +
                $" characters long, but I'm not telling.");
        }
        public string DoSomethingWithSecretXUsingCredentials(string credentials)
        {
            if (credentials == "congressman with approved access")
            {
                GroupA myAccess = new GroupA();

                return myAccess.SecretX;
            }
            return string.Empty;
        }
    }
}
