using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopSharing
{
    /// <summary>
    /// Enum of port protocols
    /// </summary>
    enum PortProtocol
    {
        /// <summary>
        /// The address family is unspecified.
        /// </summary>
        AF_UNSPEC = 0,

        /// <summary>
        /// The Internet Protocol version 4 (IPv4) address family.
        /// </summary>
        AF_INET = 2,

        /// <summary>
        /// The Internet Protocol version 6 (IPv6) address family.
        /// </summary>
        AF_INET6 = 23,
    }
}
