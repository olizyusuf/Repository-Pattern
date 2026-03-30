using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpn.App
{
    public interface IListener
    {
        void Ok(Object sender, bool isNewData, object data);
    }
}
