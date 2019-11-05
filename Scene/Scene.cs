using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Scene
{
    virtual public int Update(float a_fDelta) { return 0; }
    virtual public void Render() { }
    virtual public void Interaction() { }
}
