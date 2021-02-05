using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robson.Shawn.Business;

namespace RRCAGApp
{
    class Package
    {
        private string packageName;
        private decimal packageAmount;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="packageName"></param>
        /// <param name="packageAmount"></param>
        public Package(string packageName, decimal packageAmount)
        {
            this.packageName = packageName;
            this.packageAmount = packageAmount;
        }
        /// <summary>
        /// 
        /// </summary>
        public string PackageName
        {
            get
            {
                return packageName;
            }
            set
            {
                this.packageName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal PackageAmount
        {
            get
            {
                return packageAmount;
            }
            set
            {
                this.packageAmount = value;
            }
        }






    }
}
