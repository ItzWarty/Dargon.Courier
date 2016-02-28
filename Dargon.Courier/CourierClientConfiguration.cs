using System;

namespace Dargon.Courier {
   public class CourierClientConfiguration {
      public Guid Identifier { get; set; } = Guid.Empty;
      public string Name { get; set; } = null;
   }
}