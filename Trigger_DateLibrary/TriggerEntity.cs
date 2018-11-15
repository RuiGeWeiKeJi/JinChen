using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigger_DateLibrary
{
    public class TriggerEntity
    {
        private string _raa015;
        public string RAA015
        {
            get
            {
                return _raa015;
            }
            set
            {
                _raa015 = value;
            }
        }

        private string _raa002;
        public string RAA002
        {
            get
            {
                return _raa002;
            }
            set
            {
                _raa002 = value;
            }
        }

    }
}
