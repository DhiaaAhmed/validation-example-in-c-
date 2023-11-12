using System;
using valdition;

namespace Valdition
{
    class program
    {
        static void Main (String[] args)
        {
            var processRequest = new ProcessRequest("dhiaa","It",5,"وقف قيد",1122);
            var valditor = new ProcessRequestValditor();
            var result = valditor.Validate(processRequest);
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);

                }
            }
            else
            {
                Console.WriteLine("Done successfully\n");
            }
            Console.WriteLine("finished");
            Console.ReadLine();
        }
    }
}
