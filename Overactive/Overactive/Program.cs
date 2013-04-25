using System;

namespace Overactive
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Overactive game = new Overactive())
            {
                game.Run();
            }
        }
    }
#endif
}

