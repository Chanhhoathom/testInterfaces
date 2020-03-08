using System;
using System.Collections.Generic;
using System.Text;

namespace testInterfaces
{
    class Magazine:BaseBook,ibook
    {
        public int NumberOfPages()
        {
            return 30;
        }
    }
}
