using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tower_game.sc {
    class DefenseException : System.Exception {

    }

    class OutOfBoundsException : DefenseException {
        OutOfBoundsException(string message) : base(message) {
                
        }
    }
}
