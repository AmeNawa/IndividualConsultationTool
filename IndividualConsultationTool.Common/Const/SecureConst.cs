using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualConsultationTool.Common.Const
{
    public class SecureConst
    {
        /// <summary>
        /// Password for AES
        /// </summary>
        public const string Password = "pk4141ddsfs==";

        /// <summary>
        /// Salt for AES
        /// </summary>
        public const string Salt = "grp32lmi02";

        /// <summary>
        /// Vector for AES
        /// </summary>
        public const string Vector = "ple03eki3lekoqp1";

        /// <summary>
        /// Iterations for AES
        /// </summary>
        public const int Iterations = 5;

        /// <summary>
        /// Key size for AES
        /// </summary>
        public const int KeySize = 256;
    }
}
