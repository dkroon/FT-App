using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

/** Copyright (C) 2008  Dallas Kroon

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
namespace FTAppWM6
{
    public class EntityRecord
    {
        private String _EntityID;
        private DateTime _SilkingDate = DateTime.MinValue;
        private DateTime _AnthesisDate = DateTime.MinValue;
        //private String _SilkingScorer;
        //private String _AnthesisScorer;
        //private DateTime _SilkingDateStamp = DateTime.MinValue;
        //private DateTime _AnthesisDateStamp = DateTime.MinValue;
        

        public EntityRecord()
        {

        }

        // getters and setters
        public String EntityID
        {
            get { return _EntityID; }
            set { _EntityID = value; }
        }

        public DateTime SilkingDate
        {
            get { return _SilkingDate; }
            set { _SilkingDate = value; /*SilkingDateStamp = DateTime.Now;*/ }
        }

        public DateTime AnthesisDate
        {
            get { return _AnthesisDate; }
            set { _AnthesisDate = value; /*AnthesisDateStamp = DateTime.Now;*/  }
        }

        //public String AnthesisScorer 
        //{
        //    get { return _AnthesisScorer; }
        //    set { _AnthesisScorer = value; }
        //}
        //public String SilkingScorer
        //{
        //    get { return _SilkingScorer; }
        //    set { _SilkingScorer = value; }   
        //}



        public String EntityIDSuffix
        {
            get 
            {
                string suffix = _EntityID;
                if (_EntityID != null)
                {
                    if (_EntityID.Length == 7)
                    {
                        suffix = _EntityID.Substring(3, 4) + " " + _EntityID.Substring(7);
                    }
                }
                return suffix;
            }
        }

        //public DateTime AnthesisDateStamp
        //{
        //    get { return _AnthesisDateStamp; }
        //    set { _AnthesisDateStamp = value; }
        //}

        //public DateTime SilkingDateStamp
        //{
        //    get { return _SilkingDateStamp; }
        //    set { _SilkingDateStamp = value; }
        //}

        public override string ToString()
        {
            string AnthDate = this.AnthesisDate.ToShortDateString();
            if (AnthesisDate == DateTime.MinValue) { AnthDate = "."; }
            String SilkDate = this.SilkingDate.ToShortDateString();
            if (SilkingDate == DateTime.MinValue) { SilkDate = "."; }

            return this.EntityID + "\t" +
                   AnthDate + "\t" +
                /*this.AnthesisDateStamp.ToShortDateString() + " " + this.AnthesisDateStamp.ToShortTimeString() + "\t" +
                this.AnthesisScorer + "\t" + */
                   SilkDate; /* +"\t" +
                   this.SilkingDateStamp.ToShortDateString() + " " + this.SilkingDateStamp.ToShortTimeString() + "\t" +
                   this.SilkingScorer;*/
        }
    }
}
