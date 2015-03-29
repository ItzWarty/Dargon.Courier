﻿using Dargon.PortableObjects;

namespace Dargon.Courier.PortableObjects {
   public class DargonCourierImplPofContext : PofContext {
      public DargonCourierImplPofContext(int basePofId) {
         RegisterPortableObjectType(basePofId + 0, typeof(CourierAnnounceV1));
      }
   }
}