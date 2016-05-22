using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skewd.peeling_onions {
    public class Onion {
        private readonly Onion containedLayer;

        public Onion() { }

        public Onion(Onion containedLayer) {
            this.containedLayer = containedLayer;
        }

        public int NumberOfInnerLayers {
            get {
                int count = 0;
                Onion inner = this.containedLayer;

                while (inner != null) {
                    count++;
                    inner = inner.containedLayer;
                }
                    
                return count;
            }
        }
    }
}