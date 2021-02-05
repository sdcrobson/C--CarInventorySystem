using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robson.Shawn.Business;

namespace RRCAGApp
{
    class Fragrance
    {
        private string fragranceName;
        private decimal fragranceAmount;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fragranceName"></param>
        /// <param name="fragranceAmount"></param>
        public Fragrance(string fragranceName, decimal fragranceAmount)
        {
            this.fragranceName = fragranceName;
            this.fragranceAmount = fragranceAmount;

        }
        /// <summary>
        /// 
        /// </summary>
        public string FragranceName
        {
            get
            {
                return fragranceName;
            }
            set
            {
                this.fragranceName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal FragranceAmount
        {
            get
            {
                return fragranceAmount;
            }
            set
            {
                this.fragranceAmount = value;
            }
        }








    }
}
