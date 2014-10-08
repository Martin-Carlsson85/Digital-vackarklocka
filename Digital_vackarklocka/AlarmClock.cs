using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_vackarklocka
{
    class AlarmClock
    {   
        //Fält
        private int _alarmaHour;
        private int _alarmaMinute;
        private int _hour;
        private int _minute;


        //Egenskaper
        public int AlarmHour
        {
            get { return _alarmaHour; }

            set {
                    if (value < 0 || value > 23)
                    {
                        throw new ArgumentException();

                    }

                    _alarmaHour = value;
            
            }
        }

        public int AlarmMinute
        {
            get { return _alarmaMinute; }

            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();

                }

                _alarmaMinute = value;

            }

        }

        public int Hour
        {
            get { return _hour; }

            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();

                }

                _hour = value;

            }
        
        }

        public int Minute
        {
            get { return _minute; }

            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();

                }

                _minute = value;

            }
        
        }

        //Kunstruktorer med parameterlista
        public AlarmClock()
            :this (0,0)
        {

        }


        public AlarmClock(int hour, int minute)
            :this (hour, minute, 0, 0)
        {

        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
            
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;

        }



        //Metoder
        public bool TickTock()
        {
            Minute++;
            if (_minute < 59)
            {
                Minute = 0;

                Hour++;

                if (Hour > 23)    
                {
                    Hour = 0;
                }
            }
            if (Hour == AlarmHour && Minute == AlarmMinute)
            {
                return true;
            }
            else
            {
                return false;
            }
        
    
    
        }
        public override string ToString()
        {
            if (Minute < 10)
            {
                return string.Format("{0}:0{1}", Hour, Minute); //Om Minute är en siffra så läggs 0 till innan siffran.
            }
            else
            {
                return string.Format("{0}:{1}", Hour, Minute); //Annars om Minute är ett tal så läggs inte 0 till.
            }
        }
    }
}
