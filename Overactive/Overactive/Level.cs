using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;

namespace Overactive
{
    class Level :IDisposable
    {
        public ContentManager Content {
            get { return content; }
           
        
        }
        ContentManager content;
        public void Dispose() {
            Content.Unload();
        
        }


    }
}
