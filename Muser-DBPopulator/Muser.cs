using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flippedout

{

    class Muser {

        public string Location { get; set; }
        public bool OnlineCollaboration { get; set; }
        public List<String> Instruments { get; set; }
        public int NumInstruments { get; set; } = 0;
        public List<String>[] Genres { get; set; }
        public string Skill { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        private const bool IsAdmin = false;
        public const bool IsHidden = false;
        public const bool IsValid = true;

        private string Password { get; set; }
        private string Salt { get; set; }

        // Muser constructor
        public Muser() {}

		// Muser othershit
	}
}