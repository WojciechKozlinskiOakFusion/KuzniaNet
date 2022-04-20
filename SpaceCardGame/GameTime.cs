using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateGamePropertiesModel
{

    public partial class GameTime
    {
        private DateTime _dtvalue, _tvalue;
        private int _vvalue;


        //Clock
        public string RealLifeTime
        {
            get { return _dtvalue.ToString(); }
            set { DateTime.TryParse(value, out _dtvalue); }
        }

        //hh:mm:ss
        public string TimeInGame
        {
            get { return _tvalue.ToString(); }
            set { DateTime.TryParse(value, out _tvalue); }
        }



    }
}
