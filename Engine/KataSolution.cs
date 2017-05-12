using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class KataSolution
    {
        public static bool is_valid_IP(string IpAddres)
      {
          try
          {
              if (IpAddres.Split('.').Count() != 4)
              {
                  throw new Exception();
              }

              IpAddres.Split('.').ToList().ForEach(x =>
              {
                  if (!x.TrimStart('0').Equals(x))
                  {
                      throw new Exception();
                  }

                  if (!x.Trim(' ').Equals(x))
                  {
                      throw new Exception();
                  }

                  var i = int.Parse(x);

                  if (i < 0 || i > 255)
                  {
                      throw new Exception();
                  }
              });

              return true;
          }
          catch
          {
              return false;
          }
      }
    }
}
