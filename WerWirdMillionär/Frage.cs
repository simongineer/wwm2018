using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerWirdMillionär
{
    class Frage
    {
        private Int32 id;
        private Int32 schwierigkeit;
        private String frage1;
        private String antwortR;
        private String antwortF1;
        private String antwortF2;
        private String antwortF3;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Schwierigkeit
        {
            get
            {
                return schwierigkeit;
            }

            set
            {
                schwierigkeit = value;
            }
        }

        public string Frage1
        {
            get
            {
                return frage1;
            }

            set
            {
                frage1 = value;
            }
        }

        public string AntwortR
        {
            get
            {
                return antwortR;
            }

            set
            {
                antwortR = value;
            }
        }

        public string AntwortF1
        {
            get
            {
                return antwortF1;
            }

            set
            {
                antwortF1 = value;
            }
        }

        public string AntwortF2
        {
            get
            {
                return antwortF2;
            }

            set
            {
                antwortF2 = value;
            }
        }

        public string AntwortF3
        {
            get
            {
                return antwortF3;
            }

            set
            {
                antwortF3 = value;
            }
        }
    }
}
