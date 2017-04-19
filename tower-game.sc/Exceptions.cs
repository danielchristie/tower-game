using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game.sc {
    class DefenseException : System.Exception {
        public DefenseException() {

        }

        public DefenseException(string message) : base(message) {
            
        }
    }

    class OutOfBoundsException : DefenseException {
        public OutOfBoundsException() {

        }

        public OutOfBoundsException(string message) : base(message) {
            
        }
    }
}
