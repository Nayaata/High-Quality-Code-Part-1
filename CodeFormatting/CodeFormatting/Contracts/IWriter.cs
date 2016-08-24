namespace CodeFormatting.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface IWriter
    /// </summary>
    public interface IWriter
    {
        /// <summary>
        /// Write method in the interface wich must be inplement
        /// </summary>
        /// <param name="message">string message</param>
       public void Write(string message);

        /// <summary>
       /// WriteLine method in the interface wich must be inplement
        /// </summary>
       /// <param name="message">string message</param>
       public void WriteLine(string message);
    }
}
