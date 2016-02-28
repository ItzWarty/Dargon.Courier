using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dargon.Courier {
   public interface CourierClientFactory {
      CourierClient CreateUdpCourierClient(int port, CourierClientConfiguration clientConfiguration = null);
   }
}
