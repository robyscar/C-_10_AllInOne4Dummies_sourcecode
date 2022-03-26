using CIAAssembly;
using System;

namespace InternalLimitsAccess
{
    class Congress
    {
        static void Main(string[] args)
        {
            // Code to oversee CIA
            // The following line doesn't compile because GroupA isn't accessible
            // outside CIAAssembly. Congress can't get at GroupA over at CIA.

            // CIAAssembly.GroupA groupA = new CIAAssembly.GroupA();

            // Class Congress can access GroupB because it's declared public.
            // GroupB is willing to admit to knowing the secret, but it’s
            // not telling -- except for a small hint.
            GroupB groupB = new GroupB();
            groupB.DoSomethingWithSecretX();

            // If a congressman has the right credentials, it's possible to
            // know the secret.
            Console.WriteLine($"Here's the secret: " +
                $"{groupB.DoSomethingWithSecretXUsingCredentials("congressman with approved access")}");
            Console.Read();
        }
    }
}
